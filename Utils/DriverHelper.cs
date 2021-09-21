using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;

namespace Affordit_Automation.Utils
{
	public class DriverHelper
	{
		public IWebDriver WebDriver { get; }

		public PropertyReader Properties { get; }


		int timeOutSeconds;

		public DriverHelper(IWebDriver driver)
		{
			WebDriver = driver;
			Properties = PropertyReader.Instance;
			timeOutSeconds = 155;
			//timeOutSeconds = Convert.ToInt16(ConfigurationManager.AppSettings["TimeOut"]);
		}

		public By ByLocator(string locator)
		{
			By result;

			if (locator.StartsWith("//"))
			{
				result = By.XPath(locator);
			}
			else if (locator.StartsWith("css="))
			{
				result = By.CssSelector(locator.Replace("css=", ""));
			}
			else if (locator.StartsWith("#"))
			{
				result = By.Name(locator.Replace("#", ""));
			}
			else if (locator.StartsWith("link="))
			{
				result = By.LinkText(locator.Replace("link=", ""));
			}
			else if (locator.StartsWith("class="))
			{
				result = By.ClassName(locator.Replace("class=", ""));
			}
			else if (locator.StartsWith("name="))
			{
				result = By.Name(locator.Replace("name=", ""));
			}
			else if (locator.StartsWith("id="))
			{
				result = By.Id(locator.Replace("id=", ""));
			}
			else if (locator.StartsWith("("))
			{
				result = By.XPath(locator);
			}
			else
			{
				result = By.XPath(locator);
			}
			return result;
		}

		public object ExecuteScript(string javascrpt, params object[] args)
		{
			try
			{
				IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
				return js.ExecuteScript(javascrpt, args);
			}
			catch (Exception)
			{
				return null;    // UPDATED: why are we ignoring the exception?
								//This was causing black page issue in Edge browser so to avoid that we ignored it instead of updating full code
			}
		}

		public TResult Wait<TResult>(Func<IWebDriver, TResult> predicate, int timeoutSeconds)
		{
			WebDriverWait wait = GetWait(timeoutSeconds);
			return wait.Until(predicate);
		}


		// find an element satisfying a specific predicate allowing for some time before the condition is satisfied
		public IWebElement FindElement(By locator, Func<By, Func<IWebDriver, IWebElement>> predicate, int timeoutSeconds, bool throwError = true)
		{
			try
			{
				return Wait(predicate(locator), timeoutSeconds);	// UPDATED: why are we calling Wait here and wait.Until above?
			}
			catch (StaleElementReferenceException)
			{
				return Wait(predicate(locator), timeoutSeconds); // UPDATED: why are we waiting again?  And will we ever get here, given that Wait ignores StaleElementReferenceException?
																			// To avoid failing test case because of StaleElementReferenceException exception which is intermittently.
			}
			catch
			{
				if (throwError)
					throw;
			}

			return null;
		}

		public WebDriverWait GetWait(int timeOutSeconds)
		{
			WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeOutSeconds));
			wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
			wait.IgnoreExceptionTypes(typeof(InvalidElementStateException));    // UPDATE: what's the effect of ignoring this?
			return wait;                                                       //Earlier script was failing because of InvalidElementStateException we we added it
		}

		//Verify element is present or not
		public bool IsElementPresent(By locator, int timeout = 5)
		{
			return FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeout, false) != null;
		}

		//Wait until element doesn't hide
		public void WaitForElementHide(By locator, int timeoutSeconds = 10)
		{
			GetWait(timeoutSeconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
		}

		//Wait until element doesn't display
		public void WaitForElementDisplay(By locator, int timeoutSeconds = 10)
		{

			GetWait(timeoutSeconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
		}

		//Wait for element until it gets enable
		public void WaitForElementEnabled(By locator, int timeoutSeconds = 10)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeoutSeconds);

			GetWait(timeoutSeconds).Until(drv => el.Enabled);
		}

		//Verify element is enabled or not
		public bool IsElementEnabled(By locator)
		{
			return FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, 3, false) != null;	// TODO: IsElementXXX should always be instantaneous
		}

		//Verify element is visible or not
		public bool IsElementDisplayed(By locator, int timeout = 10)
		{
			return FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeout, false) != null;
		}

		//Perform mouse over action on an element
		public void MouseOver(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds);	// DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																   //REPLACED hardCoded value with setting
			el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeOutSeconds);	// TODO: why does a mouse over need the element to be clickable?

			Actions builder = new Actions(WebDriver);
			builder.MoveToElement(el).Build().Perform();
		}

		//Perform drag and drop action
		public void DragAndDrop(By draggable, By to)
		{
			IWebElement elDraggable = FindElement(draggable, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeOutSeconds);   // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																				//REPLACED hardCoded value with setting
			IWebElement todrag = FindElement(to, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeOutSeconds);

			Actions builder = new Actions(WebDriver);
			builder.DragAndDrop(elDraggable, todrag).Build().Perform();
		}

		//Simple click on an element
		public void Click(By locator, params string[] modifiers)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																		//REPLACED hardCoded value with setting
			el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeOutSeconds);
			Actions action = new Actions(WebDriver);
			// press modifier keys (if any)
			if (modifiers != null && modifiers.Length > 0)
			{
				foreach (string key in modifiers)
					action = action.KeyDown(key);
			}

			try
			{
				el.Click();
			}
			catch (StaleElementReferenceException)
			{
				el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting
				el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeOutSeconds);
				el.Click();
			}
			// release modifier keys (if any)
			if (modifiers != null && modifiers.Length > 0)
			{
				foreach (string key in modifiers.Reverse())
					action = action.KeyUp(key);
			}
		}

		//Click on an element using javaScript
		public void ClickByJS(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds); // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting
			ExecuteScript("arguments[0].click();", el);
		}

		//Select value from drop down
		public void SelectDropDown(By locator, string targetValue)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																		//REPLACED hardCoded value with setting
			new SelectElement(el).SelectByText(targetValue);
			Wait(d => SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(el), 5);
		}

		//Verify element contains text or not
		public bool IsTextPresent(By locator, string str)
		{
			return GetText(locator).Contains(str);
		}

		//Get available text of an element
		//Updated time from 5 to 15 because element was not being visible in 5 sec.
		//While using ElementExists we were getting blank as the test so used ElementIsVisible
		public string GetText(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds); // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting
			el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, 10);
			return el.Text;
		}

		//Enter data in the field without clearing it
		public void SendKeys(By locator, string text, bool clear = false)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																		//REPLACED hardCoded value with setting

			if (clear)
				el.Clear();

			el.SendKeys(text);
		}

		//Enter data in the field after clearing it
		public void SetText(By locator, string text)
		{
			SendKeys(locator, text, true);
		}

		//Some time selenium sendkeys was giving error so used this method to set text field value 
		public void SetTextByJS(By locator, string text)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds); // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting
			ExecuteScript("arguments[0].setAttribute('value', '" + text + "')", el);
			el.SendKeys(Keys.Enter);
		}

		//Verify element checked or not
		public bool IsChecked(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																	//REPLACED hardCoded value with setting
			return el.Selected;
		}

		//Get value of an attribute of given element
		public string GetAttribute(By locator, string attribute)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds); // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting
			return el.GetAttribute(attribute);
		}

		//In small screen/ low resolution full grid doesn't displayed this method scroll the age to the down
		public void ScrollToBottom()
		{
			ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
		}

		//This method scroll the age to the top
		public void ScrollToTop()
		{
			ExecuteScript("window.scrollTo(0,0)");
			//ExecuteScript("window.scrollBy(0,-300)");
			WebDriver.FindElement(By.TagName("body")).SendKeys(Keys.PageUp);
		}

		public void ScrollIntoView(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds); // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting
			ExecuteScript("arguments[0].scrollIntoView();", el);
		}

		//wait for frame to be available and switch into it
		public void SwitchToFrame(string xpath, int timeout = 20)
		{
			Wait(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(xpath), timeout);
		}

		//To get back from frame
		public void DefaultSwitch()
		{
			WebDriver.SwitchTo().DefaultContent();
		}

		//Get current project path
		public string GetPath()
		{
			return Properties.GetPath();
		}

		//Update System time zone
		public void SetSystemTimeZone(string timeZoneId)
		{
			var process = Process.Start(new ProcessStartInfo
			{
				FileName = "tzutil.exe",
				Arguments = "/s \"" + timeZoneId + "\"",
				UseShellExecute = false,
				CreateNoWindow = true
			});

			if (process != null)
			{
				process.WaitForExit();
				TimeZoneInfo.ClearCachedData();
			}
		}

		//Perform Zoom in-out action
		public void Zoom(int percentage = 100)
		{
			try
			{
				ExecuteScript("document.body.style.zoom = '" + percentage + "%';");
			}
			catch (Exception) { }
		}

		//Get CSS attribute value of an element
		public string GetCssAttribute(By locator, String css)
		{
			//IWebElement el = FindElement(locator, ExpectedConditions.ElementExists, 10);
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																	//REPLACED hardCoded value with setting
			return el.GetCssValue(css);
		}

		public bool IsAlertPresent()
		{
			try
			{
				WebDriver.SwitchTo().Alert();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		//Perform mouse over action on an element
		public void MouseOverUsingJavaScript(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, timeOutSeconds); // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																//REPLACED hardCoded value with setting

			String mouseOverScript = "if(document.createEvent){var evObj = document.createEvent('MouseEvents');evObj.initEvent('mouseover',true, false); arguments[0].dispatchEvent(evObj);} else if(document.createEventObject) { arguments[0].fireEvent('onmouseover');}";
			ExecuteScript(mouseOverScript, el);
		}

		public string GetActiveElementAttributeValue(string attribute)
		{
			return WebDriver.SwitchTo().ActiveElement().GetAttribute(attribute);
		}

		public void ClearInputBox(By locator)
		{
			IWebElement el = FindElement(locator, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, timeOutSeconds);  // DONE: 10 seconds? that's a lot.  If it needs to be hardcoded, it should be a setting
																																		//REPLACED hardCoded value with setting
			el.Clear();
		}

	}
}
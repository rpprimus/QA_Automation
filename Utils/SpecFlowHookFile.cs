using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.IO;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace Affordit_Automation.Utils
{
	[Binding]
	public class SpecFlowHookFile
	{
		public enum BrowserTypes
		{
			Chrome = 0,
			Firefox = 1,
			Edge = 2,
			IE = 3,
			Safari = 4
		}

		private static IObjectContainer _objectContainer;
		private static BrowserTypes _browser;
		private static DriverOptions _options;

		private static string _applicationUrl;
		private static bool _headless;
		private static ExtentHtmlReporter htmlReporter;
		private static ExtentReports extent;
		private static ExtentTest featureName;
		private static ExtentTest scenario;

		protected static readonly PropertyReader _propertyReader = PropertyReader.Instance;

		public static Exception LastException { get; private set; }
		protected static IWebDriver Driver;
		static SpecFlowHookFile()
		{
			//string downloadPath = Path.Combine(_propertyReader.GetSharedFolderPath(), "downloadedFile");
			//if (!Directory.Exists(downloadPath))
			//Directory.CreateDirectory(downloadPath);
			_applicationUrl = _propertyReader["ApplicationUrl"];

			if (_browser == BrowserTypes.Firefox)
			{
				FirefoxProfile profile = new FirefoxProfile();
				profile.SetPreference("security.sandbox.content.level", 5);
				profile.SetPreference("browser.download.folderList", 2);
				//profile.SetPreference("browser.download.dir", downloadPath);
				profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;, application/csv, text/csv, text/html, text/plain, application/zip, application/x-zip, image/png");
				profile.SetPreference("browser.download.manager.focusWhenStarting", false);
				profile.SetPreference("browser.download.useDownloadDir", true);
				profile.SetPreference("browser.helperApps.alwaysAsk.force", false);
				profile.SetPreference("browser.download.manager.alertOnEXEOpen", false);
				profile.SetPreference("browser.download.manager.closeWhenDone", true);
				profile.SetPreference("browser.download.manager.showAlertOnComplete", false);
				profile.SetPreference("browser.download.manager.useWindow", false);
				profile.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);

				_options = new FirefoxOptions
				{
					AcceptInsecureCertificates = FirefoxDriver.AcceptUntrustedCertificates,
					PageLoadStrategy = PageLoadStrategy.Eager,
					Profile = profile
				};
			}
			else if (_browser == BrowserTypes.IE)
			{
				_options = new InternetExplorerOptions
				{
					IntroduceInstabilityByIgnoringProtectedModeSettings = true,
					IgnoreZoomLevel = true,
					UnhandledPromptBehavior = UnhandledPromptBehavior.Accept,
					PageLoadStrategy = PageLoadStrategy.Eager
				};
				((InternetExplorerOptions)_options).AddAdditionalCapability("AcceptInsecureCertificates", true);
				((InternetExplorerOptions)_options).AddAdditionalCapability("AcceptSslCertificates", true);
			}
			else if (_browser == BrowserTypes.Edge)
			{
				_options = new EdgeOptions
				{
					PageLoadStrategy = PageLoadStrategy.Eager
				};
				((EdgeOptions)_options).AddAdditionalCapability("browserName", "MicrosoftEdge");
				((EdgeOptions)_options).AddAdditionalCapability("platform", "WINDOWS");
				((EdgeOptions)_options).AddAdditionalCapability("ms:inPrivate", true);
			}
			else
			{
				_options = new ChromeOptions();
				((ChromeOptions)_options).AddArguments("--incognito");
				((ChromeOptions)_options).AddArguments("--disable-infobars");
				//((ChromeOptions)_options).AddUserProfilePreference("download.default_directory", downloadPath);
				if (_headless) ((ChromeOptions)_options).AddArguments("--headless");
			}
		}

		[BeforeTestRun(Order = 0)]
		public static void InitializeContainer(IObjectContainer objectContainer)
		{
			_objectContainer = objectContainer;
		}

		[BeforeTestRun(Order = 1)]
		public static void InitializeDriver()
		{
			htmlReporter = new ExtentHtmlReporter(_propertyReader.GetPath()+@"\ExtentReport\");
			htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
			htmlReporter.LoadConfig(_propertyReader.GetPath() + @"\ExtentReport\extent-config.xml");
			extent = new ExtentReports();
			extent.AttachReporter(htmlReporter);
			extent.AddSystemInfo("Host Name", "Primus Software");
			extent.AddSystemInfo("Browser:", "Google Chrome");
			extent.AddSystemInfo("Operating System", "Window 10");
			extent.AddSystemInfo("Environment", "QA");
			extent.AddSystemInfo("User Name", "AffordIt");
			switch (_browser)
			{
				case BrowserTypes.Firefox:
					Driver = new FirefoxDriver((FirefoxOptions)_options);
					break;
				case BrowserTypes.IE:
					Driver = new InternetExplorerDriver((InternetExplorerOptions)_options);
					break;
				case BrowserTypes.Chrome:
					Driver = new ChromeDriver((ChromeOptions)_options);
					break;
				default:
					throw new NotSupportedException();
			}

			Driver.Manage().Window.Maximize();
			Driver.Manage().Cookies.DeleteAllCookies();

			_objectContainer.RegisterInstanceAs(Driver);
		}

		[AfterTestRun]
		public static void QuitAllDriverInstances()
		{
			extent.Flush();
			KillDriver();
		}

		[BeforeFeature]
		public static void FeatureInitialize()
		{
			KillDriver(true);
			featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
			Console.WriteLine("BeforeFeature");
		}

		[AfterFeature]
		public static void FeatureCleanup()
		{
			KillDriver();
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			GoToHome();
			scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
		}

		[AfterStep]
		[Obsolete]
		public void InsertReportingSteps()
		{
			var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
			if (ScenarioContext.Current.TestError == null)
			{
				if (stepType == "Given")
					scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "When")
					scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "Then")
					scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
				else if (stepType == "And")
					scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
			}
			else if (ScenarioContext.Current.TestError != null)

			{
				if (stepType == "Given")
					scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot());
				else if (stepType == "When")
					scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot());
				else if (stepType == "Then")
					scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot());
				else if (stepType == "And")
					scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(TakeScreenshot());
			}
		}

		private static void KillDriver(bool reinitialize = false)
		{
			if (Driver == null)
				return;

			try
			{
				Driver.Quit();

				if (reinitialize)
					InitializeDriver();
			}
			catch
			{
				if (reinitialize)
					InitializeDriver();
			}
		}

		private static void GoToHome()
		{
			Driver.Navigate().GoToUrl(_applicationUrl);
		}

		[Obsolete]
		private string TakeScreenshot()
		{
			string callerName = ScenarioContext.Current.ScenarioInfo.Title;

			var error = ScenarioContext.Current.TestError;

			string snapshotDirectory = _propertyReader.GetPath() + @"\ExtentReport\ScreenShot\";


			if (!Directory.Exists(snapshotDirectory))
			{
				Directory.CreateDirectory(snapshotDirectory);
			}
			callerName = Regex.Replace(callerName, "[^0-9A-Za-z]+", "_");

			string location = snapshotDirectory + callerName + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".jpeg";
			Console.WriteLine("Screen shot Location :=>\n {0}\n\n", location);

			((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile(location, ScreenshotImageFormat.Png);

			return location;
		}
	}
}
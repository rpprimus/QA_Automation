using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
	public class LoginPageObjects : DriverHelper
	{
		public By userName => ByLocator("id=Username");
		public By userPassword => ByLocator("id=Password");
		public By loginButton => ByLocator("css=button[value='login']");
		public By selectButton => ByLocator("css=button[type='submit']");
		public By userMenu => ByLocator("css=a.user-menu-link");

		public By TenentXpath(string tenent)
		{
			return ByLocator($"//li[contains(@class,'list-group-item')]/label[contains(text(),'{tenent}')]");
		}
		
		public By GetErrorXpath(string error)
		{
			return ByLocator($"//div[@class='login-validation']//li[contains(text(),'{error}')]");
		}

		public LoginPageObjects(IWebDriver driver) : base(driver)
		{ }

		public void EnterUserName(string name)
		{
			SendKeys(userName, name, true);
		}
		
		public void EnterPassword(string password)
		{
			SendKeys(userPassword, password, true); 
		}

		public void ClickOnLoginButton()
		{
			Click(loginButton);
		}

		public void SelectTenent(string tenent)
		{
			Click(TenentXpath(tenent));
		}

		public void ClickOnSelectButton()
		{
			Click(selectButton);
		}

		public bool IsUserMenuAvailable()
		{
			WaitForElementDisplay(userMenu, 20);
			return IsElementDisplayed(userMenu);
		}

		public bool IsErrorDisplayed(string error)
		{
			WaitForElementDisplay(GetErrorXpath(error), 20);
			return IsElementDisplayed(GetErrorXpath(error));
		}

		
	}
}
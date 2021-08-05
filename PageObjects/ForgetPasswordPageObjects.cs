using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
    public class ForgetPasswordPageObjects : DriverHelper
	{
		public By EmailID => ByLocator("id=Email");
		public By ForgetLink => ByLocator("//a[@href='/Account/ForgotPassword']");
		public By SendEmail => ByLocator("//button[text()='Submit']");

		public ForgetPasswordPageObjects(IWebDriver driver) : base(driver)
		{ }

		public void EnterEmailID(string email)
		{
			SendKeys(EmailID, email, true);
		}

		public void ForgetLinkBtn()
		{
			Click(ForgetLink);
		}

		public void ClickOnSendEmailButton()
		{
			Click(SendEmail);
		}
	

	}
}

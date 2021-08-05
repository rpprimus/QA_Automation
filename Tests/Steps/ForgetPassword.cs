using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Affordit_Automation.Tests.Steps
{
    [Binding]
    public class ForgetPassword
    {
        private IWebDriver _driver;
        protected readonly PropertyReader _propertyReader = null;
        protected readonly ForgetPasswordPageObjects _ForgotPageObjects = null;
        protected string loggedUser;

        public ForgetPassword(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _ForgotPageObjects = new ForgetPasswordPageObjects(_driver);
        }
        [Given(@"Navigating onto the Affordit Loginpage")]
        public void GivenNavigatingOntoTheAfforditLoginpage()
        {
            _ForgotPageObjects.WebDriver.Navigate().GoToUrl(_propertyReader["ApplicationUrl"]);
        }
        [Given(@"User Should Click on ForgetLink")]
        public void GivenUserShouldClickOnForgetLink()
        {
            _ForgotPageObjects.WebDriver.Navigate().GoToUrl(_propertyReader["ForgetUrl"]);
        }
        [When(@"Enter ""(.*)""")]
        public void WhenEnter(string emailid)
        {
            _ForgotPageObjects.EnterEmailID(_propertyReader[emailid]);
        }
        [Then(@"User click on Send Button")]
        public void ThenUserClickOnSendButton()
        {
            _ForgotPageObjects.ClickOnSendEmailButton();
        }


    }
}

using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PrimusFramework.StepDefination.LogForg
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver _driver;
        protected readonly PropertyReader _propertyReader = null;
        protected readonly LoginPageObjects _loginPageObjects = null;
        protected string loggedUser;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _loginPageObjects = new LoginPageObjects(_driver);
        }

        [Given(@"I am navigating onto the Affordit Loginpage")]
        public void GivenIAmNavigatingOntoTheAfforditLoginpage()
        {
            _loginPageObjects.WebDriver.Navigate().GoToUrl(_propertyReader["ApplicationUrl"]);
        }

        //[Given(@"Enter ""(.*)"" and ""(.*)""")]
        //public void GivenEnterAnd(string username, string password)
        //{
            
        //    _loginPageObjects.EnterUserName(_propertyReader[username]);
        //    _loginPageObjects.EnterPassword(_propertyReader[password]);
        //}
        [Given(@"Enter ""(.*)"" and ""(.*)"" for Login")]
        public void GivenEnterAndForLogin(string username, string password)
        {
            _loginPageObjects.EnterUserName(_propertyReader[username]);
            _loginPageObjects.EnterPassword(_propertyReader[password]);
        }

        [When(@"User click on login Button")]
        public void WhenUserClickOnLoginButton()
        {
            _loginPageObjects.ClickOnLoginButton();
        }

        [When(@"Select ""(.*)"" tenent")]
        public void WhenSelectTenent(string tenent)
        {
            _loginPageObjects.SelectTenent(tenent);
        }

        [When(@"Click on Select Button")]
        public void WhenClickOnSelectButton()
        {
            _loginPageObjects.ClickOnSelectButton();
        }

        [Then(@"Redirect to Manage Your Applications Page")]
        public void ThenRedirectToManageYourApplicationsPage()
        {
            Assert.AreEqual(true, _loginPageObjects.IsUserMenuAvailable());
        }

        [Then(@"Error message should appear ""(.*)""")]
        public void ThenErrorMessageShouldAppear(string error)
        {
            _loginPageObjects.IsErrorDisplayed(error);
        }

    }
}

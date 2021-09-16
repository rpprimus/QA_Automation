using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Affordit_Automation.Tests.Steps
{
    [Binding]
    public class BorrowerCreditScore
    {
        private IWebDriver _driver;

        Actions act;

        protected readonly PropertyReader _propertyReader;
        protected readonly BorrowerCreditScorePageObjects _BorrowerCreditScorePageObject;

        public BorrowerCreditScore(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _BorrowerCreditScorePageObject = new BorrowerCreditScorePageObjects(_driver);
            act = new Actions(driver);
        }
        [Given(@"Navigate to New Application Page with ""(.*)"" and ""(.*)""")]
        public void GivenNavigateToNewApplicationPageWithAnd(string username, string password)
        {
            _BorrowerCreditScorePageObject.WebDriver.Navigate().GoToUrl(_propertyReader["ApplicationUrl"]);
            Thread.Sleep(3000);
            _BorrowerCreditScorePageObject.EnterUserName(_propertyReader[username]);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _BorrowerCreditScorePageObject.EnterPassword(_propertyReader[password]);
            _BorrowerCreditScorePageObject.ClickOnLoginButtonNew();
        }
        [Given(@"Select ""(.*)"" tenant")]
        public void GivenSelectTenent(string tenent)
        {
            _BorrowerCreditScorePageObject.SelectTenent(tenent);
            _BorrowerCreditScorePageObject.ClickOnSelectButton();
        }
        [Given(@"Click on New Application Button")]
        public void GivenClickOnNewApplicationButton()
        {
             _BorrowerCreditScorePageObject.ClickOnAddApplicant();
        }
        [When(@"Click on Next For Credit Records")]
        public void WhenClickOnNextForCreditRecords()
        {
           
            _BorrowerCreditScorePageObject.ClickForCreditScore();
        }
  
        [When(@"Enter Correct ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenEnterCorrectAndAnd(string limit1, string limit2, string limit3)
        {
                _BorrowerCreditScorePageObject.EnterCreditScore1(_propertyReader[limit1]);
                _BorrowerCreditScorePageObject.EnterCreditScore2(_propertyReader[limit2]);
                _BorrowerCreditScorePageObject.EnterCreditScore3(_propertyReader[limit3]);
        }

        [Then(@"Click on Page to see the Result")]
        public void ThenClickOnPageToSeeTheResult()
        {
            //_BorrowerCreditScorePageObject.ClickOnModal();
        }

    }
}

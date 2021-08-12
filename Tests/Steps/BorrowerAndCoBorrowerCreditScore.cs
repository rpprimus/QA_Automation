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
    public  class BorrowerAndCoBorrowerCreditScore
    {
        private IWebDriver _driver;
        protected readonly PropertyReader _propertyReader;
        protected readonly BorrowerCreditScorePageObjects _BorrowerPageObject;
        protected readonly BorrowerAndCoBorrowerPageObjects _CoBorrowerPageObject;
        public BorrowerAndCoBorrowerCreditScore(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _BorrowerPageObject = new BorrowerCreditScorePageObjects(_driver);
            _CoBorrowerPageObject = new BorrowerAndCoBorrowerPageObjects(_driver);
        }
        [Then(@"Click on Yes Button")]
        public void ThenClickOnYesButton()
        {
            _CoBorrowerPageObject.ClickonYesBtn();
        }
        [Then(@"Click on Next For Credit Records")]
        public void ThenClickOnNextForCreditRecords()
        {
            _CoBorrowerPageObject.ClickNextForCreditScore();
        }
        [Then(@"Enter Valid Coborrower ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void ThenEnterValidCoborrowerAndAnd(string limit1, string limit2, string limit3)
        {
            _CoBorrowerPageObject.EnterCoCreditScore1(_propertyReader[limit1]);
            _CoBorrowerPageObject.EnterCoCreditScore2(_propertyReader[limit2]);
            _CoBorrowerPageObject.EnterCoCreditScore3(_propertyReader[limit3]);
        }
        [Then(@"Enter Valid ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void ThenEnterValidAndAnd(string limit1, string limit2, string limit3)
        {
            _BorrowerPageObject.EnterCreditScore1(_propertyReader[limit1]);
            _BorrowerPageObject.EnterCreditScore2(_propertyReader[limit2]);
            _BorrowerPageObject.EnterCreditScore3(_propertyReader[limit3]);
        }

        [Then(@"Click on Next Page Link")]
        public void ThenClickOnNextPageLink()
        {
            _CoBorrowerPageObject.ClickNextForCreditScoreCo();
        }

    }
}

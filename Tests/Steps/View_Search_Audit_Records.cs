using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
namespace Affordit_Automation.Tests.Steps
{
    [Binding]
    public sealed class View_Search_Audit_Records
    {
        private IWebDriver _driver;

        Actions act;

        protected readonly PropertyReader _propertyReader;
        protected readonly View_Search_Audit_Records_PageObjects _view_Search_Audit_Records_PageObjects;
        // protected string loggedUser;
        
        private readonly ScenarioContext _scenarioContext;

        public View_Search_Audit_Records(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _view_Search_Audit_Records_PageObjects = new View_Search_Audit_Records_PageObjects(_driver);
            act = new Actions(driver);
        }

        [Then(@"Click on Audit Records")]
        public void ThenClickOnAuditRecords()
        {
            _view_Search_Audit_Records_PageObjects.ClickOnAuditRecords();
        }
        [Then(@"Enter Application Id in Search box and Click Enter")]
        public void ThenEnterApplicationIdInSearchBoxAndClickEnter()
        {
            _view_Search_Audit_Records_PageObjects.SearchBoxAndClickEnter();
        }
        [Then(@"Enter Type in Search box and Click Enter")]
        public void ThenEnterTypeInSearchBoxAndClickEnter()
        {
            _view_Search_Audit_Records_PageObjects.EnterTypeInSearchBoxAndClickEnter();
        }
        [Then(@"Enter Modified By in Search box and Click Enter")]
        public void ThenEnterModifiedByInSearchBoxAndClickEnter()
        {
            _view_Search_Audit_Records_PageObjects.EnterModifiedByInSearchBoxAndClickEnter();
        }
        [Then(@"Enter Occurred On in Search box and Click Enter")]
        public void ThenEnterOccurredOnInSearchBoxAndClickEnter()
        {
            _view_Search_Audit_Records_PageObjects.EnterOccurredOnInSearchBoxAndClickEnter();
        }
        [Then(@"Click on View Details Button")]
        public void ThenClickOnViewDetailsButton()
        {
            _view_Search_Audit_Records_PageObjects.ViewDetailsButton();
        }
        [Then(@"Click Close Button")]
        public void ThenClickCloseButton()
        {
            _view_Search_Audit_Records_PageObjects.CloseButton();
        }



    }
}

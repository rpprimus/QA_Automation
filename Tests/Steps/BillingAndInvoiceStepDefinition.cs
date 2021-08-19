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
    public sealed class BillingAndInvoiceStepDefinition
    {
        private IWebDriver _driver;

        Actions act;
        WebDriverWait wait;

        protected readonly PropertyReader _propertyReader;
        protected readonly BillingAndInvoicePageObjects _billingAndInvoicePageObjects;
        // protected string loggedUser;
       
        private readonly ScenarioContext _scenarioContext;

        public BillingAndInvoiceStepDefinition(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _billingAndInvoicePageObjects = new BillingAndInvoicePageObjects(_driver);
            act = new Actions(driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }
        [Then(@"Click on Billing and Invoice")]
        public void ThenClickOnBillingAndInvoice()
        {
            _billingAndInvoicePageObjects.ClickOnBillingAndInvoice();
        }
        [Then(@"Enter Price Per Report")]
        public void ThenEnterPricePerReport()
        {
            _billingAndInvoicePageObjects.EnterPricePerReport();
        }
        [Then(@"Click Save and Submit Button")]
        public void ThenClickSaveAndSubmitButton()
        {
            _billingAndInvoicePageObjects.ClickSaveAndSubmitButton();
        }
        [Then(@"Click Tiered Pricing Radio Button")]
        public void ThenClickTieredPricingRadioButton()
        {
            _billingAndInvoicePageObjects.ClickTieredPricingRadioButton();
        }
        [Then(@"Enter Minimum Reports")]
        public void ThenEnterMinimumReports()
        {
            _billingAndInvoicePageObjects.EnterMinimumReports();
        }
        [Then(@"Enter Maximum Reports")]
        public void ThenEnterMaximumReports()
        {
            _billingAndInvoicePageObjects.EnterMaximumReports();
        }
        [Then(@"Enter Price Per Report for Tiered Pricing")]
        public void ThenEnterPricePerReportForTieredPricing()
        {
            _billingAndInvoicePageObjects.PricePerReportForTieredPricing();
        }
        [Then(@"Click Save and Submit Button for Tiered Pricing")]
        public void ThenClickSaveAndSubmitButtonForTieredPricing()
        {
            _billingAndInvoicePageObjects.ClickSaveAndSubmitButtonForTieredPricing();
        }
        [Then(@"Click Invoice Tab")]
        public void ThenClickInvoiceTab()
        {
            _billingAndInvoicePageObjects.ClickInvoiceTab();
        }
        [Then(@"Enter Email Id in Search Box and Select it")]
        public void ThenEnterEmailIdInSearchBoxAndSelectIt()
        {
            _billingAndInvoicePageObjects.EnterEmailIdInSearchBoxAndSelectIt();
        }
        [Then(@"Click Settings Tab")]
        public void ThenClickSettingsTab()
        {
            _billingAndInvoicePageObjects.ClickSettingsTab();
        }
        [Then(@"Select or Enter Date")]
        public void ThenSelectOrEnterDate()
        {
            Thread.Sleep(3000);
            IWebElement SelectDate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-settings/div/form/mat-form-field/div/div[1]/div[1]/input")));
            SelectDate.Click();
            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/div/mat-datepicker-content/div[2]/mat-calendar/div/mat-month-view/table/tbody/tr[1]/td[2]/div[1]")));
            Select.Click();
        }
    
        [Then(@"Click Save Settings")]
        public void ThenClickSaveSettings()
        {
            _billingAndInvoicePageObjects.ClickSaveSettings();
        }


    }
}

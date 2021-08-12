using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Affordit_Automation.Tests.Steps
{
    [Binding]
    public class EmploymentDetailsSteps
    {
        private readonly IWebDriver _driver;
        readonly Actions act;
        WebDriverWait wait;

        protected readonly PropertyReader _propertyReader;
        protected readonly EmployerObjects _employerObjects;

        public EmploymentDetailsSteps(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _employerObjects = new EmployerObjects(_driver);
            act = new Actions(driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(90000));
        }
        [Then(@"Click on Employment Button")]
        public void ThenClickOnEmploymentButton()
        {
            Thread.Sleep(2000);
            IWebElement EmploymentButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[1]/mat-step-header[4]/div[1]")));
            act.MoveToElement(EmploymentButton).Click().Build().Perform();

        }
        [Then(@"Click Next for CoBorrower Information")]
        public void ThenClickNextForCoborrowerInfo()
        {
            IWebElement CoborrowerInfo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            CoborrowerInfo.Click();
        }
        
        [Then(@"Click Next for Income and Asset Details")]
        public void ThenClickNextForIncomeAndAssetDetails()
        {
            IWebElement IncomeAndAssetDetails = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            IncomeAndAssetDetails.Click();

        }

    }
}


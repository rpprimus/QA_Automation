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
        [Then(@"Enter Employer Name")]
        public void ThenEnterEmployerName()
        {
            IWebElement EmployerName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[1]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));

            EmployerName.SendKeys("ajay");
        }
        [Then(@"Enter Phone Number")]
        public void ThenEnterPhoneNumber()
        {
            IWebElement Empphonenumber = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[1]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            Empphonenumber.Click();
            Empphonenumber.SendKeys("9250240861");
        }
        [Then(@"Enter Title")]
        public void ThenEnterTitle()
        {
            IWebElement Emptitle = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[1]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            Emptitle.Click();
            Emptitle.SendKeys("Borrower");
        }
        [Then(@"Click Next for Borrower More Information")]
        public void ThenClickNextForBorrowerMoreInfo()
        {
            IWebElement BorrowerMoreInfo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            BorrowerMoreInfo.Click();
        }
        [Then(@"Enter Address line First")]
        public void ThenEnterAddressLineFirst()
        {
            IWebElement AddressLineFirst = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[2]/div/div[1]/mat-form-field/div/div[1]/div/input")));
            AddressLineFirst.Click();
            AddressLineFirst.SendKeys("2521 Palomar Airport Rd ");
        }
        [Then(@"Enter Address line Second")]
        public void ThenEnterAddressLineSecond()
        {
            IWebElement AddressLineSecond = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[2]/div/div[2]/mat-form-field/div/div[1]/div/input")));
            AddressLineSecond.Click();
            AddressLineSecond.SendKeys("Ste 1050 Unit 7");
        }
        [Then(@"Click Next for CoBorrower Information")]
        public void ThenClickNextForCoborrowerInfo()
        {
            IWebElement CoborrowerInfo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            CoborrowerInfo.Click();
        }
        [Then(@"Enter CoBorrower Employer Name")]
        public void ThenEnterCoborrowerEmployerName()
        {
            IWebElement CoborrowerEmployerName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[3]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            CoborrowerEmployerName.Click();
            CoborrowerEmployerName.SendKeys("coborrower ajay");
        }
        [Then(@"Enter CoBorrower Phone Number")]
        public void ThenEnterCoborrowerPhoneNumber()
        {
            IWebElement CoborrowerPhoneNumber = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[3]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            CoborrowerPhoneNumber.Click();
            CoborrowerPhoneNumber.SendKeys("8076478072");
        }
        [Then(@"Enter CoBorrower Title")]
        public void ThenEnterCoborrowerTitle()
        {
            IWebElement CoborrowerTitle = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[3]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            CoborrowerTitle.Click();
            CoborrowerTitle.SendKeys("coborrower");
        }
        [Then(@"Click Next for CoBorrower More Information")]
        public void ThenClickNextForCoborrowerMoreInfo()
        {
            IWebElement CoborrowerMoreInfo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            CoborrowerMoreInfo.Click();
        }
        [Then(@"Enter CoBorrower Address line First")]
        public void ThenEnterCoborrowerAddressLineFirst()
        {
                IWebElement CoborrowerAddressLineFirst = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[4]/div/div[1]/mat-form-field/div/div[1]/div/input")));
                CoborrowerAddressLineFirst.Click();
                CoborrowerAddressLineFirst.SendKeys("2267 S. El Camino Real");
        }
        [Then(@"Enter CoBorrower Address line Second")]
        public void ThenEnterCoborrowerAddressLineSecond()
        {
                IWebElement CoborrowerAddressLineSecond = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[4]/div/div[2]/mat-form-field/div/div[1]/div/input")));
                CoborrowerAddressLineSecond.Click();
                CoborrowerAddressLineSecond.SendKeys("Suite 100b Unit 5");
        }

        [Then(@"Click Next for Income and Asset Details")]
        public void ThenClickNextForIncomeAndAssetDetails()
        {
            IWebElement IncomeAndAssetDetails = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            IncomeAndAssetDetails.Click();

        }

    }
}


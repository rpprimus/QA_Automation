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
    public class LoanTypeStepDefination
    {
        private readonly IWebDriver _driver;
        readonly Actions act;


        protected readonly PropertyReader _propertyReader;
        protected readonly LoanTypePageObjects _loanTypePageObjects;

        WebDriverWait wait;
        public LoanTypeStepDefination(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _loanTypePageObjects = new LoanTypePageObjects(_driver);

            act = new Actions(driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(9000));
        }


        [When(@"Click on Next Icon For Credit Records")]
        public void WhenClickOnNextForCreditRecords()
        {
            IWebElement NextForCreditRecords = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]")));
            NextForCreditRecords.Click();
        }

        [When(@"Enter ""(.*)"" and ""(.*)"" and ""(.*)"" between limits")]
        public void WhenEnterAndAndBetweenLimits(string limit1, string limit2, string limit3)
        {
            _loanTypePageObjects.EnterCreditScore1(_propertyReader[limit1]);
            _loanTypePageObjects.EnterCreditScore2(_propertyReader[limit2]);
            _loanTypePageObjects.EnterCreditScore3(_propertyReader[limit3]);
        }

        [Then(@"Click on Next Icon For Loan Type")]
        public void ThenClickOnNextIconForLoanType()
        {
            IWebElement NextIconForLoanType = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]")));
            NextIconForLoanType.Click();
            Thread.Sleep(2000);
        }
        [Then(@"Click MORTGAGE Icon")]
        public void ThenClickMORTGAGEIcon()
        {
            IWebElement MORTGAGEIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[2]/div[1]")));
            MORTGAGEIcon.Click();
        }
        [Then(@"Select Type of Loan Request for MORTGAGE")]
        public void ThenSelectTypeOfLoanRequestForMORTGAGE()
        {
            IWebElement LoanRequestForMORTGAGE = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestForMORTGAGE.Click();
            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[2]")));
            select.Click();
        }
        [Then(@"Enter Purchase Price for MORTGAGE")]
        public void ThenEnterPurchasePriceForMORTGAGE()
        {
            IWebElement PurchasePriceForMORTGAGE = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            PurchasePriceForMORTGAGE.Click();
            PurchasePriceForMORTGAGE.SendKeys("6000");
        }

        [Then(@"Enter Down Payment\(%\) for MORTGAGE")]
        public void ThenEnterDownPaymentForMORTGAGE()
        {
            IWebElement DownPaymentForMORTGAGE = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            DownPaymentForMORTGAGE.Click();
            DownPaymentForMORTGAGE.SendKeys("3");
        }
        [Then(@"Enter of Months for Reserves")]
        public void ThenEnterOfMonthsForReserves()
        {
            IWebElement MonthsForReserves = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[4]/div[1]/mat-form-field/div/div[1]/div/input")));
            MonthsForReserves.Click();
            MonthsForReserves.SendKeys("3");
        }
        [Then(@"Click Next Icon Link")]
        public void ThenClickNextIconLink()
        {
            IWebElement NextIconLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/div/a[2]")));
            NextIconLink.Click();
        }
        [Then(@"Click HOME EQUITY Icon")]
        public void ThenClickHOMEEQUITYIcon()
        {
            IWebElement HOMEEQUITYIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[2]/div[2]")));
            HOMEEQUITYIcon.Click();
        }
        [Then(@"Select Type of Loan Request for HOME EQUITY")]
        public void ThenSelectTypeOfLoanRequestForHOMEEQUITY()
        {

            IWebElement LoanRequestHOMEEQUITY = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestHOMEEQUITY.Click();

            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[2]")));
            select.Click();
        }
        [Then(@"Enter Loan Amount for HOME EQUITY")]
        public void ThenEnterLoanAmountForHOMEEQUITY()
        {
            IWebElement LoanAmountForHOMEEQUITY = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            LoanAmountForHOMEEQUITY.Click();
            LoanAmountForHOMEEQUITY.SendKeys("60000");
        }
        [Then(@"Click PERSONAL Icon")]
        public void ThenClickPERSONALIcon()
        {
            IWebElement PERSONALIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[2]/div[3]")));
            PERSONALIcon.Click();
        }
        [Then(@"Select Type of Loan Request for PERSONAL")]
        public void ThenSelectTypeOfLoanRequestForPERSONAL()
        {
            IWebElement LoanRequestForPERSONAL = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestForPERSONAL.Click();
            Thread.Sleep(2000);
            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            select.Click();
        }
        [Then(@"Enter Loan Amount for PERSONAL")]
        public void ThenEnterLoanAmountForPERSONAL()
        {
            IWebElement LoanAmountForPERSONAL = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            LoanAmountForPERSONAL.Click();
            LoanAmountForPERSONAL.SendKeys("60000");
        }
        [Then(@"Click AUTO Icon")]
        public void ThenClickAUTOIcon()
        {
            IWebElement AUTOIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[3]/div[1]")));
            AUTOIcon.Click();
        }
        [Then(@"Select Type of Loan Request for AUTO")]
        public void ThenSelectTypeOfLoanRequestForAUTO()
        {
            IWebElement LoanRequestForAUTO = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestForAUTO.Click();

            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
            select.Click();
        }
        [Then(@"Enter Purchase Price for AUTO")]
        public void ThenEnterPurchasePriceForAUTO()
        {
            IWebElement PurchasePriceForAUTO = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            PurchasePriceForAUTO.Click();
            PurchasePriceForAUTO.SendKeys("70000");
        }
        [Then(@"Enter Down Payment\(%\) for AUTO")]
        public void ThenEnterDownPaymentForAUTO()
        {
            IWebElement DownPaymentForAUTO = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            DownPaymentForAUTO.Click();
            DownPaymentForAUTO.SendKeys("2");
        }
        [Then(@"Click MoTORCYCLE Icon")]
        public void ThenClickMoTORCYCLEIcon()
        {
            IWebElement MoTORCYCLEIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[3]/div[2]")));
            MoTORCYCLEIcon.Click();
        }

        [Then(@"Select Type of Loan Request for MoTORCYCLE")]
        public void ThenSelectTypeOfLoanRequestForMoTORCYCLE()
        {
            IWebElement LoanRequestForMoTORCYCLE = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestForMoTORCYCLE.Click();

            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[2]")));
            select.Click();
        }
        [Then(@"Enter Purchase Price for MoTORCYCLE")]
        public void ThenEnterPurchasePriceForMoTORCYCLE()
        {
            IWebElement PurchasePriceForMoTORCYCLE = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            PurchasePriceForMoTORCYCLE.Click();
            PurchasePriceForMoTORCYCLE.SendKeys("5000");
        }
        [Then(@"Enter Down Payment\(%\) for MoTORCYCLE")]
        public void ThenEnterDownPaymentForMoTORCYCLE()
        {
            IWebElement DownPaymentForMoTORCYCLE = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            DownPaymentForMoTORCYCLE.Click();
            DownPaymentForMoTORCYCLE.SendKeys("4");
        }
        [Then(@"Click BOAT Icon")]
        public void ThenClickBOATIcon()
        {
            IWebElement BOATIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[3]/div[3]")));
            BOATIcon.Click();
        }
        [Then(@"Select Type of Loan Request for BOAT")]
        public void ThenSelectTypeOfLoanRequestForBOAT()
        {
            IWebElement LoanRequestForBOAT = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestForBOAT.Click();

            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
            select.Click();
        }
        [Then(@"Enter Purchase Price for BOAT")]
        public void ThenEnterPurchasePriceForBOAT()
        {
            IWebElement PurchasePriceForBOAT = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            PurchasePriceForBOAT.Click();
            PurchasePriceForBOAT.SendKeys("60000");
        }
        [Then(@"Enter Down Payment\(%\) for BOAT")]
        public void ThenEnterDownPaymentForBOAT()
        {
            IWebElement DownPaymentForBOAT = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            DownPaymentForBOAT.Click();
            DownPaymentForBOAT.SendKeys("3");
        }

        [Then(@"Click RV/ATV Icon")]
        public void ThenClickRVATVIcon()
        {
            IWebElement RVATVIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[3]/div[4]")));
            RVATVIcon.Click();
        }
        [Then(@"Select Type of Loan Request for RV/ATV")]
        public void ThenSelectTypeOfLoanRequestForRVATV()
        {
            IWebElement LoanRequestForRVATV = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            LoanRequestForRVATV.Click();

            IWebElement select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            select.Click();
        }
        [Then(@"Enter Purchase Price for RV/ATV")]
        public void ThenEnterPurchasePriceForRVATV()
        {
            IWebElement PurchasePriceForRVATV = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            PurchasePriceForRVATV.Click();
            PurchasePriceForRVATV.SendKeys("40000");
        }
        [Then(@"Enter Down Payment\(%\) for RV/ATV")]
        public void ThenEnterDownPaymentForRVATV()
        {
            IWebElement DownPaymentForRVATV = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[2]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            DownPaymentForRVATV.Click();
            DownPaymentForRVATV.SendKeys("4");
        }

    }
}

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
    public class LiabilitiesStepsDefination
    {
        private readonly IWebDriver _driver;
        readonly Actions act;


        protected readonly PropertyReader _propertyReader;
        //protected readonly CoBorrowerObject _coBorrowerObject;

        WebDriverWait wait;
        public LiabilitiesStepsDefination(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            act = new Actions(driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }
        [Then(@"Select Yes")]
        public void ThenSelectYes()
        {
            IWebElement Yesbtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/form/div[1]/div/div/mat-button-toggle-group/mat-button-toggle[1]/button")));
            act.MoveToElement(Yesbtn).Click().Build().Perform();
        }


        [Then(@"Click on Liabilities")]
        public void ThenClickOnLiabilities()
        {

            IWebElement Liabilities = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[1]/mat-step-header[6]")));
            Liabilities.Click();
        }

        [Then(@"click Add Liabilities")]
        public void ThenClickAddLiabilities()
        {
            IWebElement AddLiabilities = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[text()=' Add Liability ']")));
            AddLiabilities.Click();
        }
        [Then(@"Select Liabilities")]
        public void ThenSelectLiabilities()
        {
            IWebElement SelectLiabilities = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[2]/div/ng-select/div/div/div[2]/input")));
            SelectLiabilities.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
            Select.Click();
        }
        [Then(@"Click on Balance Amount")]
        public void ThenClickOnBalanceAmount()
        {
            IWebElement BalanceAmount = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[3]/div[3]/mat-form-field/div/div[1]/div/input")));
            BalanceAmount.Click();
            BalanceAmount.SendKeys("2000");

        }
        [Then(@"Click the Dropdown Icon")]
        public void ThenClickTheDropdownIcon()
        {
            IWebElement DropdownIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[3]/div[4]/div/a/i")));
            DropdownIcon.Click();
        }

        [Then(@"Click on Original Loan Amount")]
        public void ThenClickOnOriginalLoanAmount()
        {
            IWebElement OriginalLoanAmount = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            OriginalLoanAmount.Click();
            OriginalLoanAmount.SendKeys("5000");
        }
        [Then(@"Click on Payment Amount")]
        public void ThenClickOnPaymentAmount()
        {
            IWebElement PaymentAmount = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[6]/mat-form-field/div/div[1]/div/input")));
            PaymentAmount.Click();
            PaymentAmount.SendKeys("3000");
        }
        [Then(@"Enter Terms")]
        public void ThenEnterTerms()
        {
            IWebElement EnterTerms = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            EnterTerms.Click();
            EnterTerms.SendKeys("5");
        }
        [Then(@"Enter Interest Rate")]
        public void ThenEnterInterestRate()
        {
            IWebElement InterestRate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[4]/mat-form-field/div/div[1]/div/input")));
            InterestRate.Click();
            InterestRate.SendKeys("4");
        }
        [Then(@"Enter Year")]
        public void ThenEnterYear()
        {
            IWebElement EnterYear = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[1]/ng-select/div/div/div[2]/input"))); EnterYear.Click();
            EnterYear.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[5]")));
            Select.Click();
        }
        [Then(@"Enter Make")]
        public void ThenEnterMake()
        {
            IWebElement EnterMake = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[2]/ng-select/div/div/div[2]/input")));
            EnterMake.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            Select.Click();
        }
        [Then(@"Enter Model")]
        public void ThenEnterModel()
        {
            IWebElement EnterModel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[3]/ng-select/div/div/div[2]/input")));
            EnterModel.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
            Select.Click();
        }
        [Then(@"Check the Special Interest Checkbox")]
        public void ThenCheckTheSpecialInterestCheckbox()
        {
            IWebElement SpecialInterestCheckbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div/mat-checkbox/label/span[1]")));
            SpecialInterestCheckbox.Click();
        }
        [Then(@"Enter Special Interest Rate")]
        public void ThenEnterSpecialInterestRate()
        {
            IWebElement EnterSpecialInterestRate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div[2]/mat-form-field/div/div[1]/div/input")));
            EnterSpecialInterestRate.Click();
            EnterSpecialInterestRate.SendKeys("4");
        }
        [Then(@"Click Next Page Icon")]
        public void ThenClickNextPageIcon()
        {
            try
            {
                IWebElement NextPageIcon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/div[2]/a[2]")));
                act.MoveToElement(NextPageIcon).Click().Build().Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception is " + ex);
            }
        }
        [Then(@"Click Next Page Icon for CoBorrower")]
        public void ThenClickNextPageIconForCoBorrower()
        {
            IWebElement NextPageIconForCoBorrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/div[2]/a[2]")));
            NextPageIconForCoBorrower.Click();
        }


        [Then(@"Click Add Liabilities Button for CoBorrower")]
        public void ThenClickAddLiabilitiesButtonForCoborrower()
        {
            IWebElement ClickAddLiabilitiesButtonForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div/button")));
            ClickAddLiabilitiesButtonForCoborrower.Click();
        }
        [Then(@"Select Liabilities for CoBorrower")]
        public void ThenSelectLiabilitiesForCoborrower()
        {
            IWebElement SelectLiabilitiesForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[2]/div/ng-select/div/div/div[2]/input")));
            SelectLiabilitiesForCoborrower.Click();
            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            Select.Click();
        }
        [Then(@"Click on Balance Amount for CoBorrower")]
        public void ThenClickOnBalanceAmountForCoborrower()
        {
            IWebElement BalanceAmountForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[3]/div[3]/mat-form-field/div/div[1]/div/input")));
            BalanceAmountForCoborrower.Click();
            BalanceAmountForCoborrower.SendKeys("7000");
        }
        [Then(@"Click the Dropdown Icon for CoBorrower")]
        public void ThenClickTheDropdownIconForCoborrower()
        {
            IWebElement DropdownIconForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[3]/div[4]/div/a")));
            DropdownIconForCoborrower.Click();
        }

        [Then(@"Check the Special Interest Checkbox for CoBorrower")]
        public void ThenCheckTheSpecialInterestCheckboxForCoborrower()
        {
            IWebElement SpecialInterestCheckbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div/mat-checkbox/label/span[1]")));
            SpecialInterestCheckbox.Click();
        }
        [Then(@"Enter Special Interest Rate for CoBorrower")]
        public void ThenEnterSpecialInterestRateForCoborrower()
        {
            IWebElement SpecialInterestRate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div[2]/mat-form-field/div/div[1]/div/input")));
            SpecialInterestRate.Click();
            SpecialInterestRate.SendKeys("2");
        }
        [Then(@"Click on Original Loan Amount for CoBorrower")]
        public void ThenClickOnOriginalLoanAmountForCoborrower()
        {
            IWebElement OriginalLoanAmountForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            OriginalLoanAmountForCoborrower.Click();
            OriginalLoanAmountForCoborrower.SendKeys("5000");
        }
        [Then(@"Click on Payment Amount for CoBorrower")]
        public void ThenClickOnPaymentAmountForCoborrower()
        {
            IWebElement PaymentAmountForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[6]/mat-form-field/div/div[1]/div/input")));
            PaymentAmountForCoborrower.Click();
            PaymentAmountForCoborrower.SendKeys("4000");
        }
        [Then(@"Enter Terms for CoBorrower")]
        public void ThenEnterTermsForCoborrower()
        {
            IWebElement TermsForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            TermsForCoborrower.Click();
            TermsForCoborrower.SendKeys("4");
        }
        [Then(@"Enter Interest Rate for CoBorrower")]
        public void ThenEnterInterestRateForCoborrower()
        {
            IWebElement RateForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[4]/mat-form-field/div/div[1]/div/input")));
            RateForCoborrower.Click();
            RateForCoborrower.SendKeys("3");
        }
        [Then(@"Enter Year for CoBorrower")]
        public void ThenEnterYearForCoborrower()
        {
            IWebElement EnterYearForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[1]/ng-select/div/div/div[2]/input")));
            EnterYearForCoborrower.Click();
            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            Select.Click();
        }
        [Then(@"Enter Make for CoBorrower")]
        public void ThenEnterMakeForCoborrower()
        {
            IWebElement EnterMakeForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[2]/ng-select/div/div/div[2]/input")));
            EnterMakeForCoborrower.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            Select.Click();
        }
        [Then(@"Enter Model for CoBorrower")]
        public void ThenEnterModelForCoborrower()
        {
            IWebElement EnterModelForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[3]/ng-select/div/div/div[2]/input")));
            EnterModelForCoborrower.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
            Select.Click();
        }
    }
}

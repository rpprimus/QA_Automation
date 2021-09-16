using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using OpenQA.Selenium;
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
    public sealed class SBO_Report
    {

        Actions act;
        private IWebDriver _driver;
        public readonly PropertyReader _propertyReader = null;
        public LoginPageObjects _loginPageObjects = null;
        public IncomeAndAssetsPrimaryPageObject _AL1PageObjects = null;
        public SBOReportPageObjects _sbo = null;
        WebDriverWait wait;
        public IJavaScriptExecutor exec;
        public SBO_Report(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _loginPageObjects = new LoginPageObjects(_driver);
            _AL1PageObjects = new IncomeAndAssetsPrimaryPageObject(_driver);
            _sbo = new SBOReportPageObjects(_driver);
            act = new Actions(_driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(100));
            exec = (IJavaScriptExecutor)_driver;
        }
        [Then(@"Click on Next Icon For Loan Type")]
        public void ThenClickOnNextIconForLoanType()
        {
            _sbo.nextbtnforloantype();
        }
        [Then(@"Click MORTGAGE Icon")]
        public void ThenClickMORTGAGEIcon()
        {
            _sbo.ClickMortgageIcon();
        }

        [Then(@"Select Type of Loan Request for MORTGAGE")]
        public void ThenSelectTypeOfLoanRequestForMORTGAGE()
        {
            _sbo.ClickOnTypeOfLoanRequest();
            _sbo.SelectLoanSubTypeMortgage();
        }
        [Then(@"Enter Purchase Price for MORTGAGE")]
        public void ThenEnterPurchasePriceForMORTGAGE()
        {
            _sbo.EnterAmountinPurchasePrice();
        }
        [Then(@"Enter Down Payment\(%\) for MORTGAGE")]
        public void ThenEnterDownPaymentForMORTGAGE()
        {
            _sbo.DownPaymentInterest();
        }
        [Then(@"Enter of Months for Reserves")]
        public void ThenEnterOfMonthsForReserves()
        {
            _sbo.MonthForReserve();
        }
        [Then(@"Click PERSONAL Icon")]
        public void ThenClickPERSONALIcon()
        {
            _sbo.PersonalLoanIcon();
        }
        [Then(@"Select Type of Loan Request for PERSONAL")]
        public void ThenSelectTypeOfLoanRequestForPERSONAL()
        {
            IWebElement LoanRequestForPersonal = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div")));
            LoanRequestForPersonal.Click();
            IWebElement selectFromLoanType = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[1]")));
            selectFromLoanType.Click();
        }
        [Then(@"Enter Loan Amount for PERSONAL")]
        public void ThenEnterLoanAmountForPERSONAL()
        {
            _sbo.PersonalLoanAmount();
        }

        [Then(@"Click Next For Personal Information")]
        public void ThenClickNextForPersonalInformation()
        {
            _sbo.NextbtnforPersonalPage();
        }
        [Then(@"Enter Firstname of Borrower")]
        public void ThenEnterFirstnameOfBorrower()
        {
            _sbo.BorrowerFirstName();
        }
        [Then(@"Enter Last name of Borrower")]
        public void ThenEnterLastNameOfBorrower()
        {
            _sbo.BorrowerLastName();
        }
        [Then(@"Enter Borrower Date of Birth")]
        public void ThenEnterBorrowerDateOfBirth()
        {
            IWebElement datepicker = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[1]/div[1]/div[6]/mat-form-field/div/div[1]/div[1]/input")));
            datepicker.Click();
            IWebElement Selectdate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/div/mat-datepicker-content/div[2]/mat-calendar/div/mat-month-view/table/tbody/tr[2]/td[2]/div[1]")));
            Selectdate.Click();
        }
        [Then(@"Enter Social ""(.*)""")]
        public void ThenEnterSocial(string securitynumber)
        {
            _sbo.SecurityNumber(_propertyReader[securitynumber]);
        }
        [Then(@"Click on Next link for Borrower other information")]
        public void ThenClickOnNextLinkForBorrowerOtherInformation()
        {
            _sbo.NextbtnforBorrowerOtherPersonalInformation();
        }
        [Then(@"Enter Address Line one")]
        public void ThenEnterAddressLineOne()
        {
            _sbo.AddressLineOne();
        }
        [Then(@"Enter Address Line two")]
        public void ThenEnterAddressLineTwo()
        {
            _sbo.AddressLinetwo();
        }
        [Then(@"Enter City for Borrower")]
        public void ThenEnterCityForBorrower()
        {
            _sbo.CityBorrower();
        }
        [Then(@"Select State")]
        public void ThenSelectState()
        {
            IWebElement ClickOnState = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[2]/div[1]/div[4]/ng-select/div/div/div[2]/input")));
            ClickOnState.Click();
            IWebElement SelectStatefromDropdown = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
            SelectStatefromDropdown.Click();
        }

        [Then(@"Enter ZipCode")]
        public void ThenEnterZipCode()
        {
            _sbo.ZipCode();
        }
        [Then(@"Click on Next link for Employer more information")]
        public void ThenClickOnNextLinkForEmployerMoreInformation()
        {
            _sbo.NextbtnforEmployeerInformation();
        }
        [Then(@"Enter Employer Name")]
        public void ThenEnterEmployerName()
        {
            _sbo.EmployerName();
        }
        [Then(@"Enter Phone Number")]
        public void ThenEnterPhoneNumber()
        {
            _sbo.EmployerPhoneNo();
        }
        [Then(@"Enter Title")]
        public void ThenEnterTitle()
        {
            _sbo.EmployeerTitle();
        }
        [Then(@"Enter Years on this Job")]
        public void ThenEnterYearsOnThisJob()
        {
            IWebElement YearsOnThisJob = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[1]/div[1]/div[5]/mat-form-field/div/div[1]/div/input")));
            YearsOnThisJob.SendKeys("5");
        }
        [When(@"Click on Next Link for Assets Page")]
        public void WhenClickOnNextLinkForAssetsPage()
        {
            _AL1PageObjects.LinkForAssetsPage();
        }
        [When(@"Click on Next Button to See the Result")]
        public void WhenClickOnNextButtonToSeeTheResult()
        {
            _AL1PageObjects.NextForResult();
        }

        [Then(@"Click Next for Borrower More Information")]
        public void ThenClickNextForBorrowerMoreInformation()
        {
            _sbo.NextbntforEmployeerAddressPage();
        }
        [Then(@"Enter Address line First")]
        public void ThenEnterAddressLineFirst()
        {
            _sbo.EnterEmployeerAddress1();
        }
        [Then(@"Enter Address line Second")]
        public void ThenEnterAddressLineSecond()
        {
            _sbo.EnterEmployeerAddress1();
        }
        [When(@"Click on Next Link for Liabilites Page")]
        public void WhenClickOnNextLinkForLiabilitesPage()
        {
            _sbo.ClickOnNextbtnForLiabilites();
        }
        [Then(@"Enter Creditor Name")]
        public void ThenEnterCreditorName()
        {
            IWebElement creditorname1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Creditor Name'])[1]")));
            creditorname1.SendKeys("TOYOTA MOTOR CREDIT");
        }
        [Then(@"Enter Creditor Name Credit Card")]
        public void ThenEnterCreditorNameCreditCard()
        {
            IWebElement creditorname1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Creditor Name'])[2]")));
            creditorname1.SendKeys("City Bank");
        }
        [Then(@"Enter Creditor Name Credit Card second")]
        public void ThenEnterCreditorNameCreditCardSecond()
        {
            IWebElement creditorname1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Creditor Name'])[3]")));
            creditorname1.SendKeys("Yes Bank");
        }

        [Then(@"Enter Date Opened")]
        public void ThenEnterDateOpened()
        {
            IWebElement OpenedDate1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Date Opened'])[1]")));
            OpenedDate1.Click();
            OpenedDate1.SendKeys("6/12/2018");
        }
        [Then(@"Enter Date Opened Credit Card")]
        public void ThenEnterDateOpenedCreditCard()
        {
            IWebElement OpenedDate2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Date Opened'])[2]")));
            OpenedDate2.Click();
            OpenedDate2.SendKeys("6/10/2015");
        }
        [Then(@"Enter Date Opened Credit Card second")]
        public void ThenEnterDateOpenedCreditCardSecond()
        {
            IWebElement OpenedDate3= wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Date Opened'])[3]")));
            OpenedDate3.Click();
            OpenedDate3.SendKeys("12/6/2013");
        }

        [Then(@"Enter Balance Amount Credit Card")]
        public void ThenEnterBalanceAmountCreditCard()
        {
            IWebElement BalanceAmtCredit1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Balance Amount'])[2]")));
            BalanceAmtCredit1.SendKeys("3508");
        }
        [Then(@"Enter Balance Amount Credit Card second")]
        public void ThenEnterBalanceAmountCreditCardSecond()
        {
            IWebElement BalanceAmtCredit2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Balance Amount'])[3]")));
            BalanceAmtCredit2.SendKeys("3045");
        }

        [Then(@"Enter Account Number Credit Card")]
        public void ThenEnterAccountNumberCreditCard()
        {
            IWebElement AccountNo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Account Number'])[2]")));
            AccountNo.SendKeys("345678967");
        }
        [Then(@"Enter Account Number Credit Card second")]
        public void ThenEnterAccountNumberCreditCardSecond()
        {
            IWebElement AccountNo1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Account Number'])[3]")));
            AccountNo1.SendKeys("345678447");
        }

        [Then(@"Enter Credit Limit first")]
        public void ThenEnterCreditLimitFirst()
        {
            IWebElement termscc1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Credit Limit'])[1]")));
            termscc1.SendKeys("0");
        }
        [Then(@"Enter Credit Limit second")]
        public void ThenEnterCreditLimitSecond()
        {
            IWebElement termscc2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Credit Limit'])[2]")));
            termscc2.SendKeys("0");
        }

        [Then(@"Enter Months Reviewed Credit Card")]
        public void ThenEnterMonthsReviewedCreditCard()
        {
            IWebElement monthreviewedcc1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Months Reviewed'])[2]")));
            monthreviewedcc1.SendKeys("99");
        }
        [Then(@"Enter Months Reviewed Credit Card second")]
        public void ThenEnterMonthsReviewedCreditCardSecond()
        {
            IWebElement monthreviewedcc2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Months Reviewed'])[3]")));
            monthreviewedcc2.SendKeys("99");
        }

        [Then(@"Click on Payment Amount Credit Card")]
        public void ThenClickOnPaymentAmountCreditCard()
        {
            IWebElement paymentamountcc1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Payment Amount'])[2]")));
            paymentamountcc1.SendKeys("78");
        }
        [Then(@"Click on Payment Amount Credit Card second")]
        public void ThenClickOnPaymentAmountCreditCardSecond()
        {
            IWebElement paymentamountcc2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Payment Amount'])[3]")));
            paymentamountcc2.SendKeys("65");
        }

        [When(@"Click Next for Income and Asset Details")]
        public void WhenClickNextForIncomeAndAssetDetails()
        {
            _sbo.ClickOnNextbtnforIncomeAssetsPage();
        }
        [Then(@"Click on Next Link for Liabilites Page")]
        public void ThenClickOnNextLinkForLiabilitesPage()
        {
            _sbo.ClickOnNextbtnForLiabilites();
        }
        [Then(@"Click On Add Liability Button")]
        public void ThenClickOnAddLiabilityButton()
        {
            _sbo.ClickOnLiabilityButton();
        }
        [Then(@"Click on Liabilities Option")]
        public void ThenClickOnLiabilitiesOption()
        {
            _sbo.ClickOnLiblityDropdown();
        }

        [Then(@"Click on Liabilities Option for first Credit Card")]
        public void ThenClickOnLiabilitiesOptionForFirstCreditCard()
        {
            _sbo.ClickOnLiblityDropdown1();
        }
        [Then(@"Click on Liabilities Option for Second Credit Card")]
        public void ThenClickOnLiabilitiesOptionForSecondCreditCard()
        {
            _sbo.ClickOnLiblityDropdown2();
        }

        [Then(@"Select Liability from Dropdown")]
        public void ThenSelectLiabilityFromDropdown()
        {
            _sbo.SelectLiability();
        }
        [Then(@"Select Liability from Dropdown Credit Card")]
        public void ThenSelectLiabilityFromDropdownCreditCard()
        {
            _sbo.SelectLiabilityCreditCard1();
        }
        [Then(@"Select Liability from Dropdown Credit Card second")]
        public void ThenSelectLiabilityFromDropdownCreditCardSecond()
        {
            _sbo.SelectLiabilityCreditCard2();
        }

        [Then(@"Enter Balance Amount")]
        public void ThenEnterBalanceAmount()
        {
            _sbo.EnterBalanceAmtforLiability();
        }
        [Then(@"Enter Account Number")]
        public void ThenEnterAccountNumber()
        {
            //IWebElement AccNo1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Account Number'])[1]")));
            //AccNo1.SendKeys("70401260748384443");
        }

        [Then(@"Click the Dropdown Icon")]
        public void ThenClickTheDropdownIcon()
        {
            //_sbo.ClickOnDropdownIcon();
        }
        [Then(@"Click on Original Loan Amount")]
        public void ThenClickOnOriginalLoanAmount()
        {
            //_sbo.EnterOrignalLoanAmount();
        }
        [Then(@"Click on Payment Amount")]
        public void ThenClickOnPaymentAmount()
        {
            //_sbo.EnterPaymentAmount();
        }
        [Then(@"Enter Terms")]
        public void ThenEnterTerms()
        {
            //_sbo.EnterTermLiability();
        }
        [Then(@"Enter Interest Rate")]
        public void ThenEnterInterestRate()
        {
            //_sbo.EnterInterestRate();
        }


        [Then(@"Enter Year")]
        public void ThenEnterYear()
        {
            //IWebElement ClickonYear = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[1]/ng-select/div")));
            //ClickonYear.Click();
            //IWebElement SelectYear = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
            //SelectYear.Click();
        }
        [Then(@"Enter Make")]
        public void ThenEnterMake()
        {
            //IWebElement ClickOnMake = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[2]/ng-select/div/div/div[2]/input")));
            //ClickOnMake.Click();
            //IWebElement SelectMake = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[26]")));
            //SelectMake.Click();
        }
        [Then(@"Enter Model")]
        public void ThenEnterModel()
        {
            //Actions action = new Actions(_driver);
            //IWebElement ClickOnModel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='cdk-step-content-0-5']/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[3]/ng-select/div/div/div[2]/input")));
            //action.MoveToElement(ClickOnModel).Click().Perform();
            //IWebElement SelectModal = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[5]")));
            //exec.ExecuteScript("arguments[0].click();", SelectModal);
        }
        [Then(@"Select Body")]
        public void ThenSelectBody()
        {
            //IWebElement ClickOnBody = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[4]/ng-select/div")));
            //ClickOnBody.Click();
            //IWebElement SelectBody = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[5]")));
            //SelectBody.Click();
        }

        //[Then(@"Click on Next link for Co Borrower details")]
        //public void ThenClickOnNextLinkForCoBorrowerDetails()
        //{
        //    _sbo.NextbtnlinkCoborrowerPersonal();
        //}
        //[Then(@"Enter Firstname of CoBorrower")]
        //public void ThenEnterFirstnameOfCoBorrower()
        //{
        //    _sbo.CoBorrowerFirstName();
        //}
        //[Then(@"Enter Last name of CoBorrower")]
        //public void ThenEnterLastNameOfCoBorrower()
        //{
        //    _sbo.CoBorrowerLastName();
        //}
        //[Then(@"Enter CoBorrower Date of Birth")]
        //public void ThenEnterCoBorrowerDateOfBirth()
        //{
        //    IWebElement ClickonDate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/div[1]/div[6]/mat-form-field/div/div[1]/div[1]/input")));
        //    ClickonDate.Click();
        //    IWebElement SelectDateOfBirth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/div/mat-datepicker-content/div[2]/mat-calendar/div/mat-month-view/table/tbody/tr[1]/td[2]/div[1]")));
        //    SelectDateOfBirth.Click();
        //}

        //[Then(@"Enter Coborrower Social ""(.*)""")]
        //public void ThenEnterCoborrowerSocial(string secnumber2)
        //{
        //    _sbo.CoSecurityNumber(_propertyReader[secnumber2]);

        //}
        //[Then(@"Click on Next link for Coborrower Other information")]
        //public void ThenClickOnNextLinkForCoborrowerOtherInformation()
        //{
        //    _sbo.nextbtnlinkCoboOtherInfo();
        //}
        //[Then(@"Enter CoBorrower Address line one")]
        //public void ThenEnterCoBorrowerAddressLineOne()
        //{
        //    _sbo.CoAddressLineOne();
        //}
        //[Then(@"Enter CoBorrower Address line two")]
        //public void ThenEnterCoBorrowerAddressLineTwo()
        //{
        //    _sbo.CoAddressLinetwo();
        //}
        //[Then(@"Enter CoBorrower City")]
        //public void ThenEnterCoBorrowerCity()
        //{
        //    _sbo.CityCoBorrower();
        //}
        //[Then(@"Enter CoBorrower ZipCode")]
        //public void ThenEnterCoBorrowerZipCode()
        //{
        //    _sbo.CoZipCode();
        //}
        //[Then(@"Click Next Page Icon for CoBorrower")]
        //public void ThenClickNextPageIconForCoBorrower()
        //{
        //    IWebElement ClickAddLiabilitiesnextlinkForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/div[2]/a[2]")));
        //    ClickAddLiabilitiesnextlinkForCoborrower.Click();
        //}
        //[Then(@"Click Add Liabilities Button for CoBorrower")]
        //public void ThenClickAddLiabilitiesButtonForCoBorrower()
        //{
        //    IWebElement ClickAddLiabilitiesButtonForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div/button")));
        //    ClickAddLiabilitiesButtonForCoborrower.Click();
        //}
        //[Then(@"Select Liabilities for CoBorrower")]
        //public void ThenSelectLiabilitiesForCoBorrower()
        //{
        //    IWebElement SelectLiabilitiesForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[2]/div/ng-select/div/div/div[2]/input")));
        //    SelectLiabilitiesForCoborrower.Click();
        //    IWebElement SelectLiabilitiesfromDropdown = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
        //    SelectLiabilitiesfromDropdown.Click();
        //}
        //[Then(@"Click on Balance Amount for CoBorrower")]
        //public void ThenClickOnBalanceAmountForCoBorrower()
        //{
        //    IWebElement BalanceAmountForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[3]/div[3]/mat-form-field/div/div[1]/div/input")));
        //    BalanceAmountForCoborrower.SendKeys("7000");
        //}
        //[Then(@"Click the Dropdown Icon for CoBorrower")]
        //public void ThenClickTheDropdownIconForCoBorrower()
        //{
        //    IWebElement DropdownIconForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[3]/div[4]/div/a")));
        //    DropdownIconForCoborrower.Click();
        //}
        //[Then(@"Check on Has Special Interest Rate")]
        //public void ThenCheckOnHasSpecialInterestRate()
        //{
        //    IWebElement SpecialInterestCheckbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div/mat-checkbox/label/span[1]")));
        //    SpecialInterestCheckbox.Click();
        //}

        //[Then(@"Click on Original Loan Amount for CoBorrower")]
        //public void ThenClickOnOriginalLoanAmountForCoBorrower()
        //{
        //    IWebElement OrignalLoanAmount = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
        //    OrignalLoanAmount.SendKeys("10000");

        //}
        //[Then(@"Click on Payment Amount for CoBorrower")]
        //public void ThenClickOnPaymentAmountForCoBorrower()
        //{
        //    IWebElement PaymentAmountForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[6]/mat-form-field/div/div[1]/div/input")));
        //    PaymentAmountForCoborrower.SendKeys("4000");
        //}
        //[Then(@"Enter Terms for CoBorrower")]
        //public void ThenEnterTermsForCoBorrower()
        //{
        //    IWebElement TermsForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
        //    TermsForCoborrower.SendKeys("4");
        //}
        //[Then(@"Enter Interest Rate for CoBorrower")]
        //public void ThenEnterInterestRateForCoBorrower()
        //{
        //    IWebElement RateForCoborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[1]/div[4]/mat-form-field/div/div[1]/div/input")));
        //    RateForCoborrower.SendKeys("3");
        //}
        //[Then(@"Enter Special Interest Rate For Co Borrower")]
        //public void ThenEnterSpecialInterestRateForCoBorrower()
        //{
        //    IWebElement SpecialInterestRate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div[2]/mat-form-field/div/div[1]/div/input")));
        //    SpecialInterestRate.SendKeys("3");
        //}

        //[Then(@"Enter Year for CoBorrower")]
        //public void ThenEnterYearForCoBorrower()
        //{
        //    IWebElement EnterYear = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[1]/ng-select/div/div/div[2]/input")));
        //    EnterYear.Click();
        //    IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
        //    Select.Click();
        //}
        //[Then(@"Enter Make for CoBorrower")]
        //public void ThenEnterMakeForCoBorrower()
        //{
        //    IWebElement EnterYear = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[2]/ng-select/div/div/div[2]/input")));
        //    EnterYear.Click();

        //    IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[4]")));
        //    Select.Click();
        //}
        //[Then(@"Enter Model for CoBorrower")]
        //public void ThenEnterModelForCoBorrower()
        //{
        //    IWebElement EnterYear = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[2]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[3]/ng-select/div/div/div[2]/input")));
        //    EnterYear.Click();
        //    IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[3]")));
        //    Select.Click();
        //}
        [Then(@"Click on Next link for Borrower Other information Page")]
        public void ThenClickOnNextLinkForBorrowerOtherInformationPage()
        {
            IWebElement nextpageforOtherInfo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]/i")));
            nextpageforOtherInfo.Click();
        }
        [Then(@"Click on Next link for Employer more information Page")]
        public void ThenClickOnNextLinkForEmployerMoreInformationPage()
        {
            IWebElement nextpageforEmployerpage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]/i")));
            nextpageforEmployerpage.Click();
        }
        [Then(@"Enter CoBorrower Employer Name")]
        public void ThenEnterCoborrowerEmployerName()
        {
            IWebElement CoborrowerEmployerName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[3]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            CoborrowerEmployerName.SendKeys("Ajay Kumar");
        }
        [Then(@"Enter CoBorrower Phone Number")]
        public void ThenEnterCoborrowerPhoneNumber()
        {
            IWebElement CoborrowerPhoneNumber = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[3]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            CoborrowerPhoneNumber.SendKeys("8076478072");
        }
        [Then(@"Enter CoBorrower Title")]
        public void ThenEnterCoborrowerTitle()
        {
            IWebElement CoborrowerTitle = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[3]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            CoborrowerTitle.SendKeys("Mr.");
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
            CoborrowerAddressLineFirst.SendKeys("HN-51 New Colony Jagnnathpur, Dhurwa");

        }
        [Then(@"Enter CoBorrower Address line Second")]
        public void ThenEnterCoborrowerAddressLineSecond()
        {
            IWebElement CoborrowerAddressLineSecond = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/form/div[4]/div/div[2]/mat-form-field/div/div[1]/div/input")));
            CoborrowerAddressLineSecond.SendKeys("HN-51 New Colony Jagnnathpur, Near Jagnnathpur Temple");
        }
        [Then(@"Click on Next for Co Borrower Employeer Page")]
        public void ThenClickOnNextForCoBorrowerEmployeerPage()
        {
            IWebElement nextpageforCoboEmployeer = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i")));
            nextpageforCoboEmployeer.Click();
        }
        [Then(@"Enter Amount in Rainy Day Fund Borrower")]
        public void ThenEnterAmountInRainyDayFundBorrower()
        {
            IWebElement clickonreturn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Rate of Return'])[1]")));
            clickonreturn.Click();
            IWebElement rainydayborrower = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Rainy Day Fund'])[1]")));
            rainydayborrower.SendKeys("200");
            clickonreturn.Click();
        }
        [Then(@"Click on next Button link for Coborrower Annual Income")]
        public void ThenClickOnNextButtonLinkForCoborrowerAnnualIncome()
        {
            IWebElement nextbtnCoboAnnualIncome = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]/i")));
            nextbtnCoboAnnualIncome.Click();
        }
        [Then(@"Enter Months Reviewed")]
        public void ThenEnterMonthsReviewed()
        {
            IWebElement MonthReviewed = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@data-placeholder='Months Reviewed'])[1]")));
            MonthReviewed.SendKeys("26");
        }
        [Then(@"Click the Dropdown Icon For first Credit Card")]
        public void ThenClickTheDropdownIconForFirstCreditCard()
        {
            IWebElement dropdown2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[2]/app-liability/div/mat-card/div[3]/div[4]/div/a/i")));
            dropdown2.Click();
        }
        [Then(@"Click the Dropdown Icon Second Credit Card")]
        public void ThenClickTheDropdownIconSecondCreditCard()
        {
            IWebElement dropdown3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[3]/app-liability/div/mat-card/div[3]/div[4]/div/a/i")));
            dropdown3.Click();
        }

        [Then(@"Click Next for SBO Report")]
        public void ThenClickNextForSBOReport()
        {
            _sbo.NextlinkforSBO();
            Thread.Sleep(10000);
        }
    }
}

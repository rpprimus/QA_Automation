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
    public class Personal_info_Borr_CoBorr
    {
        private readonly IWebDriver _driver;
        readonly Actions act;


        protected readonly PropertyReader _propertyReader;
        protected readonly Personal_info_Borr_CoBorrPageObject _personal_info_Borr_CoBorrPageObject;

        WebDriverWait wait;

        public Personal_info_Borr_CoBorr(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _personal_info_Borr_CoBorrPageObject = new Personal_info_Borr_CoBorrPageObject(_driver);
            act = new Actions(driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }


        [Then(@"Select Yes button")]
        public void ThenSelectYesButton()
        {
            IWebElement Yesbtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/form/div[1]/div/div/mat-button-toggle-group/mat-button-toggle[1]/button")));
            act.MoveToElement(Yesbtn).Click().Build().Perform();
        }
        [Then(@"Click on personal information")]
        public void ThenClickOnPersonalInformation()
        {
            Thread.Sleep(2000);
            IWebElement personalInfo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[1]/mat-step-header[3]")));
            act.MoveToElement(personalInfo).Click().Build().Perform();

        }
        //[Then(@"Enter Firstname of Borrower")]
        //public void ThenEnterFirstnameOfBorrower()
        //{

        //    IWebElement Bofirstname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[1]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
        //    Bofirstname.SendKeys("Alexandra");
        //}
        //[Then(@"Enter Last name of Borrower")]
        //public void ThenEnterLastNameOfBorrower()
        //{
        //    IWebElement Bolastname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[1]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
        //    Bolastname.Click();
        //    Bolastname.SendKeys("Haynes");
        //}
        //[Then(@"Enter Borrower Date of Birth")]
        //public void ThenEnterBorrowerDateOfBirth()
        //{
        //    IWebElement BorrowerDateOfBirth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[1]/div[1]/div[6]/mat-form-field/div/div[1]/div[1]/input")));
        //    BorrowerDateOfBirth.Click();
        //    IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/div/mat-datepicker-content/div[2]/mat-calendar/div/mat-month-view/table/tbody/tr[1]/td[2]/div[1]")));
        //    Select.Click();
        //}

        //[Then(@"Enter Social ""(.*)""")]
        //public void ThenEnterSocial(String securitynumber)
        //{
        //    _personal_info_Borr_CoBorrPageObject.EnterSecuritynumber(_propertyReader[securitynumber]);

        //}
        [Then(@"Click on Next icon for Borrower other information")]
        public void ThenClickOnNexticonForBorrowerOtherInformation()
        {
            IWebElement Nexticon = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]")));
            Nexticon.Click();
        }
        [Then(@"Enter Address line one")]
        public void ThenEnterAddressLineOne()
        {
            IWebElement AddressLineOne = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[2]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            AddressLineOne.Click();
            AddressLineOne.SendKeys("260-C North El Camino Real");
        }
        [Then(@"Enter Address line two")]
        public void ThenEnterAddressLineTwo()
        {
            IWebElement AddressLineTwo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[2]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            AddressLineTwo.Click();
            AddressLineTwo.SendKeys("Suite G102 unit 98");
        }
        [Then(@"Enter City")]
        public void ThenEnterCity()
        {
            IWebElement ThenEnterCity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[2]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            ThenEnterCity.Click();
            ThenEnterCity.SendKeys("San Marcos");
        }

        //[Then(@"Select State")]
        //public void ThenSelectState()
        //{
        //    IWebElement SelectState = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[2]/div[1]/div[4]/ng-select/div/div/div[2]/input")));
        //    SelectState.Click();

        //    IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[5]")));
        //    Select.Click();
        //}
        //[Then(@"Enter ZipCode")]
        //public void ThenEnterZipCode()
        //{
        //    IWebElement ZipCode = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[2]/div[1]/div[5]/mat-form-field/div/div[1]/div/input")));
        //    ZipCode.Click();
        //    ZipCode.SendKeys("93030");
        //}
        [Then(@"Click on Next link for Coborrower other information")]
        public void ThenClickOnNextLinkForCoBorrowerOtherInformation()
        {
            IWebElement CoBorrowerOtherInformation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]/i")));
            CoBorrowerOtherInformation.Click();
        }

        [Then(@"Click on Next link for Co-Borrower details")]
        public void ThenClickOnNextLinkForCo_BorrowerDetails()
        {
            IWebElement Co_BorrowerDetails = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]/i")));
            Co_BorrowerDetails.Click();
        }
        [Then(@"Enter Firstname of CoBorrower")]
        public void ThenEnterFirstnameOfCoBorrower()
        {
            IWebElement CoBofirstname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            CoBofirstname.Click();
            CoBofirstname.SendKeys("Sid");
        }
        [Then(@"Enter Last name of CoBorrower")]
        public void ThenEnterLastNameOfCoBorrower()
        {
            IWebElement CoBolastname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            CoBolastname.Click();
            CoBolastname.SendKeys("Kumar");
        }
        [Then(@"Enter CoBorrower Date of Birth")]
        public void ThenEnterCoBorrowerDateOfBirth()
        {
            IWebElement CoBorrowerDateOfBirth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/div[1]/div[6]/mat-form-field")));
            CoBorrowerDateOfBirth.Click();
            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/div/mat-datepicker-content/div[2]/mat-calendar/div/mat-month-view/table/tbody/tr[1]/td[2]/div[1]")));
            Select.Click();
        }

        [Then(@"Enter Coborrower Social ""(.*)""")]
        public void ThenEnterCoborrowerSocial(string secnumber2)
        {
            _personal_info_Borr_CoBorrPageObject.EnterCoSecuritynumber(_propertyReader[secnumber2]);

        }
        [Then(@"Enter CoBorrower Address line one")]
        public void ThenEnterCoBorrowerrAddressLineOne()
        {
            IWebElement CoBorrowerrAddressLineOne = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[4]/div[1]/div[1]/mat-form-field/div/div[1]/div/input")));
            CoBorrowerrAddressLineOne.Click();
            CoBorrowerrAddressLineOne.SendKeys("2855 Stevens CreekBLVD");
        }
        [Then(@"Enter CoBorrower Address line two")]
        public void ThenEnterCoBorrowerAddressLineTwo()
        {
            IWebElement CoBorrowerAddressLineTwo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[4]/div[1]/div[2]/mat-form-field/div/div[1]/div/input")));
            CoBorrowerAddressLineTwo.Click();
            CoBorrowerAddressLineTwo.SendKeys("Suite 2461 unit 10");
        }
        [Then(@"Enter CoBorrower City")]
        public void ThenEnterCoBorrowerCity()
        {
            IWebElement CoBorrowerCity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[4]/div[1]/div[3]/mat-form-field/div/div[1]/div/input")));
            CoBorrowerCity.Click();
            CoBorrowerCity.SendKeys("Santa Clara");
        }

        [Then(@"Select CoBorrower State")]
        public void ThenSelectCoBorrowertState()
        {
            IWebElement CoBorrowertState = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[4]/div[1]/div[4]/ng-select/div/div/div[2]/input")));
            CoBorrowertState.Click();

            IWebElement Select = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/ng-dropdown-panel/div/div[2]/div[5]")));
            Select.Click();
        }
        [Then(@"Enter CoBorrower ZipCode")]
        public void ThenEnterCoborrowerZipCode()
        {
            IWebElement CoborrowerZipCode = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[4]/div[1]/div[5]/mat-form-field/div/div[1]/div/input")));
            CoborrowerZipCode.Click();
            CoborrowerZipCode.SendKeys("93030");
        }
        [Then(@"Click on Next link for borrower more information")]
        public void ThenClickOnNextLinkForBorrowerMoreInformation()
        {
            IWebElement BorrowerMoreInformation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/a[2]/i")));
            BorrowerMoreInformation.Click();
        }
        //[Then(@"Click on Next link for Employer more information")]
        //public void ThenClickOnNextLinkForEmployerMoreInformation()
        //{
        //    IWebElement EmployerMoreInformation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/a[2]/i")));
        //    EmployerMoreInformation.Click();
        //}
        //[Then(@"Click on Next link for Borrower other information")]
        //public void ThenClickOnNextLinkForBorrowerOtherInformation()
        //{
        //    IWebElement BorrowerOtherInformation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/a[2]")));
        //    BorrowerOtherInformation.Click();
        //}

    }
}

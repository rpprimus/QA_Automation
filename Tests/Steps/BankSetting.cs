﻿using Affordit_Automation.PageObjects;
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
    public class BankSetting
    {
        private IWebDriver _driver;
        protected readonly PropertyReader _propertyReader;
        protected readonly BankSettingPageObject _bSPageObject;
        public BankSetting(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _bSPageObject = new BankSettingPageObject(_driver);
        }
        [When(@"Click on Hamberber Menu")]
        public void WhenClickOnHamberberMenu()
        {
            
            _bSPageObject.HamMenu();
        }
        [Then(@"Click on Bank Setting")]
        public void ThenClickOnBankSetting()
        {
            _bSPageObject.BankSetting();
        }
        [Then(@"Click on Bank Rates")]
        public void ThenClickOnBankRates()
        {
            _bSPageObject.BankRate();
        }
        [Then(@"Select  Credit Card Classic")]
        public void ThenSelectCreditCardClassic()
        {
            _bSPageObject.Credit_Card_Classic();
        }
        [Then(@"Select Used Auto")]
        public void ThenSelectUsedAuto()
        {
            _bSPageObject.UsedAuto();
        }
        [Then(@"Click on Bank Value")]
        public void ThenClickOnBankValue()
        {
            _bSPageObject.BankValue();
        }
        [Then(@"Click on Product Financial Tables")]
        public void ThenClickOnProductFinancialTables()
        {
            _bSPageObject.Product_financial_table();
        }
        [Then(@"Change Interest Rate in Credit Card Classic")]
        public void ThenChangeInterestRateInCreditCardClassic()
        {
            _bSPageObject.InterestRateChangeFinancialTables();
            Thread.Sleep(7000);
        }
        [Then(@"Click on Save and Submit Button")]
        public void ThenClickOnSaveAndSubmitButton()
        {
            _bSPageObject.Save_And_Submitbtn();
            Thread.Sleep(2000);
        }
        [Then(@"Click on Refinance Option")]
        public void ThenClickOnRefinanceOption()
        {
            _bSPageObject.Refinance();
        }

        [Then(@"Click on Ranking Factors")]
        public void ThenClickOnRankingFactors()
        {
            _bSPageObject.Ranking_Factor();
        }
        [Then(@"Click on Monthly Payment Factor Rank")]
        public void ThenClickOnMonthlyPaymentFactorRank()
        {
            _bSPageObject.MonthlyPaymentRank();
        }
        [Then(@"Enter value in Monthly Payment Factor Rank")]
        public void ThenEnterValueInMonthlyPaymentFactorRank()
        {
            _bSPageObject.Monthly_Payment_Rank();
        }
        [Then(@"Click on Total Interest Rank")]
        public void ThenClickOnTotalInterestRank()
        {
            _bSPageObject.TotalInterestFactor();
        }
        [Then(@"Enter Value in Total Interest Rank")]
        public void ThenEnterValueInTotalInterestRank()
        {
            _bSPageObject.Total_Interest_Factor_Rank();
        }
        [Then(@"Click on Save Ranking Factor")]
        public void ThenClickOnSaveRankingFactor()
        {
            _bSPageObject.SaveRankingFactorBtn();
        }
        [Then(@"Click on Promotional Offers")]
        public void ThenClickOnPromotionalOffers()
        {
            _bSPageObject.Promotioal_Offer();
        }
        [Then(@"Click enable Insurance Option")]
        public void ThenClickEnableInsuranceOption()
        {
            _bSPageObject.ToggleInsurance();
        }
        [Then(@"Click disable Insurance Option")]
        public void ThenClickDisableInsuranceOption()
        {
            _bSPageObject.ToggleInsurance();
        }
        [Then(@"Click on Loan Group Option")]
        public void ThenClickOnLoanGroupOption()
        {
            _bSPageObject.Loan_Group();
        }
        [Then(@"Click on toggle HELOAN")]
        public void ThenClickOnToggleHELOAN()
        {
            _bSPageObject.ToggleLoangroup();
        }
        [Then(@"Click on Tenant Files")]
        public void ThenClickOnTenantFiles()
        {
            _bSPageObject.TenantFiles();
        }
        [Then(@"Click on Upload button")]
        public void ThenClickOnUploadButton()
        {
            _bSPageObject.UploadButton();
        }
        [Then(@"Choose on Purpose from Dropdown")]
        public void ThenChooseOnPurposeFromDropdown()
        {
            _bSPageObject.ClickOnDropDown();
        }
        [Then(@"Select Logo from dropdown")]
        public void ThenSelectLogoFromDropdown()
        {
            _bSPageObject.SelectPurpose();
        }
        [Then(@"Select File to Upload")]
        public void ThenSelectFileToUpload()
        {
            _bSPageObject.UploadFile();
        }
        [Then(@"Click on Upload Button to Upload File or Logo")]
        public void ThenClickOnUploadButtonToUploadFileOrLogo()
        {
            _bSPageObject.ClickOnUploadButton();
        }
        [Then(@"Click on Delete button")]
        public void ThenClickOnDeleteButton()
        {
            _bSPageObject.ClickOnDeleteBtn();
        }
        [Then(@"Click on Confirm Button to Delete")]
        public void ThenClickOnConfirmButtonToDelete()
        {
            _bSPageObject.ClickOnConfirm();
        }
        [Then(@"Click on Download button")]
        public void ThenClickOnDownloadButton()
        {
            _bSPageObject.ClickOnDownload();
            Thread.Sleep(5000);
        }
        [Then(@"Click on Edit button")]
        public void ThenClickOnEditButton()
        {
            _bSPageObject.ClickOnEdit();
        }
        [Then(@"Enter Data in filename")]
        public void ThenEnterDataInFilename()
        {
            _bSPageObject.EnterFileName();
        }
        [Then(@"Click on Update button")]
        public void ThenClickOnUpdateButton()
        {
            _bSPageObject.ClickOnUpdateBtn();
            Thread.Sleep(5000);
        }
        [Then(@"Click on Loan Type")]
        public void ThenClickOnLoanType()
        {
            _bSPageObject.LoanType();
        }
        [Then(@"Click on Add Loan Type")]
        public void ThenClickOnAddLoanType()
        {
            _bSPageObject.AddLoanType();
        }
        [Then(@"Click on Dropdown Loan Type")]
        public void ThenClickOnDropdownLoanType()
        {
            _bSPageObject.DropdownLoanType();
        }
        [Then(@"Select Personal for Loan Group")]
        public void ThenSelectPersonalForLoanGroup()
        {
            _bSPageObject.LoanGroup();
        }
        [Then(@"Enter Loan Type")]
        public void ThenEnterLoanType()
        {
            _bSPageObject.LoanTypeName();
        }
        [Then(@"Click on Add Loan Type Button")]
        public void ThenClickOnAddLoanTypeButton()
        {
            _bSPageObject.SaveLoanType();
            Thread.Sleep(5000);
        }

    }
}

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
    public class IncomeAndAssetsBorrower
    {
        Actions act;
        private IWebDriver _driver;
        public readonly PropertyReader _propertyReader = null;
        public LoginPageObjects _loginPageObjects = null;
        public IncomeAndAssetsPrimaryPageObject _AL1PageObjects = null;
        WebDriverWait wait;
        public IncomeAndAssetsBorrower(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _loginPageObjects = new LoginPageObjects(_driver);
            _AL1PageObjects = new IncomeAndAssetsPrimaryPageObject(_driver);
            act = new Actions(_driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(25));
        }

        [When(@"Click on Income and Assets Link")]
        public void WhenClickOnIncomeAndAssetsLink()
        {
            
            IWebElement NewAppBtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//div/span[contains(text(),'Income and')])")));
            act.MoveToElement(NewAppBtn).Click().Build().Perform();
          
        }
        [When(@"Enter Data in ""(.*)""")]
        public void WhenEnterDataIn(string ABIncome)
        {
            _AL1PageObjects.EnterAnnualBaseIncome(_propertyReader[ABIncome]);
        }
        [Then(@"Click on Monthly Income")]
        public void ThenClickOnMonthlyIncome()
        {

         
            _AL1PageObjects.MonthlyBaseIncome();
        
        }
        [Then(@"Click on Next Link for Assets Page")]
        public void ThenClickOnNextLinkForAssetsPage()
        {
           
            _AL1PageObjects.LinkForAssetsPage();

        }
        [When(@"Click on Add Borrower Assets Button")]
        public void WhenClickOnAddBorrowerAssetsButton()
        {
            _AL1PageObjects.AssetsButton();
         
        }
        [When(@"Click on Borrower Assets Page")]
        public void WhenClickOnBorrowerAssetsPage()
        {
  
            IWebElement NewAssetbtn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//*[@id='cdk-step-content-0-4']/app-financial-and-asset/div/div[2]/form/div[2]/div[1]/div/button)")));
            act.MoveToElement(NewAssetbtn).Click().Build().Perform();
           
        }

        [When(@"Select one Option From Dropdown ""(.*)""")]
        public void WhenSelectOneOptionFromDropdown(string atype)
        {
            _AL1PageObjects.AssetTypes(atype);
        }
        [When(@"Click on borrower Assets Type")]
        public void WhenClickOnBorrowerAssetsType()
        {
            _AL1PageObjects.AssetsType();
        }

        [Then(@"Enter Amount in ""(.*)""")]
        public void ThenEnterAmountIn(string amt)
        {        
            _AL1PageObjects.AddAssetsAmt(_propertyReader[amt]);           
        }
        [When(@"Enter Annual Overtime")]
        public void WhenEnterAnnualOvertime()
        {
            _AL1PageObjects.AnnualOvertime();
        }
        [When(@"Enter Annual Bonuses")]
        public void WhenEnterAnnualBonuses()
        {
            _AL1PageObjects.AnnualBonuses();
        }
        [When(@"Enter Annual Commissions")]
        public void WhenEnterAnnualCommissions()
        {
            _AL1PageObjects.AnnualCommision();
        }

        [When(@"Enter Annual Dividends/Interest")]
        public void ThenEnterAnnualDividendsInterest()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            IWebElement AnnualInterest = _driver.FindElement(By.XPath("//input[@data-placeholder='Annual Dividends/Interest']"));
            AnnualInterest.SendKeys("16000");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }
        [When(@"Enter Annual Net Rental Income")]
        public void ThenEnterAnnualNetRentalIncome()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            IWebElement ANRI = _driver.FindElement(By.XPath("//input[@data-placeholder='Annual Net Rental Income']"));
            ANRI.SendKeys("7500");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

        }

        [When(@"Enter Amount in Annual Other Income")]
        public void WhenEnterAmountInAnnualOtherIncome()
        {
            _AL1PageObjects.AnnualOtherIncome();
        }
        [When(@"Enter Description")]
        public void WhenEnterDescription()
        {
            _AL1PageObjects.Description();
        }
    
        [Then(@"Click on Next Button to See the Result")]
        public void ThenClickOnNextButtonToSeeTheResult()
        {
            _AL1PageObjects.NextForResult();
            Thread.Sleep(5000);// to see the result on Net Cash Available, THis is option , You can change
            //_AL1PageObjects.NetCashAvailable();
        }
        [Then(@"Click on Exclude Assets")]
        public void ThenClickOnExcludeAssets()
        {
            _AL1PageObjects.ExcludeAssets();
        }
        [Then(@"Enter Amount in Rainy Day Fund")]
        public void ThenEnterAmountInRainyDayFund()
        {
            _AL1PageObjects.RainyDayFund();
           
        }
        [Given(@"Click on Yes Button For CoBorrower")]
        public void GivenClickOnYesButtonForCoBorrower()
        {
            _AL1PageObjects.ClickOnYes();
        }
        [Then(@"Click on next Button link for Coborrower")]
        public void ThenClickOnNextButtonLinkForCoborrower()
        {
            _AL1PageObjects.ClickNextbtnforCo();
        }
        [Then(@"Enter Amount in ""(.*)"" Coborrower")]
        public void ThenEnterAmountInCoborrower(string amt)
        {
            _AL1PageObjects.EnterAnnualBaseIncomeCo(_propertyReader[amt]);
        }
        [Then(@"Click on Next btn Link for Coborrwer Assets")]
        public void ThenClickOnNextBtnLinkForCoborrwerAssets()
        {
            _AL1PageObjects.CoBorrowerAssets();
        }
        [Then(@"Clcik on Co Borrower Assets Button")]
        public void ThenClcikOnCoBorrowerAssetsButton()
        {
            _AL1PageObjects.CoBoAssetsBtn();
        }
        [Then(@"Click on Co borrower Assets  Types")]
        public void ThenClickOnCoBorrowerAssetsTypes()
        {
            _AL1PageObjects.ClickonAssestType();
        }
        [Then(@"Select one Option From Dropdown ""(.*)""")]
        public void ThenSelectOneOptionFromDropdown(string coatype)
        {
            _AL1PageObjects.AssetTypes(coatype);
        }
        [Then(@"Select Date From Date Picker")]
        public void ThenSelectDateFromDatePicker()
        {
            IWebElement date = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[4]/div[1]/mat-card/div[2]/div[2]/mat-form-field/div/div[1]")));
            date.Click(); ;
            new Actions(_driver).MoveToElement(date).MoveByOffset(100, 200).Click().Perform();
        }
        [Then(@"Enter Rate of Return")]
        public void ThenEnterRateOfReturn()
        {
            _AL1PageObjects.InterestRate();
        }
        [Then(@"Enter Amount for Assets")]
        public void ThenEnterAmountForAssets()
        {
            _AL1PageObjects.AssetsAmtCo();
        }
        [Then(@"Click on Next Button to See the Result for Primary and Co Borrower")]
        public void ThenClickOnNextButtonToSeeTheResultForPrimaryAndCoBorrower()
        {
            _AL1PageObjects.CoBoResult();
            Thread.Sleep(5000); // Optional to See the Result in Net Result
        }
        [Then(@"Enter Amount in Rainy Day Fund for Co Borrower")]
        public void ThenEnterAmountInRainyDayFundForCoBorrower()
        {
            _AL1PageObjects.RainyDayFundCoBo();
        }
        [Then(@"Enter Annual Overtime Co Borrower")]
        public void ThenEnterAnnualOvertimeCoBorrower()
        {
            _AL1PageObjects.AnnualOvertimeCo();
        }
        [Then(@"Enter Annual Bonuses Co Borrower")]
        public void ThenEnterAnnualBonusesCoBorrower()
        {
            _AL1PageObjects.AnnualBonusesCo();
        }
        [Then(@"Enter Annual Commissions Co Borrower")]
        public void ThenEnterAnnualCommissionsCoBorrower()
        {
            _AL1PageObjects.AnnualCommisionCo();
        }
        [Then(@"Enter Annual Dividends/Interest Co Borrower")]
        public void ThenEnterAnnualDividendsInterestCoBorrower()
        {
            _AL1PageObjects.AnnualDividendsInterestCo();
        }
        [Then(@"Enter Annual Net Rental Income Co Borrower")]
        public void ThenEnterAnnualNetRentalIncomeCoBorrower()
        {
            _AL1PageObjects.AnnualRentCoBo();
        }
        [Then(@"Enter Amount in Annual Other Income Co Borrower")]
        public void ThenEnterAmountInAnnualOtherIncomeCoBorrower()
        {
            _AL1PageObjects.AnnualOtherIncomeCoBo();
        }
        [Then(@"Enter Description Co Borrower")]
        public void ThenEnterDescriptionCoBorrower()
        {
            _AL1PageObjects.DescriptionCobo();
        }

    }
}

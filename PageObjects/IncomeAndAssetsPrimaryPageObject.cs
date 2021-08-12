using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
    public class IncomeAndAssetsPrimaryPageObject : DriverHelper
    {
        public string AnnualBaseIncome = "//input[@name='borrowerBaseIncome']";
        public By Annual => ByLocator("//input[@name='borrowerBaseIncome']");
        public By AnnualC => ByLocator("(//*[@id='mat-input-47'])");
        public By Monthly => ByLocator("(//*[@id='mat-input-35'])");
        public By CoMonthly => ByLocator("(//*[@id='mat-input-54'])");
        public By coborrower => ByLocator("(//*[@id='cdk-step-content-0-4']/app-financial-and-asset/div/div[2]/div/a[2])");
        public By SelectCo => ByLocator("(//button/span[text()='YES'])[1]");
        public By LinkAssetsPage => ByLocator("//*[@id='cdk-step-content-0-4']/app-financial-and-asset/div/div[2]/div/a[2]");
        public By Assetsbtn => ByLocator("//*[@id='cdk-step-content-0-4']/app-financial-and-asset/div/div[2]/form/div[2]/div[1]/div/button");
        public By Assetsamt => ByLocator("//input[@data-placeholder='Amount']");
        public By AssetsTypebtn => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[2]/div[1]/mat-card/div[2]/div[1]/ng-select/div");
        public By nextbtnResult => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]");
        public By netcash => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]");
        public By excludeassets => ByLocator("//span/input[@id='mat-checkbox-1-input']");
        public By rainyday => ByLocator("//input[@name='borrowerReserveAmount']");
        public By annualovertime => ByLocator("//input[@data-placeholder='Annual Overtime']");
        public By annualbonus => ByLocator("//input[@data-placeholder='Annual Bonuses']");
        public By annualcomm => ByLocator("//input[@data-placeholder='Annual Commissions']");
        public By Acomm => ByLocator("//input[@data-placeholder='Annual Commissions']");
        public By AOI => ByLocator("//input[@data-placeholder='Annual Other Income']");
        public By Desc => ByLocator("//input[@data-placeholder='Describe Other Income']");
        public By CoboNextLink => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]");
        public By coabtn => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[4]/div[1]/div/button");
        public By coboAssetstype => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[4]/div[1]/mat-card/div[2]/div[1]/ng-select/div");
        public By ROR => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[4]/div[1]/mat-card/div[2]/div[3]/mat-form-field/div/div[1]/div/input");
        public By AsAmtCo => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[4]/div[1]/mat-card/div[2]/div[4]/mat-form-field/div/div[1]/div/input");
        public By CoBoResView => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]/i");
        public By CoBoNextforAssets => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]");
        public By RateofRetureB => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[2]/div[1]/mat-card/div[2]/div[3]/mat-form-field/div/div[1]/div/input");
        public By rainydaycobo => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[4]/div[2]/div[2]/mat-form-field/div/div[1]/div/input");
        public By annualovertimeCo => ByLocator("//input[@name='coBorrowerOvertime']");
        public By annualbounsco => ByLocator("//input[@name='coBorrowerBonuses']");
        public By annualcommCo => ByLocator("//input[@name='coBorrowerCommissions']");
        public By annuadevco => ByLocator("//input[@name='coBorrowerDividends']");
        public By annuarentco => ByLocator("//input[@name='coBorrowerNetRentalIncome']");
        public By annotherincco => ByLocator("//input[@name='coBorrowerOtherIncome']");
        public By DescCobo => ByLocator("//input[@name='coBorrowerDescribeOtherIncome']");
        public By anotherAssetsbtn => ByLocator("/html/body/modal-container[2]/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[2]/div[1]/mat-card[2]/div[1]/a/i");
        public IncomeAndAssetsPrimaryPageObject(IWebDriver driver) : base(driver)
        { }
        public By AssetsXpath(string assettype)
        {
            return ByLocator($"//div//span[contains(text(),'{assettype}')]");
        }
        public By GetErrorXpath()
        {
            return ByLocator("/html/body/modal-container[2]/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/form/div[2]/div[1]/mat-card[2]/div[1]/a/is");
        }
        public bool IsAnotherAssetsPanelAppear()
        {
            WaitForElementDisplay(GetErrorXpath(), 20);
            return IsElementDisplayed(GetErrorXpath());
        }
        public void EnterAnnualBaseIncome(string ABIncome)
        {
            SendKeys(Annual, ABIncome, true);
        }
        public void MonthlyBaseIncome()
        {
            Click(Monthly);
        }
        public void ClickOnYes()
        {
            Click(SelectCo);
        }
        public void CoBorrowerLink()
        {
            Click(coborrower);
        }
        public void EnterAnnualBaseIncomeCo(string ACBIncome)
        {
            SendKeys(AnnualC, ACBIncome, true);
        }
        public void CoBorrowerBoard()
        {
            Click(CoMonthly);
        }
        public void AssetTypes(string atype)
        {
            Click(AssetsXpath(atype));
        }
        public void LinkForAssetsPage()
        {
            Click(LinkAssetsPage);
        }
        public void AssetsButton()
        {
            Click(Assetsbtn);
        }
        public void AddAssetsAmt(string assetsamt)
        {
            SendKeys(Assetsamt, assetsamt, true);
        }
        public void AssetsType()
        {
            Click(AssetsTypebtn);
        }
        public void NextForResult()
        {
            Click(nextbtnResult);
        }
        public void NetCashAvailable()
        {
            Click(netcash);
        }
        public void ExcludeAssets()
        {
            Click(excludeassets);
        }
        public void RainyDayFund()
        {       
            Click(RateofRetureB);
            Click(rainyday);
            SendKeys(rainyday, "2000", true);
            
        }
        public void AnnualOvertime()
        {
            SendKeys(annualovertime, "5000", true);
        }
        public void AnnualBonuses()
        {
            SendKeys(annualbonus, "10000", true);
        }
        public void AnnualCommision()
        {
            SendKeys(Acomm,"1000",true);
        }
        public void AnnualOtherIncome()
        {
            SendKeys(AOI, "10000", true);
        }
        public void Description()
        {
            Click(annualbonus);
            SendKeys(Desc, "Getting Interesrt From Shares Market", true);
        }
        public void ClickNextbtnforCo()
        {
            Click(CoboNextLink);
        }
        public void CoBoAssetsBtn()
        {
            Click(coabtn);
        }
        public void ClickonAssestType()
        {
            Click(coboAssetstype);
        }
        public void InterestRate()
        {
            SendKeys(ROR, "3", true);
        }
        public void AssetsAmtCo()
        {
            SendKeys(AsAmtCo, "30000", true);
        }
        public void CoBoResult()
        {
            Click(CoBoResView);
        }
        public void CoBorrowerAssets()
        {
            Click(CoBoNextforAssets);
        }
        public void RainyDayFundCoBo()
        {
            Click(ROR);
            Thread.Sleep(2000);
            SendKeys(rainydaycobo, "1500", true);
            Click(ROR);
        }
        public void AnnualOvertimeCo()
        {
            SendKeys(annualovertimeCo, "5500", true);
        }
        public void AnnualBonusesCo()
        {
            SendKeys(annualbounsco, "2500", true);
        }
        public void AnnualCommisionCo()
        {
            SendKeys(annualcommCo, "2500", true);
        }
        public void AnnualDividendsInterestCo()
        {
            SendKeys(annuadevco, "3500", true);
        }
        public void AnnualRentCoBo()
        {
            SendKeys(annuarentco, "3000", true);
        }
        public void AnnualOtherIncomeCoBo()
        {
            SendKeys(annotherincco, "3000", true);
        }
        public void DescriptionCobo()
        {
            Click(annuadevco);
            SendKeys(DescCobo, "Geeting Money from Rent", true);
        }
    }
}

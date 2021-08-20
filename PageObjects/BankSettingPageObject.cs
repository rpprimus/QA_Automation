﻿using Affordit_Automation.Utils;
using AutoItX3Lib;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
   public class BankSettingPageObject : DriverHelper
    {
        public By hammenu => ByLocator("/html/body/app-root/app-private-layout/div[1]/div/div[1]/a/i");
        public By banksettinglink => ByLocator("//a[@href='#/manage']");
        public By bankrate => ByLocator("//a[@href='#/manage/bank-rates']");
        public By bankvalue => ByLocator("//a[@href='#/manage/bank-values']");
        public By productfinrate => ByLocator("//a[@href='#/manage/product-financial-tables']");
        public By refinance => ByLocator("//a[@href='#/manage/refinance-options']");
        public By rankingfactor => ByLocator("//a[@href='#/manage/ranking-factors']");
        public By loangroupoption => ByLocator("//a[@href='#/manage/loan-group-options']");
        public By promotional => ByLocator("//a[text()='Promotional Offers']");
        public By loangroup => ByLocator("//a[text()='Loan Group Options']");
        public By tenant => ByLocator("//a[contains(text(),'Tenant Files')]");
        public By monthlyPaymentfactorrank => ByLocator("//span[text()='Monthly Payment Factor']");
        public By mpfr => ByLocator("(//input[@data-placeholder='Rank'])[1]");
        public By totalInterestfactor => ByLocator("//span[text()='Total Interest Factor']");
        public By saverankingfactorbtn => ByLocator("(//button[contains(text(),'Save Ranking Factors')])[1]");
        public By tif => ByLocator("(//input[@data-placeholder='Rank'])[2]");
        public By ccclassic => ByLocator("//span[contains(text(),'Credit Card Classic')]");  
        public By usedauto => ByLocator("//span[contains(text(),'Used Auto')]");
        public By interestrateft => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-product-financial-tables/div/div/div[2]/mat-accordion/mat-expansion-panel[1]/div/div/div[4]/div[1]/table/tr[3]/td[3]/input");
        public By insurancetoggle => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-cross-sell-items/div/div[3]/table/tbody/tr[2]/td[3]/mat-slide-toggle/label/div");
        public By savesubmitbtnfinance => ByLocator("(//button[contains(text(),'Save and Submit')])[1]");
        public By heloan => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-loan-group-options/div/div[2]/table/tbody/tr[16]/td[2]/mat-slide-toggle");
        public By purpose => ByLocator("/html/body/modal-container/div[2]/div/app-upload-tenant-file-modal/app-upload-file-modal/div[2]/mat-form-field/div/div[1]/div/mat-select/div/div[2]/div");
        public By Uploadbtn => ByLocator("//button[contains(text(),'Upload')]");
        public By selectfile => ByLocator("/html/body/modal-container/div[2]/div/app-upload-tenant-file-modal/app-upload-file-modal/div[2]/div/app-copernicus-file-uploader/div/label");
        public By uploadbtn => ByLocator("/html/body/modal-container/div[2]/div/app-upload-tenant-file-modal/app-upload-file-modal/div[2]/div/app-copernicus-file-uploader/div/button");
        public By deletebtn => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-tenant-files/div/table/tbody/tr/td[7]/button[3]/span");
        public By confirmbtn => ByLocator("//button[text()=' Confirm ']");
        public By downloadbtn => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-tenant-files/div/table/tbody/tr/td[7]/button[2]/span");
        public By editbtn => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-tenant-files/div/table/tbody/tr/td[7]/button[1]/span");
        public By filename => ByLocator("//input[@name='fileName']");
        public By updatebtn => ByLocator("//button[contains(text(),'Update')]");
        public By loantypebtn => ByLocator("//a[contains(text(),'Loan Types')]");
        public By loantypename => ByLocator("/html/body/modal-container/div[2]/div/app-configurable-loan-type-modal/div[2]/form/mat-form-field/div/div[1]/div/input");
        public By addloanbtn => ByLocator("//button[contains(text(),'Add Loan Type')]");
        public By dropdownloantype => ByLocator("/html/body/modal-container/div[2]/div/app-configurable-loan-type-modal/div[2]/form/ng-select/div/span");
        public By saveloantype => ByLocator("/html/body/modal-container/div[2]/div/app-configurable-loan-type-modal/div[3]/button");
        public By mortgage20=>ByLocator("//span[text()='Mortgage 20 Year']");
        public By refinanceloantype => ByLocator("/html/body/app-root/app-private-layout/app-manage/div/div/div/app-refinance-options/div/div/form/mat-accordion/mat-expansion-panel[7]/div/div/div/ng-select/div/div/div[6]");
        public BankSettingPageObject(IWebDriver driver) : base(driver)
        {
        }
        public By Purpose(string purpose)
        {
            return ByLocator($"//div//span[contains(text(),'{purpose}')]");

        }
        public By LoanGroupOption()
        {
            return ByLocator($"(//div//span[contains(text(),'Personal')])[4]");
        }
        public void HamMenu()
        {
            
            Click(hammenu);
        }
        public void BankSetting()
        {
            Click(banksettinglink);
        }
        public void BankRate()
        {
            Click(bankrate); 
        }
        public void Credit_Card_Classic()
        {
            Click(ccclassic);
        }
        public void UsedAuto()
        {
            Click(usedauto);
        }
        public void BankValue()
        {
            Click(bankvalue);
        }
        public void Product_financial_table()
        {
            Click(productfinrate);
        }
        public void InterestRateChangeFinancialTables()
        {
            Click(interestrateft);
            SendKeys(interestrateft, "19.9", true);
        }
        public void Save_And_Submitbtn()
        {
            Click(savesubmitbtnfinance);
        }
        public void Refinance()
        {
            Click(refinance);
        }
        public void Ranking_Factor()
        {
            Click(rankingfactor);
        }
        public void MonthlyPaymentRank()
        {
            Click(monthlyPaymentfactorrank);
        }
        public void Monthly_Payment_Rank()
        {
            Click(mpfr);
            SendKeys(mpfr,"74",true);
           
        }
        public void TotalInterestFactor()
        {
            Click(totalInterestfactor);
        }
        public void Total_Interest_Factor_Rank()
        {
            Click(tif);
            SendKeys(tif, "26", true);
           
        }
        public void SaveRankingFactorBtn()
        {
            Click(saverankingfactorbtn);
        }
        public void Promotioal_Offer()
        {
            Click(promotional);
        }
        public void ToggleInsurance()
        {
            Click(insurancetoggle);
        }
        public void Loan_Group()
        {
            Click(loangroup);
        }
        public void ToggleLoangroup()
        {
           // Thread.Sleep(2000);
            Click(heloan);
          // Thread.Sleep(5000);
        }
        public void TenantFiles()
        {
            Click(tenant);
        }
        public void UploadButton()
        {          
            Click(Uploadbtn);
        }
        public void ClickOnDropDown()
        {
            Click(purpose);
        }
        public void SelectPurpose(string pur)
        {
            Click(Purpose(pur));
        }
        public void UploadFile()
        {
            string path = @"C:\title-logo.png";
            Click(selectfile);
            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");
            auto.Send(path);
            //Thread.Sleep(1000);
            auto.Send("{ENTER}");
           // Thread.Sleep(1000);
        }
        public void ClickOnUploadButton()
        {
            Click(uploadbtn);
          //  Thread.Sleep(2000);
        }
        public void ClickOnDeleteBtn()
        {
            Click(deletebtn);
            //Thread.Sleep(2000);
        }
        public void ClickOnConfirm()
        {
            Click(confirmbtn);
          //  Thread.Sleep(3000);
        }
        public void ClickOnDownload()
        {
            Click(downloadbtn);
        }
        public void ClickOnEdit()
        {
            Click(editbtn);
        }
        public void EnterFileName()
        {
            SendKeys(filename,"Logo Demo",true);
        }
        public void ClickOnUpdateBtn()
        {
            Click(updatebtn);
        }
        public void LoanType()
        {
            Click(loantypebtn);
        }
        public void LoanGroup()
        {
            Click(LoanGroupOption());
        }
        public void AddLoanType()
        {
            Click(addloanbtn);
        }
        public void DropdownLoanType()
        {
            Click(dropdownloantype);
        }
        public void LoanTypeName()
        {
            SendKeys(loantypename, "Test(Loan Personal)", true);
        }
        public void SaveLoanType()
        {
            Click(saveloantype);
        }
    }
}

using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
	public class BorrowerAndCoBorrowerPageObjects : DriverHelper
	{
		public By AddAppButton => ByLocator("//button[@class='btn btn-primary ng-tns-c228-0");
		public By ModalBlankCredit => ByLocator("//*[@id='cdk-step-content-1-0']/app-credit-record/div/div[2]/form/div[2]/div");
		public By NextLinkForCoborrower => ByLocator("//app-financial-and-asset/div/div[2]/div/a[2]");
		public By userName => ByLocator("id=Username");
		public By CoCredit1 => ByLocator("//input[@id= 'mat-input-44']");
		public By CoCredit2 => ByLocator("//input[@id= 'mat-input-45']");
		public By CoCredit3 => ByLocator("//input[@id= 'mat-input-46']");

		public By userPassword => ByLocator("id=Password");
		public By loginButton => ByLocator("css=button[value='login']");
		public By selectButton => ByLocator("css=button[type='submit']");
		public By userMenu => ByLocator("css=a.user-menu-link");
		public By BtnYes => ByLocator("(//button/span[text()='YES'])[1]");
		public By forCreditScore => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]");
		public By forCreditScoreCo => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]");
		public BorrowerAndCoBorrowerPageObjects(IWebDriver driver) : base(driver)
		{
		}
		public By TenentXpathNew(string tenent)
		{
			return ByLocator($"//li[contains(@class,'list-group-item')]/label[contains(text(),'{tenent}')]");
		}
		public void EnterUserNameNew(string name)
		{
			SendKeys(userName, name, true);
		}

		public void EnterPasswordNew(string password)
		{
			SendKeys(userPassword, password, true);
		}
		public void ClickonYesBtn()
		{
			Click(BtnYes);
		}
		public void ClickOnLoginButtonNew()
		{
			Click(loginButton);
		}

		public void ClickOnSelectButtonNew()
		{
			Click(selectButton);
		}

		public void SelectTenentNew(string tenent)
		{
			Click(TenentXpathNew(tenent));
		}
		public void ClickOnAddApplicant()
		{
			Click(AddAppButton);
		}
		public void ClickForCoborrowerPage()
		{
			Click(NextLinkForCoborrower);
		}
		public void ModalBlankClick()
		{
			Click(ModalBlankCredit);
		}
		public void EnterCoCreditScore1(string c1)
		{
			SendKeys(CoCredit1, c1, true);
		}
		public void EnterCoCreditScore2(string c2)
		{
			SendKeys(CoCredit2, c2, true);
		}
		public void EnterCoCreditScore3(string c3)
		{
			SendKeys(CoCredit3, c3, true);
		}
		public void ClickNextForCreditScore()
		{
			Click(forCreditScore);
		}
		public void ClickNextForCreditScoreCo()
		{
			Click(forCreditScoreCo);
		}
	}
}

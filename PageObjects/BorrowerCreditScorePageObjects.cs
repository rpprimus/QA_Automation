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
   public class BorrowerCreditScorePageObjects : DriverHelper
	{
		////button[@class='btn btn-primary ng-tns-c228-0
		public By AddAppButton => ByLocator("//button[text()=' Create New Application ']");
		public By SameModel => ByLocator("(//fieldset)[1]");
		public By NextBtnForCS => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]");
		public By userName => ByLocator("//input[@id='Username']");
		public By Credit1 => ByLocator("//input[@id= 'mat-input-1']");
		public By Credit2 => ByLocator("//input[@id= 'mat-input-2']");
		public By Credit3 => ByLocator("//input[@id= 'mat-input-3']");

		public By userPassword => ByLocator("id=Password");
		public By loginButton => ByLocator("css=button[value='login']");
		public By selectButton => ByLocator("css=button[type='submit']");
		public By userMenu => ByLocator("css=a.user-menu-link");




		public BorrowerCreditScorePageObjects(IWebDriver driver) : base(driver)
		{
		}
		public By TenentXpathNew(string tenent)
		{
			return ByLocator($"//li[contains(@class,'list-group-item')]/label[contains(text(),'{tenent}')]");
		}
		public void EnterUserName(string name)
		{
			SendKeys(userName, name, true);
		}

		public void EnterPassword(string password)
		{
			SendKeys(userPassword, password, true);
		}

		public void ClickOnLoginButtonNew()
		{
			Click(loginButton);
		}

		public void ClickOnSelectButton()
		{
			Click(selectButton);
		}

		public void SelectTenent(string tenent)
		{
			Click(TenentXpathNew(tenent));
		}
		public void ClickOnAddApplicant()
		{
			Click(AddAppButton);
		}
		public void ClickForCreditScore()
		{
			Click(NextBtnForCS);
		}
		public void ClickOnModal()
		{
			Click(SameModel);
		}
		public void EnterCreditScore1(string c1)
		{
			SendKeys(Credit1, c1, true);
		}
		public void EnterCreditScore2(string c2)
		{
			SendKeys(Credit2, c2, true);
		}
		public void EnterCreditScore3(string c3)
		{
			SendKeys(Credit3, c3, true);
		}
	}
}

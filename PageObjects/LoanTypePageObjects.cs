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
	public class LoanTypePageObjects : DriverHelper
	{
		
		public By Credit1 => ByLocator("//input[@id= 'mat-input-1']");
		public By Credit2 => ByLocator("//input[@id= 'mat-input-2']");
		public By Credit3 => ByLocator("//input[@id= 'mat-input-3']");
		public By NextBtnForCS => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]");



		public LoanTypePageObjects(IWebDriver driver) : base(driver)
		{
		}
		public void ClickForCreditScore()
		{
			
			Click(NextBtnForCS);
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

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
    public class View_Search_Audit_Records_PageObjects : DriverHelper
    {
		public By AuditRecords => ByLocator("/html/body/app-root/app-private-layout/div[2]/div/div[2]/a[6]");
		public By Close => ByLocator("/html/body/modal-container/div[2]/div/app-view-audit-record-details-modal/div[3]/button");
		public By EnterIDClickEnter => ByLocator("/html/body/app-root/app-private-layout/app-audit-page/div/div/mat-card/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By TypeClickEnter => ByLocator("/html/body/app-root/app-private-layout/app-audit-page/div/div/mat-card/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By ModifiedByClickEnter => ByLocator("/html/body/app-root/app-private-layout/app-audit-page/div/div/mat-card/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By OccurredOnClickEnter => ByLocator("/html/body/app-root/app-private-layout/app-audit-page/div/div/mat-card/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By DetailsButton => ByLocator("/html/body/app-root/app-private-layout/app-audit-page/div/div/mat-card/div[2]/div/table/tbody/tr[1]/td[5]/a");
		public View_Search_Audit_Records_PageObjects(IWebDriver driver) : base(driver)
		{
		}

		public void ClickOnAuditRecords()
		{
			Click(AuditRecords);
		}
		public void SearchBoxAndClickEnter()
		{
			SendKeys(EnterIDClickEnter, "7627", true);
			SendKeys(EnterIDClickEnter, Keys.Enter, true);
		}
		public void EnterTypeInSearchBoxAndClickEnter()
		{
			SendKeys(TypeClickEnter, "UpdateCrossSell", true);
			SendKeys(TypeClickEnter, Keys.Enter, true);
		}
		public void EnterModifiedByInSearchBoxAndClickEnter()
		{
			SendKeys(ModifiedByClickEnter, "f8e6d099-2318-47e4-affb-2591b5e718d6", true);
			SendKeys(ModifiedByClickEnter, Keys.Enter, true);
		}
		public void EnterOccurredOnInSearchBoxAndClickEnter()
		{
			SendKeys(OccurredOnClickEnter, "8/16/21, 2:57 PM", true);
			SendKeys(OccurredOnClickEnter, Keys.Enter, true);
		}
		public void ViewDetailsButton()
		{
			Click(DetailsButton);
		}
		public void CloseButton()
		{
			Click(Close);
		}
	}
}

using Affordit_Automation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
    public class BillingAndInvoicePageObjects : DriverHelper
    {
        private IWebDriver _driver; 

        public By BillingAndInvoice => ByLocator("/html/body/app-root/app-private-layout/div[2]/div/div[2]/a[7]");
        public By PricePerReport => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[1]/div[2]/div[1]/div[3]/div/mat-form-field/div/div[1]/div/input");
        public By SaveAndSubmitButton => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[3]/button");
        public By TieredPricingRadioButton => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[1]/div[2]/div[1]/div[2]/div[2]/mat-radio-group/mat-radio-button[2]");
        public By MinimumReports => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[1]/div[2]/div[1]/div[3]/div/table/tbody/tr/td[1]/mat-form-field/div/div[1]/div/input");
        public By MaximumReports => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[1]/div[2]/div[1]/div[3]/div/table/tbody/tr/td[2]/mat-form-field/div/div[1]/div/input");
        public By PricePerReportTieredPricing => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[1]/div[2]/div[1]/div[3]/div/table/tbody/tr/td[3]/mat-form-field/div/div[1]/div/input");
        public By InvoiceTab => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/ul/li[2]/a");
        public By SettingsTab => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/ul/li[3]/a");
        public By EnterEmailId => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-invoice-admin/div/div[2]/ng-select/div/div/div[2]/input");
        public By SelectIt => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-invoice-admin/div/div[2]/ng-select/ng-dropdown-panel/div/div[2]/div");
        public By AdditionalSetting => ByLocator("//html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-admin/app-billing-setting/div/form/div[2]/h3");
        public By EnterDate => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-settings/div/form/mat-form-field/div/div[1]/div[1]/input");
        public By SaveSettings => ByLocator("/html/body/app-root/app-private-layout/app-billing-invoice-admin/div/div/div/app-billing-settings/div/form/div/button");
        public By SaveAndSubmitButtonForTieredPricing => ByLocator("//button[contains(text(),'Save and Submit')]");
        public BillingAndInvoicePageObjects(IWebDriver driver) : base(driver)
        {
        }
        public void ClickOnBillingAndInvoice()
        {
            Click(BillingAndInvoice);
        }
        public void EnterPricePerReport()
        {
            SendKeys(PricePerReport, "20", true);
        }
        public void ClickSaveAndSubmitButton()
        {
            Click(SaveAndSubmitButton);
        }
        public void ClickTieredPricingRadioButton()
        {
            Click(TieredPricingRadioButton);
        }
        public void EnterMinimumReports()
        {
            SendKeys(MinimumReports, "0", true);
        }
        public void EnterMaximumReports()
        {
            SendKeys(MaximumReports, "5", true);
        }
        public void PricePerReportForTieredPricing()
        {
            SendKeys(PricePerReportTieredPricing, "10", true);
        }
        public void ClickInvoiceTab()
        {
            Click(InvoiceTab);
        }
        public void EnterEmailIdInSearchBoxAndSelectIt()
        {
            SendKeys(EnterEmailId, "niruti", true);
            Click(SelectIt);
        }
        public void ClickSettingsTab()
        {
            Click(SettingsTab);
        }
        public void ClickSaveAndSubmitButtonForTieredPricing()
        {
            ClickByJS(AdditionalSetting);
            ClickByJS(SaveAndSubmitButtonForTieredPricing);
        }
        public void ClickSaveSettings()
        {
            Click(SaveSettings);
        }
    }
}

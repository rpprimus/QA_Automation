using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects 
{
	public class Add_Edit_Tenant_User_PageObjects : DriverHelper
	{
		public By MenuIconButton => ByLocator("/html/body/app-root/app-private-layout/div[1]/div/div[1]/a");

		public By SecuritySettingsButton => ByLocator("/html/body/app-root/app-private-layout/div[2]/div/div[2]/a[5]");
		public By CreateNewTenant => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[1]/div[2]/button");
		public By EntID => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[1]/mat-form-field/div/div[1]/div/input");
		public By EntName => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[2]/mat-form-field/div/div[1]/div/input");
		public By EntAdminEmail => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[3]/mat-form-field/div/div[1]/div/input");
		public By ThirdPartyIntegration => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[4]/mat-form-field/div/div[1]/div/mat-select");
		public By Meridian => ByLocator("/html/body/div[3]/div[2]/div/div/div/mat-option[2]");
		public By EntEmailHosts => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[6]/ng-select/div/div/div[2]/input");
		public By Add => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[6]/ng-select/ng-dropdown-panel/div/div[2]/div");
		public By CreateTenant => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[3]/button[2]");
		public By CuDirect => ByLocator("/html/body/div[3]/div[2]/div/div/div/mat-option[3]");
		public By Demonstration => ByLocator("/html/body/div[3]/div[2]/div/div/div/mat-option[4]");
		public By SearchField => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By NameOfTenant => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By EnterButton => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By IDOfTenant => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By PrimaryAdminOfTenant => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By TenantEditIcon => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-tenants/div/div[3]/table/tbody/tr[2]/td[7]/a");
		public By EditName => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[2]/div/form/div[2]/mat-form-field/div/div[1]/div/input");
		public By SaveTenantButton => ByLocator("/html/body/modal-container/div[2]/div/app-edit-tenant-modal/div[3]/button[2]");
		public By UsersTab => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/ul/li[2]/a");
		public By NewUserButton => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-users/div/div[1]/div[2]/button");
		public By UserEmail => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[1]/mat-form-field/div/div[1]/div/input");
		public By UserFirstName => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[2]/mat-form-field/div/div[1]/div/input");
		public By UserLastName => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[3]/mat-form-field/div/div[1]/div/input");
		public By ThirdPartyUserCode => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[4]/mat-form-field/div/div[1]/div/input");
		public By LocationId => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[5]/ng-select/div/div/div[2]/input");
		public By SelectoneLocationId => ByLocator("/html/body/ng-dropdown-panel/div/div[2]/div[2]");
		public By ToggleOfClientAdmin => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[6]/mat-slide-toggle/label/div");
		public By CreateSystemUser => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[3]/button[2]");
		public By ToggleOfSystemAdmin => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[7]/mat-slide-toggle/label/div");
		public By FirstNameUser => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-users/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By LastNameUser => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-users/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By UserSearchEnterButton => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-users/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public By EditLastName => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[2]/mat-form-field/div/div[1]/div/input");
		public By EditFirstName => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[2]/div/form/div[2]/mat-form-field/div/div[1]/div/input");
		public By ClickEditIcon => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-users/div/div[3]/table/tbody/tr[11]/td[6]/a");
		public By UserButton => ByLocator("/html/body/modal-container/div[2]/div/app-edit-user-modal/div[3]/button[2]");
		public By SearchUserTextFields => ByLocator("/html/body/app-root/app-private-layout/app-security/div/div[1]/div/app-list-users/div/div[1]/div[1]/form/mat-form-field/div/div[1]/div/input");
		public Add_Edit_Tenant_User_PageObjects(IWebDriver driver) : base(driver)
		{
		}

		public void ClickMenuIcon()
		{
			ClickByJS(MenuIconButton);
		}
		public void ClickonSecuritySettings()
		{
			Click(SecuritySettingsButton);
		}
		public void CreateNewTenantButton()
		{
			Click(CreateNewTenant);
		}
		public void EnterID()
		{
			SendKeys(EntID, "Test100", true);
		}
		public void EnterName()
		{
			SendKeys(EntName, "Test", true);
		}
		public void EnterAdminEmail()
		{
			SendKeys(EntAdminEmail, "test@test.com", true);
		}
		public void SelectThirdPartyIntegrationMeridian()
		{
			Click(ThirdPartyIntegration);
			Click(Meridian);
		}
		public void SelectThirdPartyIntegrationCuDirect()
		{
			Click(ThirdPartyIntegration);
			Click(CuDirect);
		}
		public void SelectThirdPartyIntegrationDemonstration()
		{
			Click(ThirdPartyIntegration);
			Click(Demonstration);
		}
		public void AddAllowableEmailHosts()
		{
			SendKeys(EntEmailHosts, "testing", true);
			Click(Add);
		}
		public void ClickCreateTenant()
		{
			Click(CreateTenant);
		}
		public void SearchTextFields()
		{
			Click(SearchField);
		}
		public void EnterNameOfTenant()
		{
			SendKeys(NameOfTenant, "Test50", true);
			SendKeys(NameOfTenant, Keys.Enter, true);
		}
		public void EnterIDOfTenant()
		{
			SendKeys(IDOfTenant, "Testing100", true);
			SendKeys(IDOfTenant, Keys.Enter, true);
		}
		public void EnterPrimaryAdminOfTenant()
		{
			SendKeys(PrimaryAdminOfTenant, "Test@Test.com", true);
			SendKeys(PrimaryAdminOfTenant, Keys.Enter, true);
		}
		
		public void ClickTenantEditIcon()
		{
			Click(TenantEditIcon);

		}
		public void UpdateName()
		{
			SendKeys(EditName, "Test50", true);

		}
		public void ClickSaveTenantButton()
		{
			ClickByJS(SaveTenantButton);

		}
		public void ClickOnUsersTab()
		{
			Click(UsersTab);

		}
		public void CreateNewUserButton()
		{
			Click(NewUserButton);

		}
		public void EnterEmail()
		{
			Click(UserEmail);
			SendKeys(UserEmail, "Test@affordit.com", true);

		}
		public void EnterFirstName()
		{
			SendKeys(UserFirstName, "Testuser", true);
		}
		public void EnterLastName()
		{
			SendKeys(UserFirstName, "Test", true);
		}
		public void EnterThirdPartyUserCode()
		{
			SendKeys(ThirdPartyUserCode, "700", true);
		}
		public void SelectLocationId()
		{
			Click(LocationId);
			Click(SelectoneLocationId);

		}
		public void EnableToggleOfClientAdmin()
		{
			Click(ToggleOfClientAdmin);

		}
		public void ClickCreateSystemUser()
		{
			Click(CreateSystemUser);

		}
		public void EnableToggleOfSystemAdmin()
		{
			Click(ToggleOfSystemAdmin);

		}
		public void ClickOnSearchUserTextFields()
		{
			Click(SearchUserTextFields);
		}
		public void FirstNameOfUser()
		{
			SendKeys(FirstNameUser, "Testuser", true);
			SendKeys(FirstNameUser, Keys.Enter, true);
		}
		public void LastNameOfUser()
		{
			SendKeys(LastNameUser, "Test", true);
			SendKeys(LastNameUser, Keys.Enter, true);
		}
		public void ClickOnEditIcon()
		{
			Click(ClickEditIcon);
		}
		public void UpdateFirstName()
		{
			SendKeys(EditFirstName, "Testuser", true);
		}
		public void UpdateLastName()
		{
			SendKeys(EditLastName, "Test", true);
		}
		public void ClickSaveUserButton()
		{
			Click(UserButton);
		}
	}
}

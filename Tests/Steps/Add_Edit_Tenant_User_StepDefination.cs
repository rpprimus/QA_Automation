using Affordit_Automation.PageObjects;
using Affordit_Automation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    public sealed class Add_Edit_Tenant_User_StepDefination
    {
        private IWebDriver _driver;
        Actions act;
        protected readonly PropertyReader _propertyReader;
        protected readonly Add_Edit_Tenant_User_PageObjects _add_Edit_Tenant_User_PageObjects;
        
        private readonly ScenarioContext _scenarioContext;

        public Add_Edit_Tenant_User_StepDefination(IWebDriver driver)
        {
            _driver = driver;
            _propertyReader = PropertyReader.Instance;
            _add_Edit_Tenant_User_PageObjects = new Add_Edit_Tenant_User_PageObjects(_driver);
            act = new Actions(driver);
        }
        [Then(@"Click the Menu Icon appears on top left of screen")]
        public void ThenClickTheMenuIconAppearsOnTopLeftOfScreen()
        {
            _add_Edit_Tenant_User_PageObjects.ClickMenuIcon();
        }
        [Then(@"Click on Security Settings")]
        public void ThenClickOnSecuritySettings()
        {
            _add_Edit_Tenant_User_PageObjects.ClickonSecuritySettings();
        }
        [Then(@"Click on Create New Tenant Button")]
        public void ThenClickOnCreateNewTenantButton()
        {
            _add_Edit_Tenant_User_PageObjects.CreateNewTenantButton();
        }

        [Then(@"Enter ID")]
        public void ThenEnterID()
        {
            _add_Edit_Tenant_User_PageObjects.EnterID();
        }
        [Then(@"Enter Name")]
        public void ThenEnterName()
        {
            _add_Edit_Tenant_User_PageObjects.EnterName();
        }
        [Then(@"Enter Admin Email")]
        public void ThenEnterAdminEmail()
        {
            _add_Edit_Tenant_User_PageObjects.EnterAdminEmail();
        }
        [Then(@"Select Third Party Integration Meridian")]
        public void ThenSelectThirdPartyIntegrationMeridian()
        {
            _add_Edit_Tenant_User_PageObjects.SelectThirdPartyIntegrationMeridian();
        }
        [Then(@"Select Third Party Integration CuDirect")]
        public void ThenSelectThirdPartyIntegrationCuDirect()
        {
            _add_Edit_Tenant_User_PageObjects.SelectThirdPartyIntegrationCuDirect();
        }
        [Then(@"Select Third Party Integration Demonstration")]
        public void ThenSelectThirdPartyIntegrationDemonstration()
        {
            _add_Edit_Tenant_User_PageObjects.SelectThirdPartyIntegrationDemonstration();
        }

        [Then(@"Add Allowable Email Hosts")]
        public void ThenAddAllowableEmailHosts()
        {
            _add_Edit_Tenant_User_PageObjects.AddAllowableEmailHosts();
        }
        [Then(@"Click Create Tenant")]
        public void ThenClickCreateTenant()
        {
            _add_Edit_Tenant_User_PageObjects.ClickCreateTenant();
        }
        [Then(@"Click on Search text fields")]
        public void ThenClickOnSearchTextFields()
        {
            _add_Edit_Tenant_User_PageObjects.SearchTextFields();
        }
        [Then(@"Enter Name of Tenant and Click Enter")]
        public void ThenEnterNameOfTenantAndClickEnter()
        {
            _add_Edit_Tenant_User_PageObjects.EnterNameOfTenant();
        }
  
        [Then(@"Enter ID of Tenant and Click Enter")]
        public void ThenEnterIDOfTenant()
        {
            _add_Edit_Tenant_User_PageObjects.EnterIDOfTenant();
        }
        [Then(@"Enter Primary Admin of Tenant and Click Enter")]
        public void ThenEnterPrimaryAdminOfTenant()
        {
            _add_Edit_Tenant_User_PageObjects.EnterPrimaryAdminOfTenant();
        }

        [Then(@"Click Tenant Edit Icon")]
        public void ThenClickTenantEditIcon()
        {
            _add_Edit_Tenant_User_PageObjects.ClickTenantEditIcon();
        }
        [Then(@"Update Name")]
        public void ThenUpdateName()
        {
            _add_Edit_Tenant_User_PageObjects.UpdateName();
        }
        [Then(@"Click Save Tenant Button")]
        public void ThenClickSaveTenantButton()
        {
            _add_Edit_Tenant_User_PageObjects.ClickSaveTenantButton();
        }
        [Then(@"Click on Users Tab")]
        public void ThenClickOnUsersTab()
        {
            _add_Edit_Tenant_User_PageObjects.ClickOnUsersTab();
        }
        [Then(@"Click on Create New User Button")]
        public void ThenClickOnCreateNewUserButton()
        {
            _add_Edit_Tenant_User_PageObjects.CreateNewUserButton();
        }
        [Then(@"Enter Email")]
        public void ThenEnterEmail()
        {
            _add_Edit_Tenant_User_PageObjects.EnterEmail();
        }
        [Then(@"Enter First Name")]
        public void ThenEnterFirstName()
        {
            _add_Edit_Tenant_User_PageObjects.EnterFirstName();
        }
        [Then(@"Enter Last Name")]
        public void ThenEnterLastName()
        {
            _add_Edit_Tenant_User_PageObjects.EnterLastName();
        }
        [Then(@"Enter Third Party User Code")]
        public void ThenEnterThirdPartyUserCode()
        {
            _add_Edit_Tenant_User_PageObjects.EnterThirdPartyUserCode();
        }
        [Then(@"Select Location Id")]
        public void ThenSelectLocationId()
        {
            _add_Edit_Tenant_User_PageObjects.SelectLocationId();
        }
        [Then(@"Enable Toggle of Client Admin")]
        public void ThenEnableToggleOfClientAdmin()
        {
            _add_Edit_Tenant_User_PageObjects.EnableToggleOfClientAdmin();
        }
        [Then(@"Click Create System User")]
        public void ThenClickCreateSystemUser()
        {
            _add_Edit_Tenant_User_PageObjects.ClickCreateSystemUser();
        }
        [Then(@"Enable Toggle of System Admin")]
        public void ThenEnableToggleOfSystemAdmin()
        {
            _add_Edit_Tenant_User_PageObjects.EnableToggleOfSystemAdmin();
        }
        [Then(@"Click on Search User text fields")]
        public void ThenClickOnSearchUserTextFields()
        {
            _add_Edit_Tenant_User_PageObjects.ClickOnSearchUserTextFields();
        }

        [Then(@"Enter FirstName of User and Click Enter")]
        public void ThenEnterFirstNameOfUser()
        {
            _add_Edit_Tenant_User_PageObjects.FirstNameOfUser();
        }
        [Then(@"Enter LastName of User and Click Enter")]
        public void ThenEnterLastNameOfUser()
        {
            _add_Edit_Tenant_User_PageObjects.LastNameOfUser();
        }
        [Then(@"Click on Edit Icon")]
        public void ThenClickOnEditIcon()
        {
            _add_Edit_Tenant_User_PageObjects.ClickOnEditIcon();
        }
        [Then(@"Update First Name")]
        public void ThenUpdateFirstName()
        {
            _add_Edit_Tenant_User_PageObjects.UpdateFirstName();
        }
        [Then(@"Update Last Name")]
        public void ThenUpdateLastName()
        {
            _add_Edit_Tenant_User_PageObjects.UpdateLastName();
        }
        [Then(@"Click Save User Button")]
        public void ThenClickSaveUserButton()
        {
            _add_Edit_Tenant_User_PageObjects.ClickSaveUserButton();
        }













    }
}

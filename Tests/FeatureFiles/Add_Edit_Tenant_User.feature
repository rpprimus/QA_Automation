Feature: PRIM-240 As a User I should be able to add and edit Tenant/User under Security Settings
	
Background: 
	Given I am navigating onto the Affordit Loginpage

Scenario: Scenario_01_Add New Tenant with Third Party Integration Meridian (PRIM-252) 
	And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Create New Tenant Button
	Then Enter ID
	Then Enter Name
	Then Enter Admin Email
	Then Select Third Party Integration Meridian
	Then Add Allowable Email Hosts
    Then Click Create Tenant

Scenario: Scenario_02_Add New Tenant with Third Party Integration CuDirect (PRIM-253)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Create New Tenant Button
	Then Enter ID
	Then Enter Name
	Then Enter Admin Email
	Then Select Third Party Integration CuDirect
	Then Add Allowable Email Hosts
    Then Click Create Tenant

Scenario: Scenario_03_Add New Tenant with Third Party Integration Demonstration (PRIM-254)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Create New Tenant Button
	Then Enter ID
	Then Enter Name
	Then Enter Admin Email
	Then Select Third Party Integration Demonstration
	Then Add Allowable Email Hosts
    Then Click Create Tenant

Scenario: Scenario_04_Search the Tenant by Name (PRIM-255)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Search text fields
	Then Enter Name of Tenant and Click Enter
	
Scenario: Scenario_05_Search the Tenant by ID (PRIM-259)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Search text fields
	Then Enter ID of Tenant and Click Enter

Scenario: Scenario_06_Search the Tenant by Primary Admin (PRIM-260)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Search text fields
	Then Enter Primary Admin of Tenant and Click Enter

Scenario: Scenario_07_Edit New Tenant (PRIM-256)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click Tenant Edit Icon
	Then Update Name
	Then Click Save Tenant Button
	
Scenario: Scenario_08_Add New user as Client Admin (PRIM-257)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Users Tab
	Then Click on Create New User Button
	Then Enter Email
	Then Enter First Name
	Then Enter Last Name
	Then Enter Third Party User Code
	Then Select Location Id
	Then Enable Toggle of Client Admin
	Then Click Create System User
	
Scenario: Scenario_09_Add New user as System Admin (PRIM-258)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Users Tab
	Then Click on Create New User Button
	Then Enter Email
	Then Enter First Name
	Then Enter Last Name
	Then Enter Third Party User Code
	Then Select Location Id
	Then Enable Toggle of System Admin
	Then Click Create System User

Scenario: Scenario_10_Search the User by FirstName (PRIM-261)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Users Tab
	Then Click on Search User text fields
	Then Enter FirstName of User and Click Enter

Scenario: Scenario_11_Search the User by LastName (PRIM-262)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Users Tab
	Then Click on Search User text fields
	Then Enter LastName of User and Click Enter

Scenario: Scenario_12_Edit New user (PRIM-263)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Security Settings
	Then Click on Users Tab
	Then Click on Edit Icon
	Then Update First Name
	Then Update Last Name
	Then Click Save User Button


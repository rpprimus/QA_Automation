Feature: PRIM-242 As a User I should be able to add/edit the Billing and Pricing section for the SBO reports
	

Scenario: Scenario_01_Billing with Flat Rate Pricing (PRIM-268) 
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	Then Click the Menu Icon appears on top left of screen
	Then Click on Billing and Invoice
	Then Enter Price Per Report
	Then Click Save and Submit Button

Scenario: Scenario_02_Billing with Tiered Pricing(PRIM-269) 
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Billing and Invoice
	Then Click Tiered Pricing Radio Button
	Then Enter Minimum Reports
	Then Enter Maximum Reports
	Then Enter Price Per Report for Tiered Pricing
	Then Click Save and Submit Button for Tiered Pricing

Scenario: Scenario_03_Search Invoice by User Email(PRIM-270) 
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Billing and Invoice
	Then Click Invoice Tab
	Then Enter Email Id in Search Box and Select it


Scenario: Scenario_04_Enter Date from which customer charged for generating SBO report.(PRIM-271) 
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Billing and Invoice
	Then Click Settings Tab
	Then Select or Enter Date
	Then Click Save Settings
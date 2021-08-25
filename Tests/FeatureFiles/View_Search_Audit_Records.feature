Feature: PRIM-241 As a User I should be able to view/search the Audit Records of the New/Current application
	

Scenario: Scenario_01_View Audit Records(PRIM-274) 
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	Then Click the Menu Icon appears on top left of screen
	Then Click on Audit Records
	Then Click on View Details Button
	Then Click Close Button
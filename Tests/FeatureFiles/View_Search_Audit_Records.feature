Feature: PRIM-241 As a User I should be able to view/search the Audit Records of the New/Current application
	
Background: 
	Given I am navigating onto the Affordit Loginpage

#Scenario: Scenario_01_Search Audit Records by Application ID (PRIM-252) 
#	And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
#	And Select "Meridian Test (MER)" tenent
#	Then Click the Menu Icon appears on top left of screen
#	Then Click on Audit Records
#	Then Enter Application Id in Search box and Click Enter
#
#Scenario: Scenario_02_Search Audit Records by Type (PRIM-252) 
#	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
#	#And Select "Meridian Test (MER)" tenent
#	Then Click the Menu Icon appears on top left of screen
#	Then Click on Audit Records
#	Then Enter Type in Search box and Click Enter
#
#Scenario: Scenario_03_Search Audit Records by Modified By (PRIM-252) 
#	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
#	#And Select "Meridian Test (MER)" tenent
#	Then Click the Menu Icon appears on top left of screen
#	Then Click on Audit Records
#	Then Enter Modified By in Search box and Click Enter
#
#Scenario: Scenario_04_Search Audit Records by Occurred On (PRIM-252) 
#	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
#	#And Select "Meridian Test (MER)" tenent
#	Then Click the Menu Icon appears on top left of screen
#	Then Click on Audit Records
#	Then Enter Occurred On in Search box and Click Enter

Scenario: Scenario_01_View Audit Records(PRIM-274) 
	And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	Then Click the Menu Icon appears on top left of screen
	Then Click on Audit Records
	Then Click on View Details Button
	Then Click Close Button
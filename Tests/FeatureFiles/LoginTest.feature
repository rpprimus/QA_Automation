@web
Feature: PRIM-140 As a User I should be able to login into the application so that i can view claimant information
Background: 
	Given I am navigating onto the Affordit Loginpage

@Regression
Scenario: Scenario_01_Check the Account Details of a user with valid username and wrong Password PRIM-169
	And Enter "CorrectUsername" and "InCorrectPassword" for Login
	When User click on login Button
	Then Error message should appear "Invalid username or password"

@Regression
Scenario: Scenario_02_Check the Account Details of a user with Invalid username and Valid Password PRIM-170
	And Enter "InCorrectUsername" and "CorrectPassword" for Login
	When User click on login Button
	Then Error message should appear "Invalid username or password"

@Regression
Scenario: Scenario_03_Check the Account Details of a user with empty username and password PRIM-171
	When User click on login Button
	Then Error message should appear "The Username field is required."
	Then Error message should appear "The Password field is required."

@Regression
Scenario: Scenario_04_Check the Account Details of a user with valid user PRIM-168
	And Enter "CorrectUsername" and "CorrectPassword" for Login
	When User click on login Button
	And Select "Meridian Test (MER)" tenent
	When Click on Select Button
	Then Redirect to Manage Your Applications Page
@web
Feature: PRIM-141 As a User I should be able to reset my password so that i can login into the application 
Background:
	Given Navigating onto the Affordit Loginpage
	And User Should Click on ForgetLink
@Regression
Scenario: Scenario_01_Check User can get reset link on Registered EmailId PRIM-172
	
	When Enter "ForgetEmail"
	Then User click on Send Button
	
@Regression
Scenario: Scenario_02_Check User can get reset link on Unregistered EmailId PRIM-173
	When Enter "WrongForgetEmail"
	Then User click on Send Button
	
@Regression
Scenario: Scenario_03_Check User can get reset link without any EmailId PRIM-174
	Then User click on Send Button
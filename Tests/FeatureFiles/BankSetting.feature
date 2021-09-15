Feature: PRIM-192 As a user I should be able to modify the Bank Settings
Scenario: Scenario_01_Bank Rates PRIM-219
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Bank Rates
	Then Select  Credit Card Classic 
	Then Select Used Auto
Scenario: Scenario_02_Bank Values PRIM-220
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Bank Value
	Then Select  Credit Card Classic 
	Then Select Used Auto
Scenario: Scenario_03_Product Financial Tables PRIM-221
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Product Financial Tables
	Then Select  Credit Card Classic
	Then Change Interest Rate in Credit Card Classic
	Then Click on Save and Submit Button 
	Then Click on Bank Rates
	Then Select  Credit Card Classic 
Scenario: Scenario_04_Ranking Factors PRIM-223
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Ranking Factors
	Then Click on Monthly Payment Factor Rank
	Then Enter value in Monthly Payment Factor Rank
	Then Click on Total Interest Rank
	Then Enter Value in Total Interest Rank
	Then Click on Save Ranking Factor
Scenario: Scenario_05_Promotional Offers Activation - 1 PRIM-224
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Promotional Offers
	Then Click enable Insurance Option
Scenario: Scenario_06_Promotional Offers Activation - 2 PRIM-224
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Promotional Offers
	Then Click disable Insurance Option
Scenario: Scenario_07_Loan Group Options PRIM-232
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Loan Group Option
	Then Click on toggle HELOAN
Scenario:Scenario_08_Tenant Files Part-1 Uplaod File PRIM-232
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Tenant Files
	Then Click on Upload button
	Then Choose on Purpose from Dropdown
	Then Select "Logo" from dropdown
	Then Select File to Upload
	Then Click on Upload Button to Upload File or Logo
Scenario:Scenario_09_Tenant Files Part-3 Update File PRIM-232
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Tenant Files
	Then Click on Edit button
	Then Enter Data in filename
	Then Click on Update button
Scenario:Scenario_10_Tenant Files Part-4 Download File PRIM-232
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Tenant Files
	Then Click on Download button
Scenario:Scenario_11_Tenant Files Part-2 Delete File PRIM-232
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Tenant Files
	Then Click on Delete button
	Then Click on Confirm Button to Delete
Scenario: Scenario_12_Loan Types PRIM-264
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Loan Type
	Then Click on Add Loan Type
	Then Click on Dropdown Loan Type
	Then Select Personal for Loan Group
	Then Enter Loan Type
	Then Click on Add Loan Type Button
Scenario: Scenario_13_Refinance Options PRIM-222
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Refinance Option
	Then Click on New Mortgage
	Then Click on Loan Type for Refinace Option
	Then Select an Option from the List
	Then Click on Save Refinance Option
Scenario: Scenario_14_Liability Appraisal PRIM-265
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Liability Appraisal
	Then Click on Borrower Loan Groups to Appraise
	Then Select an Option from the List for Liability Appraisal
	Then Click on Use liability balance as appraisal value if an appraisal value cannot be determined
	Then Click on Save Setting
Scenario: Scenario_15_Miscellaneous Settings PRIM-266 Part - 1
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Miscellaneous Settings
	Then Click on Enable Adjustable DTI Threshold
	Then Click on Save Setting button
	Then Goto Home Link
	Then Enter AffordIt ID to Search
	Then Click on the Data to See Effect on SBO Report
	Then Check Whether DTI Threshold Presence
Scenario: Scenario_16_Miscellaneous Settings PRIM-266 Part - 2
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenant
	When Click on Hamburger Menu 
	Then Click on Bank Setting
	Then Click on Miscellaneous Settings
	Then Click on Enable Adjustable DTI Threshold
	Then Click on Save Setting button
	Then Goto Home Link
	Then Enter AffordIt ID to Search
	Then Click on the Data to See Effect on SBO Report
	Then Check Whether DTI Threshold Presence
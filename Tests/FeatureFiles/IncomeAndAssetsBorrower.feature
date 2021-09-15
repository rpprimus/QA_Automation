Feature: PRIM-161 User I should be able to fill the Income and Assets Details of the Applicant with Borrower – 1(PRIM-150,PRIM-152)
@Regression
Scenario: Scenario_01_Entering Annual Base Income of Borrower and Asset Type Cash Deposit (PRIM-181)
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	And Click on New Application Button
	When Click on Income and Assets Link
	And Enter Data in "AnnualBaseIncome"
	Then Click on Monthly Income 
	And Click on Next Link for Assets Page
	When Click on Add Borrower Assets Button
	And Click on borrower Assets Type
	And Select one Option From Dropdown "Cash Deposit"
	Then Enter Amount in "AssetsAmount"
	And Click on Next Button to See the Result
	
@Regression
Scenario: Scenario_02_Entering Annual Base Income of Borrower With All Annual Income and Assets Type Cash Deposit (PRIM-181) 
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Income and Assets Link
	And Enter Data in "AnnualBaseIncome"
	And Enter Annual Overtime
	And Enter Annual Bonuses
	And Enter Annual Commissions
	And Enter Annual Dividends/Interest
	And Enter Annual Net Rental Income
	And Enter Amount in Annual Other Income
	And Enter Description 
	Then Click on Monthly Income 
	And Click on Next Link for Assets Page
	When Click on Add Borrower Assets Button
	And Click on borrower Assets Type
	And Select one Option From Dropdown "Cash Deposit"
	Then Enter Amount in "AssetsAmount"
	And Enter Amount in Rainy Day Fund
	And Click on Next Button to See the Result

Scenario: Scenario_03_Entering Annual Base Income of Primary and Co Borrower and Asset Type Cash Deposit
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	And Click on Yes Button For CoBorrower
	When Click on Income and Assets Link
	And Enter Data in "AnnualBaseIncome"
	Then Click on Monthly Income 
	And Click on Next Link for Assets Page
	When Click on Add Borrower Assets Button
	And Click on borrower Assets Type
	And Select one Option From Dropdown "Cash Deposit"
	Then Enter Amount in "AssetsAmount"
	And Click on next Button link for Coborrower
	And Enter Amount in "AnnualBaseIncomeCo" Coborrower
	Then Click on Next btn Link for Coborrwer Assets
	And Click on Co Borrower Assets Button
	And Click on Co borrower Assets  Types
	And Select one Option From Dropdown "Money Market"
	And Select Date From Date Picker
	And Enter Rate of Return
	And Enter Amount for Assets
	And Click on Next Button to See the Result for Primary and Co Borrower

Scenario: Scenario_04_Entering Annual Base Income of Primary and Co Borrower and Asset Type Cash Deposit
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	And Click on Yes Button For CoBorrower
	When Click on Income and Assets Link
	And Enter Data in "AnnualBaseIncome"
	And Enter Annual Overtime
	And Enter Annual Bonuses
	And Enter Annual Commissions
	And Enter Annual Dividends/Interest
	And Enter Annual Net Rental Income
	And Enter Amount in Annual Other Income
	And Enter Description 
	Then Click on Monthly Income 
	And Click on Next Link for Assets Page
	When Click on Add Borrower Assets Button
	And Click on borrower Assets Type
	And Select one Option From Dropdown "Cash Deposit"
	Then Enter Amount in "AssetsAmount"
	And Enter Amount in Rainy Day Fund
	And Click on next Button link for Coborrower
	And Enter Amount in "AnnualBaseIncomeCo" Coborrower
	And Enter Annual Overtime Co Borrower
	And Enter Annual Bonuses Co Borrower
	And Enter Annual Commissions Co Borrower
	And Enter Annual Dividends/Interest Co Borrower
	And Enter Annual Net Rental Income Co Borrower
	And Enter Amount in Annual Other Income Co Borrower
	And Enter Description Co Borrower
	Then Click on Next btn Link for Coborrwer Assets
	And Click on Co Borrower Assets Button
	And Click on Co borrower Assets  Types
	And Select one Option From Dropdown "Money Market"
	And Select Date From Date Picker
	And Enter Rate of Return
	And Enter Amount for Assets
	Then Enter Amount in Rainy Day Fund for Co Borrower
	And Click on Next Button to See the Result for Primary and Co Borrower
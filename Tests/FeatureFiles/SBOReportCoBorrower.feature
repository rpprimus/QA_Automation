Feature:PRIM-167 User I should be able to generate the SBO Report For Primary and Co Borrower

Scenario:Scenario_01_Solution Based Outcome Report for Primary and Co Borrower
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Click on Yes Button
	And Click on Next For Credit Records
	Then Enter Valid "CreditScore1" and "CreditScore2" and "CreditScore3"
	And Click on Next Page Link
	Then Enter Valid Coborrower "CoCreditScore1" and "CoCreditScore2" and "CoCreditScore3"
	Then Click on Next Icon For Loan Type
	Then Click PERSONAL Icon
	Then Select Type of Loan Request for PERSONAL
	Then Enter Loan Amount for PERSONAL
	Then Click Next For Personal Information
	Then Enter Firstname of Borrower
	Then Enter Last name of Borrower
	Then Enter Borrower Date of Birth
	Then Enter Social "Securitynumber"
	Then Click on Next link for Borrower Other information Page
	Then Enter Address Line one
	Then Enter Address Line two
	Then Enter City for Borrower
	Then Select State
	Then Enter ZipCode
	Then Click on Next link for Co Borrower details
	Then Enter Firstname of CoBorrower
	Then Enter Last name of CoBorrower
	Then Enter CoBorrower Date of Birth
	Then Enter Coborrower Social "coborrowerSecuritynumber"
	Then Click on Next link for Coborrower Other information
	Then Enter CoBorrower Address line one
	Then Enter CoBorrower Address line two
	Then Enter CoBorrower City
	Then Enter CoBorrower ZipCode
	Then Click on Next link for Employer more information Page
	Then Enter Employer Name
	Then Enter Phone Number
	Then Enter Title
	Then Click Next for Borrower More Information
	Then Enter Address line First
	Then Enter Address line Second
	Then Click on Next for Co Borrower Employeer Page
	Then Enter CoBorrower Employer Name
	Then Enter CoBorrower Phone Number
	Then Enter CoBorrower Title
	Then Click Next for CoBorrower More Information
	Then Enter CoBorrower Address line First
	Then Enter CoBorrower Address line Second
	When Click Next for Income and Asset Details
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
	And Enter Amount in Rainy Day Fund Borrower
	And Click on next Button link for Coborrower Annual Income
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
	And Click on Next Button to See the Result
	And Click on Next Link for Liabilites Page
	Then Click On Add Liability Button
	Then Click on Liabilities Option
	Then Select Liability from Dropdown
	Then Enter Balance Amount
	Then Click the Dropdown Icon
	Then Click on Original Loan Amount
	Then Click on Payment Amount
	Then Enter Terms
	Then Enter Interest Rate
	Then Check the Special Interest Checkbox
	Then Enter Special Interest Rate
	Then Enter Year
	Then Enter Make
	Then Enter Model
	Then Click Next Page Icon for CoBorrower
	Then Click Add Liabilities Button for CoBorrower
	Then Select Liabilities for CoBorrower
	Then Click on Balance Amount for CoBorrower
	Then Click the Dropdown Icon for CoBorrower
	Then Click on Original Loan Amount for CoBorrower
	Then Click on Payment Amount for CoBorrower
	Then Enter Terms for CoBorrower
	Then Enter Interest Rate for CoBorrower
	Then Enter Year for CoBorrower
	Then Enter Make for CoBorrower
	Then Enter Model for CoBorrower
	Then Click Next for SBO Report
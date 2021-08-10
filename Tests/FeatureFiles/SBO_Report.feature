Feature:PRIM-167 User I should be able to generate the SBO Report For Primary
	
Scenario:Scenario_01_Solution Based Outcome Report for Primary
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1" and "CreditScore2" and "CreditScore3"
	Then Click on Next Icon For Loan Type
	Then Click MORTGAGE Icon
	Then Select Type of Loan Request for MORTGAGE
	Then Enter Purchase Price for MORTGAGE
	Then Enter Down Payment(%) for MORTGAGE
	Then Enter of Months for Reserves
	Then Click Next For Personal Information
	Then Enter Firstname of Borrower
	Then Enter Last name of Borrower
	Then Enter Borrower Date of Birth
	Then Enter Social "Securitynumber"
	Then Click on Next link for Borrower other information
	Then Enter Address Line one
	Then Enter Address Line two
	Then Enter City for Borrower
	Then Select State
	Then Enter ZipCode
	Then Click on Next link for Employer more information
	Then Enter Employer Name
	Then Enter Phone Number
	Then Enter Title
	Then Click Next for Borrower More Information
	Then Enter Address line First
	Then Enter Address line Second
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
	And Enter Amount in Rainy Day Fund
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
	Then Click Next for SBO Report

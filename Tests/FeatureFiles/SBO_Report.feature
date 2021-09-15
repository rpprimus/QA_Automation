Feature:PRIM-167 User I should be able to Generate the Solution Based Outcome Report For Primary

Scenario:Scenario_01_Solution Based Outcome Report for Primary
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1" and "CreditScore2" and "CreditScore3"
	Then Click on Next Icon For Loan Type
	Then Click PERSONAL Icon
	Then Select Type of Loan Request for PERSONAL
	Then Enter Loan Amount for PERSONAL
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
	Then Enter Years on this Job
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
	And Click on Next Link for Assets Page
	And Click on Next Button to See the Result
	And Click on Next Link for Liabilites Page
	Then Click On Add Liability Button
	Then Click on Liabilities Option
	Then Select Liability from Dropdown
	Then Enter Creditor Name
	Then Enter Date Opened
	Then Enter Balance Amount
	Then Click the Dropdown Icon
	Then Enter Account Number
	Then Click on Original Loan Amount
	Then Enter Terms
	Then Enter Interest Rate
	Then Enter Months Reviewed
	Then Click on Payment Amount
	Then Enter Year
	Then Enter Make
	Then Enter Model
	Then Select Body
#	Then Click On Add Liability Button
#	Then Click on Liabilities Option for first Credit Card
#	Then Select Liability from Dropdown Credit Card
#	Then Enter Creditor Name Credit Card
#	Then Enter Date Opened Credit Card
#	Then Enter Balance Amount Credit Card
#	Then Click the Dropdown Icon For first Credit Card
#	Then Enter Account Number Credit Card
#	Then Enter Credit Limit first
#	Then Enter Months Reviewed Credit Card
#	Then Click on Payment Amount Credit Card
#	Then Click On Add Liability Button
#	Then Click on Liabilities Option for Second Credit Card
#	Then Select Liability from Dropdown Credit Card second
#	Then Enter Creditor Name Credit Card second
#	Then Enter Date Opened Credit Card second
#	Then Enter Balance Amount Credit Card second
#	Then Click the Dropdown Icon Second Credit Card
#	Then Enter Account Number Credit Card second
#	Then Enter Credit Limit second
#	Then Enter Months Reviewed Credit Card second
#	Then Click on Payment Amount Credit Card second
#	Then Click Next for SBO Report

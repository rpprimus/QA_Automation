Feature: PRIM-162 Liabilities for Borrower and CoBorrower
	

Scenario: Scenario_01_Add Liabilities details for Borrower (PRIM-200)
   Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	And Click on New Application Button
	Then Click on Liabilities
	Then click Add Liabilities
	Then Select Liabilities
	Then Click on Balance Amount
	Then Click the Dropdown Icon
	Then Click on Original Loan Amount
	Then Click on Payment Amount
	Then Enter Terms
	Then Enter Interest Rate
	Then Enter Year
	Then Enter Make
	Then Enter Model

Scenario: Scenario_02_Add Liabilities details for Borrower with special interest rate (PRIM-201)
    #And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Click on Liabilities
	Then click Add Liabilities
	Then Select Liabilities
	Then Click on Balance Amount
	Then Click the Dropdown Icon
	Then Check the Special Interest Checkbox
	Then Enter Special Interest Rate
	Then Click on Original Loan Amount
	Then Click on Payment Amount
	Then Enter Terms
	Then Enter Interest Rate
	Then Enter Year
	Then Enter Make
	Then Enter Model

Scenario: Scenario_03_Add Liabilities details for Borrower and CoBorrower with special interest rate (PRIM-202)
    #And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Select Yes
	Then Click on Liabilities
	Then click Add Liabilities
	Then Select Liabilities
	Then Click on Balance Amount
	Then Click the Dropdown Icon
	Then Check the Special Interest Checkbox
	Then Enter Special Interest Rate
	Then Click on Original Loan Amount
	Then Click on Payment Amount
	Then Enter Terms
	Then Enter Interest Rate
	Then Enter Year
	Then Enter Make
	Then Enter Model
	Then Click Next Page Icon for CoBorrower
	Then Click Add Liabilities Button for CoBorrower
	Then Select Liabilities for CoBorrower
	Then Click on Balance Amount for CoBorrower
	Then Click the Dropdown Icon for CoBorrower
	Then Check the Special Interest Checkbox for CoBorrower
	Then Enter Special Interest Rate for CoBorrower
	Then Click on Original Loan Amount for CoBorrower
	Then Click on Payment Amount for CoBorrower
	Then Enter Terms for CoBorrower
	Then Enter Interest Rate for CoBorrower
	Then Enter Year for CoBorrower
	Then Enter Make for CoBorrower
	Then Enter Model for CoBorrower

Scenario: Scenario_04_Add Liabilities details for Borrower and coborrower without special interest rate (PRIM-203)
    #And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Select Yes
	Then Click on Liabilities
	Then click Add Liabilities
	Then Select Liabilities
	Then Click on Balance Amount
	Then Click the Dropdown Icon
	Then Click on Original Loan Amount
	Then Click on Payment Amount
	Then Enter Terms
	Then Enter Interest Rate
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
	Then Click Next Page Icon

	


	
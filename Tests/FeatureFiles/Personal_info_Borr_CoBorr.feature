Feature: PRIM-159 Borrower and CoBorrower Personal Information

Background: 
	Given I am navigating onto the Affordit Loginpage

Scenario: Scenario_01_Add Personal Information of Borrower and CoBorrower PRIM-196
	And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Select Yes button
	Then Click on personal information
	Then Enter Firstname of Borrower
	Then Enter Last name of Borrower
	Then Enter Borrower Date of Birth
	Then Enter Social "Securitynumber"
	Then Click on Next icon for Borrower other information
	Then Enter Address line one
	Then Enter Address line two
	Then Enter City
	Then Select State
	Then Enter ZipCode
	Then Click on Next link for Co-Borrower details
	Then Enter Firstname of CoBorrower
	Then Enter Last name of CoBorrower
	Then Enter CoBorrower Date of Birth
	Then Enter Coborrower Social "coborrowerSecuritynumber"
	Then Click on Next link for Coborrower other information
	Then Enter CoBorrower Address line one
	Then Enter CoBorrower Address line two
	Then Enter CoBorrower City
	Then Select CoBorrower State
	Then Enter CoBorrower ZipCode
	Then Click on Next link for Co-Borrower details


Scenario: Scenario_02_Add Personal Information of Borrower PRIM-197
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Click on personal information
	Then Enter Firstname of Borrower
	Then Enter Last name of Borrower
	Then Enter Borrower Date of Birth
	Then Enter Social "Securitynumber"
	Then Click on Next link for Borrower other information
	Then Enter Address line one
	Then Enter Address line two
	Then Enter City
	Then Select State
	Then Enter ZipCode
	Then Click on Next link for Employer more information

	


	



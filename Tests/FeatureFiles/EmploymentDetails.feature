Feature: PRIM-160 Employement Details of Borrower and Co-Borrower

Background: 
	Given I am navigating onto the Affordit Loginpage


Scenario: 1 Add Employment Details of Borrower and  CoBorrower (PRIM-198)
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Select Yes button
	Then Click on Employment Button
	Then Enter Employer Name
	Then Enter Phone Number
	Then Enter Title
	Then Click Next for Borrower More Information
	Then Enter Address line First
	Then Enter Address line Second
	Then Click Next for CoBorrower Information
	Then Enter CoBorrower Employer Name
	Then Enter CoBorrower Phone Number
	Then Enter CoBorrower Title
	Then Click Next for CoBorrower More Information
	Then Enter CoBorrower Address line First
	Then Enter CoBorrower Address line Second
	Then Click Next for Income and Asset Details

	Scenario: 2 Add Employment Details of Borrower (PRIM-199)
	#Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Click on Employment Button
	Then Enter Employer Name
	Then Enter Phone Number
	Then Enter Title
	Then Click Next for Borrower More Information
	Then Enter Address line First
	Then Enter Address line Second
	Then Click Next for Income and Asset Details

	
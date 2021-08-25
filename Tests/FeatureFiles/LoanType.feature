Feature: PRIM-191 Loan Type for Borrower and CoBorrower

Scenario: Scenario_01_Add Loan Type for MORTGAGE (PRIM-225)
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click MORTGAGE Icon
	Then Select Type of Loan Request for MORTGAGE
	Then Enter Purchase Price for MORTGAGE
	Then Enter Down Payment(%) for MORTGAGE
	Then Enter of Months for Reserves
	Then Click Next Icon Link

Scenario: Scenario_02_Add Loan Type for HOME EQUITY (PRIM-226)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click HOME EQUITY Icon
	Then Select Type of Loan Request for HOME EQUITY
	Then Enter Loan Amount for HOME EQUITY
	Then Click Next Icon Link

Scenario: Scenario_03_Add Loan Type for PERSONAL (PRIM-227)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click PERSONAL Icon
	Then Select Type of Loan Request for PERSONAL
	Then Enter Loan Amount for PERSONAL
	Then Click Next Icon Link

Scenario: Scenario_04_Add Loan Type for AUTO (PRIM-228)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click AUTO Icon
	Then Select Type of Loan Request for AUTO
	Then Enter Purchase Price for AUTO
	Then Enter Down Payment(%) for AUTO
	Then Click Next Icon Link

Scenario: Scenario_05_Add Loan Type for MoTORCYCLE (PRIM-229)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click MoTORCYCLE Icon 
	Then Select Type of Loan Request for MoTORCYCLE
	Then Enter Purchase Price for MoTORCYCLE
	Then Enter Down Payment(%) for MoTORCYCLE
	Then Click Next Icon Link

Scenario: Scenario_06_Add Loan Type for BOAT (PRIM-230)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click BOAT Icon 
	Then Select Type of Loan Request for BOAT
	Then Enter Purchase Price for BOAT
	Then Enter Down Payment(%) for BOAT
	Then Click Next Icon Link

Scenario: Scenario_07_Add Loan Type for RV/ATV (PRIM-231)
	#And Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	#And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	When Click on Next Icon For Credit Records
	And Enter "CreditScore1" and "CreditScore2" and "CreditScore3" between limits
	Then Click on Next Icon For Loan Type
	Then Click RV/ATV Icon 
	Then Select Type of Loan Request for RV/ATV
	Then Enter Purchase Price for RV/ATV
	Then Enter Down Payment(%) for RV/ATV
	Then Click Next Icon Link





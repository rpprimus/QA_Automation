
Feature: PRIM-158 For Co-Borrower - Enter All Credit Score within Limit (PRIM-190)

Scenario: Scenario_01_Enter All Credit Score within Limit for Borrower and Co Borrower
	Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenent
	And Click on New Application Button
	Then Click on Yes Button
	And Click on Next For Credit Records
	Then Enter Valid "CreditScore1" and "CreditScore2" and "CreditScore3"
	And Click on Next Page Link
	Then Enter Valid Coborrower "CoCreditScore1" and "CoCreditScore2" and "CoCreditScore3"

Scenario: Scenario_02_Enter All Credit Score for Borrower and Base Limit for Co Borrower
	
	And Click on New Application Button
	Then Click on Yes Button
	And Click on Next For Credit Records
	Then Enter Valid "CreditScore1" and "CreditScore2" and "CreditScore3"
	And Click on Next Page Link
	Then Enter Valid Coborrower "CoCreditScore1min" and "CoCreditScore2min" and "CoCreditScore3min"

Scenario: Scenario_03_Enter All Credit Score for Borrower and Upper Limit for Co Borrower

	And Click on New Application Button
	Then Click on Yes Button
	And Click on Next For Credit Records
	Then Enter Valid "CreditScore1" and "CreditScore2" and "CreditScore3"
	And Click on Next Page Link
	Then Enter Valid Coborrower "CoCreditScore1max" and "CoCreditScore2max" and "CoCreditScore3max"

Scenario: Scenario_04_Enter All Credit Score for Borrower and Under Limit for Co Borrower
	
	And Click on New Application Button
	Then Click on Yes Button
	And Click on Next For Credit Records
	Then Enter Valid "CreditScore1" and "CreditScore2" and "CreditScore3"
	And Click on Next Page Link
	Then Enter Valid Coborrower "CoCreditScore1Less" and "CoCreditScore2Less" and "CoCreditScore3Less"

Scenario: Scenario_05_Enter All Credit Score for Borrower and Over Limit for Co Borrower

	And Click on New Application Button
	Then Click on Yes Button
	And Click on Next For Credit Records
	Then Enter Valid "CreditScore1" and "CreditScore2" and "CreditScore3"
	And Click on Next Page Link
	Then Enter Valid Coborrower "CoCreditScore1Over" and "CoCreditScore2Over" and "CoCreditScore3Over"
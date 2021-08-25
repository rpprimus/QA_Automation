@web
Feature: PRIM-158 - For Primary Borrower - Enter All Credit Score within Limit (PRIM-177)

Scenario: Scenario_01_Enter All Credit Score within Limit
    Given Navigate to New Application Page with "CorrectUsername" and "CorrectPassword" 
	And Select "Meridian Test (MER)" tenant
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1" and "CreditScore2" and "CreditScore3"
	Then Click on Page to see the Result

Scenario: Scenario_02_Enter All Credit Score Base Limit
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1min" and "CreditScore2min" and "CreditScore3min"
	Then Click on Page to see the Result

Scenario: Scenario_03_Enter All Credit Score Upper Limit
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1max" and "CreditScore2max" and "CreditScore3max"
	Then Click on Page to see the Result

Scenario: Scenario_04_Enter All Credit Score under Limit
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1Less" and "CreditScore2Less" and "CreditScore3Less"
	Then Click on Page to see the Result

Scenario: Scenario_05_Enter All Credit Score Over Limit
	And Click on New Application Button
	When Click on Next For Credit Records
	And Enter Correct "CreditScore1Over" and "CreditScore2Over" and "CreditScore3Over"
	Then Click on Page to see the Result



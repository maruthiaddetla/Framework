Feature: KiwiSaver Retirement Calculator 		

@mytag
Scenario: Verify information icon present for all fields
	Given I have launched the application 
	When  I navigate to 'KiwiSaverCalculator' page
	Then I should see information icon present for all fields in the calculator

	
Scenario Outline: Verify the users are able to plan their investments better.
	Given I have launched the application 
	When  I navigate to 'KiwiSaverCalculator' page
	And I enter <currentAge>,<employmentStatus>,<salary>,<kiviSavercontributions>,<PIR>,<currentBalance>,<voluntaryContributions>,<frequency>,<risk> and <savingsGoal>
	And I click View Projections button
	Then I should able to calculate my projected balance at retirement
	Examples: 
	| currentAge | employmentStatus | salary | kiviSavercontributions | PIR   | currentBalance | voluntaryContributions | frequency   | risk  | savingsGoal |
	| 28         | Employed         | 82000  | 4                      | 17.5% |                |                        |             | High  |             |
	| 45         | Self-employed    |        |                        | 10.5% | 100000         | 90                     | Fortnightly | Medium| 290000      |
	| 55         | Not employed     |        |                        | 10.5% | 140000         | 10                     | Annually    | Medium| 200000      |
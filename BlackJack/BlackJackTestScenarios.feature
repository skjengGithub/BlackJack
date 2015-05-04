Feature: : BlackJackTestScenarios
In order to test if the basic unit functions work fine together
As a careful user
I want to be to

ld the result of running all test scenarios

@mytag
Scenario: Test Scenario 1
	Given the default card deck 
	When I press enter
	Then the result should be "passed" on the console screen



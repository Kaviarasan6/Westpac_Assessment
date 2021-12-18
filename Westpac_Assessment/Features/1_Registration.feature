Feature: 1_Registration
As a tester
	I want to test the registration functionality of the Buggy Cars rating application

@automation
Scenario: Registration
	Given I Navigate to the website
	And I click on Register button
	And I fill registration details
	When I click on Register button
	Then I should be registered successfully

Feature: 01_Registration
	As a tester
	I want to test the registration functionality of Buggy Cars rating application

@smoke
Scenario: Registration
	Given I Navigate to the website
	And   I click on Register button
	And   I fill registration details
	When  I click on Register button
	Then  I should be registered successfully

	Examples: 
	| ScreenshotName |
	| Registration           |
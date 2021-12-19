Feature: 1_Registration
As a tester
	I want to test the registration functionality of the Buggy Cars rating application

@Smoke
Scenario Outline: Registration
	Given I Navigate to the website
	And I click on Register button
	And I fill registration details <username>, <firstname>, <lastname>, <password>, <confirmPassword>
	When I click on Register button
	Then I should be registered successfully

	Examples:
		| username  | firstname | lastname | password   | confirmPassword |
		| TestBuggy | Kavi      | Arasan   | Password1$ | Password1$      |
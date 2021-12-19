Feature: 2_Login
	 As a tester, I wanted to test the login functionality to the Buggy Cars rating application

Background:
	Given I Navigate to the website

@Smoke
Scenario Outline: 01 Log into the application with different inputs
	And  I enter login credentials <data>,<username>,<password>
	When I click login button
	Then I should be successfully logged in <data>,<firstname>

	Examples:
		| data    | username  | password   | firstname |
		| valid   | TestBuggy | Password1$ | Kavi      |
		| invalid | kavi001   | Password1$ |           |
		| null    |           | Password1$ |           |

@Smoke
Scenario Outline: 02 Logging out from the application
	And  I enter login credentials <data>,<username>,<password>
	When I click login button
	Then I should be successfully logged in <data>,<firstname>
	When I click on Logout button
	Then I should be successfully logged out from the application

	Examples:
		| data  | username  | password   | firstname |
		| valid | TestBuggy | Password1$ | Kavi      |
Feature: 2_Login
	 As a tester, I wanted to test the login functionality to the Buggy Cars rating application


Scenario: 01 Log into the application with different inputs
	Given I open the browser and navigate to the url
	When  I enter login credentials and click login button
	Then  I validate successfull login



Scenario: 02 Logging out from the application
	Given  I open browser and navigate to the url
	When   I enter login credentials and click login button
	And    I click on Logout button
	Then   I should be successfully logged out from the application

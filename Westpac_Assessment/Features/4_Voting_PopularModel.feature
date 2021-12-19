Feature: 4_Vote through Popular Model
  As a tester, I wanted to test the voting through Popular model feautre

@Smoke
Scenario: Vote through Popular Model
	Given I Navigate to the website
	And   I login to the application using valid credentials valid,TestBuggy,Password1$
	And   I click on Popular Model category
	When  I cast my vote
	Then  Voting has been casted successfully

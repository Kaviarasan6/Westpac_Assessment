Feature: 3_Vote through Popular Make
  As a tester, I wanted to test the voting through Popular make feautre

@Smoke
Scenario: Vote through Popular Make
	Given I Navigate to the website
	And   I login to the application using valid credentials valid,TestBuggy,Password1$
	And   I click on Popular Make category
	And   I click on the favourite car model
	When  I cast my vote
	Then  Voting has been casted successfully

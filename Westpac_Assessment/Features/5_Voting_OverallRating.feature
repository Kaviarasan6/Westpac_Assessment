Feature: 5_Vote through Overall rating
  As a tester, I wanted to test the voting through overall rating feautre

@Smoke
Scenario: Vote through Overall rating
	Given I Navigate to the website
	And   I login to the application using valid credentials valid,TestBuggy,Password1$
	And   I click on Overall rating
	And   I click on the favourite car in Overall Rating category
	When  I cast my vote
	Then  Voting has been casted successfully

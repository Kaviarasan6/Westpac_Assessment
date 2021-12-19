Feature: 6_UpdateProfile
	As a tester, I need to test my profile feature

Background:
	Given I Navigate to the website
	And I login to the application using valid credentials valid,TestBuggy,Password1$

@smoke
Scenario Outline: 01_Update my information
	And I enter data to all fields <firstname>,<lastname>,<gender>,<age>,<address>,<phone>,<hobby>
	When I click on Save button
	Then The profile should be saved successfully

	Examples:
		| firstname | lastname | gender | age | address        | phone    | hobby   |
		| boy       | girl     | male   | 12  | 33 cuba street | 02251028 | Drawing |

@smoke
Scenario Outline: 02_Change Password
	And I enter data to the password fields <currentPassword>,<newPassword>,<confirmPassword>
	When I click on Save button
	Then The password should be changed successfully

	Examples:
		| currentPassword | newPassword | confirmPassword |
		| Password1$      | Password2$  | Password2$      |
Feature: Login
	Check if the login functionality is working
	as expected with different permutations and combinations of data

@smoke @positive
Scenario: Check login with correct username and password
	Given I have navigated to the app
	And I see app opened
	Then I click login link
	When I enter username and password
	| Username | Password |
	| admin    | password |
	Then I click login button
	Then I should see username with hello
	Then I click logout

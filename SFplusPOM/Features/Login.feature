Feature: Login
	Test the login functionality of application
	Will verify if the username and password combinations are working as expected

@Regressiontest
@Browser:Chrome
	Scenario Outline: Verify if the login functionality is working (+ye case)
	Given I have navigated to my app
	And I typed the <username> and <password>
	When I click login button
	Then I should see the EA page

	Examples:
	|username|password|
	|admin|admin|
	|username|password|


Feature: Google search
	Feature to test Google page search functionality
	Here we will test autotest

@SmokeTest
@Browser:Chrome
Scenario: Google search for Execute Automation
	Given: I have navigated to Google page
	And: I see the google page fully loaded
	When: I type search keywords as
	|Keyword|
	|execute automation|
	Then: I should see the result for keyword
	|Keyword|
	|Execute Automation|
	
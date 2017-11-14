Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@mytag7 @mytag11
Scenario: Create new employees with mandatory details	
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I fill form <Email> <Name> <Phone> 
	| Name | Age | Phone | Email |
	|name1     |  12   |  +380504894389    |  1@yahoo.com     |
	|name2     |  63   |  +38050487899    |  2@yahoo.com     |
	|name3     |  42   |  +38050487904389    |  3@yahoo.com     |
	|name4     |  22   |  +380504000009    |  4@yahoo.com     |
	Then the result should be on the screens

@mytag8
Scenario Outline: Add two numbers with separate data
	When I add data like <Name>, <Age>, <Phone>, <Email>
Examples: 
	| Name | Age | Phone | Email |
	|nam1     |  12   |  +380504894389    |  1@yahoo.com     |
	|nam2     |  63   |  +38050487899    |  2@yahoo.com     |
	|nam3     |  42   |  +38050487904389    |  3@yahoo.com     |
	
@mytag9
Scenario: Create new employees through code
When I add data like next

@mytag10
Scenario: Add  data through Assist
	When I add data through Assist
	| Name | Age | Phone | Email |
	|nam1     |  12   |  +380504894389    |  1@yahoo.com     |
	|nam2     |  63   |  +38050487899    |  2@yahoo.com     |
	|nam3     |  42   |  +38050487904389    |  3@yahoo.com     |
	
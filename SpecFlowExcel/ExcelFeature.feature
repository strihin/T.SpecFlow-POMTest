Feature: ExcelFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Plus 2 integer
	Given Input sum1 <Int1> and input sum2 <Int2>
	When Table with data for sum there
	Then Result should be <Result>
@source:SumInteger.xlsx
Examples: 
| Int1 | Int2 | Result |
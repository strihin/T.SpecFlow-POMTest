Feature: Verify Menu

@mytag
Scenario: Write menuitem
	When Menu list consist of
	| Menu1 | Menu2 | Menu3   | Menu4    |
	| Login | Name  | Address | Password |

	Then the result should be 120 on the screen

Feature: SelectMenu
	Simple testing of Select Menu item

@mytag
Scenario: Checking Select Menu 
	Given I navigate to ToolsQA demo site
	And I click on widgets menu
	And I click on Select Menu item
	And I choose 'Group 2, option 1' for Select Value
	And I choose 'Other' for Select One 
	And I choose 'Voilet' for Old Style Select Menu
	Then I should see 'Group 2, option 1' for Select Value, 
	And I should see 'Other' for Select One 
	And I should see 'Voilet' for Old Style Select Menu
Feature: Link
	Link Menu Testing

@mytag
Scenario: Click on Link menu item
	Given I navigate to ToolsQA demo site
	And I click on Element
	And I click on Links section
	And I click on Home 
	Then I should see a new tab opened
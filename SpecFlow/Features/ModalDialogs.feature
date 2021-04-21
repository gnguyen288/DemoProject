Feature: ModalDialogs
	Simple testing of popup alert window

@mytag
Scenario: Clicking alert window
	Given I navigate to ToolsQA demo site
	And I click on Alert menu item
	And I click on Modal Dialogs
	And I choose Small modal
	Then The text 'This is a small modal. It has very less content' is shown and I close the popup
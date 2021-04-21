Feature: ProgressBar
	Simple testing of progress bar

@mytag
Scenario: Clicking on progress bar
	Given I navigate to ToolsQA demo site
	And I click on widgets menu
	And I click on Progress Bar
	When I click on Start button
	Then The progress bar should be active 
	When I click on Reset button
	Then The progress bar should be inactive
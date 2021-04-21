Feature: DatePicker
	Checking DatePicker

@mytag
Scenario: Select a date from Date Picker menu item
	Given I navigate to ToolsQA demo site
	And I click on widgets menu
	And I click on Date Picker item
	And I click on Select Date field
	And I pick 'December' as Month, '23' as Date and '2020' as Year 
	And I click Date And Time field
	And I pick 'December' as Month, '23' as Date, '2020' as Year and '16:00' as Time
	Then I should see '12/23/2020' in Select Date box and 
	And I should see 'December 23, 2020 4:00 PM' from Date and Time Box
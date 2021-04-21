Feature: WebTables
	Simple Testing of Web Tables with pop up window

@mytag
Scenario: Open Web Tables
	Given I navigate to ToolsQA demo site
	And I click on Element
	And I click on Web Tables section
	And I click Add button
	And I fill in 'John' as First Name, 'Smith' as Last Name, 'abc@gmail.com' as Email, '20' as Age, '2000' as Salary, 'HR' as Department
	And I click Submit on page
	Then I should see the new record added 
Feature: Textbox 
	Textbox menu testing

@mytag
Scenario: Open Element menu
	Given I navigate to ToolsQA demo site
	And I click on Element
	And I click on Text Box section
	And I fill in all fields 'Giang Nguyen' in Full Name, 'abc@gmail.com' in Email, '123 K Street' in Current Address and '123 K Street' in Permanent Address
	And I click Submit
	Then The Output box is displayed

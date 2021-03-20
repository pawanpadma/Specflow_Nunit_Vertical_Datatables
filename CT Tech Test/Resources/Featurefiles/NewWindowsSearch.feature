Feature: HomePageSearch
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@NewWindowSearch
Scenario: Perform the Search and Validate the result
	Given I am on Automation Testing page
	When I enter "Specflow" in Search box
	And click on Search button
	Then "SpecFlow" should be displayed in the result

@NewWindowSearch
Scenario: Perform the Search with empty result
	Given I am on Automation Testing page
	When I enter "" in Search box
	And click on Search button
	Then "Please enter text to search." should be displayed in the result

@NewWindowSearch
Scenario: Perform the Search with random string and Validate the result
	Given I am on Automation Testing page
	When I enter "abcbacbacbc" in Search box
	And click on Search button
	Then "No results found." should be displayed in the result

@NewWindowSearch
Scenario: Perform the Search with more than five results and Validate the result
	Given I am on Automation Testing page
	When I enter "Selenium" in Search box
	And click on Search button
	Then "More »" should be displayed in the result
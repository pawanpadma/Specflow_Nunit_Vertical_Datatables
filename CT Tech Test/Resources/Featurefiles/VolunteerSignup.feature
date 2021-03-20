Feature: HomePageSignup
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@signupform
Scenario: Filling all the fields in signup form except fileupload
	Given I am on Automation Testing page
	When I enter details in volunteer signup form with out fileuploaded
	| key          | value            |
	| firstname    | pawan           |
	| lastname     | k                |
	| phone        | 441234567890     |
	| Country      | UK               |
	| City         | Horsham          |
	| EmailAddress | test1@test.co.uk |
	And  submit the form	
	Then Verify "An error has occurred" is displayed

@signupform
Scenario: uploading a file in volunteeer singup form
	Given I am on Automation Testing page
	When I upload a file		
	Then Verify "An error has occurred" is displayed

@signupform
Scenario: submitting the form with only first and last name
	Given I am on Automation Testing page
	When I enter firstname and lastname in the form	
	| key          | value            |
	| firstname    | meenal           |
	| lastname     | k                |
	And  submit the form
	Then Verify "An error has occurred" is displayed

@signupform
Scenario: submitting the form with email address only
	Given I am on Automation Testing page
	When I enter email address only
	| key          | value            |
	| EmailAddress | test1@test.co.uk |
	And  submit the form
	Then Verify "An error has occurred" is displayed

@signupform
Scenario: submitting the form with only first and last name and Country
	Given I am on Automation Testing page
	When I enter firstname and lastname and Country in the form	
	| key          | value            |
	| firstname    | meenal           |
	| lastname     | k                |
	| Country      | UK               |
	And  submit the form
	Then Verify "An error has occurred" is displayed

@signupform
Scenario: submitting the form with invalid Phone number
	Given I am on Automation Testing page
	When I enter invalid Phone
	| key          | value   |
	| phone			|123456 |
	And  submit the form
	Then Verify "An error has occurred" is displayed
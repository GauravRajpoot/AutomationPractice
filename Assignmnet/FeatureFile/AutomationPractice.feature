Feature: Check the Login functionality of AutomationPractice.com
	WE have to check the for each and every case of login
	


Scenario: For Empty email and vaid Password
	Given I have navigated to the website 
	And click on login button
	When Pass the parameter
	Then Message is Displayed
	And Close th Browser

Scenario: For Empty Password and valid email
	Given I have navigated to the website 
	And click on login button
	
	When Pass the parameters
	Then Unsucessfull Message is displayed
	And Close th Browser

Scenario: For Invalid Email and Invalid Password
	Given I have navigated to the website 
	And click on login button
	
	When Pass the Arguments
	Then Unsucessfull Message is shown
	And Close th Browser

Scenario: For Empty Email and Empty Password
	Given I have navigated to the website 
	And click on login button
	
	When No Argument is passed
	Then Message is displayed accordingly
	And Close th Browser

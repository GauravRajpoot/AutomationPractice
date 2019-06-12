Feature: UnSucessfull Registration

Scenario: Checking the unsucessfull registration
Given We have client and request 
	And Pass the Parameter
	When Response  is collected
	Then token is generated

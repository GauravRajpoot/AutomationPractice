Feature: Checking the functionality of flight booking at Expedia.com
        In this we are booking multicity flight with given source and destination 
		Also displaying the totla expense 

Scenario: Login in to Expedia
Given Open Chrome WebBrowser  
Then Pass the URL of Website

Scenario: Multicity flight booking
Then Click on flight tab
And Choose MultiCity OPtion
Then Pass Source and Destination Place
And Choose DateOfJourney and Choose Number of Passengers
Then Again choose Source and Destination for second time
And Choose DateOfJourney 
Then Again choose Source  and Destination for third time
And Choose DateOfJourney  for return


Scenario: Searchinfg the flight
Then Click On the Search BUtton
And Display the successfull message

Scenario: Trip Summary
When ENsuring correct information of all three flights
Then Ensuring the correct amount per person 

 Scenario: ZClosing the Browser
     When Report are generate
     Then dismis browser
      


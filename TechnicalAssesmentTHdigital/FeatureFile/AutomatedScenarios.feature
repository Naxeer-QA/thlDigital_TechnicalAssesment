Feature: AutomatedScenarios
	Below are the separate scenarios that were automated

Background: Given the Britz.com website homepage is shown

@performSearchOnBritz.com
Scenario: Perform successful search 
	Given the user selects country from the destination field
	And selects pickup and dropoff dates
	And enters pickup and dropoff lcoations
	When the user enters passenger details
	And enters Drivers licence
	And clicks on the search button
	Then the search result is shown

Scenario: Validate Booking related error copies
	Given the user clicks on Book button
	Then underlay modal appears
	When the user enters detination in the input field
	Then the booking relevant component is shown
	When the user clicks Search button without entering any data
	Then the error copies are shown

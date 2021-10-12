Feature: Booking
	Booking related scenarios

@Booking through Book button
Scenario: Book button
	Given the user is on the homepage
	And the Book button is shown
	When the user hovers the mouse on it
	Then the button is highlighted

Scenario: Modal Underlay 
	Given the user clicks on the Book button
	And the modal underlay is shown
	When the user clicks on the cross mark from modal underlay
	Then it disappears

Scenario: Modal Underlay copy verification
	Given the user clicks on the Book button
	And the modal underlay is shown
	When the copy reads as Welcome to Britz Campervans
	
Scenario: Modal Underlay Booking
	Given the user clicks on the Book button
	And the modal underlay is shown
	When the user clicks in the destination input field
	Then the dropdown appears

Scenario: Modal Underlay Booking location icon
	Given the user clicks on the Book button
	And the modal underlay is shown
	And the location icon is shown on the far right cornor of the input field in a grey out form
	When the user click in the input field
	Then the drown down appers
	And the location icon changes to orange.

Scenario: Modal Underlay Booking Copy verification
	Given the user clicks on the Book button
	And the modal underlay is shown
	And the input field shows the water copy as Choose your destination
	When the user click in the input field
	Then the dropdown list shows two items
	When the user hovers the mouse on New Zealand or Australia 
	Then the item colors changes to orange

Scenario: Booking module from Modal Underlay 
	Given the user clicks on the Book button
	And the modal underlay is shown
	When the user selects any item from the dropdown
	Then the booking module is shown
	And the selected item is shown in the choose destination field

Scenario: Change destination from booking module from Modal Underlay 
	Given the user clicks on the Book button
	And the modal underlay is shown
	When the user selects any item from the dropdown
	Then the booking module is shown
	And the selected item is shown in the choose destination field
	When the user changes the destination 
	Then the modified destination is shown in the choose destination field
	
@openCalendarWidget
Scenario: Select dates for pick up from booking Module
	Given the user clicks on the Book button
	And the modal underlay is shown
	When the user selects any item from the dropdown
	Then the booking module is shown
	And the selected item is shown in the choose destination field
	When the user clicks on the pick up calendar icon
	Then the calendar widget is shown

Scenario: select a date in the calendar and display in the repective date picker field
	Given the booking module is open
	When the user clicks on the pick up calendar icon
	Then the calendar is shown with the current day highlighted and the month and year on the top
	And past days and back arrow is greyed out or disabled
	And the Next arrow is enabled
	When the user clicks on any day
	Then the selected day along with the month and year is shown in the pickup input field
	And the calendar moves to drop off input field to select the dates for drop off
	And the chosen date is highlighted in the calendar

Scenario: calendar forward and backward button
	Given the booking module is open
	When the user clicks on the pick up calendar icon
	Then the calendar is shown with the back arrow of the previous days and months disabled
	And the forward arrow is enabled
	When the user clicks on the forward arrow
	Then the calendar shows the next month and the days with the back arrow enabled
	When the user clicks on the back arrow
	Then it lands back to the previous month

Scenario: Validate calendar error messages
	Given the user navigates to the booking module
	When the user clicks on the search button without any input
	Then the error messages for pick up and drop off are displayed
	And the error message for pick up and drop off location are shown

Scenario: Select pick up and drop off location
	Given the user navigates to the booking module
	When the user clicks on the pick up or drop off location
	Then the location icon becomes colourful
	And the dropdown allows to select the listed locations
	And only single location is allowed to be selected
	When the user selects listed locations
	Then the location is shown in the respective fields

@below Test conditions to write steps
Scenario: Verification of default calendar width as per the specifications
Scenario: Verification of date format supported by the calendar
Scenario: User edits the date after already selecting it
Scenario: Date picker fields do not allow manual insertions
Scenario: User unable to select invalid dates from the calendar.



	

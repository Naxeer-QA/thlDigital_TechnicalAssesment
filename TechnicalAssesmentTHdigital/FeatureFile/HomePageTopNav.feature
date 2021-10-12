Feature: HomePageTopNav
	Verify the top navigation headers on the homepage

Background: Given britz.com homepage is shown

@changeLanguage
Scenario: Display language support
	Given the user clicks on the default language flag
	Then the language support flags are shown

Scenario: Change language
	Given the user clicks on the default language flag
	And selects any desired language from the drowpdown
	Then the page gets refreshed with the default selected language flag
	And the content is shown in the selected language

@testlogo
Scenario: Logo clickability
	Given the user clicks on the logo
	Then the page gets refreshed/reloaded

@topHeaderItems - Navigation
Scenario: Britz Australia Header
	Given the user clicks on the header link
	Then the user is navigated to the relevant page on the same tab
	And the country code is shown in the url
	When the user performs the browser back button
	Then the previous homepage is shown to the user.

Scenario: Britz New Zealand Header
	Given the user clicks on the header link
	Then the user is navigated to the relevant page on a new tab
	And the country code is shown in the url

Scenario: Britz USA Header
	Given the user clicks on the header link
	Then the user is navigated to the relevant page on a new tab
	And the country code is shown in the url

Scenario: Britz Southern Africa Header
	Given the user clicks on the header link
	Then the user is navigated to the relevant page on a new tab
	And the country code is shown in the url

@topHeaderItems - Hyperlinks
Scenario: Hover the mouse to verify the headers are hyperlinked
	Given the user hovers the mouse on any header items
	Then the orange horizontal line should appear

@topHeaderItems - Hyperlinks
Scenario: Verify the header copies
	Given the top header items are shown
	And the header text is the expected and verified text

@tabLogicalOrder
Scenario: Navigation through tab
	Given the user navigates through tab from keyboard
	When the user hits enter from the keyboard on any order
	Then the respective link should open

	


Feature: LinkOnSearchResults
		As a user
		When the search keyword 'Britz' is googled 
		then the website link www.britz.com. is shown on google search results

Background: 
	Given Google search page is opened in a browser

@webTests
Scenario: Google auto suggest shows the website link on search result, when clicked.
	Given the user enters search keyword Britz in the search input field
	And the auto suggestion dropdown shows the website in the list
	When the user clicks on the auto suggest dropdown item
	Then the search result shows the website link.

Scenario: Search result shows the website link when the user performs search
	When the user enters the keyword Britz in the search input field
	And hits enter
	Then the search result shows the website link

Scenario: Search result shows the website link when the user performs similar match search
	When the user enters the keyword Britz in the search input field
	And clicks on any similar match from the auto suggestion dropdown
	Then the search result shows the website link

Scenario: Search result shows the website link when the user performs search with the type vehicle
	When the user enters keyword Campervan in the search input field
	And hits enter
	Then the search result shows the website link

	@Unsure about the below scenario
Scenario: Maui, being a sister brand of Britz, when the user performs search by Maui keyword, then parent company britz.com link should be dispalyed in search results
	When the user enters keyword Maui in the search input field
	And hits enter
	Then the search result should show the parent company link.
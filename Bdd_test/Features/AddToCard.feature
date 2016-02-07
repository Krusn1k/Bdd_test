Feature: AddToCard

@mytag
Scenario Outline: Add_To_Card
	Given I go to url
	And I set search request "<request>"
	And I perform search
	And I open first search result
	And I select item options
	When I add item to card
	Then the "<request>" purchase page is open
	Examples: 
	| request        |
	| iPhone 4S      |
	| Samsung Galaxy |

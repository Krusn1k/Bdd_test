Feature: TwoDifferentProductsPriceCheck
	In purchase page
	As a user
	I want to see correct price of the two different products

@mytag
Scenario: Two_Different_Products_Price_Check
	Given I go to url
	And I set search request "iPhone 4S"
	And I perform search
	And I see on first search result price
	And I open first search result
	And I select item options
	And I add item to card
	And I go to url
	And I set search request "Samsung Galaxy"
	And I perform search
	And I see on first search result price of second product
	And I open first search result
	And I select item options
	When I add item to card
	Then the price on the purchase page such as price on the search page of both product


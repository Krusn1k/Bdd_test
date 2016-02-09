Feature: TwoProductsPriceCheck
	In purchase page
	As a user
	I want to see correct price of the two similar products

@mytag
Scenario Outline: Two_Products_Price_Check
	Given I go to url
	And I set search request "iPhone 4S"
	And I perform search
	And I see on first search result price
	And I open first search result
	And I select item options
	And I increase product count on "<count>"
	When I add item to card
	Then the price on the purchase page such as price on the search page "<count>" times magnified
	Examples: 
	| count |
	| 2     |

Feature: OpenFindPage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Open_Find_Page
	Given I go to url
	And I set search request "iPhone 4S"
	And I perform search
	When I open first search result
	Then the "iPhone 4S" search result page is open

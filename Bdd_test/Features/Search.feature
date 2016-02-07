Feature: Basic_search

/*Background: Initialize driver
Given I initialize driver for tests
And I cleanup driver for test*/

@mytag
Scenario: Basic_search_scenario
	Given I go to url
	And I set search request "iPhone 4S"
	When I perform search
	Then the search query "iPhone 4S" should be the first in the Search Result grid

Scenario Outline: Basic_search_scenario_2
	Given I go to url
	And I set search request "<request>"
	When I perform search
	Then the search query "<request>" should be the first in the Search Result grid
	Examples:
	| request        |
	| iPhone 4S      |
	| Samsung Galaxy |

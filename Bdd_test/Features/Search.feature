Feature: Basic_search
	
@mytag
Scenario: Add two numbers
	Given I set search rquest "iPhone 4s"
	When I perform search
	Then the search query "iPhone 4s" should be the first in the Search Result grid

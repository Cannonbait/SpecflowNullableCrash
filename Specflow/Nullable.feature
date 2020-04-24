Feature: Nullable
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Core
Scenario: Add two numbers
	Given I have a table with an enum that is null
	| Name  | CauseOfDeath |
	| Peter | null         |
	| Linda | null         |
	Then I want to be able to see some info

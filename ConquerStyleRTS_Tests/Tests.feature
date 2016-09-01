Feature: Tests
	Ensuring terrain tiles 

@mytag
Scenario: GetTerrainType returns terrain
	Given I have a terrain tile
	When I call the GetTerrainType method
	Then A terrain type is returned

Scenario: SetTerrainType int returns terrain
	Given I have a terrain tile
	When I call the SetTerrainType method with an int argument
	Then the terrain type is set correctly

Scenario: SetTerrainType enum returns terrain
	Given I have a terrain tile
	When I call the SetTerrainType method with an enum argument
	Then the terrain type is set correctly


Scenario: GetDefBonus returns terrain
	Given I have a terrain tile
	When I call the GetDefBonus
	Then a double is returned


Scenario: GetAtkBonus returns terrain
	Given I have a terrain tile
	When I call the GetAtkBonus
	Then a double is returned
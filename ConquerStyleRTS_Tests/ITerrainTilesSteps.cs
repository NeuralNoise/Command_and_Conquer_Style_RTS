using Command_and_Conquer_Style_RTS.Enums.Terrain;
using Command_and_Conquer_Style_RTS.Interfaces.Map;
using System;
using TechTalk.SpecFlow;

namespace ConquerStyleRTS_Tests
{
    [Binding]
    public class ITerrainTilesSteps
    {
        ITerrainTile testTile;
        TerrainType returnedTerrainType; 
        [Given(@"I have a terrain tile")]
        public void GivenIHaveATerrainTile()
        {
            // Add a terrain tile
        }
        
        [When(@"I call the GetTerrainType method")]
        public void WhenICallTheGetTerrainTypeMethod()
        {
            returnedTerrainType = testTile.GetTerrainType();
        }
        
        [When(@"I call the SetTerrainType method with an int argument")]
        public void WhenICallTheSetTerrainTypeMethodWithAnIntArgument()
        {
            testTile.
        }
        
        [When(@"I call the SetTerrainType method with an enum argument")]
        public void WhenICallTheSetTerrainTypeMethodWithAnEnumArgument()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call the GetDefBonus")]
        public void WhenICallTheGetDefBonus()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call the GetAtkBonus")]
        public void WhenICallTheGetAtkBonus()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"A terrain type is returned")]
        public void ThenATerrainTypeIsReturned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the terrain type is set correctly")]
        public void ThenTheTerrainTypeIsSetCorrectly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a double is returned")]
        public void ThenADoubleIsReturned()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command_and_Conquer_Style_RTS.Interfaces.Map;
using Command_and_Conquer_Style_RTS.Enums.Terrain;

namespace Command_and_Conquer_Style_RTS.Tests
{
    [TestClass]
    public class ITerrainTilesTest
    {
        private ITerrainTile testsubject;
        [TestMethod]
        public void SetTerrainTypeInt()
        {
            TerrainType expectedvalue = TerrainType.Desert;
            int inputvalue = 0;
            testsubject.SetTerrainType(inputvalue);
            Assert.AreEqual(expectedvalue, testsubject.TerrainType);
        }
    }
}

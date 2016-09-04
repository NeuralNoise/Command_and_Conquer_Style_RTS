using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command_and_Conquer_Style_RTS.Interfaces.Map;
using Command_and_Conquer_Style_RTS.Enums.Terrain;
using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces;

namespace Command_and_Conquer_Style_RTS.Tests
{
    [TestClass]
    public class IPositionableTest
    {
        private IPositionable testsubject;
        [TestMethod]
        public void GetTileFromMap()
        {
            IPosition pos = testsubject.Position;
            ITile tile = testsubject.GetTileFromMap();

            IPosition testposition = tile.Position;

            Assert.AreEqual(pos, testposition);
        }
        [TestMethod]
        public void CanAddItemEmpty()
        {
            IUnit a = new StubIUnit
            {

            };
            ITile tile = testsubject.GetTileFromMap();

            IPosition testposition = tile.Position;

            Assert.AreEqual(pos, testposition);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command_and_Conquer_Style_RTS.Interfaces.Map;
using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces;
using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Fakes;

namespace Command_and_Conquer_Style_RTS.Tests
{
    [TestClass]
    public class ITileTest
    {
        private ITile testsubject;
        [TestMethod]
        public void CanAddItemToUnitList()
        {
            IUnit testingunit1 = new StubIUnit
            {
                IsCollidableGet = () => true
            };
            testsubject.AddItem(testingunit1);
            Assert.IsTrue(testsubject.UnitList.Contains(testingunit1));
         }
        [TestMethod]
        public void CanAddItemEmpty()
        {
            IUnit testingunit1 = new StubIUnit
            {
                IsCollidableGet = () => true
            };
            IUnit testingunit2 = new StubIUnit
            {
                IsCollidableGet = () => true
            };
            testsubject.AddItem(testingunit1);
            Assert.IsFalse(testsubject.UnitList.Contains(testingunit1));
        }
    }
}

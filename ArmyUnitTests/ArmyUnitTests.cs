using CalculationOfArmy.Models;
using CalculationOfArmy.Models.UnitArmyModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArmyUnitTests
{
    [TestClass]
    public class ArmyUnitTests
    {
        [TestMethod]
        public void TestPrice()
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Militia("", 0, 5, true));
            units.Add(new Necromancer("", 5, 15, new Militia("", 0, 5, true)));
            units.Add(new Orcs("", 3, 13, new Militia("", 0, 5, false)));

            Army army = new Army(units);
            Assert.AreEqual(9, army.GetPrice());
        }

        [TestMethod]
        public void TestSpeed()
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Militia("", 0, 5, true));
            units.Add(new Necromancer("", 5, 15, new Militia("", 0, 5, true)));
            units.Add(new Orcs("", 3, 13, new Militia("", 0, 5, false)));

            Army army = new Army(units);
            Assert.AreEqual(11, army.GetAverageSpeed());
        }

        [TestMethod]
        public void TestNecromancerPrice1()
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Necromancer("", 5, 15, new Militia("", 0, 5, true)));

            Army army = new Army(units);
            Assert.AreEqual(6, army.GetPrice());
        }

        [TestMethod]
        public void TestNecromancerPrice2()
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Necromancer("", 5, 15, new Militia("", 0, 5, false)));

            Army army = new Army(units);
            Assert.AreEqual(5, army.GetPrice());
        }
    }
}

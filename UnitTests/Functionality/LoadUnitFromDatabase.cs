using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class LoadUnitFromDatabase
    {
        [TestMethod]
        public void LengthFromDatabase()
        {

            double value = 10;
            string unit = "Meter";

            Length length = value.AddUnit<LengthUnit>(unit);


            Assert.AreEqual("10 m", $"{length:S5}");

        }

        [TestMethod]
        public void TemperatureFromDatabase()
        {

            double value = 164.254567;
            string unit = "Kelvin";

            Temperature temp = value.AddUnit<TemperatureUnit>(unit);


            Assert.AreEqual("164.25 K", $"{temp:S5}");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromDatabaseWrongUnits()
        {
            double value = 10;
            string unit = "Meter";

            Length length = value.AddUnit<TemperatureUnit>(unit);


            Assert.AreEqual("10 m", $"{length:S5}");

        }



    }
}

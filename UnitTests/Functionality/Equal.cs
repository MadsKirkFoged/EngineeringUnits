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
    public class Equal
    {
        [TestMethod]
        public void ConsistentEqualsOperations()
        {
            var voltMinutes = new BaseUnit(2.0, new UnitSystem(ElectricPotentialUnit.Volt * DurationUnit.Minute, "V\u00b7min"));
            var weber = MagneticFlux.FromWeber(2 * 60);
            Assert.IsTrue(voltMinutes == weber);
            Assert.IsTrue(weber == voltMinutes);
            Assert.IsTrue(weber.Equals(voltMinutes));
            Assert.IsTrue(voltMinutes.Equals(weber));
            Assert.AreEqual(0, weber.CompareTo(voltMinutes));
            // The following assertion fails:
            Assert.AreEqual(0, voltMinutes.CompareTo(weber));
        }


    }
}

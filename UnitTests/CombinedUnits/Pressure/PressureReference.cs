using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineeringUnits;
using EngineeringUnits.Units;

namespace UnitTests
{
    [TestClass]
    public class PressureReferenceTest
    {

        [TestMethod]
        public void Pressure()
        {

            Pressure P1 = new Pressure(10, PressureUnit.Bar);
            Assert.AreEqual(P1.ToString(), "10 bar");
            Assert.AreEqual($"{P1}", "10 bar");

            Pressure P2 = P1.ToUnit(PressureUnit.Bar, PressureReference.Absolute);
            Assert.AreEqual(P2.ToString(), "10 barₐ");
            Assert.AreEqual($"{P2}", "10 barₐ");

            Pressure P3 = P1.ToUnit( PressureReference.Gauge);
            Assert.AreEqual(P3.ToString(), "8.987 barᶢ");
            Assert.AreEqual($"{P3}", "8.987 barᶢ");

            Pressure P4 = new Pressure(10m, PressureUnit.Bar, PressureReference.Gauge);
            Assert.AreEqual(P4.ToString(), "10 barᶢ");
            Assert.AreEqual($"{P4}", "10 barᶢ");

            Pressure P5 = new Pressure(10m, PressureUnit.Bar, PressureReference.Absolute);
            Assert.AreEqual(P5.ToString(), "10 barₐ");
            Assert.AreEqual($"{P5}", "10 barₐ");

            Pressure P6 = P4.ToUnit(PressureReference.Gauge);
            Assert.AreEqual(P6.ToString(), "10 barᶢ");
            Assert.AreEqual($"{P6}", "10 barᶢ");

            Pressure P7 = P5.ToUnit(PressureReference.Gauge);
            Assert.AreEqual(P7.ToString(), "8.987 barᶢ");
            Assert.AreEqual($"{P7}", "8.987 barᶢ");

            Pressure P8 = P4.ToUnit(PressureReference.Absolute);
            Assert.AreEqual(P8.ToString(), "11.01 barₐ");
            Assert.AreEqual($"{P8}", "11.01 barₐ");

            Pressure P9 = P5.ToUnit(PressureReference.Absolute);
            Assert.AreEqual(P9.ToString(), "10 barₐ");
            Assert.AreEqual($"{P9}", "10 barₐ");


        }
    }
}

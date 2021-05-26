using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class SpeedTest
    {
        [TestMethod]
        public void SpeedSimple()
        {
            Length L1 = new Length(100, LengthUnit.Meter);
            Duration D1 = new Duration(10, DurationUnit.Second);

            Speed S1 = L1 / D1;


            Assert.AreEqual(10, (double)S1.As(SpeedUnit.MeterPerSecond));
            Assert.AreEqual(36, (double)S1.As(SpeedUnit.KilometerPerhour));

        }


       
    }
}

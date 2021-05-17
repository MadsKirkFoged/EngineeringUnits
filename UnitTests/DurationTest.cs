using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class DurationTest
    {
        [TestMethod]
        public void LengthSI2SI()
        {
            Duration L1 = new Duration(3600, DurationUnit.Second);


            Assert.AreEqual(0.041666666666666664, L1.As(DurationUnit.Day));
            Assert.AreEqual(1, L1.As(DurationUnit.Hour));
            Assert.AreEqual(3599999999999.9995, L1.As(DurationUnit.Nanosecond));
        }

       

    }
}

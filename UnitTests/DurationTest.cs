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
        public void DurationConverts()
        {
            Duration L1 = new Duration(3600, DurationUnit.Second);


            Assert.AreEqual(0.041666666666666664d, (double)L1.As(DurationUnit.Day), 0000000000.1);
            Assert.AreEqual(1d, (double)L1.As(DurationUnit.Hour),0000000000.1);
            Assert.AreEqual(3599999999999.9995d, (double)L1.As(DurationUnit.Nanosecond), 0000000000.1);
        }

       

    }
}

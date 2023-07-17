using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Functionality
{
    [TestClass]
    public class MinMax
    {
        [TestMethod]
        public void MinimumWithNoEffect()
        {
            Length L1 = new(10d, LengthUnit.Meter);

            Length L2 = L1.Minimum(Length.FromMeter(5));

            Assert.AreEqual(L1, L2);

        }

        [TestMethod]
        public void Minimum()
        {
            Length L1 = new(10d, LengthUnit.Meter);

            Length L2 = L1.Minimum(Length.FromMeter(15));

            Assert.AreNotEqual(L1, L2);

            Assert.AreEqual("15 m", $"{L2:S5}");
        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void MinimumWithWrongUnit()
        {
            Length L1 = new(10d, LengthUnit.Meter);

            Length L2 = L1.Minimum(Frequency.FromSI(15));

        }





        [TestMethod]
        public void MaximumWithNoEffect()
        {
            Length L1 = new(10d, LengthUnit.Meter);

            Length L2 = L1.Maximum(Length.FromMeter(15));

            Assert.AreEqual(L1, L2);

        }

        [TestMethod]
        public void Maximum()
        {
            Length L1 = new(10d, LengthUnit.Meter);

            Length L2 = L1.Maximum(Length.FromMeter(5));

            Assert.AreNotEqual(L1, L2);

            Assert.AreEqual("5 m", $"{L2:S5}");
        }

        [TestMethod]
        [ExpectedException(typeof(WrongUnitException))]
        public void MaximumWithWrongUnit()
        {
            Length L1 = new(10d, LengthUnit.Meter);

            Length L2 = L1.Maximum(Frequency.FromSI(15));

        }

        [TestMethod]
        public void MaximumWithNull()
        {
            Length L1 = null;
            Length L2 = L1.Maximum(Length.FromMeter(5));

            Assert.IsNull(L1);
            Assert.IsNull(L2);
        }

        [TestMethod]
        public void MaximumWithNull2()
        {
            Length L1 = new(10d, LengthUnit.Meter);
            Length L2 = L1.Maximum(null);

            Assert.IsNull(L2);
        }

        [TestMethod]
        public void MinimumWithNull()
        {
            Length L1 = null;
            Length L2 = L1.Minimum(Length.FromMeter(5));

            Assert.IsNull(L1);
            Assert.IsNull(L2);
        }

        [TestMethod]
        public void MinimumWithNull2()
        {
            Length L1 = new(10d, LengthUnit.Meter);
            Length L2 = L1.Minimum(null);

            Assert.IsNull(L2);
        }
    }
}

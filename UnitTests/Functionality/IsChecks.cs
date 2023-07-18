using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Functionality
{
    [TestClass]
    public class IsChecks
    {

        [TestMethod]
        public void LengthOperators()
        {
            Length L0 = new(0, LengthUnit.Meter);
            Length L1 = new(5, LengthUnit.Meter);
            Length L2 = null;
            UnknownUnit L3 = L1 * L1;
            UnknownUnit L4 = null;

            Assert.IsTrue(L0.IsZero());
            Assert.IsFalse(L0.IsNotZero());
            Assert.IsFalse(L0.IsAboveZero());
            Assert.IsFalse(L0.IsBelowZero());


            Assert.IsFalse(L1.IsZero());
            Assert.IsTrue(L1.IsNotZero());
            Assert.IsTrue(L1.IsAboveZero());
            Assert.IsFalse(L1.IsBelowZero());

            Assert.IsFalse(L2.IsZero());
            Assert.IsFalse(L2.IsNotZero());
            Assert.IsFalse(L2.IsAboveZero());
            Assert.IsFalse(L2.IsBelowZero());

            Assert.IsFalse(L3.IsZero());
            Assert.IsTrue(L3.IsNotZero());
            Assert.IsTrue(L3.IsAboveZero());
            Assert.IsFalse(L3.IsBelowZero());

            Assert.IsFalse(L4.IsZero());
            Assert.IsFalse(L4.IsNotZero());
            Assert.IsFalse(L4.IsAboveZero());
            Assert.IsFalse(L4.IsBelowZero());

        }


    }
}

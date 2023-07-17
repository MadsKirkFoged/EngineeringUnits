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
    public class Operators
    {

        [TestMethod]
        public void LengthOperators()
        {
            Length L1 = new(5, LengthUnit.Meter);
            Length L2 = null;
            Length L3 = null;

            Assert.IsTrue(L1 != L2);
            Assert.IsTrue(L2 != L1);
            Assert.IsFalse(L2 != L3);

            Assert.IsFalse(L1 == L2);
            Assert.IsFalse(L2 == L1);
            Assert.IsTrue(L2 == L3);

            Assert.IsFalse(L1 >= L2);
            Assert.IsFalse(L2 >= L1);
            Assert.IsTrue(L2 >= L3);

            Assert.IsFalse(L1 <= L2);
            Assert.IsFalse(L2 <= L1);
            Assert.IsTrue(L2 <= L3);

            Assert.IsFalse(L1 < L2);
            Assert.IsFalse(L2 < L1);
            Assert.IsFalse(L2 < L3);

            Assert.IsFalse(L1 > L2);
            Assert.IsFalse(L2 > L1);
            Assert.IsFalse(L2 > L3);
        }

        [TestMethod]
        public void UnknownOperators()
        {
            Length L1 = new(5, LengthUnit.Meter);

            UnknownUnit U1 = L1 * L1;

            UnknownUnit L2 = null;
            UnknownUnit L3 = null;


            Assert.IsTrue(L1 != L2);
            Assert.IsTrue(L2 != L1);
            Assert.IsFalse(L2 != L3);

            Assert.IsFalse(L1 == L2);
            Assert.IsFalse(L2 == L1);
            Assert.IsTrue(L2 == L3);

            Assert.IsFalse(L1 >= L2);
            Assert.IsFalse(L2 >= L1);
            Assert.IsTrue(L2 >= L3);

            Assert.IsFalse(L1 <= L2);
            Assert.IsFalse(L2 <= L1);
            Assert.IsTrue(L2 <= L3);

            Assert.IsFalse(L1 < L2);
            Assert.IsFalse(L2 < L1);
            Assert.IsFalse(L2 < L3);

            Assert.IsFalse(L1 > L2);
            Assert.IsFalse(L2 > L1);
            Assert.IsFalse(L2 > L3);


        }

        [TestMethod]
        public void OperatorsWithNull()
        {
            Length L1 = new(5, LengthUnit.Meter);
            UnknownUnit L2 = null;

            UnknownUnit L3 = L1 * L1;
            Length L4 = null;

            Assert.IsNull(L1 / L2);
            Assert.IsNull(L2 / L1);
            Assert.IsNull(L2 / L2);

            Assert.IsNull(L3 / L4);
            Assert.IsNull(L4 / L3);
            Assert.IsNull(L4 / L4);

            Assert.IsNull(L1 * L2);
            Assert.IsNull(L2 * L1);
            Assert.IsNull(L2 * L2);

            Assert.IsNull(L3 * L4);
            Assert.IsNull(L4 * L3);
            Assert.IsNull(L4 * L4);



        }

    }
}

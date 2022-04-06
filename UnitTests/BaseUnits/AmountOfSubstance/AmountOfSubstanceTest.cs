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
    public class AmountOfSubstanceTest
    {

        [TestMethod]
        public void AmountOfSubstance01()
        {
            AmountOfSubstance a1 = AmountOfSubstance.From(10, AmountOfSubstanceUnit.Centimole);
            Assert.AreEqual(10, a1.Centimole);

            AmountOfSubstance a2 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Decimole);
            Assert.AreEqual(a1, a2);
        }
        [TestMethod]
        public void AmountOfSubstance02()
        {
            double? value = null;
            AmountOfSubstance a = AmountOfSubstance.From(value, AmountOfSubstanceUnit.Centimole);
            Assert.IsNull(a);

        }


         [TestMethod]
        public void FromAmountOfSubstance()
        {
            double? value = 100;
            AmountOfSubstance a = AmountOfSubstance.From(value, AmountOfSubstanceUnit.Centimole);
            AmountOfSubstance a2 = AmountOfSubstance.From(value, null);
            Assert.IsNotNull(a);
            Assert.IsNull(a2);

        }
    }
}

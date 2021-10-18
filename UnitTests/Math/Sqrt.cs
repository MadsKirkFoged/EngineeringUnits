using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Sqrt
    {
        [TestMethod]
        public void Sqrt1()
        {
            Speed M6 = (Area.FromAcres(10) / (Duration.FromSeconds(1).Pow(2))).Sqrt();

            Assert.AreEqual(201.168, M6.SI); 
        }

        [TestMethod]
        public void Sqrt2()
        {
            Area A1 = Area.FromSquareFeet(19);

            Length L1 = A1.Sqrt();

            Assert.AreEqual(1.3285923979911973, L1.SI); 
        }


    }
}

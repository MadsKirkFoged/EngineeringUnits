using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class GetUnitByString
    {
        [TestMethod]
        public void GetUnitByString01()
        {
            LengthUnit unitasstring = Enumeration.GetUnitByString<LengthUnit>("Kilometer");

            Assert.AreEqual(unitasstring.Symbol, "km");
        }

       
    }
}

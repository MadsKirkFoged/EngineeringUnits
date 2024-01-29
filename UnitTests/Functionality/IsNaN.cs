using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EngineeringUnits.BaseUnitExtensions;


namespace UnitTests.Functionality
{
    [TestClass]
    public class IsNaN
    {
        [TestMethod]
        public void IsNaNCheck()
        {
            Mass mass1 = new Mass(double.NaN, MassUnit.SI);
            Mass mass2 = Mass.FromCentigram(double.NaN);
            Mass mass3 = Mass.FromCentigram(5);

            Assert.IsTrue(mass1.IsNaN());
            Assert.IsTrue(mass2.IsNaN());
            Assert.IsFalse(mass3.IsNaN());

            // old check. could remove ...........
            double nan1 = mass1.SI;
            double nan2 = mass2.Gram;
            Assert.AreEqual(nan1, double.NaN);
            Assert.AreEqual(nan2, double.NaN);
            // ....................................
        }

        [TestMethod]
        public void IsNaNCheckTemperature()
        {
            Temperature temp1 = new Temperature(double.NaN, TemperatureUnit.SI);
            Temperature temp2 = Temperature.FromKelvins(double.NaN);

            Assert.IsTrue(temp1.IsNaN());
            Assert.IsTrue(temp2.IsNaN());

            // old check. could remove ...........
            double nan1 = temp1.SI;
            double nan2 = temp2.DegreesCelsius;
            Assert.AreEqual(nan1, double.NaN);
            Assert.AreEqual(nan2, double.NaN);
            // ....................................
        }
    }
}

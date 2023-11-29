using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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

            double nan1 = mass1.SI;

            double nan2 = mass2.Gram;

            Assert.AreEqual(nan1, double.NaN);
            Assert.AreEqual(nan2, double.NaN);
        }

        [TestMethod]
        public void IsNaNCheckTemperature()
        {

            Temperature temp1 = new Temperature(double.NaN, TemperatureUnit.SI);

            Temperature temp2 = Temperature.FromKelvins(double.NaN);

            double nan1 = temp1.SI;

            double nan2 = temp2.DegreesCelsius;

            Assert.AreEqual(nan1, double.NaN);
            Assert.AreEqual(nan2, double.NaN);
        }
    }
}

using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EngineeringUnits.BaseUnitExtensions;

namespace UnitTests.Functionality;

[TestClass]
public class IsNaN
{
    [TestMethod]
    public void IsNaNCheck()
    {
        Mass massNan1 = new Mass(double.NaN, MassUnit.SI);
        Mass massNan2 = Mass.FromCentigram(double.NaN);
        Mass massNan3 = Mass.NaN;

        Mass massNotNan1 = Mass.FromCentigram(5);

        Assert.IsTrue(massNan1.IsNaN());
        Assert.IsTrue(massNan2.IsNaN());
        Assert.IsTrue(massNan3.IsNaN());

        Assert.IsFalse(massNotNan1.IsNaN());
    }

    [TestMethod]
    public void IsNaNCheckTemperature()
    {
        Temperature tempNan1 = new Temperature(double.NaN, TemperatureUnit.SI);
        Temperature tempNan2 = Temperature.FromKelvins(double.NaN);

        Temperature tempNotNan1 = Temperature.FromDegreesCelsius(20);

        Assert.IsTrue(tempNan1.IsNaN());
        Assert.IsTrue(tempNan2.IsNaN());
        Assert.IsFalse(tempNotNan1.IsNaN());
    }
}
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
        Mass mass1 = new Mass(double.NaN, MassUnit.SI);
        Mass mass2 = Mass.FromCentigram(double.NaN);
        Mass mass3 = Mass.FromCentigram(5);

        Assert.IsTrue(mass1.IsNaN());
        Assert.IsTrue(mass2.IsNaN());
        Assert.IsFalse(mass3.IsNaN());
    }

    [TestMethod]
    public void IsNaNCheckTemperature()
    {
        Temperature temp1 = new Temperature(double.NaN, TemperatureUnit.SI);
        Temperature temp2 = Temperature.FromKelvins(double.NaN);
        Temperature temp3 = Temperature.FromDegreesCelsius(20);

        Assert.IsTrue(temp1.IsNaN());
        Assert.IsTrue(temp2.IsNaN());
        Assert.IsFalse(temp3.IsNaN());
    }
}
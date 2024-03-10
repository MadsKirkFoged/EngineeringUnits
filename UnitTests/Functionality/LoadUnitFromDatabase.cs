using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests;

[TestClass]
public class LoadUnitFromDatabase
{
    [TestMethod]
    public void LengthFromDatabase()
    {

        double value = 10;
        var unit = "Meter";

        Length length = value.AddUnit<LengthUnit>(unit);

        Assert.AreEqual("10 m", $"{length:S5}");

    }

    [TestMethod]
    public void TemperatureFromDatabase()
    {

        var value = 164.254567;
        var unit = "Kelvin";

        Temperature temp = value.AddUnit<TemperatureUnit>(unit);

        Assert.AreEqual("164.25 K", $"{temp:S5}");

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FromDatabaseWrongUnits()
    {
        double value = 10;
        var unit = "Meter";

        Length length = value.AddUnit<TemperatureUnit>(unit);

        Assert.AreEqual("10 m", $"{length:S5}");

    }
}

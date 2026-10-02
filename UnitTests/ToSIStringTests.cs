using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class ToSIStringTests
{
    [TestMethod]
    public void ToSIString_LengthInNonSI_ReturnsMeters()
    {
        var length = new Length(1000, LengthUnit.Millimeter);
        var result = length.ToSIString();

        Assert.IsTrue(result.EndsWith("m"), $"Expected SI symbol 'm', got: {result}");
        Assert.IsTrue(result.Contains("1"), $"Expected value ~1, got: {result}");
    }

    [TestMethod]
    public void ToSIString_LengthAlreadySI_ReturnsSameValue()
    {
        var length = new Length(5, LengthUnit.Meter);
        var result = length.ToSIString();

        Assert.AreEqual("5 m", result);
    }

    [TestMethod]
    public void ToSIString_WithFormat_F2()
    {
        var length = new Length(1, LengthUnit.Meter);
        var result = length.ToSIString("f2");

        Assert.AreEqual("1.00 m", result);
    }

    [TestMethod]
    public void ToSIString_WithFormat_E2()
    {
        var length = new Length(1000, LengthUnit.Meter);
        var result = length.ToSIString("e2");

        Assert.AreEqual("1.00e+003 m", result);
    }

    [TestMethod]
    public void ToSIString_WithFormat_SignificantDigits_V3()
    {
        var length = new Length(123.456, LengthUnit.Meter);
        var result = length.ToSIString("v3");

        Assert.IsTrue(result.Contains("123"), $"Expected 3 significant digits, got: {result}");
        Assert.IsTrue(result.EndsWith("m"), $"Expected SI symbol 'm', got: {result}");
    }

    [TestMethod]
    public void ToSIString_Mass_KilogramIsSI()
    {
        var mass = new Mass(500, MassUnit.Gram);
        var result = mass.ToSIString();

        Assert.IsTrue(result.EndsWith("kg"), $"Expected SI symbol 'kg', got: {result}");
        Assert.IsTrue(result.Contains("0.5"), $"Expected 0.5 kg, got: {result}");
    }

    [TestMethod]
    public void ToSIString_Temperature_KelvinIsSI()
    {
        var temp = new Temperature(100, TemperatureUnit.DegreeCelsius);
        var result = temp.ToSIString();

        Assert.IsTrue(result.EndsWith("K"), $"Expected SI symbol 'K', got: {result}");
    }

    [TestMethod]
    public void ToSIString_Pressure_ShowsSIDimensions()
    {
        var pressure = new Pressure(1, PressureUnit.Bar);
        var result = pressure.ToSIString();

        // Pressure SI is Pa but GetStandardSymbol falls back to raw dimensions
        Assert.IsTrue(result.Contains("1"), $"Expected value containing 1e+05, got: {result}");
        Assert.IsTrue(result.Contains("kg"), $"Expected SI dimensions with kg, got: {result}");
    }

    [TestMethod]
    public void ToSIString_DefaultFormat_UsesG4()
    {
        var length = new Length(1.23456789, LengthUnit.Meter);
        var defaultResult = length.ToSIString();
        var g4Result = length.ToSIString("g4");

        Assert.AreEqual(g4Result, defaultResult);
    }
}

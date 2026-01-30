using EngineeringUnits;
using EngineeringUnits.NumberExtensions.NumberToLength;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EngineeringUnits.NumberExtensions.CS14.Tests;

[TestClass]
public class NumberToLengthExtensionsDoubleReceiverTests
{
    [TestMethod]
    public void Meter_property_on_double_creates_expected_length()
    {
        // Arrange
        var expected = Length.FromMeter(10d);

        // Act
        Length actual = 10d.Meter;

        // Assert
        Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void Centimeter_property_on_double_creates_expected_length()
    {
        // Arrange
        var expected = Length.FromCentimeter(10d);

        // Act
        Length actual = 10d.Centimeter;

        // Assert
        Assert.AreEqual(actual, expected);
    }
}
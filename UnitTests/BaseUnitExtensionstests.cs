using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass()]
public class BaseUnitExtensionstests
{

    [TestMethod()]
    public void HasValueTest_True()
    {
        // Arrange
        var unit = new Ratio(10, RatioUnit.Percent);

        // Act
        var result = unit.HasValue();

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod()]
    public void HasValueTest_False()
    {
        // Arrange
        var unit = new Ratio(double.NaN, RatioUnit.Percent);

        // Act
        var result = unit.HasValue();

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod()]
    public void HasValueTest_False2()
    {
        // Arrange
        var unit = new Ratio(double.PositiveInfinity, RatioUnit.Percent);

        // Act
        var result = unit.HasValue();

        // Assert
        Assert.IsFalse(result);
    }
}

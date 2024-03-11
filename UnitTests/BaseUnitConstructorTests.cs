using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EngineeringUnits.Tests;

[TestClass()]
public class BaseUnitConstructorTests
{
    [TestMethod()]
    public void BaseUnitIntRatio()
    {
        // Arrange
        var ratio = new BaseUnit(1);

        // Act

        // Assert
        Assert.AreEqual(1, ratio.AsSI);
    }

    [TestMethod()]
    public void BaseUnitDoubleRatio()
    {
        // Arrange
        var ratio = new BaseUnit(1d);

        // Act

        // Assert
        Assert.AreEqual(1, ratio.AsSI);
    }

    [TestMethod()]
    public void BaseUnitDecimalRatio()
    {
        // Arrange
        var ratio = new BaseUnit(1m);

        // Act

        // Assert
        Assert.AreEqual(1, ratio.AsSI);
    }
}
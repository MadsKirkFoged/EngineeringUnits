using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EngineeringUnits.Tests;

[TestClass()]
public class BaseUnitUnknownUnitTest
{
    [TestMethod()]
    public void PressureToUnknownNUll()
    {
        //Arrange
        Pressure p1 = null;

        // Act
        UnknownUnit p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void LengthToUnknownNUll()
    {
        //Arrange
        Length p1 = null;

        // Act
        UnknownUnit p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void TemperatureToUnknownNUll()
    {
        //Arrange
        Temperature p1 = null;

        // Act
        UnknownUnit p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void UnknownToPressureNUll()
    {
        //Arrange
        UnknownUnit p1 = null;

        // Act
        Pressure p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void UnknownToLengthNUll()
    {
        //Arrange
        UnknownUnit p1 = null;

        // Act
        Length p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void UnknownToTemperatureNUll()
    {
        //Arrange
        UnknownUnit p1 = null;

        // Act
        Temperature p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }
}
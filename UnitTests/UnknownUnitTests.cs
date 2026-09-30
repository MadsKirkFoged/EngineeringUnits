using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass()]
public class UnknownUnitTests

{
    [TestMethod()]
    public void ToStringOfUnknownUnitWithHiddenFactor()
    {
        // Issue #79: g has a symbol-less factor (9.80665) that was dropped when printing g·g
        Acceleration acc1 = Acceleration.FromStandardGravity(1.0);
        Acceleration acc2 = acc1.ToUnit(AccelerationUnit.MeterPerSecondSquared);

        Assert.AreEqual("96.17 m²/s⁴", (acc1 * acc2).ToString());
        Assert.AreEqual("96.17 m²/s⁴", (acc2 * acc1).ToString());
        Assert.AreEqual("96.17 m²/s⁴", (acc1 * acc1).ToString());
        Assert.AreEqual("96.17 m²/s⁴", (acc2 * acc2).ToString());
    }

    [TestMethod()]
    public void PressureToUnknownNUll()
    {
        //Arrange
        Pressure? p1 = null;

        // Act
        UnknownUnit? p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void LengthToUnknownNUll()
    {
        //Arrange
        Length? p1 = null;

        // Act
        UnknownUnit? p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void TemperatureToUnknownNUll()
    {
        //Arrange
        Temperature? p1 = null;

        // Act
        UnknownUnit? p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void UnknownToPressureNUll()
    {
        //Arrange
        UnknownUnit? p1 = null;

        // Act
        Pressure? p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void UnknownToLengthNUll()
    {
        //Arrange
        UnknownUnit? p1 = null;

        // Act
        Length? p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }

    [TestMethod()]
    public void UnknownToTemperatureNUll()
    {
        //Arrange
        UnknownUnit? p1 = null;

        // Act
        Temperature? p2 = p1;

        // Assert
        Assert.IsNull(p1);
        Assert.IsNull(p2);

    }
}
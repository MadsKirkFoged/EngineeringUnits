using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

[TestClass]
public class IsInf
{
    [TestMethod]
    public void Inf_Test()
    {
        // Arrange
        var unit = new BaseUnit(double.PositiveInfinity, MassFlowUnit.SI);

        // Act
        var value = unit.As(MassFlowUnit.SI);

        // Assert
        Assert.AreEqual(double.PositiveInfinity, value);
    }

    //add inf test with negative inf
    [TestMethod]
    public void NegInf_Test()
    {
        // Arrange
        var unit = new BaseUnit(double.NegativeInfinity, MassFlowUnit.SI);

        // Act
        var value = unit.As(MassFlowUnit.SI);

        // Assert
        Assert.AreEqual(double.PositiveInfinity, value);
    }

    //add inf test with massflow
    [TestMethod]
    public void Inf_Test2()
    {
        // Arrange
        var unit = new MassFlow(double.PositiveInfinity, MassFlowUnit.KilogramPerSecond);

        // Act
        var value = unit.As(MassFlowUnit.KilogramPerSecond);

        // Assert
        Assert.AreEqual(double.PositiveInfinity, value);
    }

    //add inf test for temperature
    [TestMethod]
    public void Inf_Test3()
    {
        // Arrange
        var unit = new Temperature(double.PositiveInfinity, TemperatureUnit.Kelvin);

        // Act
        var value = unit.As(TemperatureUnit.Kelvin);

        // Assert
        Assert.AreEqual(double.PositiveInfinity, value);
    }
}


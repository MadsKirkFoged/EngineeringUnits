using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BaseUnits;
[TestClass]
public class CreatingBaseUnits
{


    [TestMethod]
    public void Decimal_Test()
    {
        // Arrange
        var unit = new BaseUnit(1.5m, MassFlowUnit.KilogramPerSecond);

        // Act
        var value = unit.As(MassFlowUnit.KilogramPerSecond);

        // Assert
        Assert.AreEqual(1.5, value);
    }


    [TestMethod]    
    public void NegDecimal_Test()
    {
        // Arrange
        var unit = new BaseUnit(-1.5m, MassFlowUnit.KilogramPerSecond);

        // Act
        var value = unit.As(MassFlowUnit.KilogramPerSecond);

        // Assert
        Assert.AreEqual(-1.5, value);
    }

    //add test for int and temperature
    [TestMethod]    
    public void Int_Test()
    {
        // Arrange
        var unit = new BaseUnit(1, TemperatureUnit.DegreeCelsius);

        // Act
        var value = unit.As(TemperatureUnit.DegreeCelsius);

        // Assert
        Assert.AreEqual(1, value);
    }

    //add test for int and pressure
    [TestMethod]
    public void Int_Test2()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var value = unit.As(PressureUnit.Pascal);

        // Assert
        Assert.AreEqual(1, value);
    }

    //Create test for implicit operator baseunit to unknownunit
    [TestMethod]
    public void ImplicitOperator_Test()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var UnknownUnit = unit.ToUnknownUnit();
        var BackToPressureUnit = (Pressure)UnknownUnit;

        // Assert
        Assert.AreEqual(1, BackToPressureUnit.Pascal);
    }


    //Create test for implicit operator baseunit to unitsystem
    [TestMethod]
    public void ImplicitOperator_Test2()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var UnitSystem = (UnitSystem)unit;

        // Assert
        Assert.AreEqual("Pa", UnitSystem.ToString());
    }

    //Create test for baseunits GetStandardSymbol
    [TestMethod]
    public void GetStandardSymbol_Test()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var StandardSymbol = unit.GetStandardSymbol(PressureUnit.SI);

        // Assert
        Assert.AreEqual("Pa", StandardSymbol);
    }

    //Create test for baseunits Equals
    [TestMethod]
    public void Equals_Test()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);
        var unit2 = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var Equals = unit.Equals(unit2);

        // Assert
        Assert.AreEqual(true, Equals);
    }

    //Create test for baseunits Equals where it is not equal
    [TestMethod]
    public void Equals_Test2()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);
        var unit2 = new BaseUnit(2, PressureUnit.Pascal);

        // Act
        var Equals = unit.Equals(unit2);

        // Assert
        Assert.AreEqual(false, Equals);
    }

    //Create test for CompareTo(BaseUnit other)
    [TestMethod]
    public void CompareTo_Test()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);
        var unit2 = new BaseUnit(2, PressureUnit.Pascal);

        // Act
        var CompareTo = unit.CompareTo(unit2);

        // Assert
        Assert.AreEqual(-1, CompareTo);
    }

    //Create test for CompareTo(BaseUnit other) big i conpared to small
    [TestMethod]
    public void CompareTo_Test2()
    {
        // Arrange
        var unit = new BaseUnit(2, PressureUnit.Pascal);
        var unit2 = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var CompareTo = unit.CompareTo(unit2);

        // Assert
        Assert.AreEqual(1, CompareTo);
    }

    //Create test for CompareTo(BaseUnit other) where they are equal
    [TestMethod]
    public void CompareTo_Test3()
    {
        // Arrange
        var unit = new BaseUnit(1, PressureUnit.Pascal);
        var unit2 = new BaseUnit(1, PressureUnit.Pascal);

        // Act
        var CompareTo = unit.CompareTo(unit2);

        // Assert
        Assert.AreEqual(0, CompareTo);
    }

    //create test for GetBaseValue and dont use pressure again!
    [TestMethod]
    public void GetBaseValue_Test()
    {
        // Arrange
        var unit = new BaseUnit(1, MassUnit.Gram);

        // Act
        var GetBaseValue = unit.SI;

        // Assert
        Assert.AreEqual(0.001m, GetBaseValue);
    }


}

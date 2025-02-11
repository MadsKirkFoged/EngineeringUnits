using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class CreatingFunctions
{

    public static UnknownUnit Adding1(UnknownUnit a, UnknownUnit b) => a + b;

    [TestMethod]
    public void AddingTest1()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        UnknownUnit unit3 = Adding1(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }

    public static UnknownUnit Adding2(EngineeringUnits.BaseUnit a, EngineeringUnits.BaseUnit b) => a + b;

    [TestMethod]
    public void AddingTest2()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        UnknownUnit unit3 = Adding2(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }

    public static EngineeringUnits.BaseUnit Adding3(EngineeringUnits.BaseUnit a, EngineeringUnits.BaseUnit b) => a + b;

    [TestMethod]
    public void AddingTest3()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        EngineeringUnits.BaseUnit unit3 = Adding3(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }

    public static EngineeringUnits.BaseUnit Adding4(UnknownUnit a, UnknownUnit b) => a + b;

    [TestMethod]
    public void AddingTest4()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        EngineeringUnits.BaseUnit unit3 = Adding4(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }
}

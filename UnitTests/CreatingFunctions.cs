using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass]
public class CreatingFunctions
{

    public static UnknownUnit adding1(UnknownUnit a, UnknownUnit b)
    {

        return a + b;
    }


    [TestMethod]
    public void AddingTest1()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        var unit3 = adding1(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }


    public static UnknownUnit adding2(BaseUnit a, BaseUnit b)
    {
        return a + b;
    }


    [TestMethod]
    public void AddingTest2()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        var unit3 = adding2(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }


    public static BaseUnit adding3(BaseUnit a, BaseUnit b)
    {
        return a + b;
    }


    [TestMethod]
    public void AddingTest3()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        var unit3 = adding3(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }


    public static BaseUnit adding4(UnknownUnit a, UnknownUnit b)
    {
        return a + b;
    }


    [TestMethod]
    public void AddingTest4()
    {
        // Arrange
        var unit1 = new Length(1, LengthUnit.Meter);
        var unit2 = new Length(2, LengthUnit.Meter);

        // Act
        var unit3 = adding4(unit1, unit2);

        // Assert
        Assert.AreEqual(3, unit3.As(LengthUnit.Meter));
    }

}

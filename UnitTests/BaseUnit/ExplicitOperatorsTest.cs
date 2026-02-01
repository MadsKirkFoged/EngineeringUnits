using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BaseUnit;

[TestClass()]
public class BaseUnitImplicitOperatorsTest
{
    [TestMethod()]
    public void RatioToInt()
    {
        // Arrange
        var R1 = new Ratio(1, RatioUnit.SI);

        // Act
        int Int1 = (int)R1;

        // Assert
        Assert.AreEqual(1, Int1);

    }

    [TestMethod()]
    public void RatioToDouble()
    {
        // Arrange
        var R1 = new Ratio(1d, RatioUnit.SI);

        // Act
        double Double1 = (double)R1;

        // Assert
        Assert.AreEqual(1, Double1);

    }

    [TestMethod()]
    public void RatioToDecimal()
    {
        // Arrange
        var R1 = new Ratio(1m, RatioUnit.SI);

        // Act
        decimal Decimal1 = (decimal)R1;

        // Assert
        Assert.AreEqual(1, Decimal1);

    }

    //[TestMethod()]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void LengthToInt()
    //{
    //    // Arrange
    //    var R1 = new Length(1, LengthUnit.SI);

    //    // Act
    //    int Int1 = R1;

    //    // Assert
    //    Assert.AreEqual(1, Int1);

    //}

    //[TestMethod()]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void LengthToDouble()
    //{
    //    // Arrange
    //    var R1 = new Length(1d, LengthUnit.SI);

    //    // Act
    //    double Double1 = R1;

    //    // Assert
    //    Assert.AreEqual(1, Double1);

    //}

    //[TestMethod()]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void LengthToDecimal()
    //{
    //    // Arrange
    //    var R1 = new Length(1m, LengthUnit.SI);

    //    // Act
    //    decimal Decimal1 = R1;

    //    // Assert
    //    Assert.AreEqual(1, Decimal1);

    //}
}
using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Math;


[TestClass()]
public class MathWithNulls
{

    //Does it even make sense to add a null value to a unit?

    [TestMethod()]
    public void AddNull()
    {
        //Arrange
        Length L1 = Length.FromMeter(10);
        double? D1 = null;


        // Act
        var test2 = L1 + D1;

        // Assert
        Assert.IsNull(test2);
    }

    [TestMethod()]
    public void SubNull()
    {
        //Arrange
        Length L1 = Length.FromMeter(10);
        double? D1 = null;


        // Act
        var test2 = L1 - D1;

        // Assert
        Assert.IsNull(test2);
    }

    [TestMethod()]
    public void MultiplyNull()
    {
        //Arrange
        Length L1 = Length.FromMeter(10);
        double? D1 = null;


        // Act
        var test2 = L1 * D1;

        // Assert
        Assert.IsNull(test2);
    }


    [TestMethod()]
    public void DivideNull()
    {
        //Arrange
        Length L1 = Length.FromMeter(10);
        double? D1 = null;


        // Act
        var test2 = L1 / D1;

        // Assert
        Assert.IsNull(test2);
    }
}

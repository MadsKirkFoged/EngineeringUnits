using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class DimensionlessTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new Dimensionless(10, DimensionlessUnit.Percent);

        // Assert
        Assert.AreEqual("10 %", test.ToString());
    }
}

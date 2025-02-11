using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ElectricConductanceTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new ElectricConductance(10, ElectricConductanceUnit.CubicMeter);

        // Assert
        Assert.AreEqual("10 m³", test.ToString());
    }
}

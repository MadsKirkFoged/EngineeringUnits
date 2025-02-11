using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class PowerCostTests
{

    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new PowerCost(10, PowerCostUnit.USDollarPerKilowatt);

        // Assert
        Assert.AreEqual("10 $/kW", test.ToString());
    }
}

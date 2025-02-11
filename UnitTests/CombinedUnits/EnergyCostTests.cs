using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class EnergyCostTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new EnergyCost(10, EnergyCostUnit.USDollarPerKilowattHour);

        // Assert
        Assert.AreEqual("10 $/kWh", test.ToString());
    }
}

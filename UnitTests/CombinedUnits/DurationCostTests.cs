using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class DurationCostTests
{

    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test1 = new DurationCost(10, DurationCostUnit.SI);
        var test2 = EngineeringUnits.DurationCost.FromMillionUSDollarPerYear365(10);

        // Assert
        Assert.AreEqual("10 $/s", test1.ToString());
        Assert.AreEqual("10 M$/yr", test2.ToString());
    }
}

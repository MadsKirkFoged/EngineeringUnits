using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ForceCostTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new ForceCost(10, ForceCostUnit.USDollarPerNewton);

        // Assert
        Assert.AreEqual("10 $/N", test.ToString());
    }
}

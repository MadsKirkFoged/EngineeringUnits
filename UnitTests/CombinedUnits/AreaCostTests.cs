using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class AreaCostTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new AreaCost(10, AreaCostUnit.SI);

        // Assert
        Assert.AreEqual("10 $/m²", test.ToString());
    }
}

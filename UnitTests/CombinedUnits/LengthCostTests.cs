using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class LengthCostTests
{

    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new LengthCost(10, LengthCostUnit.EuroPerMeter);

        // Assert
        Assert.AreEqual("10 €/m", test.ToString());
    }
}

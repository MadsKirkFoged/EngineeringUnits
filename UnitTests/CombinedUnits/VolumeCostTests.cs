using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumeCostTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new VolumeCost(10, VolumeCostUnit.EuroPerCubicMeter);

        // Assert
        Assert.AreEqual("10 €/m³", test.ToString());
    }
}

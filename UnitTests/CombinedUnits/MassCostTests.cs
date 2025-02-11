using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class MassCostTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new MassCost(10, MassCostUnit.EuroPerKilogram);

        // Assert
        Assert.AreEqual("10 €/kg", test.ToString());
    }
}

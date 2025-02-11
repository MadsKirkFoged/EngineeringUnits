using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class MolarFlowTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new MolarFlow(10, MolarFlowUnit.MolePerSecond);

        // Assert
        Assert.AreEqual("10 mol/s", test.ToString());
    }
}

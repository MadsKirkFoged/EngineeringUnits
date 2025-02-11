using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class RotationalSpeedTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new RotationalSpeed(10, RotationalSpeedUnit.Megahertz);

        // Assert
        Assert.AreEqual("10 MHz", test.ToString());
    }
}

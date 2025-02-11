using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class SnapTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new Snap(10, SnapUnit.MeterPerSecond4);

        // Assert
        Assert.AreEqual("10 m/s⁴", test.ToString());
    }
}

using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class JerkTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new Jerk(10, JerkUnit.MeterPerSecondCubed);

        // Assert
        Assert.AreEqual("10 m/s³", test.ToString());
    }
}

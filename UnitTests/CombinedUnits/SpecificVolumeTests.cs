using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class SpecificVolumeTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new SpecificVolume(10, SpecificVolumeUnit.CubicMeterPerKilogram);

        // Assert
        Assert.AreEqual("10 m³/kg", test.ToString());
    }
}

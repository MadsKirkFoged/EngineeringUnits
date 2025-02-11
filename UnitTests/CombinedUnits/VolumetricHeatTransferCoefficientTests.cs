using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumetricHeatTransferCoefficientTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new VolumetricHeatTransferCoefficient(10, VolumetricHeatTransferCoefficientUnit.WattPerCubicMeterKelvin);

        // Assert
        Assert.AreEqual("10 W/m³K", test.ToString());
    }
}

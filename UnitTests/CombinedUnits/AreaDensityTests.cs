using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class AreaDensityTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new AreaDensity(10, AreaDensityUnit.KilogramPerSquareMeter);

        // Assert
        Assert.AreEqual("10 kg/m²", test.ToString());
    }
}

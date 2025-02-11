using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BaseUnits;

[TestClass]
public class LuminousIntensityTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new LuminousIntensity(10, LuminousIntensityUnit.Candela);

        // Assert
        Assert.AreEqual("10 cd", test.ToString());
    }
}

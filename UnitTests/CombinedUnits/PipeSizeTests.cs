using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class PipeSizeTests
{
    [TestMethod()]
    public void Simple()
    {
        //Arrange
        var test = new PipeSize(10, PipeSizeUnit.DN);

        // Assert
        Assert.AreEqual("10 DN", test.ToString());
    }
}

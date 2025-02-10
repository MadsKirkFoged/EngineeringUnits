using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

[TestClass()]
public class IfNullSetToZero
{


    [TestMethod()]
    public void CostDollar()
    {
        //Arrange
        var test = MassFlow.FromKilogramPerSecond(null);


        //Act
        test = test.IfNullSetToZero();

        // Assert
        Assert.AreEqual(MassFlow.Zero, test);
    }


}

using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

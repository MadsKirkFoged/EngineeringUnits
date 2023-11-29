using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass]
public class Constantstest
{

    //Create a tests for the Constants
    [TestMethod]
    public void GravitationalConstant_Test()
    {
        // Arrange
        var unit = Constants.GravitationalConstant;

        // Act
        var value = unit.As(ForceUnit.Newton);

        // Assert
        Assert.AreEqual(0.0000000000667408, value);
    }

 
}

using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass()]
internal class CostTests
{
    [TestMethod()]
    public void Cost()
    {
        //Arrange
        Cost test = new Cost(10, CostUnit.USDollar);


        // Assert
        Assert.AreEqual("10 US", test.ToString());
    }


}

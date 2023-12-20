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
public class UnaryOperatorsTest
{

    //add test for + operator
    [TestMethod]
    public void AddOperator()
    {
        Length length = new(1, LengthUnit.Meter);
 

        Length length2 = +length;

        Assert.AreEqual(length, length2);
    }


    //same test for unknownunit
    [TestMethod]
    public void AddOperatorUnknownUnit()
    {
        UnknownUnit unknownUnit = new(1d, new UnitSystem());
 

        UnknownUnit unknownUnit2 = +unknownUnit;

        Assert.AreEqual(unknownUnit, unknownUnit2);
    }

    //add test for - operator
    [TestMethod]
    public void MinusOperator()
    {
        Length length = new(1, LengthUnit.Meter); 

        Length length2 = -length;

        Assert.AreEqual(Length.FromMeter(-1), length2);
        Assert.AreNotEqual(length, length2);
    }

    //same test for unknownunit
    [TestMethod]
    public void MinusOperatorUnknownUnit()
    {
        UnknownUnit unknownUnit = new(1d, new UnitSystem()); 

        UnknownUnit unknownUnit2 = -unknownUnit;

        Assert.AreEqual(new UnknownUnit(-1d, new UnitSystem()), unknownUnit2);
        Assert.AreNotEqual(unknownUnit, unknownUnit2);
    }

}

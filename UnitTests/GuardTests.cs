using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests;

[TestClass]
public class GuardTests
{

    //Create test for GuardAgainst.DifferentUnits
    [TestMethod]
    public void DifferentUnits()
    {
        Length Unit1 = new(1, LengthUnit.Meter);
        Mass Unit2 = new(1, MassUnit.Decigram);

        _=Assert.ThrowsException<WrongUnitException>(() => GuardAgainst.DifferentUnits(Unit1, Unit2));
    }

    //Create test for GuardAgainst.DifferentUnits with a list if units
    [TestMethod]
    public void DifferentUnitsList()
    {
        Length Unit1 = new(1, LengthUnit.Meter);
        Mass Unit2 = new(1, MassUnit.Decigram);
        Length Unit3 = new(1, LengthUnit.Centimeter);

        var ListOfUnits = new List<UnitSystem>
        {
            Unit1,
            Unit2,
            Unit3
        };

        _=Assert.ThrowsException<WrongUnitException>(() => GuardAgainst.DifferentUnits(ListOfUnits));
    }

    //Create test for GuardAgainst.DifferentUnits with a list if the same units where it should not thros an exception
    [TestMethod]
    public void DifferentUnitsListSameUnits()
    {
        Length Unit1 = new(1, LengthUnit.Meter);
        Length Unit2 = new(1, LengthUnit.Decimeter);
        Length Unit3 = new(1, LengthUnit.Centimeter);

        var ListOfUnits = new List<UnitSystem>
        {
            Unit1,
            Unit2,
            Unit3
        };

        GuardAgainst.DifferentUnits(ListOfUnits);
    }
}

using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests;

[TestClass]
public class ExtensionTests
{

    //create test for Extensions.ReduceUnits
    [TestMethod]
    public void ReduceUnitsHard()
    {
        Length SI = new(1, LengthUnit.Meter);
        Length NonSI = new(1, LengthUnit.Hand);

        Area area = SI * NonSI;

        UnitSystem unitSystem = area;

        Assert.AreEqual("mh", unitSystem.ToString());
        Assert.AreEqual("m²", unitSystem.ReduceUnitsHard().ToString());
    }

    [TestMethod]
    public void ReduceUnits()
    {
        Length SI = new(1, LengthUnit.Meter);
        Length SI2 = new(1, LengthUnit.Centimeter);

        Area area = SI * SI2;

        UnitSystem unitSystem = area;

        Assert.AreEqual(2, unitSystem.ListOfUnits.Count());
        Assert.AreEqual(2, unitSystem.ReduceUnits().ListOfUnits.Count());
        Assert.AreEqual(1, unitSystem.ReduceUnitsHard().ListOfUnits.Count());
    }

    //Create test for ToUnit
    [TestMethod]
    public void ToUnit()
    {
        Length SI = new(1, LengthUnit.Meter);

        Length NewUnit = SI.ToUnit(LengthUnit.Chain);

        Assert.AreEqual("1 m", SI.ToString("G5"));
        Assert.AreEqual("0.04971 ch", NewUnit.ToString("G5"));
    }

    //Create test for ToUnit where we use UnknownUnit

    [TestMethod]
    public void ToUnitUnknownUnit()
    {
        Length SI = new(1, LengthUnit.Meter);

        var Unknown = SI.ToUnknownUnit();

        Length NewUnit = Unknown.ToUnit(LengthUnit.Chain);

        Assert.AreEqual("1 m", SI.ToString("G5"));
        Assert.AreEqual("0.04971 ch", NewUnit.ToString("G5"));
    }

    //Create test for Mean(this IEnumerable<UnknownUnit> list)
    [TestMethod]
    public void Mean()
    {
        Length SI = new(1, LengthUnit.Meter);
        Length SI2 = new(2, LengthUnit.Meter);
        Length SI3 = new(3, LengthUnit.Meter);

        List<Length> list = [SI, SI2, SI3];

        Length? Mean = list.Mean();

        Assert.IsNotNull(Mean);
        Assert.AreEqual("2 m", Mean.ToString("G5"));
    }

    //Create test for Mean(this IEnumerable<UnknownUnit> list) with an even number of items
    [TestMethod]
    public void MeanEven()
    {
        Length SI = new(1, LengthUnit.Meter);
        Length SI2 = new(2, LengthUnit.Meter);
        Length SI3 = new(3, LengthUnit.Meter);
        Length SI4 = new(4, LengthUnit.Meter);

        List<Length> list = [SI, SI2, SI3, SI4];

        Length? Mean = list.Mean();

        Assert.IsNotNull(Mean);
        Assert.AreEqual("3 m", Mean.ToString("G5"));
    }

    //create test for Sum with zero items
    [TestMethod]
    public void SumZero()
    {
        List<Length> list = [];

        Length? Sum = list.Sum();

        Assert.IsNull(Sum);
    }

    //create test for sum with one item
    [TestMethod]
    public void SumOne()
    {
        Length SI = new(1, LengthUnit.Meter);

        List<Length> list = [SI];

        Length? Sum = list.Sum();

        Assert.IsNotNull(Sum);
        Assert.AreEqual("1 m", Sum.ToString("G5"));
    }

    [TestMethod]
    public void Rounding()
    {
        Volume v0 = Volume.FromCubicMeter(95.0);

        Assert.AreEqual((Volume)v0.CeilingTo(Volume.FromCubicMeter(10)), Volume.FromCubicMeter(100));
        Assert.AreEqual((Volume)v0.RoundTo(  Volume.FromCubicMeter(10)), Volume.FromCubicMeter(100));
        Assert.AreEqual((Volume)v0.FloorTo(  Volume.FromCubicMeter(10)), Volume.FromCubicMeter( 90));

    }
}

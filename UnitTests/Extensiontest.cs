﻿using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass]
public class Extensiontest
{

    //create test for Extensions.ReduceUnits
    [TestMethod]
    public void ReduceUnitsHard()
    {
        Length SI = new(1, LengthUnit.Meter);
        Length NonSI = new(1, LengthUnit.Hand);

        Area area = SI * NonSI;

        Assert.AreEqual("mh", area.Unit.ToString());
        Assert.AreEqual("m²", area.Unit.ReduceUnitsHard().ToString());
    }


    [TestMethod]
    public void ReduceUnits()
    {
        Length SI = new(1, LengthUnit.Meter);
        Length SI2 = new(1, LengthUnit.Centimeter);

        Area area = SI * SI2;

        Assert.AreEqual(2, area.Unit.ListOfUnits.Count());
        Assert.AreEqual(2, area.Unit.ReduceUnits().ListOfUnits.Count());
        Assert.AreEqual(1, area.Unit.ReduceUnitsHard().ListOfUnits.Count());
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

        var Unknown = (UnknownUnit)SI;

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

        List<Length> list = new() { SI, SI2, SI3 };

        Length Mean = list.Mean();

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

        List<Length> list = new() { SI, SI2, SI3, SI4 };

        Length Mean = list.Mean();

        Assert.AreEqual("3 m", Mean.ToString("G5"));
    }

    //create test for Sum with zero items
    [TestMethod]
    public void SumZero()
    {
        List<Length> list = new();

        Length Sum = list.Sum();

        Assert.IsNull(Sum);
    }


    //create test for sum with one item
    [TestMethod]
    public void SumOne()
    {
        Length SI = new(1, LengthUnit.Meter);

        List<Length> list = new() { SI };

        Length Sum = list.Sum();

        Assert.AreEqual("1 m", Sum.ToString("G5"));
    }


}

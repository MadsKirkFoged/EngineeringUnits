using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

[TestClass]
public class MinMax
{
    [TestMethod]
    //[Obsolete]
    public void MinimumWithNoEffect()
    {
        Length L1 = new(10d, LengthUnit.Meter);

        Length L2 = L1.LowerLimitAt(Length.FromMeter(5));

        Assert.AreEqual(L1, L2);

    }

    [TestMethod]
    //[Obsolete]
    public void Minimum()
    {
        Length L1 = new(10d, LengthUnit.Meter);

        Length L2 = L1.LowerLimitAt(Length.FromMeter(15));

        Assert.AreNotEqual(L1, L2);

        Assert.AreEqual("15 m", $"{L2:S5}");
    }

    [TestMethod]
    [ExpectedException(typeof(WrongUnitException))]
    //[Obsolete]
    public void MinimumWithWrongUnit()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        _ = L1.LowerLimitAt(Frequency.FromSI(15));

    }

    [TestMethod]
    //[Obsolete]
    public void MaximumWithNoEffect()
    {
        Length L1 = new(10d, LengthUnit.Meter);

        Length L2 = L1.UpperLimitAt(Length.FromMeter(15));

        Assert.AreEqual(L1, L2);

    }

    [TestMethod]
    //[Obsolete]
    public void Maximum()
    {
        Length L1 = new(10d, LengthUnit.Meter);

        Length L2 = L1.UpperLimitAt(Length.FromMeter(5));

        Assert.AreNotEqual(L1, L2);

        Assert.AreEqual("5 m", $"{L2:S5}");
    }

    [TestMethod]
    [ExpectedException(typeof(WrongUnitException))]
    //[Obsolete]
    public void MaximumWithWrongUnit()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        _ = L1.UpperLimitAt(Frequency.FromSI(15));

    }

    [TestMethod]
    //[Obsolete]
    public void MaximumWithNull()
    {
        Length? L1 = null;
        Length? L2 = L1.UpperLimitAt(Length.FromMeter(5));

        Assert.IsNull(L1);
        Assert.IsNull(L2);
    }

    [TestMethod]
    //[Obsolete]
    public void MaximumWithNull2()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        Length L2 = L1.UpperLimitAt(null);

        Assert.IsNull(L2);
    }

    [TestMethod]
    //[Obsolete]
    public void MinimumWithNull()
    {
        Length? L1 = null;
        Length? L2 = L1.LowerLimitAt(Length.FromMeter(5));

        Assert.IsNull(L1);
        Assert.IsNull(L2);
    }

    [TestMethod]
    //[Obsolete]
    public void MinimumWithNull2()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        Length? L2 = L1.LowerLimitAt(null);

        Assert.IsNull(L2);
    }

    //Test with upperlimit  
    [TestMethod]
    public void UpperLimit()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        Length L2 = L1.UpperLimitAt(Length.FromMeter(15));

        Assert.AreEqual(L1, L2);
    }

    [TestMethod]
    public void UpperLimit2()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        Length L2 = L1.UpperLimitAt(Length.FromMeter(5));

        Assert.AreNotEqual(L1, L2);
        Assert.AreEqual("5 m", $"{L2:S5}");
    }

    //UpperLimit with unknown unit
    [TestMethod]
    public void UpperLimitUnknownUnit()
    {
        UnknownUnit L1 = new(10d, LengthUnit.Meter);
        UnknownUnit L2 = L1.UpperLimitAt(Length.FromMeter(15));

        Assert.AreEqual(L1, L2);
    }

    [TestMethod]
    public void UpperLimitUnknownUnit2()
    {
        UnknownUnit L1 = new(10d, LengthUnit.Meter);
        UnknownUnit L2 = L1.UpperLimitAt(Length.FromMeter(5));

        Assert.AreNotEqual(L1, L2);
        Assert.AreEqual("5 m", $"{L2:S5}");
    }

    //Test with lowerlimit 
    [TestMethod]
    public void LowerLimit()
    {
        Length L1 = new(10d, LengthUnit.Meter);
        Length L2 = L1.LowerLimitAt(Length.FromMeter(5));

        Assert.AreEqual(L1, L2);
    }

    //Test with lowerlimit unknwon unit

    [TestMethod]
    public void LowerLimitUnknownUnit()
    {
        UnknownUnit L1 = new(10d, LengthUnit.Meter);
        UnknownUnit L2 = L1.LowerLimitAt(Length.FromMeter(5));

        Assert.AreEqual(L1, L2);
    }
}

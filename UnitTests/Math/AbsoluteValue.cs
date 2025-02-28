using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTests.Math;

[TestClass]
public class AbsoluteValue
{
    [TestMethod]
    public void TestAbsoluteValue01()
    {
        var f1 = Frequency.FromMegahertz(-32);

        var toString = f1.ToString();

        Frequency f2 = f1.Abs();

        Assert.AreEqual(toString, f1.ToString()); // calling Abs should not mutate F1 if it returns F2
        Assert.AreNotEqual(f1, f2);
    }

    [TestMethod]
    public void TestAbsoluteValue02()
    {
        var f1 = Frequency.FromMegahertz(32);

        var toString = f1.ToString();
        Frequency f2 = f1.Abs();
        UnknownUnit f3 = f1.Abs();

        Debug.Print($"{f3}");

        Assert.AreEqual(Frequency.FromMegahertz(32).As(FrequencyUnit.Megahertz), f1.As(FrequencyUnit.Megahertz));
        Assert.AreEqual(f1.As(FrequencyUnit.Megahertz), f2.As(FrequencyUnit.Megahertz));
        Assert.AreEqual(f1.As(FrequencyUnit.Megahertz), f3.As(FrequencyUnit.Megahertz));

        Assert.AreEqual(toString, f1.ToString());
        Assert.AreEqual(toString, f2.ToString());
        Assert.AreEqual(toString, f3.ToString());
    }

    [TestMethod]
    public void TestAbsoluteValue03()
    {
        var f0 = Frequency.FromMegahertz(32);
        //decimal baseUnitValue = f0.BaseunitValue;
        var toString = f0.ToString();

        var f1 = Frequency.FromMegahertz(-32);

        Frequency f2 = f1.Abs();
        UnknownUnit f3 = f1.Abs();

        Assert.AreEqual(Frequency.FromMegahertz(32).As(FrequencyUnit.SI), f2.As(FrequencyUnit.SI));
        Assert.AreEqual(f2.As(FrequencyUnit.SI), f3.As(FrequencyUnit.SI));

        Assert.AreEqual(toString, f2.ToString());
        Assert.AreEqual(toString, f3.ToString());
    }

    [TestMethod]
    public void SIPositiveAbs()
    {
        var f1 = Frequency.FromSI(32);
        Frequency f2 = f1.Abs();

        Assert.AreEqual(f1, f2);
        Assert.AreEqual(f2, Frequency.FromSI(32));
    }

    [TestMethod]
    public void SINegativeAbs()
    {
        var f1 = Frequency.FromSI(-32);
        Frequency f2 = f1.Abs();

        Assert.AreNotEqual(f1, f2);
        Assert.AreEqual(f2, Frequency.FromSI(32));
    }

    [TestMethod]
    public void PositiveAbs()
    {
        var f1 = Power.FromBritishThermalUnitPerMinute(58);
        Power f2 = f1.Abs();

        Assert.AreEqual(f1, f2);
        Assert.AreEqual(f2, Power.FromBritishThermalUnitPerMinute(58));
    }

    [TestMethod]
    public void NegativeAbs()
    {
        var f1 = Power.FromBritishThermalUnitPerMinute(-58);
        Power f2 = f1.Abs();

        Assert.AreNotEqual(f1, f2);
        Assert.AreEqual(f2, Power.FromBritishThermalUnitPerMinute(58));
    }

    [TestMethod]
    public void UnknownPositiveAbs()
    {
        var f1 = Power.FromBritishThermalUnitPerMinute(58).ToUnknownUnit();
        UnknownUnit f2 = f1.Abs();

        Assert.AreEqual(f1, f2);
        Assert.IsTrue(f2 == Power.FromBritishThermalUnitPerMinute(58));
    }

    [TestMethod]
    public void UnknownNegativeAbs()
    {
        var f1 = Power.FromBritishThermalUnitPerMinute(-58).ToUnknownUnit();
        UnknownUnit f2 = f1.Abs();

        Assert.AreNotEqual(f1, f2);
        Assert.IsTrue(f2 == Power.FromBritishThermalUnitPerMinute(58));
    }

    [TestMethod]
    public void NullAbs()
    {
        Power? f1 = null;
        Power? f2 = f1.Abs();

        Assert.IsNull(f1);
        Assert.IsNull(f2);
    }

    [TestMethod]
    public void AbsDoesNotChangeType()
    {
        var f1 = Power.FromBritishThermalUnitPerMinute(58);
        var f2 = f1.Abs().Watt;

        Assert.AreEqual(f1.Watt, f2);
    }
}

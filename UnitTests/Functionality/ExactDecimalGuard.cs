using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

// EngineeringUnits does its math in decimal on purpose - users expect 0.1 m + 0.2 m == 0.3 m.
// These tests fail when any part of it starts doing double math (as commit 26d752ef once did for SI units).
// A double result goes back through (decimal)double, which keeps 15 significant digits and hides the double noise of
// 0.1 + 0.2 - so most of these use values that need more digits than a double has (it has 15-17).
[TestClass]
public class ExactDecimalGuard
{
    [TestMethod]
    public void TypedDoublesAddUpExactly()
    {
        // As plain doubles: 0.30000000000000004, 0.30000000000000004 and 1.2100000000000002
        Assert.IsTrue(Length.FromMeter(0.1) + Length.FromMeter(0.2) == Length.FromMeter(0.3));
        Assert.IsTrue(Length.FromMeter(0.1) * 3 == Length.FromMeter(0.3));
        Assert.IsTrue(Length.FromMeter(1.1) * Length.FromMeter(1.1) == Area.FromSquareMeter(1.21));

        Assert.AreEqual(0.3m, (Length.FromMeter(0.1) + Length.FromMeter(0.2)).AsSI);
    }

    [TestMethod]
    public void AddKeepsEveryDecimalDigit()
    {
        var sum = new Length(0.1234567890123456789m, LengthUnit.Meter) + new Length(0.0000000000000000001m, LengthUnit.Meter);

        Assert.AreEqual(0.123456789012345679m, sum.AsSI);
    }

    [TestMethod]
    public void SubtractKeepsEveryDecimalDigit()
    {
        // As doubles both are 1, so the difference would be 0
        var difference = new Length(1.0000000000000000002m, LengthUnit.Meter) - new Length(1m, LengthUnit.Meter);

        Assert.AreEqual(0.0000000000000000002m, difference.AsSI);
    }

    [TestMethod]
    public void MultiplyKeepsEveryDecimalDigit()
    {
        Area area = new Length(0.1234567890123456789m, LengthUnit.Meter) * new Length(10m, LengthUnit.Meter);

        Assert.AreEqual(1.234567890123456789m, area.AsSI);
    }

    [TestMethod]
    public void DivideKeepsEveryDecimalDigit()
    {
        Ratio third = new Length(1m, LengthUnit.Meter) / new Length(3m, LengthUnit.Meter);

        Assert.AreEqual(1m / 3m, third.AsSI);
    }

    [TestMethod]
    public void CompareSeesEveryDecimalDigit()
    {
        // As doubles both are 1
        var bigger = new Length(1.0000000000000000001m, LengthUnit.Meter);
        var one = new Length(1m, LengthUnit.Meter);

        Assert.IsTrue(bigger > one);
        Assert.IsTrue(one < bigger);
        Assert.IsTrue(bigger != one);
        Assert.IsFalse(bigger == one);
        Assert.IsFalse(bigger.Equals(one));
    }

    [TestMethod]
    public void SameNonSIUnitKeepsEveryDecimalDigit()
    {
        var sum = new Length(0.1234567890123456789m, LengthUnit.Inch) + new Length(0.0000000000000000001m, LengthUnit.Inch);

        Assert.IsTrue(sum == new Length(0.123456789012345679m, LengthUnit.Inch));
        Assert.IsTrue(new Length(1.0000000000000000001m, LengthUnit.Inch) > new Length(1m, LengthUnit.Inch));
    }

    [TestMethod]
    public void MixedUnitsKeepEveryDecimalDigit()
    {
        // 1 in is exactly 0.0254 m
        var sum = new Length(0.1234567890123456789m, LengthUnit.Meter) + new Length(1m, LengthUnit.Inch);

        Assert.AreEqual(0.1488567890123456789m, sum.AsSI);
    }

    [TestMethod]
    public void DecimalSafeMathIsDecimalMath()
    {
        var a = new DecimalSafe(0.1234567890123456789m);
        var tiny = new DecimalSafe(0.0000000000000000001m);

        Assert.AreEqual(0.123456789012345679m, (decimal)(a + tiny));
        Assert.AreEqual(0.1234567890123456788m, (decimal)(a - tiny));
        Assert.AreEqual(1.234567890123456789m, (decimal)(a * new DecimalSafe(10m)));
        Assert.AreEqual(1m / 3m, (decimal)(new DecimalSafe(1m) / new DecimalSafe(3m)));
        Assert.IsTrue(a + tiny > a);
        Assert.IsTrue(new DecimalSafe(0.1).IsDecimal);
    }
}

using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests.HaveToFail;

[TestClass]
public class UnitsAreWrong
{
    [TestMethod]
    public void AreaCantBeVolume()
    {
        Assert.ThrowsExactly<WrongUnitException>(() =>
        {
            var length = Length.FromYard(1);
            var length2 = Length.FromMeter(5);

            Area area2 = length * length2 * length2;

            Assert.AreNotEqual(length, length2);
            Assert.AreEqual(area2, area2);
        });
    }

    [TestMethod]
    public void EnergyCantBeDensity()
    {
        Assert.ThrowsExactly<WrongUnitException>(() =>
        {
            var mass = Mass.FromGram(150);
            var volume = Volume.FromLiter(3);

            Energy energy = mass / volume;
            Assert.AreEqual(energy, energy);
        });
    }

    [TestMethod]
    public void WrongBaseUnitsEqualOperator()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length == mass);
    }

    [TestMethod]
    public void WrongBaseUnitsNotEqualOperator()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length != mass);
    }

    [TestMethod]
    public void WrongBaseUnitsGreaterOperator()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length > mass);
    }
    [TestMethod]
    public void WrongBaseUnitGreaterOrEqualOperator()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length >= mass);
    }
    [TestMethod]
    public void WrongBaseUnitSmallerOperator()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length < mass);
    }
    [TestMethod]
    public void WrongBaseUnitSmallerOrEqualOperator()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length <= mass);
    }

    [TestMethod]
    public void WrongUnitToCompare()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);

        Assert.ThrowsExactly<WrongUnitException>(() => _ = length.CompareTo(mass));
    }
    [TestMethod]
    public void WrongUnitEquals()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);

        Assert.ThrowsExactly<WrongUnitException>(() => _ = length.Equals(mass));
    }

    [TestMethod]
    public void WrongUnitToCompare02()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        object test = mass;
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length.CompareTo(test));
    }

    [TestMethod]
    public void WrongUnknownUnitEquals01()
    {
        UnknownUnit speed = Length.FromCentimeter(7)/Duration.FromMinute(32);
        UnknownUnit density = Mass.FromCentigram(15)/Volume.FromCubicFoot(7);

        Assert.ThrowsExactly<WrongUnitException>(() => _ = speed.Equals(density));
    }
    [TestMethod]
    public void WrongUnknownUnitToCompare01()
    {
        var list1 = new List<UnknownUnit>
        {
            Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(2),
            Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(1),
            Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(3),
            Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(5),
            Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(4)

        };
        UnknownUnit density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);

        var test = (object)list1.First();

        Assert.ThrowsExactly<WrongUnitException>(() => _ = density.CompareTo(test));
    }
    [TestMethod]
    public void WrongUnknownUnitToCompare02()
    {
        UnknownUnit speed = Length.FromCentimeter(7) / Duration.FromMinute(32);
        UnknownUnit density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);

        Assert.ThrowsExactly<WrongUnitException>(() => _ = speed.CompareTo(density));
    }
    [TestMethod]
    public void WrongUnknownUnitToEquals02()
    {
        UnknownUnit speed = Length.FromCentimeter(7) / Duration.FromMinute(32);
        UnknownUnit density = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);
        object test = density;
        Assert.ThrowsExactly<WrongUnitException>(() => _ = speed.Equals(test));
    }

    [TestMethod]
    public void CheckWrongUnit01()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);

        //length.UnitCheck(mass);
        Assert.ThrowsExactly<WrongUnitException>(() => GuardAgainst.DifferentUnits(length, mass));
    }

    [TestMethod]
    public void CheckWrongUnit02()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);

        Assert.ThrowsExactly<WrongUnitException>(() => GuardAgainst.DifferentUnits(length, mass));
    }
    [TestMethod]
    public void CheckWrongUnit03()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);

        Assert.ThrowsExactly<WrongUnitException>(() => GuardAgainst.DifferentUnits(length, mass));
    }

    [TestMethod]
    public void WrongUnitsToAdd()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length + mass);
    }
    [TestMethod]
    public void WrongUnitsToSubtract01()
    {
        var length = Length.FromCentimeter(3);
        var mass = Mass.FromKilogram(3);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = length - mass);
    }

    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void WrongUnitsToSubtract02()
    //{
    //    var length = Length.FromCentimeter(3);
    //    var mass = Mass.FromKilogram(3);

    //    UnitSystem.Subtract(length.Unit, mass.Unit);
    //}

    [TestMethod]
    public void WrongUnitCast01()
    {
        Assert.ThrowsExactly<WrongUnitException>(() =>
        {
            var A4 = new Length(10, LengthUnit.Kilometer);
            var A5 = new Duration(1, DurationUnit.Minute);
            var A6 = new Duration(1, DurationUnit.Hour);
            _ = A4 / (A5 * A6);
            UnknownUnit res = A4 * (A5 * A6);
            _ = (double)res;
        });
    }
    [TestMethod]
    public void WrongUnitCast02()
    {
        Assert.ThrowsExactly<WrongUnitException>(() =>
        {
            var A4 = new Length(10, LengthUnit.Kilometer);
            var A5 = new Duration(1, DurationUnit.Minute);
            var A6 = new Duration(1, DurationUnit.Hour);
            _ = A4 / (A5 * A6);
            UnknownUnit res = A4 * (A5 * A6);
            _ = (decimal)res;
        });
    }

    [TestMethod]
    public void WrongUnitAddUits01()
    {
        Assert.ThrowsExactly<WrongUnitException>(() =>
        {
            var A1 = new Duration(1, DurationUnit.Minute);
            var A2 = new Length(1, LengthUnit.Chain);
            _ = A1 + A2;
        });
    }
    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void WrongUnitAddUits02()
    //{

    //    var A1 = new Duration(1, DurationUnit.Minute);
    //    var A2 = new Length(1, LengthUnit.Chain);

    //    UnitSystem Result = UnitSystem.Add(A1.Unit, A2.Unit);

    //}

    //[TestMethod]
    //[ExpectedException(typeof(InvalidOperationException))]
    //public void WrongListToCompare()
    //{
    //    var list1 = new List<UnknownUnit>
    //    {

    //    };
    //    UnknownUnit Min = UnitMath.Min(list1);
    //    UnknownUnit Average = UnitMath.Average(list1);
    //    UnknownUnit Sum = UnitMath.Sum(list1);
    //    UnknownUnit Max = UnitMath.Max(list1);

    //}
    [TestMethod]
    public void EnergyCantBePower()
    {
        Assert.ThrowsExactly<WrongUnitException>(() =>
        {
            var mass = Mass.FromCentigram(1);
            var length = Length.FromMeter(5);
            var duration = Duration.FromHour(5);

            Power local = mass * length.Pow(2) / duration.Pow(2);
            Assert.AreEqual(local, local);
        });
    }

    [TestMethod]
    public void ToUnitWithWrongUnit()
    {
        var mass = Mass.FromCentigram(1);
        Assert.ThrowsExactly<WrongUnitException>(() => _ = mass.ToUnit(MassFlowUnit.KilogramPerSecond));
    }

    //[TestMethod]
    //[ExpectedException(typeof(ArgumentException))]
    //public void GetUnitByWrongString()
    //{
    //    LengthUnit unitasstring = Enumeration.GetUnitByString<LengthUnit>("Kilobeter");

    //}

    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void SpeedShouldBeZero()
    //{
    //    Speed speed = 5;
    //}

    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void DurationShouldBeZero()
    //{
    //    Duration duration = 5;
    //}
    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void LengthShouldBeZero()
    //{
    //    Length length = 5;
    //}
    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void AmountShouldBeZero()
    //{
    //    AmountOfSubstance amount = 3;
    //}
    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void LuminousIntensityShouldBeZero()
    //{
    //    LuminousIntensity luminousIntensity = 3;
    //}

    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void AccelerationShouldBeZero()
    //{
    //    Acceleration a = 5;
    //}
    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void AngleShouldBeZero()
    //{

    //    EngineeringUnits.Angle angle = 5;
    //}

    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void MassShouldBeZero()
    //{

    //    Mass mass = 5;
    //}
    //[TestMethod]
    //[ExpectedException(typeof(WrongUnitException))]
    //public void VolumeShouldBeZero()
    //{

    //    Volume volume = 5;
    //}

}

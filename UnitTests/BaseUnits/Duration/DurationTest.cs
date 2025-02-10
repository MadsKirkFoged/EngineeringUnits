using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BaseUnits;

[TestClass]
public class DurationTest
{
    [TestMethod]
    public void DurationConverts()
    {
        Duration L1 = new(3600, DurationUnit.Second);

        Assert.AreEqual(3600, (double)L1.As(DurationUnit.Second), 0000000000.1);
        Assert.AreEqual(0.041666666666666664d, (double)L1.As(DurationUnit.Day), 0000000000.1);
        Assert.AreEqual(1d, (double)L1.As(DurationUnit.Hour), 0000000000.1);
        Assert.AreEqual(3599999999999.9995d, (double)L1.As(DurationUnit.Nanosecond), 0000000000.1);
    }

    [TestMethod]
    public void DurationConverts2()
    {
        Duration L1 = new(1, DurationUnit.Hour);

        Assert.AreEqual(3600, (double)L1.As(DurationUnit.Second), 0000000000.1);
        Assert.AreEqual(0.041666666666666664d, (double)L1.As(DurationUnit.Day), 0000000000.1);
        Assert.AreEqual(1d, (double)L1.As(DurationUnit.Hour), 0000000000.1);
        Assert.AreEqual(3599999999999.9995d, (double)L1.As(DurationUnit.Nanosecond), 0000000000.1);
    }

    [TestMethod]
    public void DurationConverts3()
    {
        var d1 = Duration.From(3600, DurationUnit.Second);
        Assert.AreEqual(1, d1.Hour);

        var d2 = Duration.From(1, DurationUnit.Hour);
        Assert.AreEqual(d1, d2);
    }
    [TestMethod]
    public void DurationConverts4()
    {
        double? value = null;
        var d = Duration.From(value, DurationUnit.Second);
        Assert.IsNull(d);

    }

    [TestMethod]
    public void FromDuration()
    {
        double? value = 100;
        var d = Duration.From(value, DurationUnit.Minute);
        var d2 = Duration.From(value, null);
        Assert.IsNotNull(d);
        Assert.IsNull(d2);

    }

    [TestMethod]
    public void FromElectricCurrent01()
    {
        double? value = null;
        var e = ElectricCurrent.From(value, null);
        Assert.IsNull(e);

    }

    [TestMethod]
    public void FromElectricCurrent02()
    {
        var e1 = ElectricCurrent.From(100, ElectricCurrentUnit.Milliampere);
        Assert.AreEqual(0.1, e1.Ampere);

        var e2 = ElectricCurrent.From(0.1, ElectricCurrentUnit.Ampere);
        Assert.AreEqual(e1, e2);
    }
    [TestMethod]
    public void FromElectricCurrent03()
    {
        double? value = 100;
        var e = ElectricCurrent.From(value, ElectricCurrentUnit.Milliampere);
        var e2 = Length.From(value, null);
        Assert.IsNotNull(e);
        Assert.IsNull(e2);

    }

    [TestMethod]
    public void ElectricCurrentCanBeZero()
    {
        ElectricCurrent el = ElectricCurrent.Zero;
        Assert.AreEqual(ElectricCurrent.Zero, el);
    }
}

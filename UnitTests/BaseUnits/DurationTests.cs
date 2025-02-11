using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace UnitTests.BaseUnits;

[TestClass]
public class DurationTests
{

    [TestMethod]
    public void Compare()
    {

        UnitsNet.Duration A1 = new(6544444.743, UnitsNet.Units.DurationUnit.Minute);
        EngineeringUnits.Duration A2 = new(6544444.743, DurationUnit.Minute);

        var jsonString = JsonConvert.SerializeObject(A2);
        EngineeringUnits.Duration? JSON = JsonConvert.DeserializeObject<EngineeringUnits.Duration>(jsonString);

        Assert.IsNotNull(JSON);
        Assert.AreEqual(0, JSON.As(DurationUnit.Day) - A1.As(UnitsNet.Units.DurationUnit.Day), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Hour) - A1.As(UnitsNet.Units.DurationUnit.Hour), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Microsecond) - A1.As(UnitsNet.Units.DurationUnit.Microsecond), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Millisecond) - A1.As(UnitsNet.Units.DurationUnit.Millisecond), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Minute) - A1.As(UnitsNet.Units.DurationUnit.Minute), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Nanosecond) - A1.As(UnitsNet.Units.DurationUnit.Nanosecond), 65);
        Assert.AreEqual(0, JSON.As(DurationUnit.Second) - A1.As(UnitsNet.Units.DurationUnit.Second), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Week) - A1.As(UnitsNet.Units.DurationUnit.Week), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Month30) - A1.As(UnitsNet.Units.DurationUnit.Month30), 0);
        Assert.AreEqual(0, JSON.As(DurationUnit.Year365) - A1.As(UnitsNet.Units.DurationUnit.Year365), 0);

        Assert.AreEqual(0, UnitsNet.Duration.FromDays(435).Days - EngineeringUnits.Duration.FromDay(435).Day, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromHours(435).Hours - EngineeringUnits.Duration.FromHour(435).Hour, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromMicroseconds(435).Microseconds - EngineeringUnits.Duration.FromMicrosecond(435).Microsecond, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromMilliseconds(435).Milliseconds - EngineeringUnits.Duration.FromMillisecond(435).Millisecond, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromMinutes(435).Minutes - EngineeringUnits.Duration.FromMinute(435).Minute, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromMonths30(435).Months30 - EngineeringUnits.Duration.FromMonth30(435).Month30, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromNanoseconds(435).Nanoseconds - EngineeringUnits.Duration.FromNanosecond(435).Nanosecond, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromSeconds(435).Seconds - EngineeringUnits.Duration.FromSecond(435).Second, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromWeeks(435).Weeks - EngineeringUnits.Duration.FromWeek(435).Week, 0);
        Assert.AreEqual(0, UnitsNet.Duration.FromYears365(435).Years365 - EngineeringUnits.Duration.FromYear365(435).Year365, 0);

        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Day),
                                                A1.As(UnitsNet.Units.DurationUnit.Day)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Hour),
                                                A1.As(UnitsNet.Units.DurationUnit.Hour)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Microsecond),
                                                A1.As(UnitsNet.Units.DurationUnit.Microsecond)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Millisecond),
                                                A1.As(UnitsNet.Units.DurationUnit.Millisecond)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Minute),
                                                A1.As(UnitsNet.Units.DurationUnit.Minute)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Month30),
                                                A1.As(UnitsNet.Units.DurationUnit.Month30)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Nanosecond),
                                                A1.As(UnitsNet.Units.DurationUnit.Nanosecond)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Second),
                                                A1.As(UnitsNet.Units.DurationUnit.Second)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Week),
                                                A1.As(UnitsNet.Units.DurationUnit.Week)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Year365),
                                                A1.As(UnitsNet.Units.DurationUnit.Year365)), 1E-10);

        //Assert.AreEqual(JSON.ToUnit(DurationUnit.Day).DisplaySymbol(),
        //                A1.ToUnit(UnitsNet.Units.DurationUnit.Day).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Hour).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Hour).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Microsecond).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Microsecond).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Millisecond).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Millisecond).ToString("a"));
        //Assert.AreEqual(JSON.ToUnit(DurationUnit.Minute).DisplaySymbol(),
        //                A1.ToUnit(UnitsNet.Units.DurationUnit.Minute).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Month30).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Month30).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Nanosecond).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Nanosecond).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Second).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Second).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Week).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Week).ToString("a"));
        Assert.AreEqual(JSON.ToUnit(DurationUnit.Year365).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.DurationUnit.Year365).ToString("a"));

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Duration(65.743, UnitsNet.Units.DurationUnit.Hour);
        var A2 = new EngineeringUnits.Duration(65.743, DurationUnit.Hour);

        var WorkingCompares = 0;

        foreach (DurationUnit EU in UnitTypebase.ListOf<DurationUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.DurationUnit> UNList = UnitsNet.Duration.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.DurationUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.DurationUnit.Nanosecond)
                    Error = 0.03125;

                //Debug.Print($"");
                //Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                //Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                //Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                //Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol()
                                .Replace("min", "m")
                                .Replace("day", "d")
                                ,

                                A1.ToUnit(UN).ToString("a")

                            );
                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(10, WorkingCompares);
    }

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

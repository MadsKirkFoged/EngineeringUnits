using EngineeringUnits.Fast;
using EngineeringUnits.Units.Fast;
using Newtonsoft.Json;
using EU = global::EngineeringUnits;
using EUUnits = global::EngineeringUnits.Units;

namespace UnitTests.Fast;

/// <summary>
/// The members that make "using EngineeringUnits;" -> "using EngineeringUnits.Fast;" work for existing code.
/// Where it makes sense the answer is compared with EngineeringUnits itself: same name AND same behaviour.
/// </summary>
[TestClass]
public class UsingSwapCompatibilityTests
{
    // ---------- Nullable quantities: "Temperature?" has the members, like the class in EngineeringUnits ----------

    [TestMethod]
    public void NullableQuantity_HasTheMembers()
    {
        Temperature? t = Temperature.FromDegreeCelsius(25);

        Assert.AreEqual(298.15, t.Kelvin, 1e-12);
        Assert.AreEqual(298.15, t.SI, 1e-12);
        Assert.AreEqual(77, t.As(TemperatureUnit.DegreeFahrenheit), 1e-9);
        Assert.AreEqual("25 °C", t.ToString(TemperatureUnit.DegreeCelsius));
        Assert.AreEqual(298.15, t.Abs()!.Value.Kelvin, 1e-12);
        Assert.IsFalse(t.IsZero());
        Assert.IsTrue(t.IsNotZero());
        Assert.IsTrue(t.IsAboveZero());
    }

    [TestMethod]
    public void NullableQuantity_ReadingNullThrows_HelpersPassNullThrough()
    {
        Pressure? p = null;

        // EngineeringUnits throws NullReferenceException here; Fast throws InvalidOperationException - both fail loudly
        Assert.ThrowsExactly<InvalidOperationException>(() => _ = p.Bar);
        Assert.ThrowsExactly<InvalidOperationException>(() => _ = p.SI);

        Assert.IsNull(p.Abs());
        Assert.IsFalse(p.IsZero());
        Assert.IsFalse(p.IsNotZero());
        Assert.IsTrue(p.HasNoValue());
        Assert.AreEqual(Pressure.Zero, p.IfNullSetToZero());
        Assert.AreEqual("", p.ToString(PressureUnit.Bar));
    }

    [TestMethod]
    public void NullableQuantity_NullStaysNull()
    {
        bool known = false;
        Power? p = known ? Power.FromWatt(1) : null;
        Assert.IsNull(p);                                     // not a throwing conversion - see the analyzer test NullIsNotAQuantity

        MassFlow? total = MassFlow.FromKilogramPerSecond(2) + (MassFlow?)null;
        Assert.IsNull(total);
    }

    [TestMethod]
    public void NullableMath_LikeSharpFluids()
    {
        MassFlow? a = MassFlow.FromKilogramPerSecond(1), b = MassFlow.FromKilogramPerSecond(3);
        MassFlow? total = a + b;

        Assert.IsTrue(total.IsNotZero());
        Ratio share = (Ratio)(a / total)!.Value;              // UnknownUnit? -> Ratio: needs the value, like any Nullable
        Ratio rest = 1 - share;                                // number - ratio, like EngineeringUnits
        Assert.AreEqual(0.25, share.DecimalFraction, 1e-15);
        Assert.AreEqual(0.75, rest.DecimalFraction, 1e-15);
    }

    // ---------- Helpers: same results as EngineeringUnits ----------

    [TestMethod]
    public void ZeroChecks_MatchOriginal()
    {
        foreach (var v in new[] { -2.5, 0, 3 })
        {
            var fast = Power.FromWatt(v);
            EU.Power full = EU.Power.FromWatt(v);
            Assert.AreEqual(EU.BaseUnitExtensions.IsZero(full), fast.IsZero(), $"IsZero({v})");
            Assert.AreEqual(EU.BaseUnitExtensions.IsNotZero(full), fast.IsNotZero(), $"IsNotZero({v})");
            Assert.AreEqual(EU.BaseUnitExtensions.IsAboveZero(full), fast.IsAboveZero(), $"IsAboveZero({v})");
            Assert.AreEqual(EU.BaseUnitExtensions.IsBelowZero(full), fast.IsBelowZero(), $"IsBelowZero({v})");
            Assert.AreEqual(EU.BaseUnitExtensions.HasValue(full), fast.HasValue(), $"HasValue({v})");
        }

        Assert.IsFalse(Power.NaN.HasValue());
        Assert.IsTrue(Power.PositiveInfinity.HasNoValue());
    }

    [TestMethod]
    public void LimitsAndClamp_MatchOriginal()
    {
        double[] values = [-10, 0, 3, 7, 50];
        foreach (var v in values)
        foreach (var lo in values)
        foreach (var hi in values)
        {
            var expectedClamp = Si(EU.BaseUnitExtensions.Clamp(EU.Length.FromMeter(v), EU.Length.FromMeter(lo), EU.Length.FromMeter(hi)));
            Assert.AreEqual(expectedClamp, Length.FromMeter(v).Clamp(Length.FromMeter(lo), Length.FromMeter(hi)).SI, $"Clamp({v}, {lo}, {hi})");
        }

        foreach (var v in values)
        foreach (var limit in values)
        {
            Assert.AreEqual(Si(EU.BaseUnitExtensions.LowerLimitAt(EU.Length.FromMeter(v), EU.Length.FromMeter(limit))), Length.FromMeter(v).LowerLimitAt(Length.FromMeter(limit)).SI);
            Assert.AreEqual(Si(EU.BaseUnitExtensions.UpperLimitAt(EU.Length.FromMeter(v), EU.Length.FromMeter(limit))), Length.FromMeter(v).UpperLimitAt(Length.FromMeter(limit)).SI);
        }

        // Null limits are no limits, like EngineeringUnits
        Assert.AreEqual(5, Length.FromMeter(5).Clamp(null, null).Meter);
        Assert.AreEqual(3, Length.FromMeter(5).Clamp(null, Length.FromMeter(3)).Meter);
        Assert.AreEqual(8, Length.FromMeter(5).Clamp(Length.FromMeter(8), null).Meter);
        Assert.AreEqual(3, Si(EU.BaseUnitExtensions.Clamp(EU.Length.FromMeter(5), null, EU.Length.FromMeter(3))));
    }

    [TestMethod]
    public void RoundTo_MatchOriginal()
    {
        foreach (var v in new[] { -7.4, -2.5, 0, 1.2, 2.5, 3.5, 12.49, 12.5 })
        {
            var step = 0.5;
            var full = EU.Length.FromMeter(v);
            var fast = Length.FromMeter(v);
            Assert.AreEqual(Si(EU.BaseUnitExtensions.RoundTo(full, EU.Length.FromMeter(step))), fast.RoundTo(Length.FromMeter(step)).SI, 1e-12, $"RoundTo({v})");
            Assert.AreEqual(Si(EU.BaseUnitExtensions.CeilingTo(full, EU.Length.FromMeter(step))), fast.CeilingTo(Length.FromMeter(step)).SI, 1e-12, $"CeilingTo({v})");
            Assert.AreEqual(Si(EU.BaseUnitExtensions.FloorTo(full, EU.Length.FromMeter(step))), fast.FloorTo(Length.FromMeter(step)).SI, 1e-12, $"FloorTo({v})");
        }
    }

    [TestMethod]
    public void RoundToNearestSize_MatchOriginal()
    {
        double[] sizes = [15, 20, 25, 32, 40, 50, 65, 80];   // pipe sizes in mm
        var fastSizes = sizes.Select(Length.FromMillimeter).ToList();
        var fullSizes = sizes.Select(s => (EU.BaseUnit?)EU.Length.FromMillimeter(s)).ToList();

        foreach (var v in new[] { 5.0, 15, 17, 22.5, 33, 80, 120 })
        {
            var fast = Length.FromMillimeter(v);
            var full = EU.Length.FromMillimeter(v);
            Assert.AreEqual(Si(EU.BaseUnitExtensions.RoundUpToNearest(fullSizes, full)), fastSizes.RoundUpToNearest(fast).SI, 1e-15, $"up {v}");
            Assert.AreEqual(Si(EU.BaseUnitExtensions.RoundDownToNearest(fullSizes, full)), fastSizes.RoundDownToNearest(fast).SI, 1e-15, $"down {v}");
            Assert.AreEqual(Si(EU.BaseUnitExtensions.RoundToNearest(fullSizes!, full)), fastSizes.RoundToNearest(fast).SI, 1e-15, $"nearest {v}");
        }
    }

    // pressureClasses.Select(x => x.MaxPressure).RoundUpToNearest(designPressure) with Pressure? everywhere
    [TestMethod]
    public void RoundToNearestSize_Nullable_SameNullRulesAsOriginal()
    {
        List<Pressure?> classes = [Pressure.FromBar(16), Pressure.FromBar(25), Pressure.FromBar(40)];
        Pressure? design = Pressure.FromBar(20);
        Pressure? none = null;

        Assert.AreEqual(25, classes.RoundUpToNearest(design)!.Value.Bar, 1e-12);
        Assert.AreEqual(16, classes.RoundDownToNearest(design)!.Value.Bar, 1e-12);
        Assert.AreEqual(16, classes.RoundToNearest(design)!.Value.Bar, 1e-12);
        Assert.AreEqual(40, classes.RoundUpToNearest(Pressure.FromBar(99))!.Value.Bar, 1e-12);

        // non-nullable list, nullable value
        Assert.AreEqual(25, classes.Select(c => c!.Value).RoundUpToNearest(design)!.Value.Bar, 1e-12);

        // null value, empty list or a null in the list -> null (EngineeringUnits does the same)
        Assert.IsNull(classes.RoundUpToNearest(none));
        Assert.IsNull(new List<Pressure?>().RoundUpToNearest(design));
        Assert.IsNull(new List<Pressure?> { Pressure.FromBar(16), null }.RoundDownToNearest(design));

        var full = new List<EU.BaseUnit?> { EU.Pressure.FromBar(16), null };
        Assert.IsNull(EU.BaseUnitExtensions.RoundDownToNearest(full, EU.Pressure.FromBar(20)));
        Assert.IsNull(EU.BaseUnitExtensions.RoundUpToNearest(new List<EU.BaseUnit?>(), EU.Pressure.FromBar(20)));
    }

    [TestMethod]
    public void ToStringWithCulture_And_ConvertToSI_LikeOriginal()
    {
        var culture = System.Globalization.CultureInfo.InvariantCulture;
        Temperature? t = Temperature.FromDegreeCelsius(25);
        Temperature? none = null;

        Assert.AreEqual(Temperature.FromDegreeCelsius(25).ToString(), Temperature.FromDegreeCelsius(25).ToString(culture));
        // (EngineeringUnits prints "25 °C" - the unit it was made in. Fast stores SI, so it prints "298.2 K")
        Assert.AreEqual(EU.Temperature.FromDegreeCelsius(25).ToUnit(EUUnits.TemperatureUnit.Kelvin).ToString(culture), t.ToString(culture));
        Assert.AreEqual("", none.ToString(culture));
        Assert.AreEqual(t.Value.ToString("S4"), t.ToString("S4"));

        UnknownUnit? heat = MassFlow.FromKilogramPerSecond(2) * SpecificEnergy.FromJoulePerKilogram(1000);
        Assert.AreEqual(heat.Value.ToString(null, culture), heat.ToString(culture));
        Assert.AreEqual(heat.Value.ToString("V4", null), heat.Value.ToString("V4"));

        // Values are always stored in SI, so ConvertToSI() hands back the same value
        var density = Density.FromPoundPerCubicFoot(50);
        Assert.AreEqual(density, density.ConvertToSI());
        Assert.AreEqual(Si(EU.BaseUnitExtensions.ConvertToSI(EU.Density.FromPoundPerCubicFoot(50))), density.ConvertToSI().SI, 1e-12);
        Density? nullDensity = null;
        Assert.IsNull(nullDensity.ConvertToSI());
    }

    // ---------- The hand-written extras of EngineeringUnits (PipeSizeExtended, Duration.extra, Amount.extra, RatioExtra) ----------

    [TestMethod]
    public void PipeSize_DNValveAndDiameters_MatchOriginal()
    {
        foreach (var dn in new[] { 15, 25, 50, 100, 150, 300 })
        {
            var fast = PipeSize.FromDN(dn);
            var full = EU.PipeSize.FromDN(dn);
            Assert.AreEqual(full.DNValve, fast.DNValve);
            Assert.AreEqual(full.GetOutsideDiameter!.As(EUUnits.LengthUnit.Meter), fast.GetOutsideDiameter!.Value.Meter, 1e-12, $"OD DN{dn}");

            full.PipeSchedule = EU.PipeScheduleEnum.SCH_40;
            Assert.AreEqual(full.GetWallThickness()!.As(EUUnits.LengthUnit.Meter), fast.GetWallThickness(PipeScheduleEnum.SCH_40)!.Value.Meter, 1e-12, $"wall DN{dn}");
            Assert.AreEqual(full.GetInsideDiameter!.As(EUUnits.LengthUnit.Meter), fast.GetInsideDiameter(PipeScheduleEnum.SCH_40)!.Value.Meter, 1e-12, $"ID DN{dn}");
        }

        PipeSize? maybe = PipeSize.FromDN(80);
        Assert.AreEqual(80, maybe.DNValve);
        // Not a DN size: both throw
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => PipeSize.FromDN(7).GetOutsideDiameter);
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => EU.PipeSize.FromDN(7).GetOutsideDiameter);
    }

    [TestMethod]
    public void Duration_TimeSpanAndDateTime_LikeOriginal()
    {
        var d = Duration.FromMinute(90);
        var start = new DateTime(2026, 1, 1, 12, 0, 0);

        Assert.AreEqual(TimeSpan.FromMinutes(90), d.ToTimeSpan());
        Assert.AreEqual(TimeSpan.FromMinutes(90), (TimeSpan)d);
        Assert.AreEqual(5400, ((Duration)TimeSpan.FromMinutes(90)).Second);
        Assert.AreEqual(start.AddMinutes(90), start + d);
        Assert.AreEqual(start.AddMinutes(-90), start - d);
        Assert.IsTrue(d > TimeSpan.FromHours(1) && d < TimeSpan.FromHours(2) && TimeSpan.FromHours(1) <= d);
        Assert.AreEqual(EU.Duration.FromMinute(90).ToTimeSpan(), d.ToTimeSpan());
    }

    [TestMethod]
    public void AmountOfSubstance_AndRatioCasts_LikeOriginal()
    {
        var n = AmountOfSubstance.FromMass(Mass.FromGram(18.015), MolarMass.FromGramPerMole(18.015));
        Assert.AreEqual(1, n.Mole, 1e-12);
        Assert.AreEqual((double)EU.AmountOfSubstance.FromMole(2).NumberOfParticles(), AmountOfSubstance.FromMole(2).NumberOfParticles(), 1e9);
        Assert.IsNull(AmountOfSubstance.FromMass(null, MolarMass.FromGramPerMole(18)));

        Assert.AreEqual(0.25, ((Ratio)0.25).SI);
        Assert.AreEqual(0.25, (double)Ratio.FromPercent(25), 1e-15);
        Assert.AreEqual((double)(EU.Ratio)0.25, (double)(Ratio)0.25);
    }

    [TestMethod]
    public void NullableUnknownUnit_Helpers_NullInNullOut()
    {
        UnknownUnit? heat = MassFlow.FromKilogramPerSecond(-2) * SpecificEnergy.FromJoulePerKilogram(1000);
        UnknownUnit? none = null;

        Assert.AreEqual(2000, heat.Abs()!.Value.SI);
        Assert.AreEqual(-1000, heat.Clamp(Power.FromWatt(-1000), Power.FromWatt(1000))!.Value.SI);
        Assert.AreEqual(-500, heat.LowerLimitAt(Power.FromWatt(-500))!.Value.SI);
        Assert.AreEqual(-2000, heat.UpperLimitAt(Power.FromWatt(-500))!.Value.SI);
        Assert.IsTrue(heat.IsBelowZero() && heat.IsNotZero() && !heat.HasNoValue());
        Assert.IsNull(none.Abs());
        Assert.IsNull(none.Sqrt());
        Assert.IsTrue(none.HasNoValue() && !none.IsZero());
        Assert.AreEqual(Power.FromWatt(5).SI, Power.FromWatt(5).ToUnknownUnit().SI);
    }

    [TestMethod]
    public void AliasConversions_ImplicitWhereOriginalIsImplicit()
    {
        SpecificEnergy e = SpecificEnergy.FromJoulePerKilogram(1000);
        Enthalpy h = e;
        SpecificEnergy? back = (Enthalpy?)h;
        SpecificHeatCapacity cp = SpecificEntropy.FromJoulePerKilogramKelvin(4180);
        Dimensionless d = Ratio.FromPercent(50);

        Assert.AreEqual(1000, h.SI);
        Assert.AreEqual(1000, back!.Value.SI);
        Assert.AreEqual(4180, cp.SI);
        Assert.AreEqual(0.5, d.SI, 1e-15);
    }

    [TestMethod]
    public void TupleHelpers_MatchOriginal()
    {
        Length a = Length.FromMeter(5), b = Length.FromMeter(15), c = Length.FromMeter(7);
        EU.Length fa = EU.Length.FromMeter(5), fb = EU.Length.FromMeter(15), fc = EU.Length.FromMeter(7);

        Assert.AreEqual(Si(EU.UnitMath.Min((fa, fb, fc))), (a, b, c).Min().SI);
        Assert.AreEqual(Si(EU.UnitMath.Max((fa, fb, fc))), (a, b, c).Max().SI);
        Assert.AreEqual(Si(EU.UnitMath.Sum((fa, fb, fc))), (a, b, c).Sum().SI);
        Assert.AreEqual(Si(EU.UnitMath.Average((fa, fb, fc))), (a, b, c).Average().SI, 1e-12);
        Assert.AreEqual(Si(EU.UnitMath.Mean((fa, fb, fc))), (a, b, c).Mean().SI);
        Assert.AreEqual(Si(EU.UnitMath.Mean((fa, fb))), (a, b).Mean().SI);
        Assert.AreEqual(10, (a, b).Average().Meter);
    }

    [TestMethod]
    public void LinearInterpolation_MatchesOriginal()
    {
        var y = UnitMath.LinearInterpolation(Temperature.FromDegreeCelsius(15), Temperature.FromDegreeCelsius(10), Temperature.FromDegreeCelsius(20),
                                             Density.FromKilogramPerCubicMeter(999.7), Density.FromKilogramPerCubicMeter(998.2));
        var expected = Si(EU.UnitMath.LinearInterpolation(EU.Temperature.FromDegreeCelsius(15), EU.Temperature.FromDegreeCelsius(10), EU.Temperature.FromDegreeCelsius(20),
                                                          EU.Density.FromKilogramPerCubicMeter(999.7), EU.Density.FromKilogramPerCubicMeter(998.2)));

        Density typed = y;                                     // the result is a Density again
        Assert.AreEqual(expected, typed.SI, 1e-9);
        Assert.AreEqual(998.95, typed.KilogramPerCubicMeter, 1e-9);

        // Same x0 and x1: the average, like EngineeringUnits
        Assert.AreEqual(5, UnitMath.LinearInterpolation(Length.FromMeter(1), Length.FromMeter(2), Length.FromMeter(2), Power.FromWatt(4), Power.FromWatt(6)).Watt);

        // Nullable: null in, null out
        Temperature? missing = null;
        Assert.IsNull(UnitMath.LinearInterpolation(missing, (Temperature?)Temperature.Zero, (Temperature?)Temperature.Zero, (Density?)Density.Zero, (Density?)Density.Zero));
    }

    [TestMethod]
    public void AngleMath_MatchesOriginal()
    {
        var fast = Angle.FromDegree(30);
        var full = EU.Angle.FromDegree(30);
        Assert.AreEqual(EU.AngleMath.Sin(full)!.Value, fast.Sin()!.Value, 1e-12);
        Assert.AreEqual(EU.AngleMath.Cos(full)!.Value, fast.Cos()!.Value, 1e-12);
        Assert.AreEqual(EU.AngleMath.Tan(full)!.Value, fast.Tan()!.Value, 1e-12);
        Assert.AreEqual(0.5, fast.Sin()!.Value, 1e-12);
        Assert.IsNull(((Angle?)null).Sin());
    }

    [TestMethod]
    public void CircleArea_MatchesOriginal()
    {
        Assert.AreEqual(Si(EU.Area.FromCircleDiameter(EU.Length.FromMillimeter(100))), Area.FromCircleDiameter(Length.FromMillimeter(100)).SI, 1e-15);
        Assert.AreEqual(Math.PI * 0.05 * 0.05, Length.FromMillimeter(100).FromCircleDiameter().SquareMeter, 1e-15);
    }

    // ---------- ToUnit: for display, like $"...{x.ToUnit(PressureUnit.Bar)}..." in log messages ----------

    [TestMethod]
    public void ToUnit_InInterpolatedStrings_MatchesOriginal()
    {
        var cases = new (IFormattable Fast, object Original)[]
        {
            (Pressure.FromBar(2.5).ToUnit(PressureUnit.Bar), EU.Pressure.FromBar(2.5).ToUnit(EUUnits.PressureUnit.Bar)),
            (Temperature.FromDegreeCelsius(35).ToUnit(TemperatureUnit.DegreeCelsius), EU.Temperature.FromDegreeCelsius(35).ToUnit(EUUnits.TemperatureUnit.DegreeCelsius)),
            (Speed.FromMeterPerSecond(1.25).ToUnit(SpeedUnit.MeterPerSecond), EU.Speed.FromMeterPerSecond(1.25).ToUnit(EUUnits.SpeedUnit.MeterPerSecond)),
            (Mass.FromKilogram(12.3456).ToUnit(MassUnit.Kilogram), EU.Mass.FromKilogram(12.3456).ToUnit(EUUnits.MassUnit.Kilogram)),
            (Volume.FromCubicMeter(0.5).ToUnit(VolumeUnit.Liter), EU.Volume.FromCubicMeter(0.5).ToUnit(EUUnits.VolumeUnit.Liter)),
            (Power.FromWatt(1500).ToUnit(PowerUnit.Kilowatt), EU.Power.FromWatt(1500).ToUnit(EUUnits.PowerUnit.Kilowatt)),
        };

        foreach (var (fast, original) in cases)
        {
            Assert.AreEqual($"{original}", $"{fast}");
            Assert.AreEqual($"{original:S2}", $"{fast:S2}");
            Assert.AreEqual($"{original:V4}", $"{fast:V4}");
        }
    }

    [TestMethod]
    public void ToUnit_ConvertsBack_AndNullPrintsNothing()
    {
        Mass charge = Mass.FromKilogram(3);
        Mass back = charge.ToUnit(MassUnit.Gram);             // "return charge.ToUnit(MassUnit.Kilogram);" keeps compiling
        Assert.AreEqual(charge, back);
        Assert.AreEqual(3000, charge.ToUnit(MassUnit.Gram).ValueInUnit, 1e-12);

        Pressure? missing = null;
        Assert.AreEqual("() bar?", $"({missing.ToUnit(PressureUnit.Bar)}) bar?");   // like EngineeringUnits: null prints as nothing
    }

    [TestMethod]
    public void AsSI_IsTheSIValue()
    {
        Level? tolerance = Level.FromDecibel(3);
        Assert.AreEqual(Power.FromKilowatt(2).SI, Power.FromKilowatt(2).AsSI);
        Assert.AreEqual(tolerance.Value.SI, tolerance.AsSI);   // (double)row.Tolerance.AsSI on a nullable
    }

    [TestMethod]
    public void UnknownUnit_ShownInARuntimeUnit()
    {
        UnknownUnit heat = MassFlow.FromKilogramPerSecond(2) * Enthalpy.FromKilojoulePerKilogram(3);
        UnitTypebase display = PowerUnit.Kilowatt;             // chosen at runtime

#pragma warning disable EUF0007 // the conscious boundary: a stored value meets a runtime unit
        var shown = heat.ToUnit(display);
#pragma warning restore EUF0007

        Assert.AreEqual("6", shown.ToString("V4"));
        Assert.AreEqual("kW", $"{shown:UnitOnly}");
        Assert.AreEqual("6 kW", shown.ToString());
    }

    // ---------- AddUnit: database rows that store a number and its unit name ----------

    [TestMethod]
    public void AddUnit_LikeADatabaseRow()
    {
        double? capacity = 12.5;
        string uom = "Kilowatt";

        Power? entity = capacity.AddUnit<PowerUnit>(uom);           // public Power? CapacityEntity => Capacity.AddUnit<PowerUnit>(Capacity_uom);
        Assert.AreEqual(12500, entity!.Value.Watt, 1e-9);

        Assert.AreEqual(12500, 12.5.AddUnit<PowerUnit>("kilowatt").SI, 1e-9);   // case-insensitive, like EngineeringUnits
        Assert.AreEqual(2000, 2.AddUnit<PowerUnit>("Kilowatt").SI);
        Assert.IsNull(((double?)null).AddUnit<PowerUnit>(uom));
        Assert.IsNull(((int?)null).AddUnit<PowerUnit>(uom));
        Assert.AreEqual(21, ((Temperature)20.AddUnit<TemperatureUnit>("DegreeCelsius")).DegreeCelsius + 1, 1e-12);
    }

    [TestMethod]
    public void AddUnit_UnknownName_ThrowsLikeTheOriginal()
    {
        var e = Assert.ThrowsExactly<ArgumentException>(() => 1.0.AddUnit<PowerUnit>("Kilowat"));
        StringAssert.Contains(e.Message, "Could not find a unit with a name of 'Kilowat'");
        StringAssert.Contains(e.Message, "Kilowatt");
        Assert.ThrowsExactly<ArgumentException>(() => 1.0.AddUnit<PowerUnit>(null!));
    }

    /// <summary>Every unit name of every quantity gives the same SI value as EngineeringUnits' AddUnit.</summary>
    [TestMethod]
    public void AddUnit_EveryUnitName_MatchesOriginal()
    {
        var fastAddUnit = typeof(Extensions).GetMethods().Single(m => m.Name == "AddUnit" && m.GetParameters()[0].ParameterType == typeof(double));
        var fullAddUnit = typeof(global::EngineeringUnits.Extensions).GetMethods().Single(m => m.Name == "AddUnit" && m.GetParameters()[0].ParameterType == typeof(double));
        var errors = new System.Text.StringBuilder();
        var checkedNames = 0;

        foreach (var q in Quantities.All)
        {
            var fastUnitType = q.SIUnit.GetType();
            var fullUnitType = Original.UnitType(q.Name);
            foreach (var u in q.Units)
            {
                var fast = ((UnknownUnit)fastAddUnit.MakeGenericMethod(fastUnitType).Invoke(null, [7.25, u.Name])!).SI;
                var full = (global::EngineeringUnits.BaseUnit)fullAddUnit.MakeGenericMethod(fullUnitType).Invoke(null, [7.25, u.Name])!;
                var expected = OriginalExact.As(full, q.Name, "SI");
                if (!Close.Enough(expected, fast))
                    errors.AppendLine($"{q.Name}: AddUnit(7.25, \"{u.Name}\") original {expected:R}, fast {fast:R}");
                checkedNames++;
            }
        }

        Assert.AreEqual("", errors.ToString());
        Assert.IsTrue(checkedNames > 1300, $"{checkedNames}");
    }

    [TestMethod]
    public void ListOfAndGetUnitByString_MatchOriginal()
    {
        var fast = UnitTypebase.ListOf<PressureUnit>().Select(u => u.Name).ToList();
        var full = global::EngineeringUnits.UnitTypebase.ListOf<EUUnits.PressureUnit>().Select(u => u.QuantityName).ToList();
        CollectionAssert.AreEqual(full, fast);

        Assert.AreSame(PressureUnit.Bar, UnitTypebase.GetUnitByString<PressureUnit>("bar"));
    }

    // ---------- Newtonsoft.Json: no registration, no silent zeros ----------

    public sealed class FluidState
    {
        public Temperature Temperature { get; set; }
        public Pressure? Pressure { get; set; }
        public MassFlow? MassFlow { get; set; }
        public List<Length> Pipes { get; set; } = [];
    }

    [TestMethod]
    public void Newtonsoft_RoundTrip()
    {
        var state = new FluidState
        {
            Temperature = Temperature.FromDegreeCelsius(25),
            Pressure = Pressure.FromBar(2),
            MassFlow = null,
            Pipes = [Length.FromMillimeter(50), Length.FromMillimeter(80)],
        };

        var json = JsonConvert.SerializeObject(state);
        Assert.AreEqual("""{"Temperature":"298.15 K","Pressure":"200000 Pa","MassFlow":null,"Pipes":["0.05 m","0.08 m"]}""", json);

        var back = JsonConvert.DeserializeObject<FluidState>(json)!;
        Assert.AreEqual(25, back.Temperature.DegreeCelsius, 1e-12);
        Assert.AreEqual(2, back.Pressure!.Value.Bar, 1e-15);
        Assert.IsNull(back.MassFlow);
        Assert.AreEqual(80, back.Pipes[1].Millimeter, 1e-12);
    }

    [TestMethod]
    public void Newtonsoft_BadData_FailsLoudly()
    {
        // Another quantity's unit: not silently zero, an exception
        Assert.ThrowsExactly<JsonSerializationException>(() => JsonConvert.DeserializeObject<FluidState>("""{"Temperature":"2 m"}"""));
        // A bare number is SI, like System.Text.Json
        Assert.AreEqual(300, JsonConvert.DeserializeObject<FluidState>("""{"Temperature":"300"}""")!.Temperature.Kelvin);
    }

    [TestMethod]
    public void Newtonsoft_NaNAndInfinityRoundTrip()
    {
        var back = JsonConvert.DeserializeObject<FluidState>(JsonConvert.SerializeObject(new FluidState { Temperature = Temperature.NaN }))!;
        Assert.IsTrue(back.Temperature.IsNaN());
    }

    private static double Si(EU.BaseUnit? value) => value is null ? double.NaN : EU.BaseUnitExtensions.GetValueAs(value, EU.UnitSystemExtensions.GetSIUnitsystem(value.Unit)).ToDouble();
}

using BenchmarkDotNet.Attributes;
using EngineeringUnits;
using EngineeringUnits.Units;

namespace Benchmark;

// The SI calculation ((m1 * (h2 - h1)) + P2) / P3 on doubles, compared to plain decimal and double, and each operation on its own
[ShortRunJob]
[MemoryDiagnoser]
public class Breakdown
{
    private static readonly Enthalpy h1 = Enthalpy.FromJoulePerKilogram(856.75245687853);
    private static readonly Enthalpy h2 = Enthalpy.FromJoulePerKilogram(1456.546239456);
    private static readonly MassFlow m1 = MassFlow.FromKilogramPerSecond(7.4526425854623);
    private static readonly Power P2 = Power.FromWatt(1567.1567896541);
    private static readonly Power P3 = Power.FromWatt(1000.3487624531);

    private static readonly UnknownUnit dh = h2 - h1;
    private static readonly UnknownUnit mdh = m1 * dh;
    private static readonly UnknownUnit sum = mdh + P2;

    private static readonly double h1d = 856.75245687853d, h2d = 1456.546239456d, m1d = 7.4526425854623d, P2d = 1567.1567896541d, P3d = 1000.3487624531d;
    private static readonly decimal h1m = 856.75245687853m, h2m = 1456.546239456m, m1m = 7.4526425854623m, P2m = 1567.1567896541m, P3m = 1000.3487624531m;

    [Benchmark(Baseline = true)] public UnknownUnit CalcUnits() => ((m1 * (h2 - h1)) + P2) / P3;
    [Benchmark] public decimal CalcDecimal() => ((m1m * (h2m - h1m)) + P2m) / P3m;
    [Benchmark] public double CalcDouble() => ((m1d * (h2d - h1d)) + P2d) / P3d;

    [Benchmark] public UnknownUnit OpSub() => h2 - h1;
    [Benchmark] public UnknownUnit OpMul() => m1 * dh;
    [Benchmark] public UnknownUnit OpAdd() => mdh + P2;
    [Benchmark] public UnknownUnit OpDiv() => sum / P3;
}

// The same SI calculation for decimal-created units, plus non-SI conversions for both kinds
[ShortRunJob]
[MemoryDiagnoser]
public class Precision
{
    private static readonly Enthalpy h1 = new Enthalpy(856.75245687853m, EnthalpyUnit.JoulePerKilogram);
    private static readonly Enthalpy h2 = new Enthalpy(1456.546239456m, EnthalpyUnit.JoulePerKilogram);
    private static readonly MassFlow m1 = new MassFlow(7.4526425854623m, MassFlowUnit.KilogramPerSecond);
    private static readonly Power P2 = new Power(1567.1567896541m, PowerUnit.Watt);
    private static readonly Power P3 = new Power(1000.3487624531m, PowerUnit.Watt);

    private static readonly Length ftD = Length.FromFoot(12.345), mD = Length.FromMeter(3.21);
    private static readonly Length ftM = new Length(12.345m, LengthUnit.Foot), mM = new Length(3.21m, LengthUnit.Meter);
    private static readonly Temperature cD = Temperature.FromDegreeCelsius(21.5);
    private static readonly Temperature cM = new Temperature(21.5m, TemperatureUnit.DegreeCelsius);

    [Benchmark] public UnknownUnit CalcUnitsDecimal() => ((m1 * (h2 - h1)) + P2) / P3;

    [Benchmark] public double FootAsMeter_Double() => ftD.As(LengthUnit.Meter);
    [Benchmark] public double FootAsMeter_Decimal() => ftM.As(LengthUnit.Meter);
    [Benchmark] public UnknownUnit FootPlusMeter_Double() => ftD + mD;
    [Benchmark] public UnknownUnit FootPlusMeter_Decimal() => ftM + mM;
    [Benchmark] public double RoundTrip_Double() => ftD.ToUnit(LengthUnit.Meter).As(LengthUnit.Foot);
    [Benchmark] public double RoundTrip_Decimal() => ftM.ToUnit(LengthUnit.Meter).As(LengthUnit.Foot);
    [Benchmark] public double CelsiusAsKelvin_Double() => cD.As(TemperatureUnit.Kelvin);
    [Benchmark] public double CelsiusAsKelvin_Decimal() => cM.As(TemperatureUnit.Kelvin);
}

// Mixed-unit math on doubles - goes through the exact path
[ShortRunJob]
[MemoryDiagnoser]
public class Mixed
{
    private static readonly Length inch = new(3.87, LengthUnit.Inch), meter = new(2.78, LengthUnit.Meter);
    private static readonly Length inch2 = new(1.5, LengthUnit.Inch);
    private static readonly Length km = Length.FromKilometer(1);
    private static readonly Duration hour = Duration.FromHour(2);
    private static readonly UnknownUnit mixedResult = meter - inch;

    [Benchmark] public UnknownUnit MeterMinusInch_Double() => meter - inch;
    [Benchmark] public UnknownUnit InchPlusInch_Double() => inch + inch2;
    [Benchmark] public UnknownUnit InchDivMeter_Double() => inch / meter;
    [Benchmark] public UnknownUnit KmPerHour_Double() => km / hour;
    [Benchmark] public double MeterMinusInch_AsCm() => (meter - inch).As(LengthUnit.Centimeter);
    [Benchmark] public UnknownUnit MixedResultTimesSI() => mixedResult * meter;
}

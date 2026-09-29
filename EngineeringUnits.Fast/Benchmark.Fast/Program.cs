using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using EngineeringUnits.Fast;
using EngineeringUnits.Units.Fast;
using EU = global::EngineeringUnits;
using EUUnits = global::EngineeringUnits.Units;

BenchmarkSwitcher.FromAssembly(typeof(Formula).Assembly).Run(args);

/// <summary>((m1 * (h2 - h1)) + P2) / P3 - the same formula as Benchmark/UnitBenchmarks.cs in EngineeringUnits.</summary>
[MemoryDiagnoser, ShortRunJob]
public class Formula
{
    private double h1d = 856.75245687853, h2d = 1456.546239456, m1d = 7.4526425854623, p2d = 1567.1567896541, p3d = 1000.3487624531;

    private Enthalpy h1f = Enthalpy.FromJoulePerKilogram(856.75245687853), h2f = Enthalpy.FromJoulePerKilogram(1456.546239456);
    private MassFlow m1f = MassFlow.FromKilogramPerSecond(7.4526425854623);
    private Power p2f = Power.FromWatt(1567.1567896541), p3f = Power.FromWatt(1000.3487624531);

    private EU.Enthalpy h1e = EU.Enthalpy.FromJoulePerKilogram(856.75245687853), h2e = EU.Enthalpy.FromJoulePerKilogram(1456.546239456);
    private EU.MassFlow m1e = EU.MassFlow.FromKilogramPerSecond(7.4526425854623);
    private EU.Power p2e = EU.Power.FromWatt(1567.1567896541), p3e = EU.Power.FromWatt(1000.3487624531);

    [Benchmark(Baseline = true)] public double Double() => ((m1d * (h2d - h1d)) + p2d) / p3d;
    [Benchmark] public double Fast() => (double)(((m1f * (h2f - h1f)) + p2f) / p3f);
    [Benchmark] public EU.UnknownUnit EngineeringUnits() => ((m1e * (h2e - h1e)) + p2e) / p3e;
}

/// <summary>Q = m * cp * (T2 - T1) summed over 10 000 elements: a typical inner loop.</summary>
[DisassemblyDiagnoser(maxDepth: 2)]
[MemoryDiagnoser, ShortRunJob]
public class HeatLoop
{
    private const int N = 10_000;
    private readonly double[] md = new double[N], cpd = new double[N], t1d = new double[N], t2d = new double[N];
    private readonly MassFlow[] mf = new MassFlow[N];
    private readonly SpecificEntropy[] cpf = new SpecificEntropy[N];
    private readonly Temperature[] t1f = new Temperature[N], t2f = new Temperature[N];
    private readonly EU.MassFlow[] me = new EU.MassFlow[N];
    private readonly EU.SpecificEntropy[] cpe = new EU.SpecificEntropy[N];
    private readonly EU.Temperature[] t1e = new EU.Temperature[N], t2e = new EU.Temperature[N];

    public HeatLoop()
    {
        var r = new Random(1);
        for (int i = 0; i < N; i++)
        {
            md[i] = r.NextDouble(); cpd[i] = 4180 + r.NextDouble(); t1d[i] = 280 + r.NextDouble(); t2d[i] = 300 + r.NextDouble();
            mf[i] = MassFlow.FromKilogramPerSecond(md[i]); cpf[i] = SpecificEntropy.FromJoulePerKilogramKelvin(cpd[i]);
            t1f[i] = Temperature.FromKelvin(t1d[i]); t2f[i] = Temperature.FromKelvin(t2d[i]);
            me[i] = EU.MassFlow.FromKilogramPerSecond(md[i]); cpe[i] = EU.SpecificEntropy.FromJoulePerKilogramKelvin(cpd[i]);
            t1e[i] = EU.Temperature.FromKelvin(t1d[i]); t2e[i] = EU.Temperature.FromKelvin(t2d[i]);
        }
    }

    [Benchmark(Baseline = true)]
    public double Double()
    {
        double sum = 0;
        for (int i = 0; i < N; i++) sum += md[i] * cpd[i] * (t2d[i] - t1d[i]);
        return sum;
    }

    [Benchmark]
    public double Fast()
    {
        Power sum = Power.Zero;
        for (int i = 0; i < N; i++) sum += mf[i] * cpf[i] * (t2f[i] - t1f[i]);
        return sum.Watt;
    }

    [Benchmark]
    public double EngineeringUnits()
    {
        EU.Power sum = EU.Power.Zero;
        for (int i = 0; i < N; i++) sum = sum + (me[i] * cpe[i] * (t2e[i] - t1e[i]));
        return sum.As(EUUnits.PowerUnit.Watt);
    }
}

/// <summary>Non-SI input and output: the conversion cost.</summary>
[MemoryDiagnoser, ShortRunJob]
public class Conversions
{
    private double feet = 12.345, celsius = 21.5;

    [Benchmark(Baseline = true)] public double Double() => (feet * 0.3048) / 0.0254;
    [Benchmark] public double Fast_FootToInch() => Length.FromFoot(feet).Inch;
    [Benchmark] public double Fast_ViaUnitObjects() => Length.From(feet, LengthUnit.Foot).As(LengthUnit.Inch);
    [Benchmark] public double Fast_CelsiusToFahrenheit() => Temperature.FromDegreeCelsius(celsius).DegreeFahrenheit;
    [Benchmark] public double EngineeringUnits_FootToInch() => EU.Length.FromFoot(feet).As(EUUnits.LengthUnit.Inch);
    [Benchmark] public double EngineeringUnits_CelsiusToFahrenheit() => EU.Temperature.FromDegreeCelsius(celsius).As(EUUnits.TemperatureUnit.DegreeFahrenheit);
}

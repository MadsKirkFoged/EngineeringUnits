using BenchmarkDotNet.Attributes;
using EngineeringUnits;

namespace Benchmark;

[InProcess()]
[MemoryDiagnoser]
public class Benchy
{
    private static readonly decimal h1m = 856.75245687853m;
    private static readonly decimal h2m = 1456.546239456m;
    private static readonly decimal m1m = 7.4526425854623m;
    private static readonly decimal P2m = 1567.1567896541m;
    private static readonly decimal P3m = 1000.3487624531m;
    private static readonly double h1d = 856.75245687853d;
    private static readonly double h2d = 1456.546239456d;
    private static readonly double m1d = 7.4526425854623d;
    private static readonly double P2d = 1567.1567896541d;
    private static readonly double P3d = 1000.3487624531d;
    private static readonly Enthalpy h1 = Enthalpy.FromJoulePerKilogram(856.75245687853);
    private static readonly Enthalpy h2 = Enthalpy.FromJoulePerKilogram(1456.546239456);
    private static readonly MassFlow m1 = MassFlow.FromKilogramPerSecond(7.4526425854623);
    private static readonly Power P2 = Power.FromWatt(1567.1567896541);
    private static readonly Power P3 = Power.FromWatt(1000.3487624531);


    private static readonly int Compare1 = 650846249;
    private static readonly int? Compare2 = 650846249;
    private static readonly bool Compare3 = true;


    [Benchmark]
    public static double serial()
    { 
    
        var test1 = Math.Exp(5.345d);

        var test2 = Math.Exp(0.346534d);

        var test3 = Math.Log(0.346534d);

        var test4 = Math.Pow(0.346534, 2);

        var test5 = test1 + test2 + test3 * test4;

        return test5;

    }

    [Benchmark]
    public static async Task<double> SerialAsync()
    {
        var test1Task = Task.Run(() => Math.Exp(5.345d));
        var test2Task = Task.Run(() => Math.Exp(0.346534d));
        var test3Task = Task.Run(() => Math.Log(0.346534d));
        var test4Task = Task.Run(() => Math.Pow(0.346534, 2));

        await Task.WhenAll(test1Task, test2Task, test3Task, test4Task);

        var test5 = test1Task.Result + test2Task.Result + test3Task.Result * test4Task.Result;

        return test5;
    }

    //[Benchmark]
    //public static double Exp3() => Math.Exp(5.345d);

    //[Benchmark]
    //public static double Exp4() => Math.Exp(0.345d);

    //[Benchmark]
    //public static double Exp5() => Math.Exp(0.003d);

    //[Benchmark]
    //public static double Pow1() => Math.Pow(5.345d,2);

    //[Benchmark]
    //public static double Pow2() => 5.345d * 5.345d;

    //[Benchmark]
    //public static double Pow2() => Math.Pow(0.345d,2);

    //[Benchmark]
    //public static double Pow3() => Math.Pow(0.003d,1.4352);


    //[Benchmark]
    //public static float PowF3() => MathF.Pow(5.345f, 2);

    //[Benchmark]
    //public static float PowF4() => MathF.Pow(0.345f, 2);

    //[Benchmark]
    //public static float PowF5() => MathF.Pow(0.003f, 1.4352f);




    //| Method             | Mean        | Error     | StdDev    | Gen0   | Allocated |
    //|------------------- |------------:|----------:|----------:|-------:|----------:|
    //| CalculationUnits   | 214.6921 ns | 1.3726 ns | 1.2839 ns | 0.0443 |     192 B |
    //| CalculationDecimal |  88.9409 ns | 0.3370 ns | 0.3152 ns |      - |         - |
    //| CalculationDouble  |   0.4440 ns | 0.0119 ns | 0.0112 ns |      - |         - |

    //[Benchmark]
    //public static UnknownUnit CalculationUnits() => ((m1 * (h2 - h1)) + P2) / P3;

    //[Benchmark]
    //public static decimal CalculationDecimal() => ((m1m * (h2m - h1m)) + P2m) / P3m;

    //[Benchmark]
    //public static double CalculationDouble() => ((m1d * (h2d - h1d)) + P2d) / P3d;


    //[Benchmark]
    //public static int CompareInts1()
    //{
    //    if (Compare1 == 0)
    //    {
    //        return 0;
    //    }

    //    return Compare1;


    //}

    //[Benchmark]
    //public static int CompareInts2()
    //{
    //    if (Compare1 is 0)
    //    {
    //        return 0;
    //    }

    //    return Compare1;


    //}





    //[Benchmark]
    //public static UnknownUnit AddUnits() =>  (h2 + h1);

    //[Benchmark]
    //public static UnknownUnit SubUnits() => (h2 - h1);

    //[Benchmark]
    //public static UnknownUnit MultiplyUnits() => (h2 * h1);


    //[Benchmark]
    //public static UnknownUnit DivideUnits() => (h2 / h1);


    //Create a static Power 
    //static readonly Power Power1 = new(1, PowerUnit.Watt);

    //static readonly UnitSystem unit = Power1;

    //[Benchmark]
    //public static bool IsSIUnit()
    //{
    //    return unit.IsSIUnit();
    //}

    //[Benchmark]
    //public static Fraction GetSumConstant()
    //{
    //    return unit.SumConstant();
    //}

    ////Create a static RawUnit
    //static readonly RawUnit RawUnit1 = new()
    //{
    //    Symbol = "m",
    //    A = new(1),
    //    UnitType = BaseunitType.length,
    //    B = 0,
    //    Count = 1,
    //};

    //[Benchmark]
    //public static int HashCode()
    //{
    //    return RawUnit1.GetHashCode();
    //}

    //static readonly MassFlow MassFlowPositiveSI1 = MassFlow.FromKilogramPerSecond(2);
    //static readonly MassFlow MassFlowPositiveSI2 = MassFlow.FromKilogramPerSecond(2);

    //static readonly MassFlow MassFlowPositiveNon1 = MassFlow.FromDecagramPerDay(2);
    //static readonly MassFlow MassFlowPositiveNon2 = MassFlow.FromDecagramPerDay(2);

    //static readonly MassFlow MassFlowNegativeSI = MassFlow.FromKilogramPerSecond(-2);
    //static readonly MassFlow MassFlowNegativeNon = MassFlow.FromDecagramPerDay(-2);

    //static readonly UnknownUnit UnknownMassFlowPositiveSI = MassFlow.FromKilogramPerSecond(2).ToUnknownUnit();
    //static readonly UnknownUnit UnknownMassFlowNegativeSI = MassFlow.FromKilogramPerSecond(-2).ToUnknownUnit();
    //static readonly UnknownUnit UnknownMassFlowPositiveNon = MassFlow.FromDecagramPerDay(2).ToUnknownUnit();

    //static readonly MassFlow? MassFlowNull = null;
    //static readonly UnknownUnit? UnknownMassMassFlowNull = null;

    //[Benchmark]
    //public static bool IsZeroNull1()
    //{
    //    return UnknownMassMassFlowNull.IsZero();
    //}

    //[Benchmark]
    //public static bool IsZeroNull2()
    //{
    //    return MassFlowNull.IsZero();
    //}

    //[Benchmark]
    //public static bool IsZeroSI()
    //{
    //    return MassFlowPositiveSI2.IsZero();
    //}

    //[Benchmark]
    //public static bool IsZeroNonSI()
    //{
    //    return MassFlowPositiveNon1.IsZero();
    //}

    //[Benchmark]
    //public static bool IsZeroUnknownSI()
    //{
    //    return UnknownMassFlowPositiveSI.IsZero();
    //}

    //[Benchmark]
    //public static bool IsZeroUnknownNon()
    //{
    //    return UnknownMassFlowPositiveNon.IsZero();
    //}

    //[Benchmark]
    //public static bool IsNotZeroSI()
    //{
    //    return MassFlowPositiveSI2.IsZero();
    //}

    //[Benchmark]
    //public static bool IsNotZeroNonSI()
    //{
    //    return MassFlowPositiveNon1.IsZero();
    //}

    //[Benchmark]
    //public static bool IsAboveZeroSI()
    //{
    //    return MassFlowPositiveSI2.IsAboveZero();
    //}

    //[Benchmark]
    //public static bool IsAboveZeroUnknownSI()
    //{
    //    return UnknownMassFlowPositiveSI.IsAboveZero();
    //}

    //[Benchmark]
    //public static bool IsAboveZeroUnknownNon()
    //{
    //    return UnknownMassFlowPositiveNon.IsAboveZero();
    //}

    //[Benchmark]
    //public static bool IsAboveZeroNon()
    //{
    //    return MassFlowPositiveNon1.IsAboveZero();
    //}

    //[Benchmark]
    //public static bool IsBelowZeroSI()
    //{
    //    return MassFlowPositiveSI2.IsBelowZero();
    //}

    //[Benchmark]
    //public static bool IsBelowZeroNon()
    //{
    //    return MassFlowPositiveNon1.IsBelowZero();
    //}

    //[Benchmark]
    //public static MassFlow AbsNonSIPosetive()
    //{
    //    return MassFlowPositiveNon1.Abs();
    //}

    //[Benchmark]
    //public static MassFlow AbsSIPosetive()
    //{
    //    return MassFlowPositiveSI1.Abs();
    //}

    //[Benchmark]
    //public static MassFlow AbsNonSINegative()
    //{
    //    return MassFlowNegativeNon.Abs();
    //}

    //[Benchmark]
    //public static MassFlow AbsSINegative()
    //{
    //    return MassFlowNegativeSI.Abs();
    //}

    //[Benchmark]
    //public static MassFlow DoNothing()
    //{
    //    return MassFlowPositiveSI1;
    //}

    //[Benchmark]
    //public static UnknownUnit Convert()
    //{
    //    return MassFlowPositiveSI1.ToUnknownUnit();
    //}

    //[Benchmark]
    //public static UnknownUnit AbsUnknown()
    //{
    //    return UnknownMassFlowPositiveSI.Abs();
    //}

    //[Benchmark]
    //public static UnknownUnit AbsUnknownNegative()
    //{
    //    return UnknownMassFlowNegativeSI.Abs();
    //}

    //[Benchmark]
    //public static bool CompareNonSI()
    //{
    //    return MassFlowPositiveNon1==MassFlowPositiveNon2;
    //}

    //[Benchmark]
    //public static bool CompareSI()
    //{
    //    return MassFlowPositiveSI1==MassFlowPositiveSI2;
    //}

    //[Benchmark]
    //public static BaseUnit BaseUnit_new()
    //{
    //    return new BaseUnit();
    //}

    //[Benchmark]
    //public static UnknownUnit UnknownUnit_new()
    //{
    //    return new UnknownUnit();
    //}

    //[Benchmark]
    //public static int GetInt()
    //{
    //    var i = 10;

    //    return i;
    //}

    //[Benchmark]
    //public static double Getdouble()
    //{
    //    var i = 10d;

    //    return i;
    //}

    //[Benchmark]
    //public static decimal Getdecimal()
    //{
    //    var i = 10m;

    //    return i;
    //}

    ////| GetLengthUnit | 4.388 ns | 0.0540 ns | 0.0479 ns |         - |

    //[Benchmark]
    //public static LengthUnit GetLengthUnit()
    //{
    //    return LengthUnit.SI;
    //}

    ////| CreateLengthUnit | 753.462 ns | 14.6394 ns | 17.4272 ns | 0.2203 |     952 B |

    //[Benchmark]
    //public static LengthUnit CreateLengthUnit()
    //{
    //    return new LengthUnit(PreFix.SI);
    //}

    //2024-01-08
    //Length_new   | 10.47 ns | 0.274 ns | 0.573 ns | 0.0167 |      72 B |

    //[Benchmark]
    //public static Length Length_new()
    //{
    //    return new Length(10, LengthUnit.Inch);
    //}

    ////2024-01-08
    ////Length_new   | 10.47 ns | 0.274 ns | 0.573 ns | 0.0167 |      72 B |

    //[Benchmark]
    //public static Length LengthSI_new()
    //{
    //    return new Length(10, LengthUnit.SI);
    //}

    //readonly Length _L1 = Length.FromSI(1);
    //readonly Length _L2 = Length.FromSI(2);

    //[Benchmark]
    //public Length LengthPlusLengthSI()
    //{
    //    return _L1+_L2;
    //}

    //readonly Length _L3 = Length.FromFoot(1);
    //readonly Length _L4 = Length.FromChain(2);

    //[Benchmark]
    //public Length LengthPlusLength()
    //{
    //    return _L3+_L4;
    //}

    //[Benchmark]
    //public Length LengthMinusLength()
    //{
    //    return _L1-_L2;
    //}

    //[Benchmark]
    //public Ratio LengthDividedByLength()
    //{
    //    return _L1/_L2;
    //}

    //[Benchmark]
    //public Ratio LengthDividedByLengthRatio()
    //{
    //    return _L1/_L2;
    //}

    //[Benchmark]
    //public UnknownUnit LengthDividedByLengthUnknownUnit()
    //{
    //    return _L1/_L2;
    //}

    //[Benchmark]
    //public Area LengthTimesLength()
    //{
    //    return _L1*_L2;
    //}

    //[Benchmark]
    //public static Power Power_new()
    //{
    //    return new Power(10, PowerUnit.BritishThermalUnitPerHour);
    //}

    //[Benchmark]
    //public static Power PowerSI_new()
    //{
    //    return new Power(10, PowerUnit.SI);
    //}

    //readonly Temperature _T1 = Temperature.FromSI(1);
    //readonly Temperature _T2 = Temperature.FromSI(2);

    //[Benchmark]
    //public static Temperature Temperature_FromSI()
    //{
    //    return Temperature.FromSI(293.15);
    //}

    //[Benchmark]
    //public double Temperature_SI()
    //{
    //    return _T1.SI;
    //}

    //[Benchmark]
    //public UnknownUnit Temperature_Plus_Temperature()
    //{
    //    return _T1 + _T2;
    //}

    //readonly Power P1 = Power.FromKilowatt(10);
    //readonly Length L1 = Length.FromChain(2);
    //readonly Temperature T1 = Temperature.FromDegreesCelsius(4);

    //| CalculationIntoThermalConductivity   | 190.5 ns | 2.97 ns | 2.78 ns | 0.0501 |     216 B |

    //[Benchmark]
    //public ThermalConductivity CalculationIntoThermalConductivity()
    //{
    //    return P1 / (L1 * T1);
    //}

    //static readonly Power P2 = Power.FromSI(10);
    //static readonly Length L2 = Length.FromSI(2);
    //static readonly Temperature T2 = Temperature.FromSI(4);

    //static readonly decimal P2de = 15786.786764564564m;
    //static readonly decimal L2de = 4564.864545634653456m;
    //static readonly decimal T2de = 3456.532345334545m;

    //static readonly double P2do = 15786.786764564564d;
    //static readonly double L2do = 4564.864545634653456d;
    //static readonly double T2do = 3456.532345334545d;

    ////| CalculationIntoThermalConductivitySI | 157.4 ns | 3.08 ns | 2.88 ns | 0.0501 |     216 B |
    ////| CalculationIntoThermalConductivitySI | 133.0 ns | 2.65 ns | 2.60 ns | 0.0405 |     176 B |
    //[Benchmark]
    //public ThermalConductivity CalculationIntoThermalConductivitySI()
    //{
    //    return P2 / (L2 * T2);
    //}

    //[Benchmark]
    //public decimal CalculationIntoThermalConductivitySI2()
    //{
    //    return P2de / (L2de * T2de);
    //}

    //[Benchmark]
    //public double CalculationIntoThermalConductivitySI3()
    //{
    //    return P2do / (L2do * T2do);
    //}

    //| Method | Mean     | Error    | StdDev   | Gen0   | Allocated |
    //|------- |---------:|---------:|---------:|-------:|----------:|
    //| Values | 12.17 ns | 0.213 ns | 0.199 ns |      - |         - |
    //| units  | 28.31 ns | 0.311 ns | 0.276 ns |      - |         - |
    //| total  | 53.14 ns | 1.069 ns | 0.893 ns | 0.0167 |      72 B |

    //| Method | Mean     | Error    | StdDev   | Gen0   | Allocated |
    //|------- |---------:|---------:|---------:|-------:|----------:|
    //| Values | 12.40 ns | 0.279 ns | 0.332 ns |      - |         - |
    //| units  | 19.17 ns | 0.362 ns | 0.339 ns |      - |         - |
    //| JustCreation | 13.48 ns | 0.336 ns | 0.561 ns | 0.0167 |      72 B |
    //| total  | 45.54 ns | 0.925 ns | 0.820 ns | 0.0167 |      72 B |

    //static readonly Power Left = Power.FromSI(10);
    //static readonly Length Right = Length.FromSI(2);

    //[Benchmark]
    //public decimal Values()
    //{
    //    return Left.NEWValue / Right.NEWValue;
    //}

    //[Benchmark]
    //public UnitSystem units()
    //{
    //    return Left.Unit / Right.Unit;
    //}

    //[Benchmark]
    //public int units2()
    //{
    //    return (Left.GetHashCode() * 512265997) ^ Right.GetHashCode();
    //}

    //[Benchmark]
    //public UnknownUnit JustCreation()
    //{
    //    return new UnknownUnit(Left.NEWValue.Value, Left.Unit);
    //}

    //[Benchmark]
    //public UnknownUnit JustCreation1()
    //{
    //    return new UnknownUnit() {NEWValue = Left.NEWValue };
    //}

    //[Benchmark]
    //public UnknownUnit JustCreation2()
    //{
    //    return new UnknownUnit() { NEWValue = Left.NEWValue.Value };
    //}

    //[Benchmark]
    //public UnknownUnit JustCreation3()
    //{
    //    return new UnknownUnit() { Unit = Left.Unit };
    //}

    //[Benchmark]
    //public UnknownUnit JustCreation4()
    //{
    //    return new UnknownUnit() {};
    //}

    //[Benchmark]
    //public UnknownUnit total()
    //{
    //    return Left / Right;
    //}

}

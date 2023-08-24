using BenchmarkDotNet.Attributes;
using EngineeringUnits;
using EngineeringUnits.Units;


namespace Benchmark
{
    [InProcess()]
    [MemoryDiagnoser]
    public class Benchy
    {



        static readonly MassFlow MassFlowPositiveSI1 = MassFlow.FromKilogramPerSecond(2);
        static readonly MassFlow MassFlowPositiveSI2 = MassFlow.FromKilogramPerSecond(2);

        static readonly MassFlow MassFlowPositiveNon1 = MassFlow.FromDecagramPerDay(2);
        static readonly MassFlow MassFlowPositiveNon2 = MassFlow.FromDecagramPerDay(2);

        static readonly MassFlow MassFlowNegativeSI = MassFlow.FromKilogramPerSecond(-2);
        static readonly MassFlow MassFlowNegativeNon = MassFlow.FromDecagramPerDay(-2);

        static readonly UnknownUnit UnknownMassFlowPositiveSI = MassFlow.FromKilogramPerSecond(2);
        static readonly UnknownUnit UnknownMassFlowNegativeSI = MassFlow.FromKilogramPerSecond(-2);
        static readonly UnknownUnit UnknownMassFlowPositiveNon = MassFlow.FromDecagramPerDay(2);

        static readonly MassFlow MassFlowNull = null;
        static readonly UnknownUnit UnknownMassMassFlowNull = null;

        //[Benchmark]
        //public bool IsZeroNull1()
        //{
        //    return UnknownMassMassFlowNull.IsZero();
        //}

        //[Benchmark]
        //public bool IsZeroNull2()
        //{
        //    return MassFlowNull.IsZero();
        //}

        //[Benchmark]
        //public bool IsZeroSI()
        //{
        //    return MassFlowPositiveSI2.IsZero();
        //}

        //[Benchmark]
        //public bool IsZeroNonSI()
        //{
        //    return MassFlowPositiveNon1.IsZero();
        //}

        //[Benchmark]
        //public bool IsZeroUnknownSI()
        //{
        //    return UnknownMassFlowPositiveSI.IsZero();
        //}

        //[Benchmark]
        //public bool IsZeroUnknownNon()
        //{
        //    return UnknownMassFlowPositiveNon.IsZero();
        //}

        //[Benchmark]
        //public bool IsNotZeroSI()
        //{
        //    return MassFlowPositiveSI2.IsZero();
        //}

        //[Benchmark]
        //public bool IsNotZeroNonSI()
        //{
        //    return MassFlowPositiveNon1.IsZero();
        //}

        //[Benchmark]
        //public bool IsAboveZeroSI()
        //{
        //    return MassFlowPositiveSI2.IsAboveZero();
        //}

        //[Benchmark]
        //public bool IsAboveZeroUnknownSI()
        //{
        //    return UnknownMassFlowPositiveSI.IsAboveZero();
        //}


        //[Benchmark]
        //public bool IsAboveZeroUnknownNon()
        //{
        //    return UnknownMassFlowPositiveNon.IsAboveZero();
        //}

        //[Benchmark]
        //public bool IsAboveZeroNon()
        //{
        //    return MassFlowPositiveNon1.IsAboveZero();
        //}

        //[Benchmark]
        //public bool IsBelowZeroSI()
        //{
        //    return MassFlowPositiveSI2.IsBelowZero();
        //}

        //[Benchmark]
        //public bool IsBelowZeroNon()
        //{
        //    return MassFlowPositiveNon1.IsBelowZero();
        //}


        //[Benchmark]
        //public MassFlow AbsNonSIPosetive()
        //{
        //    return MassFlowPositiveNon1.Abs();
        //}

        //[Benchmark]
        //public MassFlow AbsSIPosetive()
        //{
        //    return MassFlowPositiveSI1.Abs();
        //}

        //[Benchmark]
        //public MassFlow AbsNonSINegative()
        //{
        //    return MassFlowNegativeNon.Abs();
        //}

        //[Benchmark]
        //public MassFlow AbsSINegative()
        //{
        //    return MassFlowNegativeSI.Abs();
        //}

        //[Benchmark]
        //public MassFlow DoNothing()
        //{
        //    return MassFlowPositiveSI1;
        //}

        //[Benchmark]
        //public UnknownUnit Convert()
        //{
        //    return MassFlowPositiveSI1;
        //}

        //[Benchmark]
        //public UnknownUnit AbsUnknown()
        //{
        //    return UnknownMassFlowPositiveSI.Abs();
        //}

        //[Benchmark]
        //public UnknownUnit AbsUnknownNegative()
        //{
        //    return UnknownMassFlowNegativeSI.Abs();
        //}


        //[Benchmark]
        //public bool CompareNonSI()
        //{
        //    return MassFlowPositiveNon1==MassFlowPositiveNon2;
        //}

        //[Benchmark]
        //public bool CompareSI()
        //{
        //    return MassFlowPositiveSI1==MassFlowPositiveSI2;
        //}


        //[Benchmark]
        //public BaseUnit BaseUnit_new()
        //{
        //    return new BaseUnit();
        //}

        //[Benchmark]
        //public UnknownUnit UnknownUnit_new()
        //{
        //    return new UnknownUnit();
        //}

        //[Benchmark]
        //public Length Length_new()
        //{
        //    return new Length(10, LengthUnit.Inch);
        //}

        //[Benchmark]
        //public Length LengthSI_new()
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
        //public double LengthDividedByLength()
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
        //public Power Power_new()
        //{
        //    return new Power(10, PowerUnit.BritishThermalUnitPerHour);
        //}

        //[Benchmark]
        //public Power PowerSI_new()
        //{
        //    return new Power(10, PowerUnit.SI);
        //}


        //readonly Temperature _T1 = Temperature.FromSI(1);
        //readonly Temperature _T2 = Temperature.FromSI(2);

        //[Benchmark]
        //public Temperature Temperature_FromSI()
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


        readonly Power P1 = Power.FromKilowatt(10);
        readonly Length L1 = Length.FromChain(2);
        readonly Temperature T1 = Temperature.FromDegreesCelsius(4);


        [Benchmark]
        public ThermalConductivity CalculationIntoThermalConductivity()
        {
            return P1 / (L1 * T1);
        }

        readonly Power P2 = Power.FromSI(10);
        readonly Length L2 = Length.FromSI(2);
        readonly Temperature T2 = Temperature.FromSI(4);


        [Benchmark]
        public ThermalConductivity CalculationIntoThermalConductivitySI()
        {
            return P2 / (L2 * T2);
        }

    }
}

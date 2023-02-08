﻿using BenchmarkDotNet.Attributes;
using EngineeringUnits;
using EngineeringUnits.Units;


namespace Benchmark
{
    [InProcess()]
    [MemoryDiagnoser]
    public class Benchy
    {



        static readonly MassFlow _M1 = MassFlow.FromKilogramPerSecond(2);
        static readonly MassFlow _M2 = MassFlow.FromKilogramPerSecond(2);

        static readonly MassFlow _M3 = MassFlow.FromDecagramPerDay(2);
        static readonly MassFlow _M4 = MassFlow.FromDecagramPerDay(2);

        static readonly MassFlow _M5 = MassFlow.FromKilogramPerSecond(-2);
        static readonly MassFlow _M6 = MassFlow.FromDecagramPerDay(-2);

        static readonly UnknownUnit _M7 = MassFlow.FromKilogramPerSecond(2);
        static readonly UnknownUnit _M8 = MassFlow.FromKilogramPerSecond(-2);


        [Benchmark]
        public MassFlow AbsNonSIPosetive()
        {
            return _M3.Abs();
        }

        [Benchmark]
        public MassFlow AbsSIPosetive()
        {
            return _M1.Abs();
        }

        [Benchmark]
        public MassFlow AbsNonSINegative()
        {
            return _M6.Abs();
        }

        [Benchmark]
        public MassFlow AbsSINegative()
        {
            return _M5.Abs();
        }

        [Benchmark]
        public MassFlow DoNothing()
        {
            return _M1;
        }

        [Benchmark]
        public UnknownUnit Convert()
        {
            return _M1;
        }

        [Benchmark]
        public UnknownUnit AbsUnknown()
        {
            return _M7.Abs();
        }

        [Benchmark]
        public UnknownUnit AbsUnknownNegative()
        {
            return _M8.Abs();
        }


        //[Benchmark]
        //public bool CompareNonSI()
        //{
        //    return _M3==_M4;
        //}

        //[Benchmark]
        //public bool CompareSI()
        //{
        //    return _M1==_M2;
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


        //readonly Power P1 = Power.FromKilowatt(10);
        //readonly Length L1 = Length.FromChain(2);
        //readonly Temperature T1 = Temperature.FromDegreesCelsius(4);


        //[Benchmark]
        //public ThermalConductivity CalculationIntoThermalConductivity()
        //{
        //    return P1 / (L1 * T1);
        //}

        //readonly Power P2 = Power.FromSI(10);
        //readonly Length L2 = Length.FromSI(2);
        //readonly Temperature T2 = Temperature.FromSI(4);


        //[Benchmark]
        //public ThermalConductivity CalculationIntoThermalConductivitySI()
        //{
        //    return P2 / (L2 * T2);
        //}

    }
}

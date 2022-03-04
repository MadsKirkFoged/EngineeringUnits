using BenchmarkDotNet.Attributes;
using EngineeringUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    [InProcess()]
    [MemoryDiagnoser]
    public class Benchy
    {
        [Benchmark]
        public BaseUnit BaseUnit_new()
        {
            return new BaseUnit();
        }

        readonly Temperature _T1 = Temperature.FromSI(1);
        readonly Temperature _T2 = Temperature.FromSI(2);

        [Benchmark]
        public Temperature Temperature_FromSI()
        {
            return Temperature.FromSI(293.15);
        }

        [Benchmark]
        public double Temperature_SI()
        {
            return _T1.SI;
        }

        [Benchmark]
        public UnknownUnit Temperature_Plus_Temperature()
        {
            return _T1 + _T2;
        }
    }
}

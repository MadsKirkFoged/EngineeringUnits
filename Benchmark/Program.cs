using BenchmarkDotNet.Running;
using EngineeringUnits;
using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {


            BenchmarkRunner.Run<Benchy>();


        }
    }
}

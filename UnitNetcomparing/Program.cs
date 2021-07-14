using EngineeringUnits;
using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace UnitNetcomparing
{
    class Program
    {
        static void Main(string[] args)
        {


            UnitsNet.UnitMath.Abs(UnitsNet.MassFlow.FromKilogramsPerSecond(-1));





            Length test = Length.FromMeters(2);


            //Debug.Print($"{test}");
            Debug.Print($"{test.Pow(-2)}");
            Debug.Print($"{test.Pow(-1)}");
            Debug.Print($"{test.Pow(0)}");
            Debug.Print($"{test.Pow(1)}");
            Debug.Print($"{test.Pow(2)}");
            Debug.Print($"{test.Pow(3)}");

            //UnitsNet.UnitMath.Average();
            //UnitsNet.UnitMath.Max
            //UnitsNet.UnitMath.Min
            //UnitsNet.UnitMath.Sum


            //Debug.Print($"'<=' 1 time: {stopwatch2.ElapsedTicks / k} tick/operation");


        }
    }
}

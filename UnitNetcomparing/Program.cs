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

            var list1 = new List<MassFlow>();

            //Average
            //Max
            //Min

            list1.Add(MassFlow.FromKilogramsPerSecond(1));
            list1.Add(MassFlow.FromKilogramsPerSecond(2));
            list1.Add(MassFlow.FromKilogramsPerSecond(3));
            list1.Add(MassFlow.FromKilogramsPerSecond(4));


            MassFlow tester1 = UnitMath.Max(list1);


            MassFlow tester2 = UnitMath.Max(MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(2), MassFlow.FromKilogramsPerSecond(3), MassFlow.FromKilogramsPerSecond(4));



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

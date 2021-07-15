using EngineeringUnits;
using EngineeringUnits.Units;
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

            var list1 = new List<Duration>();

     

            list1.Add(new Duration(1, DurationUnit.SI));
            list1.Add(new Duration(1, DurationUnit.SI));
            list1.Add(new Duration(1, DurationUnit.SI));
            list1.Add(new Duration(1, DurationUnit.SI));


            MassFlow tester1 = UnitMath.Sum(list1);


            MassFlow tester2 = UnitMath.Sum(MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(2), MassFlow.FromKilogramsPerSecond(3), MassFlow.FromKilogramsPerSecond(4));



            Length test = Length.FromMeters(2);


            //Debug.Print($"{test}");
            Debug.Print($"{test.Pow(-2)}");
            Debug.Print($"{test.Pow(-1)}");
            Debug.Print($"{test.Pow(0)}");
            Debug.Print($"{test.Pow(1)}");
            Debug.Print($"{test.Pow(2)}");
            Debug.Print($"{test.Pow(3)}");




            //Debug.Print($"'<=' 1 time: {stopwatch2.ElapsedTicks / k} tick/operation");


        }
    }
}

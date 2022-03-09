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

namespace UnitNetcomparing
{
    class Program
    {
        static void Main(string[] args)
        {

            Area SqrtTest = Area.FromSI(9);

            


            Length L2 = Length.FromSI(2);
            Length L5 = Length.FromFoot(5);


            Area Lmix = L2 * L5;


            Length SqrtTest2 = Lmix.Sqrt();


            var local = Lmix.Unit.ReduceUnits();
            var local2 = Lmix.Unit.ReduceUnitsHard();


            Length L10 = Length.FromSI(10);


            //List<Length> listOfL = new List<Length>();

            //listOfL.Add(L2);
            //listOfL.Add(L5);
            //listOfL.Add(L10);

            //var local = listOfL.RoundDownToNearest(Length.FromSI(1));

            //var test122 = new Density(1, DensityUnit.GramPerCubicCentimeter);


            //Debug.Print(test122.Unit.GetHashCode().ToString());

            Power P2 = Power.FromSI(10);
            //Length L2 = Length.FromSI(2);
            Temperature T2 = Temperature.FromSI(4);

            double ThermalConductivityAsSI = 0;
            double PowerAsSI = P2.SI;
            double LengthAsSI = L2.SI;
            double TemperatureAsSI = T2.SI;

            //Solver or function where calculation speed is critical!
            for (int i = 0; i < 1000000000; i++)
            {
                ThermalConductivityAsSI = PowerAsSI / (LengthAsSI * TemperatureAsSI);
            }

            ThermalConductivity Result = ThermalConductivity.FromSI(ThermalConductivityAsSI);


            //ThermalConductivity test = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                ThermalConductivity TC = P2 / (L2 * T2);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs.ToString());
            Console.ReadLine();

  

        }
    }
}

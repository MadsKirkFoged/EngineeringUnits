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

            var test122 = new Density(1, DensityUnit.GramPerCubicCentimeter);


            Length _L1 = Length.FromSI(1);
            Length _L2 = Length.FromSI(2);

            UnknownUnit Dicided = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                //testunit = ProfileTest.Unit.GetHashCodeForUnitCompare();

                Dicided = _L1*_L2;

            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;











        }
    }
}

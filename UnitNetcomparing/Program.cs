using EngineeringUnits;
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

            var A4 = new Length(1, LengthUnit.Meter);
            var A6 = new Duration(1, DurationUnit.Hour);
            var A5 = new Duration(1, DurationUnit.Second);

            Acceleration Result2 = A4 / (A5 * A6);

            Acceleration Result3 = Acceleration.FromMetersPerSecondSquared( A4.Meters / (A5.Seconds * A6.Seconds));


            //Debug.Print($"Percent: {L2.As(RatioUnit.Percent)}");
            //Debug.Print($"GramPerLiter: {L2.As(DensityUnit.GramPerLiter)}");
            //Debug.Print($"CentigramPerMilliliter: {L2.As(DensityUnit.CentigramPerMilliliter)}");
            //Debug.Print($"GramPerCubicCentimeter: {L2.As(DensityUnit.GramPerCubicCentimeter)}");
            //Debug.Print($"SquareChain: {A1.As(AreaUnit.SquareChain)}");
            //Debug.Print($"SquareMeter: {A1.As(AreaUnit.SquareMeter)}");

            Debug.Print($"SymbolValue: {Result2.ResultWithSymbol()}");
            Debug.Print($"BaseunitValue: {Result2.ResultWithBaseunit()}");

        }
    }
}

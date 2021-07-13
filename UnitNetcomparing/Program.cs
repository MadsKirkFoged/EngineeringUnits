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

            Length L1 = new Length(5, LengthUnit.Meter);
            Length L2 = new Length(2, LengthUnit.Inch);

            Debug.Print($"L1: {L1 * L1}");
            Debug.Print($"L2: {L2 * L2}");

            Debug.Print($"IsTrue?: {L1 * L1 > L2 * L2}");



            //Debug.Print($"Percent: {L2.As(RatioUnit.Percent)}");
            //Debug.Print($"GramPerLiter: {L2.As(DensityUnit.GramPerLiter)}");
            //Debug.Print($"CentigramPerMilliliter: {L2.As(DensityUnit.CentigramPerMilliliter)}");
            //Debug.Print($"GramPerCubicCentimeter: {L2.As(DensityUnit.GramPerCubicCentimeter)}");
            //Debug.Print($"SquareChain: {A1.As(AreaUnit.SquareChain)}");
            //Debug.Print($"SquareMeter: {A1.As(AreaUnit.SquareMeter)}");

            //Debug.Print($"SymbolValue: {Result2.ResultWithSymbol()}");
            //Debug.Print($"BaseunitValue: {Result2.ResultWithBaseunit()}");

        }
    }
}

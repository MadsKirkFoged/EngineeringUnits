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

            //Energy EngineeringUnits1 = new Energy(1, EnergyUnit.BritishThermalUnit);
            //Energy EngineeringUnits2 = new Energy(1055.06, EnergyUnit.Joule);



            //Energy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;

            Mass mass = new Mass(1, MassUnit.Pound);

            SpecificEnergy EngineeringUnits1 = new SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);
            SpecificEnergy EngineeringUnits2 = new SpecificEnergy(2326.000292, SpecificEnergyUnit.JoulePerKilogram);



            SpecificEnergy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;




            //Debug.Print($"Percent: {L2.As(RatioUnit.Percent)}");
            //Debug.Print($"GramPerLiter: {L2.As(DensityUnit.GramPerLiter)}");
            //Debug.Print($"CentigramPerMilliliter: {L2.As(DensityUnit.CentigramPerMilliliter)}");
            //Debug.Print($"GramPerCubicCentimeter: {L2.As(DensityUnit.GramPerCubicCentimeter)}");
            //Debug.Print($"SquareChain: {A1.As(AreaUnit.SquareChain)}");
            //Debug.Print($"SquareMeter: {A1.As(AreaUnit.SquareMeter)}");

            Debug.Print($"SymbolValue: {EngineeringUnits3.ResultWithSymbol()}");
            Debug.Print($"BaseunitValue: {EngineeringUnits3.ResultWithBaseunit()}");

        }
    }
}

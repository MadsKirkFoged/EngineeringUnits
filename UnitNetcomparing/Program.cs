﻿using EngineeringUnits;
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

            IEnumerable<BaseUnit> exporters = typeof(BaseUnit)
            .Assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(BaseUnit)))
            .Select(t => (BaseUnit)Activator.CreateInstance(t));



            foreach (BaseUnit item in exporters)
            {
                //Print name of unit
                Console.WriteLine(item.GetType());
            }










            MassFlow Average2 = UnitMath.Average(
                MassFlow.FromKilogramsPerSecond(1),
                MassFlow.FromKilogramsPerSecond(2),
                MassFlow.FromKilogramsPerSecond(3),
                MassFlow.FromKilogramsPerSecond(4),
                MassFlow.FromKilogramsPerSecond(5),
                MassFlow.FromKilogramsPerSecond(6),
                MassFlow.FromKilogramsPerSecond(7),
    MassFlow.FromKilogramsPerSecond(8),
    MassFlow.FromKilogramsPerSecond(9),
    MassFlow.FromKilogramsPerSecond(10)
    );


            //How much Power (Watt) does it take to heat up the water
            SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
            MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
            MassFlow M2 = new MassFlow(4, MassFlowUnit.KilogramPerSecond);
            Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

            Power Q1 = M1 * P1 * (T2 - T1);

            Debug.Print($"Result without specifying the unit: {Q1}"); //5 W

            Debug.Print($"{M1 * P1 * (T2 - T1)}"); //5 W

            //Shows in baseunit
            Debug.Print($"Shows result as double in BritishThermalUnitPerHour: {Q1.As(PowerUnit.BritishThermalUnitPerHour):g4}");

            Debug.Print($"Converting it into KilocaloriePerHour: {Q1.ToUnit(PowerUnit.KilocaloriePerHour)}");

            //Shows in baseunit
            Debug.Print(Q1.ToString());


            //Calculate Area of a square equal sides of 4.3 Foot
            Length L1 = new Length(4.3, LengthUnit.Foot);

            Area A1 = L1.Pow(2);

            Debug.Print($"Area: {A1}");


            //Precise Convertions
            Length L2 = new Length(1, LengthUnit.Mile);
            UnitsNet.Length U2 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Mile);



            Debug.Print($"EngineeringUnits in Inch: {L2.As(LengthUnit.Inch)}");
            Debug.Print($"UnitsNet in Inch: {U2.As(UnitsNet.Units.LengthUnit.Inch)}");


        }
    }
}

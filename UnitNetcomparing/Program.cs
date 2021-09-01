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



            //How much Power (Watt) does it take to heat up the water
            SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
            MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
            MassFlow M2 = new MassFlow(4, MassFlowUnit.KilogramPerSecond);
            Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);


            var test = M1 / M2;

            double test2 = M1 / M2;


            Power Q1 = M1 * P1 * (T2 - T1);

            //Q1 = Q1.ToUnit(PowerUnit.KilobritishThermalUnitPerHour);

            //Shows in baseunit
            Debug.Print($"{Q1}");

            //Shows in baseunit
            Debug.Print($"Shows result in Watt: {Q1.As(PowerUnit.Watt)}");



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

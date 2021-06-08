using Fractions;
using System;
using System.Diagnostics;

namespace EngineeringUnits
{
    class Program
    {
        static void Main(string[] args)
        {

            //Noget er lidt fjollet her:

            //Fraction c1 = 1 / (Unit.GetActualC());
            //Fraction c2 = 1 / (To.GetActualC());
            ////Fraction c3 = c2 / c1;
            //Fraction c3 = c1 / c2;


            //Vi har allerede taget højde for Unit.GetActualC() i selve værdien, så vi burde ikke skulle gøre det igen, men det for en masse test til at fejle




            SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
            MassFlow M1 = new MassFlow(2.20462, MassFlowUnit.PoundPerSecond);
            Temperature T2 = new Temperature(6, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

            Power L1 = P1 * M1 * (T2 - T1);



            Debug.Print($"{L1.As(PowerUnit.Watt)}");
            Debug.Print($"{L1.As(PowerUnit.BritishThermalUnitPerSecond)}");
            Debug.Print($"{L1.As(PowerUnit.BritishThermalUnitPerHour)}");

            //Length L1 = new Length(3.87, LengthUnit.Inch);
            //Length L2 = new Length(2.78, LengthUnit.Meter);

            //var test = L1 / L2;

            //Debug.Print($"{test}");
            //Debug.Print($"{L1.As(SpecificEnergyUnit.JoulePerKilogram)}");




        }
    }
}

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



            SpecificEnergy EngineeringUnits1 = new SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);
            SpecificEnergy EngineeringUnits2 = new SpecificEnergy(10, SpecificEnergyUnit.JoulePerKilogram);

            Debug.Print($"{EngineeringUnits1.As(SpecificEnergyUnit.BtuPerPound)}");
            Debug.Print($"{EngineeringUnits1.As(SpecificEnergyUnit.JoulePerKilogram)}");

            Debug.Print($"{EngineeringUnits2.As(SpecificEnergyUnit.BtuPerPound)}");
            Debug.Print($"{EngineeringUnits2.As(SpecificEnergyUnit.JoulePerKilogram)}");


            SpecificEnergy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;


            Debug.Print($"{EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound)}");













            //SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
            SpecificEntropy P1 = new SpecificEntropy(0.0002390057361377, SpecificEntropyUnit.BtuPerPoundRankine);
            MassFlow M1 = new MassFlow(2.20462, MassFlowUnit.PoundPerSecond);
            Temperature T2 = new Temperature(6, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

            Power L1 = P1 * M1 * (T2 - T1);

            //Power L1 = new Power(3.4121282201960077, PowerUnit.BritishThermalUnitPerHour);

            Debug.Print($"{L1.As(PowerUnit.Watt)}");
            Debug.Print($"{L1.As(PowerUnit.BritishThermalUnitPerHour)}");
            Debug.Print($"{L1.As(PowerUnit.BritishThermalUnitPerSecond)}");

            //Length L1 = new Length(3.87, LengthUnit.Inch);
            //Length L2 = new Length(2.78, LengthUnit.Meter);

            //var test = L1 / L2;

            //Debug.Print($"{test}");
            //Debug.Print($"{L1.As(SpecificEnergyUnit.JoulePerKilogram)}");




        }
    }
}

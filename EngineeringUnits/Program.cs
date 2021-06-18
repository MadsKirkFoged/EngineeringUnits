using Fractions;
using System;
using System.Diagnostics;

namespace EngineeringUnits
{
    class Program
    {
        static void Main(string[] args)
        {




            Volume test = new Volume(1, VolumeUnit.Centiliter);


            Debug.Print($"{test.As(VolumeUnit.Centiliter)}");






            //SpecificEnergy H2s = new SpecificEnergy(5, SpecificEnergyUnit.JoulePerKilogram);
            SpecificEnergy H2s = new SpecificEnergy(0.00214961, SpecificEnergyUnit.BtuPerPound);
            //SpecificEnergy h1 = new SpecificEnergy(2, SpecificEnergyUnit.JoulePerKilogram);
            SpecificEnergy h1 = new SpecificEnergy(0.000859845, SpecificEnergyUnit.BtuPerPound);
            //MassFlow M1 = new MassFlow(3,MassFlowUnit.KilogramPerSecond);
            MassFlow M1 = new MassFlow(6.61387, MassFlowUnit.PoundPerSecond);

            double EtaIsen = 0.9;



            SpecificEnergy h2 = ((H2s - h1) / EtaIsen) + h1;
            //Debug.Print($"{h2.As(SpecificEnergyUnit.JoulePerKilogram)}");

            Power PowerConsumption = M1 * (h2 - h1);

            Debug.Print($"{PowerConsumption}");
            Debug.Print($"{PowerConsumption.As(PowerUnit.Watt)}");
            Debug.Print($"{PowerConsumption.As(PowerUnit.BritishThermalUnitPerSecond)}");
        }
    }
}

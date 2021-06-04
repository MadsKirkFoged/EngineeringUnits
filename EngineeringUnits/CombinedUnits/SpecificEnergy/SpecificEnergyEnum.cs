using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class SpecificEnergyUnit : Enumeration
    {

        public static SpecificEnergyUnit SI = new SpecificEnergyUnit(EnergyUnit.Joule, MassUnit.SI);
        public static SpecificEnergyUnit JoulePerKilogram = new SpecificEnergyUnit(EnergyUnit.Joule, MassUnit.SI);
        public static SpecificEnergyUnit KilojoulePerKilogram = new SpecificEnergyUnit(EnergyUnit.Kilojoule, MassUnit.SI);
        public static SpecificEnergyUnit BtuPerPound = new SpecificEnergyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound);
        public static SpecificEnergyUnit CaloriePerGram = new SpecificEnergyUnit(EnergyUnit.Calorie, MassUnit.Gram);

        public SpecificEnergyUnit(EnergyUnit energy, MassUnit mass)
        {
            Name = "Energy";

            //  J/kg
            Unit = energy.Unit / mass.Unit;
            Unit.Symbol = $"{energy}/{mass}";

        }

        public static IEnumerable<SpecificEnergyUnit> List()
        {
            return new[] { JoulePerKilogram, KilojoulePerKilogram , BtuPerPound, CaloriePerGram };
        }

        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }

    }



}
﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record MolarEnergyUnit : UnitTypebase
    {

        public static readonly MolarEnergyUnit SI = new(EnergyUnit.SI, AmountOfSubstanceUnit.SI);
        public static readonly MolarEnergyUnit JoulePerMole = new(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit KilojoulePerMole = new(EnergyUnit.Kilojoule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit MegajoulePerMole = new(EnergyUnit.Megajoule, AmountOfSubstanceUnit.Mole);




        public MolarEnergyUnit(EnergyUnit energy, AmountOfSubstanceUnit amountOfSubstance)
        {
            Unit = new UnitSystem(energy / amountOfSubstance, 
                               $"{energy}/{amountOfSubstance}");

        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
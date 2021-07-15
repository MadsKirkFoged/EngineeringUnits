using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MolarEnergyUnit : Enumeration
    {

        public static readonly MolarEnergyUnit SI = new MolarEnergyUnit(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit JoulePerMole = new MolarEnergyUnit(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit KilojoulePerMole = new MolarEnergyUnit(EnergyUnit.Kilojoule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit MegajoulePerMole = new MolarEnergyUnit(EnergyUnit.Megajoule, AmountOfSubstanceUnit.Mole);




        public MolarEnergyUnit(EnergyUnit energy, AmountOfSubstanceUnit amountOfSubstance, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy / amountOfSubstance;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{amountOfSubstance}");
        }

       

    }




}
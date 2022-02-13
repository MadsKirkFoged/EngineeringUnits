using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MolarEnergyUnit : Enumeration
    {

        public static readonly MolarEnergyUnit SI = new(EnergyUnit.SI, AmountOfSubstanceUnit.SI);
        public static readonly MolarEnergyUnit JoulePerMole = new(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit KilojoulePerMole = new(EnergyUnit.Kilojoule, AmountOfSubstanceUnit.Mole);
        public static readonly MolarEnergyUnit MegajoulePerMole = new(EnergyUnit.Megajoule, AmountOfSubstanceUnit.Mole);




        public MolarEnergyUnit(EnergyUnit energy, AmountOfSubstanceUnit amountOfSubstance, string NewSymbol = "Empty")
        {
            Unit = energy / amountOfSubstance;
            SetNewSymbol(NewSymbol, $"{energy}/{amountOfSubstance}");
        }

       

    }




}
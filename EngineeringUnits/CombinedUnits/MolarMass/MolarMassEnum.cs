using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MolarMassUnit : Enumeration
    {

        public static MolarMassUnit SI =                new MolarMassUnit(MassUnit.Kilogram,    AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit KilogramPerMole =   new MolarMassUnit(MassUnit.Kilogram,    AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit CentigramPerMole =  new MolarMassUnit(MassUnit.Centigram,   AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit DecagramPerMole =   new MolarMassUnit(MassUnit.Decagram,    AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit DecigramPerMole =   new MolarMassUnit(MassUnit.Decigram,    AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit GramPerMole =       new MolarMassUnit(MassUnit.Gram,        AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit HectogramPerMole =  new MolarMassUnit(MassUnit.Hectogram,   AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit KilopoundPerMole =  new MolarMassUnit(MassUnit.Kilopound,   AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit MegapoundPerMole =  new MolarMassUnit(MassUnit.Megapound,   AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit MicrogramPerMole =  new MolarMassUnit(MassUnit.Microgram,   AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit MilligramPerMole =  new MolarMassUnit(MassUnit.Milligram,   AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit NanogramPerMole =   new MolarMassUnit(MassUnit.Nanogram,    AmountOfSubstanceUnit.Mole);
        public static MolarMassUnit PoundPerMole =      new MolarMassUnit(MassUnit.Pound,       AmountOfSubstanceUnit.Mole);


        public MolarMassUnit(MassUnit mass, AmountOfSubstanceUnit amount, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "MolarMass";
            Unit = mass.Unit / amount.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

        


    }




}
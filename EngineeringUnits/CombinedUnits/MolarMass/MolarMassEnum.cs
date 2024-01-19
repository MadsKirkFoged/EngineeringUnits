using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record MolarMassUnit : UnitTypebase
    {

        public static readonly MolarMassUnit SI =                new(MassUnit.SI,    AmountOfSubstanceUnit.SI);
        public static readonly MolarMassUnit KilogramPerMole =   new(MassUnit.Kilogram,    AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit CentigramPerMole =  new(MassUnit.Centigram,   AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit DecagramPerMole =   new(MassUnit.Decagram,    AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit DecigramPerMole =   new(MassUnit.Decigram,    AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit GramPerMole =       new(MassUnit.Gram,        AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit HectogramPerMole =  new(MassUnit.Hectogram,   AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit KilopoundPerMole =  new(MassUnit.Kilopound,   AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit MegapoundPerMole =  new(MassUnit.Megapound,   AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit MicrogramPerMole =  new(MassUnit.Microgram,   AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit MilligramPerMole =  new(MassUnit.Milligram,   AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit NanogramPerMole =   new(MassUnit.Nanogram,    AmountOfSubstanceUnit.Mole);
        public static readonly MolarMassUnit PoundPerMole =      new(MassUnit.Pound,       AmountOfSubstanceUnit.Mole);


        public MolarMassUnit(MassUnit mass, AmountOfSubstanceUnit amount)
        {
            Unit = mass / amount;
        }


        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public class AmountOfSubstanceUnit : Enumeration
    {



        public static AmountOfSubstanceUnit Mole = new AmountOfSubstanceUnit(PreFix.SI, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Centimole = new AmountOfSubstanceUnit(PreFix.centi, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Decimole = new AmountOfSubstanceUnit(PreFix.deci, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Kilomole = new AmountOfSubstanceUnit(PreFix.kilo, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Megamole = new AmountOfSubstanceUnit(PreFix.mega, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Micromole = new AmountOfSubstanceUnit(PreFix.micro, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Millimole = new AmountOfSubstanceUnit(PreFix.milli, BaseUnits.amountOfSubstance);
        public static AmountOfSubstanceUnit Nanomole = new AmountOfSubstanceUnit(PreFix.nano, BaseUnits.amountOfSubstance);


        public AmountOfSubstanceUnit() { }


        public AmountOfSubstanceUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            SetUnitSystem();
        }


        public AmountOfSubstanceUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Amount = this.Copy();
            Unit.Amount.Count = 1;
            Count = 1;
        }



        public static IEnumerable<AmountOfSubstanceUnit> List()
        {
            return new[] { Mole, Centimole, Decimole, Kilomole, Megamole, Micromole, Millimole, Nanomole };
        }
        // Other util methods

        public AmountOfSubstanceUnit Copy()
        {
            return new AmountOfSubstanceUnit
            {
                Name = Name,
                Symbol = Symbol,
                A1 = A1,
                A2 = A2,
                B = B,
                Count = Count
            };
        }


    }





}
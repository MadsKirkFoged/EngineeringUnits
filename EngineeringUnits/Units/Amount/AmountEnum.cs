using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public class AmountOfSubstance : Enumeration
    {



        public static AmountOfSubstance Mole = new AmountOfSubstance(PreFix.SI, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Centimole = new AmountOfSubstance(PreFix.centi, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Decimole = new AmountOfSubstance(PreFix.deci, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Kilomole = new AmountOfSubstance(PreFix.kilo, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Megamole = new AmountOfSubstance(PreFix.mega, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Micromole = new AmountOfSubstance(PreFix.micro, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Millimole = new AmountOfSubstance(PreFix.milli, BaseUnits.amountOfSubstance);
        public static AmountOfSubstance Nanomole = new AmountOfSubstance(PreFix.nano, BaseUnits.amountOfSubstance);


        protected AmountOfSubstance() { }


        public AmountOfSubstance(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
        }


        public AmountOfSubstance(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<AmountOfSubstance> List()
        {
            return new[] { Mole, Centimole, Decimole, Kilomole, Megamole, Micromole, Millimole, Nanomole };
        }
        // Other util methods
    }





}
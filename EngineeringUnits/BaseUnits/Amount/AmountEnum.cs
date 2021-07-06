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


        public static readonly AmountOfSubstanceUnit SI =        new AmountOfSubstanceUnit(PreFix.SI, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Mole =      new AmountOfSubstanceUnit(PreFix.SI, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Centimole = new AmountOfSubstanceUnit(PreFix.centi, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Decimole =  new AmountOfSubstanceUnit(PreFix.deci, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Kilomole =  new AmountOfSubstanceUnit(PreFix.kilo, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Megamole =  new AmountOfSubstanceUnit(PreFix.mega, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Micromole = new AmountOfSubstanceUnit(PreFix.micro, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Millimole = new AmountOfSubstanceUnit(PreFix.milli, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Nanomole =  new AmountOfSubstanceUnit(PreFix.nano, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Picomole = new AmountOfSubstanceUnit(PreFix.pico, BaseUnits.amountOfSubstance);

        public static readonly AmountOfSubstanceUnit NanopoundMole =     new AmountOfSubstanceUnit("nlbmol", 1e-9m,  453.59237m);
        public static readonly AmountOfSubstanceUnit MicropoundMole =    new AmountOfSubstanceUnit("µlbmol", 1e-6m,  453.59237m);
        public static readonly AmountOfSubstanceUnit MillipoundMole =    new AmountOfSubstanceUnit("mlbmol", 1e-3m,  453.59237m);
        public static readonly AmountOfSubstanceUnit PoundMole =         new AmountOfSubstanceUnit("lbmol",  1,      453.59237m);
        public static readonly AmountOfSubstanceUnit KilopoundMole =     new AmountOfSubstanceUnit("klbmol", 1e3m,   453.59237m);
        public static readonly AmountOfSubstanceUnit DecipoundMole =     new AmountOfSubstanceUnit("dlbmol", 1e-1m,  453.59237m);
        public static readonly AmountOfSubstanceUnit CentipoundMole =    new AmountOfSubstanceUnit("clbmol", 1e-2m,  453.59237m);


        public AmountOfSubstanceUnit() { }


        public AmountOfSubstanceUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Amount = (AmountOfSubstanceUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public AmountOfSubstanceUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Amount = (AmountOfSubstanceUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }     

    }

}
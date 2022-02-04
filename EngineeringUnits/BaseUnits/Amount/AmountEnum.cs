using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AmountOfSubstanceUnit : Enumeration
    {


        public static readonly AmountOfSubstanceUnit SI =        new(PreFix.SI, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Mole =      new(PreFix.SI, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Centimole = new(PreFix.centi, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Decimole =  new(PreFix.deci, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Kilomole =  new(PreFix.kilo, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Megamole =  new(PreFix.mega, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Micromole = new(PreFix.micro, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Millimole = new(PreFix.milli, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Nanomole =  new(PreFix.nano, BaseUnits.amountOfSubstance);
        public static readonly AmountOfSubstanceUnit Picomole = new(PreFix.pico, BaseUnits.amountOfSubstance);

        public static readonly AmountOfSubstanceUnit NanopoundMole =     new("nlbmol",  1e-9m * 453.59237m);
        public static readonly AmountOfSubstanceUnit MicropoundMole =    new("µlbmol",  1e-6m * 453.59237m);
        public static readonly AmountOfSubstanceUnit MillipoundMole =    new("mlbmol",  1e-3m * 453.59237m);
        public static readonly AmountOfSubstanceUnit PoundMole =         new("lbmol",   1 *     453.59237m);
        public static readonly AmountOfSubstanceUnit KilopoundMole =     new("klbmol",  1e3m *  453.59237m);
        public static readonly AmountOfSubstanceUnit DecipoundMole =     new("dlbmol",  1e-1m * 453.59237m);
        public static readonly AmountOfSubstanceUnit CentipoundMole =    new("clbmol",  1e-2m * 453.59237m);


        public AmountOfSubstanceUnit() { }


        public AmountOfSubstanceUnit(string symbol, decimal Constant) : base(symbol, Constant)
        {
            Unit = new UnitSystem();
            Unit.Amount = (AmountOfSubstanceUnit)Clone();
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
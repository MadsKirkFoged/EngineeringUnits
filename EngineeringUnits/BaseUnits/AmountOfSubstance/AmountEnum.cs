using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AmountOfSubstanceUnit : UnitEnumbase
    {


        public static readonly AmountOfSubstanceUnit SI =        new(PreFix.SI);
        public static readonly AmountOfSubstanceUnit Mole =      new(PreFix.SI);
        public static readonly AmountOfSubstanceUnit Centimole = new(PreFix.centi);
        public static readonly AmountOfSubstanceUnit Decimole =  new(PreFix.deci);
        public static readonly AmountOfSubstanceUnit Kilomole =  new(PreFix.kilo);
        public static readonly AmountOfSubstanceUnit Megamole =  new(PreFix.mega);
        public static readonly AmountOfSubstanceUnit Micromole = new(PreFix.micro);
        public static readonly AmountOfSubstanceUnit Millimole = new(PreFix.milli);
        public static readonly AmountOfSubstanceUnit Nanomole =  new(PreFix.nano);
        public static readonly AmountOfSubstanceUnit Picomole = new(PreFix.pico);

        public static readonly AmountOfSubstanceUnit NanopoundMole =     new("nlbmol",  1e-9m * 453.59237m);
        public static readonly AmountOfSubstanceUnit MicropoundMole =    new("µlbmol",  1e-6m * 453.59237m);
        public static readonly AmountOfSubstanceUnit MillipoundMole =    new("mlbmol",  1e-3m * 453.59237m);
        public static readonly AmountOfSubstanceUnit PoundMole =         new("lbmol",   1 *     453.59237m);
        public static readonly AmountOfSubstanceUnit KilopoundMole =     new("klbmol",  1e3m *  453.59237m);
        public static readonly AmountOfSubstanceUnit DecipoundMole =     new("dlbmol",  1e-1m * 453.59237m);
        public static readonly AmountOfSubstanceUnit CentipoundMole =    new("clbmol",  1e-2m * 453.59237m);


        public AmountOfSubstanceUnit() { }


        public AmountOfSubstanceUnit(string symbol, decimal Constant) : base(symbol, new Fraction(Constant), BaseunitType.amountOfSubstance)
        {
            Unit = new UnitSystem(this);
        }


        public AmountOfSubstanceUnit(PreFix SI) : base(SI, BaseunitType.amountOfSubstance)
        {
            Unit = new UnitSystem(this);
        }     

    }

}
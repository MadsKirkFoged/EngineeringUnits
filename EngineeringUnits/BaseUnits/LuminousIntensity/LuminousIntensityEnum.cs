using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{

    public class LuminousIntensityUnit : UnitEnumbase
    {

        public static readonly LuminousIntensityUnit SI = new(PreFix.SI);
        public static readonly LuminousIntensityUnit Candela = new("cd", 1);


        public LuminousIntensityUnit(string symbol, decimal Constant) : base(symbol, new Fraction(Constant), BaseunitType.luminousIntensity)
        {
            Unit = new UnitSystem(this);
        }


        public LuminousIntensityUnit(PreFix SI) : base(SI, BaseunitType.luminousIntensity)
        {
            Unit = new UnitSystem(this);
        }     
       
    }


}
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{

    public class LuminousIntensityUnit : Enumeration
    {

        public static readonly LuminousIntensityUnit SI = new(PreFix.SI, BaseUnits.luminousIntensity);
        public static readonly LuminousIntensityUnit Candela = new("cd", 1);


        public LuminousIntensityUnit(string symbol, decimal Constant) : base(symbol, Constant)
        {
            Unit = new UnitSystem();
            Unit.LuminousIntensity = (LuminousIntensityUnit)Clone();
        }


        public LuminousIntensityUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.LuminousIntensity = (LuminousIntensityUnit)Clone();
        }     
       
    }


}
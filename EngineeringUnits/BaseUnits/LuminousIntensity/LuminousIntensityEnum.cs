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

        public static readonly LuminousIntensityUnit SI = new LuminousIntensityUnit(PreFix.SI, BaseUnits.luminousIntensity);
        public static readonly LuminousIntensityUnit Candela = new LuminousIntensityUnit("cd", 1,1);


        public LuminousIntensityUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.LI = (LuminousIntensityUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public LuminousIntensityUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.LI = (LuminousIntensityUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }     
       
    }


}
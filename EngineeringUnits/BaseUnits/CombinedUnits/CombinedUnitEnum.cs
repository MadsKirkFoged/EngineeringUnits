using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class CombinedUnit : UnitEnumbase
    {




        public CombinedUnit() { }


        public CombinedUnit(string symbol, Fraction Constant) : base(symbol, Constant, BaseunitType.CombinedUnit)
        {
            Unit = new UnitSystem(this);
        }
        public CombinedUnit(decimal Constant) : base(null, new Fraction(Constant), BaseunitType.CombinedUnit)
        {
            Unit = new UnitSystem(this);
        }




    }



}
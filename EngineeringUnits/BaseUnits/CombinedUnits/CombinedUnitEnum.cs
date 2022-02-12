using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class CombinedUnit : Enumeration
    {




        public CombinedUnit() { }


        public CombinedUnit(string symbol, Fraction Constant) : base(symbol, Constant)
        {
            Unit = new UnitSystem(this);
        }     
       


    }



}
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{

    public class DimensionlessUnit : Enumeration
    {

        public static readonly DimensionlessUnit Dimensionless = new DimensionlessUnit(PreFix.SI, BaseUnits.luminousIntensity);
      //  public static readonly DimensionlessUnit Candela = new DimensionlessUnit("cd", 1,1);


        public DimensionlessUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Dimensionless = (DimensionlessUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public DimensionlessUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Dimensionless = (DimensionlessUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }     
       
    }


}
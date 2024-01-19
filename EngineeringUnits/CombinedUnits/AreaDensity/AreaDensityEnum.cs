using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record AreaDensityUnit : UnitTypebase
    {

        public static readonly AreaDensityUnit SI = new(MassUnit.SI, AreaUnit.SI);
        public static readonly AreaDensityUnit KilogramPerSquareMeter = new(MassUnit.Kilogram, AreaUnit.SquareMeter);




        public AreaDensityUnit(MassUnit mass, AreaUnit area)
        {
            Unit = mass / area;
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
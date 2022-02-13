using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AreaDensityUnit : Enumeration
    {

        public static readonly AreaDensityUnit SI = new(MassUnit.SI, AreaUnit.SI);
        public static readonly AreaDensityUnit KilogramPerSquareMeter = new(MassUnit.Kilogram, AreaUnit.SquareMeter);




        public AreaDensityUnit(MassUnit mass, AreaUnit area)
        {
            Unit = mass / area;
        }



    }




}
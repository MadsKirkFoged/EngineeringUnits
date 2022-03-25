using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricCurrentDensityUnit : UnitEnumbase
    {

        public static readonly ElectricCurrentDensityUnit SI = new(ElectricCurrentUnit.SI, AreaUnit.SI);
        public static readonly ElectricCurrentDensityUnit AmperePerSquareMeter = new(ElectricCurrentUnit.Ampere, AreaUnit.SquareMeter);
        public static readonly ElectricCurrentDensityUnit AmperePerSquareInch = new(ElectricCurrentUnit.Ampere, AreaUnit.SquareInch);
        public static readonly ElectricCurrentDensityUnit AmperePerSquareFoot = new(ElectricCurrentUnit.Ampere, AreaUnit.SquareFoot);



        public ElectricCurrentDensityUnit(ElectricCurrentUnit electricCurrent, AreaUnit Area)
        {
            Unit = new UnitSystem(electricCurrent / Area, 
                               $"{electricCurrent}/{Area}");
        }      

      

    }




}
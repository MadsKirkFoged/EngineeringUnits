using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricCurrentDensityUnit : Enumeration
    {

        public static readonly ElectricCurrentDensityUnit SI = new ElectricCurrentDensityUnit(ElectricCurrentUnit.Ampere, AreaUnit.SquareMeter);
        public static readonly ElectricCurrentDensityUnit AmperePerSquareMeter = new ElectricCurrentDensityUnit(ElectricCurrentUnit.Ampere, AreaUnit.SquareMeter);
        public static readonly ElectricCurrentDensityUnit AmperePerSquareInch = new ElectricCurrentDensityUnit(ElectricCurrentUnit.Ampere, AreaUnit.SquareInch);
        public static readonly ElectricCurrentDensityUnit AmperePerSquareFoot = new ElectricCurrentDensityUnit(ElectricCurrentUnit.Ampere, AreaUnit.SquareFoot);



        public ElectricCurrentDensityUnit(ElectricCurrentUnit electricCurrent, AreaUnit Area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCurrent / Area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricCurrent}/{Area}");
        }      

      

    }




}
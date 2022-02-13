using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MagnetizationUnit : Enumeration
    {

        public static readonly MagnetizationUnit SI = new(ElectricCurrentUnit.SI, LengthUnit.SI);
        public static readonly MagnetizationUnit AmperePerMeter = new(ElectricCurrentUnit.Ampere, LengthUnit.Meter);




        public MagnetizationUnit(ElectricCurrentUnit electricCurrent, LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = electricCurrent / Length;
            SetNewSymbol(NewSymbol, $"{electricCurrent}/{Length}");
        }

       

    }




}
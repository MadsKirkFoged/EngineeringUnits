using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MagnetizationUnit : Enumeration
    {

        public static readonly MagnetizationUnit SI = new MagnetizationUnit(ElectricCurrentUnit.Ampere, LengthUnit.Meter);
        public static readonly MagnetizationUnit AmperePerMeter = new MagnetizationUnit(ElectricCurrentUnit.Ampere, LengthUnit.Meter);




        public MagnetizationUnit(ElectricCurrentUnit electricCurrent, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCurrent / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricCurrent}/{Length}");
        }

       

    }




}
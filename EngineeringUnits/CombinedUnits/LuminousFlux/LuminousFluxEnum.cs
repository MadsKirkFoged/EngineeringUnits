using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LuminousFluxUnit : Enumeration
    {

        public static readonly LuminousFluxUnit SI = new LuminousFluxUnit(LuminousIntensityUnit.Candela);
        public static readonly LuminousFluxUnit Lumen = new LuminousFluxUnit(LuminousIntensityUnit.Candela, "lm");




        public LuminousFluxUnit(LuminousIntensityUnit luminousIntensity, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = luminousIntensity.Unit.Copy(); ;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }



    }




}
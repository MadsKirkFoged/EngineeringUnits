using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LuminousFluxUnit : Enumeration
    {

        public static readonly LuminousFluxUnit SI = new(LuminousIntensityUnit.SI);
        public static readonly LuminousFluxUnit Lumen = new(LuminousIntensityUnit.Candela, "lm");




        public LuminousFluxUnit(LuminousIntensityUnit luminousIntensity, string NewSymbol = "Empty")
        {
            Unit = luminousIntensity.Unit.Copy(); 
            SetNewSymbol(NewSymbol);
        }



    }




}
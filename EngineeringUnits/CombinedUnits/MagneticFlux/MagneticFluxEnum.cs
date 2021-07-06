using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MagneticFluxUnit : Enumeration
    {

        public static readonly MagneticFluxUnit SI = new MagneticFluxUnit(EnergyUnit.Joule, ElectricCurrentUnit.Ampere);
        public static readonly MagneticFluxUnit Weber = new MagneticFluxUnit(EnergyUnit.Joule, ElectricCurrentUnit.Ampere, "Wb");




        public MagneticFluxUnit(EnergyUnit energy, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy.Unit / electricCurrent.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

     

    }




}
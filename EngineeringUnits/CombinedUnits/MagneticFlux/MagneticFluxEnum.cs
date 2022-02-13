using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MagneticFluxUnit : Enumeration
    {

        public static readonly MagneticFluxUnit SI = new(EnergyUnit.SI, ElectricCurrentUnit.SI);
        public static readonly MagneticFluxUnit Weber = new(EnergyUnit.Joule, ElectricCurrentUnit.Ampere, "Wb");




        public MagneticFluxUnit(EnergyUnit energy, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty")
        {
            Unit = energy / electricCurrent;
            SetNewSymbol(NewSymbol);
        }

     

    }




}
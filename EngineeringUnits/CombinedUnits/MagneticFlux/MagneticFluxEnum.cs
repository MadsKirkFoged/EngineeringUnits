using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MagneticFluxUnit : UnitEnumbase
    {

        public static readonly MagneticFluxUnit SI = new(EnergyUnit.SI, ElectricCurrentUnit.SI, "Wb");
        public static readonly MagneticFluxUnit Weber = new(EnergyUnit.Joule, ElectricCurrentUnit.Ampere, "Wb");


        public MagneticFluxUnit(EnergyUnit energy, ElectricCurrentUnit electricCurrent, string NewSymbol)
        {
            Unit = new UnitSystem(energy / electricCurrent, NewSymbol);
        }    

    }
}
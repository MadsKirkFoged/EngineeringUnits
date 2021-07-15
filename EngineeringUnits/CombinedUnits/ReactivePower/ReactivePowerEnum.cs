using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ReactivePowerUnit : Enumeration
    {

        public static readonly ReactivePowerUnit SI = new ReactivePowerUnit(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI);
        public static readonly ReactivePowerUnit VoltampereReactive = new ReactivePowerUnit(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, "var");
        public static readonly ReactivePowerUnit MegavoltampereReactive = new ReactivePowerUnit(ElectricPotentialUnit.Megavolt, ElectricCurrentUnit.Ampere, "Mvar");
        public static readonly ReactivePowerUnit KilovoltampereReactive = new ReactivePowerUnit(ElectricPotentialUnit.Kilovolt, ElectricCurrentUnit.Ampere, "kvar");
        public static readonly ReactivePowerUnit GigavoltampereReactive = new ReactivePowerUnit(ElectricPotentialUnit.Gigavolt, ElectricCurrentUnit.Ampere, "Gvar");



        public ReactivePowerUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential * electricCurrent;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

     

    }




}
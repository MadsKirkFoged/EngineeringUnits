using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ReactivePowerUnit : Enumeration
    {

        public static readonly ReactivePowerUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI);
        public static readonly ReactivePowerUnit VoltampereReactive = new(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, "var");
        public static readonly ReactivePowerUnit MegavoltampereReactive = new(ElectricPotentialUnit.Megavolt, ElectricCurrentUnit.Ampere, "Mvar");
        public static readonly ReactivePowerUnit KilovoltampereReactive = new(ElectricPotentialUnit.Kilovolt, ElectricCurrentUnit.Ampere, "kvar");
        public static readonly ReactivePowerUnit GigavoltampereReactive = new(ElectricPotentialUnit.Gigavolt, ElectricCurrentUnit.Ampere, "Gvar");



        public ReactivePowerUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty")
        {
            Unit = electricPotential * electricCurrent;
            SetNewSymbol(NewSymbol);
        }

     

    }




}
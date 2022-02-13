using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ReactiveEnergyUnit : Enumeration
    {

        public static readonly ReactiveEnergyUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI, DurationUnit.SI);
        public static readonly ReactiveEnergyUnit VoltampereReactiveHour = new(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "varh");
        public static readonly ReactiveEnergyUnit MegavoltampereReactiveHour = new(ElectricPotentialUnit.Megavolt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "Mvarh");
        public static readonly ReactiveEnergyUnit KilovoltampereReactiveHour = new(ElectricPotentialUnit.Kilovolt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "kvarh");


        public ReactiveEnergyUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrent, DurationUnit duration, string NewSymbol = "Empty")
        {
            Unit = electricPotential * electricCurrent * duration;
            SetNewSymbol(NewSymbol);
        }

       

    }




}
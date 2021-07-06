using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ReactiveEnergyUnit : Enumeration
    {

        public static readonly ReactiveEnergyUnit SI = new ReactiveEnergyUnit(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, DurationUnit.Second);
        public static readonly ReactiveEnergyUnit VoltampereReactiveHour = new ReactiveEnergyUnit(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "varh");
        public static readonly ReactiveEnergyUnit MegavoltampereReactiveHour = new ReactiveEnergyUnit(ElectricPotentialUnit.Megavolt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "Mvarh");
        public static readonly ReactiveEnergyUnit KilovoltampereReactiveHour = new ReactiveEnergyUnit(ElectricPotentialUnit.Kilovolt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "kvarh");


        public ReactiveEnergyUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrent, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential.Unit * electricCurrent.Unit * duration.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

       

    }




}
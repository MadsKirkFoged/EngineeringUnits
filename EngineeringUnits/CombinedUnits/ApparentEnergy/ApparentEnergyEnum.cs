using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ApparentEnergyUnit : Enumeration
    {



        public static readonly ApparentEnergyUnit SI = new ApparentEnergyUnit(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, DurationUnit.Hour);

        public static readonly ApparentEnergyUnit VoltampereHour = new ApparentEnergyUnit(ElectricPotentialUnit.Volt , ElectricCurrentUnit.Ampere , DurationUnit.Hour, "VAh");
        public static readonly ApparentEnergyUnit MegavoltampereHour = new ApparentEnergyUnit(PreFix.mega, VoltampereHour);
        public static readonly ApparentEnergyUnit KilovoltampereHour = new ApparentEnergyUnit(PreFix.kilo, VoltampereHour);



        public ApparentEnergyUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, DurationUnit durationUnit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential * electricCurrentUnit * durationUnit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    
        public ApparentEnergyUnit(PreFix SI, ApparentEnergyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }




}
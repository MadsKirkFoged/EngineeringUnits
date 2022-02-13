using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ApparentEnergyUnit : Enumeration
    {



        public static readonly ApparentEnergyUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI, DurationUnit.SI);

        public static readonly ApparentEnergyUnit VoltampereHour = new(ElectricPotentialUnit.Volt , ElectricCurrentUnit.Ampere , DurationUnit.Hour, "VAh");
        public static readonly ApparentEnergyUnit MegavoltampereHour = new(PreFix.mega, VoltampereHour);
        public static readonly ApparentEnergyUnit KilovoltampereHour = new(PreFix.kilo, VoltampereHour);



        public ApparentEnergyUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, DurationUnit durationUnit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential * electricCurrentUnit * durationUnit * correction;
            //SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    
        public ApparentEnergyUnit(PreFix SI, ApparentEnergyUnit unit) : base(SI, unit)
        {
        }


    }




}
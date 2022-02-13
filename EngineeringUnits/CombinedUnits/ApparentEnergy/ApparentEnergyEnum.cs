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



        public ApparentEnergyUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, DurationUnit durationUnit, string NewSymbol = null)
        {
            Unit = new UnitSystem( electricPotential * electricCurrentUnit * durationUnit, NewSymbol);
        }

    
        public ApparentEnergyUnit(PreFix SI, ApparentEnergyUnit unit) : base(SI, unit) {}


    }




}
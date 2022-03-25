using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricChargeUnit : UnitEnumbase
    {

        public static readonly ElectricChargeUnit SI = new(ElectricCurrentUnit.SI, DurationUnit.SI, "C");
        public static readonly ElectricChargeUnit Coulomb = new(ElectricCurrentUnit.Ampere, DurationUnit.Second, "C");
        public static readonly ElectricChargeUnit AmpereHour = new(ElectricCurrentUnit.Ampere, DurationUnit.Hour, "A-h");
        public static readonly ElectricChargeUnit KiloampereHour = new(PreFix.kilo, AmpereHour);
        public static readonly ElectricChargeUnit MegaampereHour = new(PreFix.mega, AmpereHour);
        public static readonly ElectricChargeUnit MilliampereHour = new(PreFix.milli, AmpereHour);


        public ElectricChargeUnit(ElectricCurrentUnit electricCurrent, DurationUnit duration, string NewSymbol)
        {
            Unit = new UnitSystem(electricCurrent * duration, NewSymbol);
        }
             

        public ElectricChargeUnit(PreFix SI, ElectricChargeUnit unit) : base(SI, unit) {}

    }




}
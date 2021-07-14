using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricChargeUnit : Enumeration
    {

        public static readonly ElectricChargeUnit SI = new ElectricChargeUnit(ElectricCurrentUnit.Ampere, DurationUnit.Second);
        public static readonly ElectricChargeUnit Coulomb = new ElectricChargeUnit(ElectricCurrentUnit.Ampere, DurationUnit.Second, "C");
        public static readonly ElectricChargeUnit AmpereHour = new ElectricChargeUnit(ElectricCurrentUnit.Ampere, DurationUnit.Hour, "A-h");
        public static readonly ElectricChargeUnit KiloampereHour = new ElectricChargeUnit(PreFix.kilo, AmpereHour);
        public static readonly ElectricChargeUnit MegaampereHour = new ElectricChargeUnit(PreFix.mega, AmpereHour);
        public static readonly ElectricChargeUnit MilliampereHour = new ElectricChargeUnit(PreFix.milli, AmpereHour);


        public ElectricChargeUnit(ElectricCurrentUnit electricCurrent, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCurrent * duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }
             

        public ElectricChargeUnit(PreFix SI, ElectricChargeUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }




}
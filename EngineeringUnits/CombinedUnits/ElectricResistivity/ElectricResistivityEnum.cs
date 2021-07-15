using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricResistivityUnit : Enumeration
    {

        public static readonly ElectricResistivityUnit SI = new ElectricResistivityUnit(ElectricResistanceUnit.SI, LengthUnit.SI);
        public static readonly ElectricResistivityUnit OhmMeter = new ElectricResistivityUnit(ElectricResistanceUnit.Ohm, LengthUnit.Meter);
        public static readonly ElectricResistivityUnit OhmCentimeter = new ElectricResistivityUnit(ElectricResistanceUnit.Ohm, LengthUnit.Centimeter);

        public static readonly ElectricResistivityUnit KiloohmCentimeter = new ElectricResistivityUnit(PreFix.kilo, OhmCentimeter);
        public static readonly ElectricResistivityUnit MegaohmCentimeter = new ElectricResistivityUnit(PreFix.mega, OhmCentimeter);
        public static readonly ElectricResistivityUnit MicroohmCentimeter = new ElectricResistivityUnit(PreFix.micro, OhmCentimeter);
        public static readonly ElectricResistivityUnit MilliohmCentimeter = new ElectricResistivityUnit(PreFix.milli, OhmCentimeter);
        public static readonly ElectricResistivityUnit NanoohmCentimeter = new ElectricResistivityUnit(PreFix.nano, OhmCentimeter);
        public static readonly ElectricResistivityUnit PicoohmCentimeter = new ElectricResistivityUnit(PreFix.pico, OhmCentimeter);

        public static readonly ElectricResistivityUnit KiloohmMeter = new ElectricResistivityUnit(PreFix.kilo, OhmMeter);
        public static readonly ElectricResistivityUnit MegaohmMeter = new ElectricResistivityUnit(PreFix.mega, OhmMeter);
        public static readonly ElectricResistivityUnit MicroohmMeter = new ElectricResistivityUnit(PreFix.micro, OhmMeter);
        public static readonly ElectricResistivityUnit MilliohmMeter = new ElectricResistivityUnit(PreFix.milli, OhmMeter);
        public static readonly ElectricResistivityUnit NanoohmMeter = new ElectricResistivityUnit(PreFix.nano, OhmMeter);
        public static readonly ElectricResistivityUnit PicoohmMeter = new ElectricResistivityUnit(PreFix.pico, OhmMeter);




        public ElectricResistivityUnit(ElectricResistanceUnit electricResistance, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricResistance * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricResistance}·{Length}");
        }


        public ElectricResistivityUnit(PreFix SI, ElectricResistivityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }


}
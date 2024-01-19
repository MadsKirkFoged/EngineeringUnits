using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ElectricResistivityUnit : UnitTypebase
    {

        public static readonly ElectricResistivityUnit SI = new(ElectricResistanceUnit.SI, LengthUnit.SI);
        public static readonly ElectricResistivityUnit OhmMeter = new(ElectricResistanceUnit.Ohm, LengthUnit.Meter);
        public static readonly ElectricResistivityUnit OhmCentimeter = new(ElectricResistanceUnit.Ohm, LengthUnit.Centimeter);

        public static readonly ElectricResistivityUnit KiloohmCentimeter = new(PreFix.kilo, OhmCentimeter);
        public static readonly ElectricResistivityUnit MegaohmCentimeter = new(PreFix.mega, OhmCentimeter);
        public static readonly ElectricResistivityUnit MicroohmCentimeter = new(PreFix.micro, OhmCentimeter);
        public static readonly ElectricResistivityUnit MilliohmCentimeter = new(PreFix.milli, OhmCentimeter);
        public static readonly ElectricResistivityUnit NanoohmCentimeter = new(PreFix.nano, OhmCentimeter);
        public static readonly ElectricResistivityUnit PicoohmCentimeter = new(PreFix.pico, OhmCentimeter);

        public static readonly ElectricResistivityUnit KiloohmMeter = new(PreFix.kilo, OhmMeter);
        public static readonly ElectricResistivityUnit MegaohmMeter = new(PreFix.mega, OhmMeter);
        public static readonly ElectricResistivityUnit MicroohmMeter = new(PreFix.micro, OhmMeter);
        public static readonly ElectricResistivityUnit MilliohmMeter = new(PreFix.milli, OhmMeter);
        public static readonly ElectricResistivityUnit NanoohmMeter = new(PreFix.nano, OhmMeter);
        public static readonly ElectricResistivityUnit PicoohmMeter = new(PreFix.pico, OhmMeter);


        public ElectricResistivityUnit(ElectricResistanceUnit electricResistance, LengthUnit Length)
        {
            Unit = new UnitSystem(electricResistance * Length , 
                               $"{electricResistance}·{Length}");
        }

        public ElectricResistivityUnit(PreFix SI, ElectricResistivityUnit unit) : base(SI, unit) {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }


}
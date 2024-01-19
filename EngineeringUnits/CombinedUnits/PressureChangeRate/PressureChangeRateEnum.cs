using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record PressureChangeRateUnit : UnitTypebase
    {

        public static readonly PressureChangeRateUnit SI = new(PressureUnit.SI, DurationUnit.SI);
        public static readonly PressureChangeRateUnit PascalPerSecond = new(PressureUnit.Pascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit PascalPerMinute = new(PressureUnit.Pascal, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit MegapascalPerSecond = new(PressureUnit.Megapascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit MegapascalPerMinute = new(PressureUnit.Megapascal, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit KilopoundForcePerSquareInchPerSecond = new(PressureUnit.KilopoundForcePerSquareInch, DurationUnit.Second);
        public static readonly PressureChangeRateUnit KilopoundForcePerSquareInchPerMinute = new(PressureUnit.KilopoundForcePerSquareInch, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit KilopascalPerSecond = new(PressureUnit.Kilopascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit KilopascalPerMinute = new(PressureUnit.Kilopascal, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit AtmospherePerSecond = new(PressureUnit.Atmosphere, DurationUnit.Second);

        public static readonly PressureChangeRateUnit PoundForcePerSquareInchPerMinute = new(PressureUnit.PoundForcePerSquareInch, DurationUnit.Minute);
        public static readonly PressureChangeRateUnit PoundForcePerSquareInchPerSecond = new(PressureUnit.PoundForcePerSquareInch, DurationUnit.Second);
        public static readonly PressureChangeRateUnit MegapoundForcePerSquareInchPerSecond = new(PreFix.mega, PoundForcePerSquareInchPerSecond);
        public static readonly PressureChangeRateUnit MegapoundForcePerSquareInchPerMinute = new(PreFix.mega, PoundForcePerSquareInchPerMinute);



        public PressureChangeRateUnit(PressureUnit pressure, DurationUnit duration)
        {
            Unit = new UnitSystem(pressure / duration, 
                               $"{pressure}/{duration}");
        }    

        public PressureChangeRateUnit(PreFix SI, PressureChangeRateUnit unit) : base(SI, unit)  { }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
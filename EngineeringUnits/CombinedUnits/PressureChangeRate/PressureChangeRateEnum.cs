using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class PressureChangeRateUnit : Enumeration
    {

        public static readonly PressureChangeRateUnit SI = new PressureChangeRateUnit(PressureUnit.Pascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit PascalPerSecond = new PressureChangeRateUnit(PressureUnit.Pascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit PascalPerMinute = new PressureChangeRateUnit(PressureUnit.Pascal, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit MegapascalPerSecond = new PressureChangeRateUnit(PressureUnit.Megapascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit MegapascalPerMinute = new PressureChangeRateUnit(PressureUnit.Megapascal, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit KilopoundForcePerSquareInchPerSecond = new PressureChangeRateUnit(PressureUnit.KilopoundForcePerSquareInch, DurationUnit.Second);
        public static readonly PressureChangeRateUnit KilopoundForcePerSquareInchPerMinute = new PressureChangeRateUnit(PressureUnit.KilopoundForcePerSquareInch, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit KilopascalPerSecond = new PressureChangeRateUnit(PressureUnit.Kilopascal, DurationUnit.Second);
        public static readonly PressureChangeRateUnit KilopascalPerMinute = new PressureChangeRateUnit(PressureUnit.Kilopascal, DurationUnit.Minute);

        public static readonly PressureChangeRateUnit AtmospherePerSecond = new PressureChangeRateUnit(PressureUnit.Atmosphere, DurationUnit.Second);

        public static readonly PressureChangeRateUnit PoundForcePerSquareInchPerMinute = new PressureChangeRateUnit(PressureUnit.PoundForcePerSquareInch, DurationUnit.Minute);
        public static readonly PressureChangeRateUnit PoundForcePerSquareInchPerSecond = new PressureChangeRateUnit(PressureUnit.PoundForcePerSquareInch, DurationUnit.Second);
        public static readonly PressureChangeRateUnit MegapoundForcePerSquareInchPerSecond = new PressureChangeRateUnit(PreFix.mega, PoundForcePerSquareInchPerSecond);
        public static readonly PressureChangeRateUnit MegapoundForcePerSquareInchPerMinute = new PressureChangeRateUnit(PreFix.mega, PoundForcePerSquareInchPerMinute);



        public PressureChangeRateUnit(PressureUnit pressure, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = pressure / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{pressure}/{duration}");
        }    

        public PressureChangeRateUnit(PreFix SI, PressureChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }




}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VolumeFlowUnit : Enumeration
    {

        public static VolumeFlowUnit AcreFootPerDay = new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Day);
        public static VolumeFlowUnit AcreFootPerHour = new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Hour);
        public static VolumeFlowUnit AcreFootPerMinute = new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Minute);
        public static VolumeFlowUnit AcreFootPerSecond = new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Second);

        public static VolumeFlowUnit CentiliterPerDay = new VolumeFlowUnit(VolumeUnit.Centiliter, DurationUnit.Day);
        public static VolumeFlowUnit CentiliterPerMinute = new VolumeFlowUnit(VolumeUnit.Centiliter, DurationUnit.Minute);
        public static VolumeFlowUnit CentiliterPerSecond = new VolumeFlowUnit(VolumeUnit.Centiliter, DurationUnit.Second);

        public static VolumeFlowUnit CubicCentimeterPerMinute = new VolumeFlowUnit(VolumeUnit.CubicCentimeter, DurationUnit.Minute);
        public static VolumeFlowUnit CubicDecimeterPerMinute = new VolumeFlowUnit(VolumeUnit.CubicDecimeter, DurationUnit.Minute);
        public static VolumeFlowUnit CubicFootPerHour = new VolumeFlowUnit(VolumeUnit.CubicFoot, DurationUnit.Hour);
        public static VolumeFlowUnit CubicFootPerMinute = new VolumeFlowUnit(VolumeUnit.CubicFoot, DurationUnit.Minute);
        public static VolumeFlowUnit CubicFootPerSecond = new VolumeFlowUnit(VolumeUnit.CubicFoot, DurationUnit.Second);
        public static VolumeFlowUnit CubicMeterPerDay = new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Day);
        public static VolumeFlowUnit CubicMeterPerHour = new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Hour);
        public static VolumeFlowUnit CubicMeterPerMinute = new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Minute);
        public static VolumeFlowUnit CubicMeterPerSecond = new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Second);
        public static VolumeFlowUnit CubicMillimeterPerSecond = new VolumeFlowUnit(VolumeUnit.CubicMillimeter, DurationUnit.Second);
        public static VolumeFlowUnit CubicYardPerDay = new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Day);
        public static VolumeFlowUnit CubicYardPerHour = new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Hour);
        public static VolumeFlowUnit CubicYardPerMinute = new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Minute);
        public static VolumeFlowUnit CubicYardPerSecond = new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Second);
        public static VolumeFlowUnit DeciliterPerDay = new VolumeFlowUnit(VolumeUnit.Deciliter, DurationUnit.Day);
        public static VolumeFlowUnit DeciliterPerMinute = new VolumeFlowUnit(VolumeUnit.Deciliter, DurationUnit.Minute);
        public static VolumeFlowUnit DeciliterPerSecond = new VolumeFlowUnit(VolumeUnit.Deciliter, DurationUnit.Second);
        public static VolumeFlowUnit KiloliterPerDay = new VolumeFlowUnit(VolumeUnit.Kiloliter, DurationUnit.Day);
        public static VolumeFlowUnit KiloliterPerMinute = new VolumeFlowUnit(VolumeUnit.Kiloliter, DurationUnit.Minute);
        public static VolumeFlowUnit KiloliterPerSecond = new VolumeFlowUnit(VolumeUnit.Kiloliter, DurationUnit.Second);
        public static VolumeFlowUnit KilousGallonPerMinute = new VolumeFlowUnit(VolumeUnit.KilousGallon, DurationUnit.Second);
        public static VolumeFlowUnit LiterPerDay = new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Day);
        public static VolumeFlowUnit LiterPerHour = new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Hour);
        public static VolumeFlowUnit LiterPerMinute = new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Minute);
        public static VolumeFlowUnit LiterPerSecond = new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Second);
        public static VolumeFlowUnit MegaliterPerDay = new VolumeFlowUnit(VolumeUnit.Megaliter, DurationUnit.Day);
        //public static VolumeFlowUnit MegaukGallonPerSecond = new VolumeFlowUnit(VolumeUnit.MegaukGallon, DurationUnit.Second);
        public static VolumeFlowUnit MicroliterPerDay = new VolumeFlowUnit(VolumeUnit.Microliter, DurationUnit.Day);
        public static VolumeFlowUnit MicroliterPerMinute = new VolumeFlowUnit(VolumeUnit.Microliter, DurationUnit.Minute);
        public static VolumeFlowUnit MicroliterPerSecond = new VolumeFlowUnit(VolumeUnit.Microliter, DurationUnit.Second);
        public static VolumeFlowUnit MilliliterPerDay = new VolumeFlowUnit(VolumeUnit.Milliliter, DurationUnit.Day);
        public static VolumeFlowUnit MilliliterPerMinute = new VolumeFlowUnit(VolumeUnit.Milliliter, DurationUnit.Minute);
        public static VolumeFlowUnit MilliliterPerSecond = new VolumeFlowUnit(VolumeUnit.Milliliter, DurationUnit.Second);
        //public static VolumeFlowUnit MillionUsGallonsPerDay = new VolumeFlowUnit(VolumeUnit.MillionUsGallons, DurationUnit.Second);

        //public static VolumeFlowUnit NanoliterPerDay = new VolumeFlowUnit(VolumeUnit.Nanoliter, DurationUnit.Day);
        //public static VolumeFlowUnit NanoliterPerMinute = new VolumeFlowUnit(VolumeUnit.Nanoliter, DurationUnit.Minute);
        //public static VolumeFlowUnit NanoliterPerSecond = new VolumeFlowUnit(VolumeUnit.Nanoliter, DurationUnit.Second);

        public static VolumeFlowUnit OilBarrelPerDay = new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Day);
        public static VolumeFlowUnit OilBarrelPerHour = new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Hour);
        public static VolumeFlowUnit OilBarrelPerMinute = new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Minute);
        public static VolumeFlowUnit OilBarrelPerSecond = new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Second);
        public static VolumeFlowUnit UkGallonPerDay = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Day);
        public static VolumeFlowUnit UkGallonPerHour = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Hour);
        public static VolumeFlowUnit UkGallonPerMinute = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Minute);
        public static VolumeFlowUnit UkGallonPerSecond = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Second);
        public static VolumeFlowUnit UsGallonPerDay = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Day);
        public static VolumeFlowUnit UsGallonPerHour = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Hour);
        public static VolumeFlowUnit UsGallonPerMinute = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Minute);
        public static VolumeFlowUnit UsGallonPerSecond = new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Second);








        public VolumeFlowUnit(VolumeUnit volume,DurationUnit duration , string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "VolumeFlow";
            Unit = volume.Unit / duration.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

        public VolumeFlowUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "VolumeFlowh";
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public VolumeFlowUnit(PreFix SI, VolumeFlowUnit unit)
        {
            Name = "VolumeFlowh";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public VolumeFlowUnit(VolumeFlowUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "VolumeFlowh";
            Unit = unit.Unit.Copy();

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public static IEnumerable<VolumeFlowUnit> List()
        {
            return new[] { SI };
        }





    }




}
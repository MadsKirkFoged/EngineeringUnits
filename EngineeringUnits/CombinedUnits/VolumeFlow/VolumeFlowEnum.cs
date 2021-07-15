using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class VolumeFlowUnit : Enumeration
    {

        public static readonly VolumeFlowUnit AcreFootPerDay =           new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Day, "af/d");
        public static readonly VolumeFlowUnit AcreFootPerHour =          new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Hour, "af/h");
        public static readonly VolumeFlowUnit AcreFootPerMinute =        new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Minute, "af/m");
        public static readonly VolumeFlowUnit AcreFootPerSecond =        new VolumeFlowUnit(VolumeUnit.AcreFoot, DurationUnit.Second, "af/s");

        public static readonly VolumeFlowUnit CentiliterPerDay =         new VolumeFlowUnit(VolumeUnit.Centiliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit CentiliterPerMinute =      new VolumeFlowUnit(VolumeUnit.Centiliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CentiliterPerSecond =      new VolumeFlowUnit(VolumeUnit.Centiliter, DurationUnit.Second);

        public static readonly VolumeFlowUnit CubicCentimeterPerMinute = new VolumeFlowUnit(VolumeUnit.CubicCentimeter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicDecimeterPerMinute =  new VolumeFlowUnit(VolumeUnit.CubicDecimeter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicFootPerHour =         new VolumeFlowUnit(VolumeUnit.CubicFoot, DurationUnit.Hour);
        public static readonly VolumeFlowUnit CubicFootPerMinute =       new VolumeFlowUnit(VolumeUnit.CubicFoot, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicFootPerSecond =       new VolumeFlowUnit(VolumeUnit.CubicFoot, DurationUnit.Second);
        public static readonly VolumeFlowUnit CubicMeterPerDay =         new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Day);
        public static readonly VolumeFlowUnit CubicMeterPerHour =        new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Hour);
        public static readonly VolumeFlowUnit CubicMeterPerMinute =      new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicMeterPerSecond =      new VolumeFlowUnit(VolumeUnit.CubicMeter, DurationUnit.Second);
        public static readonly VolumeFlowUnit SI =                       new VolumeFlowUnit(VolumeUnit.SI, DurationUnit.SI);

        public static readonly VolumeFlowUnit CubicMillimeterPerSecond = new VolumeFlowUnit(VolumeUnit.CubicMillimeter, DurationUnit.Second);
        public static readonly VolumeFlowUnit CubicYardPerDay =          new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Day);
        public static readonly VolumeFlowUnit CubicYardPerHour =         new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Hour);
        public static readonly VolumeFlowUnit CubicYardPerMinute =       new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicYardPerSecond =       new VolumeFlowUnit(VolumeUnit.CubicYard, DurationUnit.Second);
        public static readonly VolumeFlowUnit DeciliterPerDay =          new VolumeFlowUnit(VolumeUnit.Deciliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit DeciliterPerMinute =       new VolumeFlowUnit(VolumeUnit.Deciliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit DeciliterPerSecond =       new VolumeFlowUnit(VolumeUnit.Deciliter, DurationUnit.Second);
        public static readonly VolumeFlowUnit KiloliterPerDay =          new VolumeFlowUnit(VolumeUnit.Kiloliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit KiloliterPerMinute =       new VolumeFlowUnit(VolumeUnit.Kiloliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit KiloliterPerSecond =       new VolumeFlowUnit(VolumeUnit.Kiloliter, DurationUnit.Second);

        public static readonly VolumeFlowUnit KilousGallonPerMinute =    new VolumeFlowUnit(VolumeUnit.KilousGallon, DurationUnit.Minute);

        public static readonly VolumeFlowUnit LiterPerDay =              new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Day);
        public static readonly VolumeFlowUnit LiterPerHour =             new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Hour);
        public static readonly VolumeFlowUnit LiterPerMinute =           new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit LiterPerSecond =           new VolumeFlowUnit(VolumeUnit.Liter, DurationUnit.Second);
        public static readonly VolumeFlowUnit MegaliterPerDay =          new VolumeFlowUnit(VolumeUnit.Megaliter, DurationUnit.Day);

        public static readonly VolumeFlowUnit MicroliterPerDay =         new VolumeFlowUnit(VolumeUnit.Microliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit MicroliterPerMinute =      new VolumeFlowUnit(VolumeUnit.Microliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit MicroliterPerSecond =      new VolumeFlowUnit(VolumeUnit.Microliter, DurationUnit.Second);
        public static readonly VolumeFlowUnit MilliliterPerDay =         new VolumeFlowUnit(VolumeUnit.Milliliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit MilliliterPerMinute =      new VolumeFlowUnit(VolumeUnit.Milliliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit MilliliterPerSecond =      new VolumeFlowUnit(VolumeUnit.Milliliter, DurationUnit.Second);
        public static readonly VolumeFlowUnit MillionUsGallonsPerDay =   new VolumeFlowUnit(VolumeUnit.UsGallon, DurationUnit.Day, "MGD", 1000000);
  
        public static readonly VolumeFlowUnit NanoliterPerDay =          new VolumeFlowUnit(VolumeUnit.Nanoliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit NanoliterPerMinute =       new VolumeFlowUnit(VolumeUnit.Nanoliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit NanoliterPerSecond =       new VolumeFlowUnit(VolumeUnit.Nanoliter, DurationUnit.Second);

        public static readonly VolumeFlowUnit OilBarrelPerDay =          new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Day);
        public static readonly VolumeFlowUnit OilBarrelPerHour =         new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Hour);
        public static readonly VolumeFlowUnit OilBarrelPerMinute =       new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Minute);
        public static readonly VolumeFlowUnit OilBarrelPerSecond =       new VolumeFlowUnit(VolumeUnit.OilBarrel, DurationUnit.Second);
        public static readonly VolumeFlowUnit UkGallonPerDay =           new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Day, "gal (U. K.)/d");
        public static readonly VolumeFlowUnit UkGallonPerHour =          new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Hour);
        public static readonly VolumeFlowUnit UkGallonPerMinute =        new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Minute);
        public static readonly VolumeFlowUnit UkGallonPerSecond =        new VolumeFlowUnit(VolumeUnit.ImperialGallon, DurationUnit.Second);
        public static readonly VolumeFlowUnit UsGallonPerDay =           new VolumeFlowUnit(VolumeUnit.UsGallon, DurationUnit.Day, "gpd");
        public static readonly VolumeFlowUnit UsGallonPerHour =          new VolumeFlowUnit(VolumeUnit.UsGallon, DurationUnit.Hour);
        public static readonly VolumeFlowUnit UsGallonPerMinute =        new VolumeFlowUnit(VolumeUnit.UsGallon, DurationUnit.Minute);
        public static readonly VolumeFlowUnit UsGallonPerSecond =        new VolumeFlowUnit(VolumeUnit.UsGallon, DurationUnit.Second);

        public static readonly VolumeFlowUnit MegaukGallonPerSecond =    new VolumeFlowUnit(PreFix.mega, UkGallonPerSecond);



        public VolumeFlowUnit(VolumeUnit volume,DurationUnit duration , string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = volume / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{volume}/{duration}");
        }

      
        public VolumeFlowUnit(PreFix SI, VolumeFlowUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }
    }
}
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class VolumeFlowUnit : Enumeration
    {

        public static readonly VolumeFlowUnit AcreFootPerDay =           new(VolumeUnit.AcreFoot, DurationUnit.Day, "af/d");
        public static readonly VolumeFlowUnit AcreFootPerHour =          new(VolumeUnit.AcreFoot, DurationUnit.Hour, "af/h");
        public static readonly VolumeFlowUnit AcreFootPerMinute =        new(VolumeUnit.AcreFoot, DurationUnit.Minute, "af/m");
        public static readonly VolumeFlowUnit AcreFootPerSecond =        new(VolumeUnit.AcreFoot, DurationUnit.Second, "af/s");

        public static readonly VolumeFlowUnit CentiliterPerDay =         new(VolumeUnit.Centiliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit CentiliterPerMinute =      new(VolumeUnit.Centiliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CentiliterPerSecond =      new(VolumeUnit.Centiliter, DurationUnit.Second);

        public static readonly VolumeFlowUnit CubicCentimeterPerMinute = new(VolumeUnit.CubicCentimeter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicDecimeterPerMinute =  new(VolumeUnit.CubicDecimeter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicFootPerHour =         new(VolumeUnit.CubicFoot, DurationUnit.Hour);
        public static readonly VolumeFlowUnit CubicFootPerMinute =       new(VolumeUnit.CubicFoot, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicFootPerSecond =       new(VolumeUnit.CubicFoot, DurationUnit.Second);
        public static readonly VolumeFlowUnit CubicMeterPerDay =         new(VolumeUnit.CubicMeter, DurationUnit.Day);
        public static readonly VolumeFlowUnit CubicMeterPerHour =        new(VolumeUnit.CubicMeter, DurationUnit.Hour);
        public static readonly VolumeFlowUnit CubicMeterPerMinute =      new(VolumeUnit.CubicMeter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicMeterPerSecond =      new(VolumeUnit.CubicMeter, DurationUnit.Second);
        public static readonly VolumeFlowUnit SI =                       new(VolumeUnit.SI, DurationUnit.SI);

        public static readonly VolumeFlowUnit CubicMillimeterPerSecond = new(VolumeUnit.CubicMillimeter, DurationUnit.Second);
        public static readonly VolumeFlowUnit CubicYardPerDay =          new(VolumeUnit.CubicYard, DurationUnit.Day);
        public static readonly VolumeFlowUnit CubicYardPerHour =         new(VolumeUnit.CubicYard, DurationUnit.Hour);
        public static readonly VolumeFlowUnit CubicYardPerMinute =       new(VolumeUnit.CubicYard, DurationUnit.Minute);
        public static readonly VolumeFlowUnit CubicYardPerSecond =       new(VolumeUnit.CubicYard, DurationUnit.Second);
        public static readonly VolumeFlowUnit DeciliterPerDay =          new(VolumeUnit.Deciliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit DeciliterPerMinute =       new(VolumeUnit.Deciliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit DeciliterPerSecond =       new(VolumeUnit.Deciliter, DurationUnit.Second);
        public static readonly VolumeFlowUnit KiloliterPerDay =          new(VolumeUnit.Kiloliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit KiloliterPerMinute =       new(VolumeUnit.Kiloliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit KiloliterPerSecond =       new(VolumeUnit.Kiloliter, DurationUnit.Second);

        public static readonly VolumeFlowUnit KilousGallonPerMinute =    new(VolumeUnit.KilousGallon, DurationUnit.Minute);

        public static readonly VolumeFlowUnit LiterPerDay =              new(VolumeUnit.Liter, DurationUnit.Day);
        public static readonly VolumeFlowUnit LiterPerHour =             new(VolumeUnit.Liter, DurationUnit.Hour);
        public static readonly VolumeFlowUnit LiterPerMinute =           new(VolumeUnit.Liter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit LiterPerSecond =           new(VolumeUnit.Liter, DurationUnit.Second);
        public static readonly VolumeFlowUnit MegaliterPerDay =          new(VolumeUnit.Megaliter, DurationUnit.Day);

        public static readonly VolumeFlowUnit MicroliterPerDay =         new(VolumeUnit.Microliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit MicroliterPerMinute =      new(VolumeUnit.Microliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit MicroliterPerSecond =      new(VolumeUnit.Microliter, DurationUnit.Second);
        public static readonly VolumeFlowUnit MilliliterPerDay =         new(VolumeUnit.Milliliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit MilliliterPerMinute =      new(VolumeUnit.Milliliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit MilliliterPerSecond =      new(VolumeUnit.Milliliter, DurationUnit.Second);
        public static readonly VolumeFlowUnit MillionUsGallonsPerDay =   new(VolumeUnit.UsGallon, DurationUnit.Day, "MGD", 1000000);
  
        public static readonly VolumeFlowUnit NanoliterPerDay =          new(VolumeUnit.Nanoliter, DurationUnit.Day);
        public static readonly VolumeFlowUnit NanoliterPerMinute =       new(VolumeUnit.Nanoliter, DurationUnit.Minute);
        public static readonly VolumeFlowUnit NanoliterPerSecond =       new(VolumeUnit.Nanoliter, DurationUnit.Second);

        public static readonly VolumeFlowUnit OilBarrelPerDay =          new(VolumeUnit.OilBarrel, DurationUnit.Day);
        public static readonly VolumeFlowUnit OilBarrelPerHour =         new(VolumeUnit.OilBarrel, DurationUnit.Hour);
        public static readonly VolumeFlowUnit OilBarrelPerMinute =       new(VolumeUnit.OilBarrel, DurationUnit.Minute);
        public static readonly VolumeFlowUnit OilBarrelPerSecond =       new(VolumeUnit.OilBarrel, DurationUnit.Second);
        public static readonly VolumeFlowUnit UkGallonPerDay =           new(VolumeUnit.ImperialGallon, DurationUnit.Day, "gal (U. K.)/d");
        public static readonly VolumeFlowUnit UkGallonPerHour =          new(VolumeUnit.ImperialGallon, DurationUnit.Hour);
        public static readonly VolumeFlowUnit UkGallonPerMinute =        new(VolumeUnit.ImperialGallon, DurationUnit.Minute);
        public static readonly VolumeFlowUnit UkGallonPerSecond =        new(VolumeUnit.ImperialGallon, DurationUnit.Second);
        public static readonly VolumeFlowUnit UsGallonPerDay =           new(VolumeUnit.UsGallon, DurationUnit.Day, "gpd");
        public static readonly VolumeFlowUnit UsGallonPerHour =          new(VolumeUnit.UsGallon, DurationUnit.Hour);
        public static readonly VolumeFlowUnit UsGallonPerMinute =        new(VolumeUnit.UsGallon, DurationUnit.Minute);
        public static readonly VolumeFlowUnit UsGallonPerSecond =        new(VolumeUnit.UsGallon, DurationUnit.Second);

        public static readonly VolumeFlowUnit MegaukGallonPerSecond =    new(PreFix.mega, UkGallonPerSecond);



        public VolumeFlowUnit(VolumeUnit volume,DurationUnit duration, decimal correction = 1)
        {
            Unit = new UnitSystem((volume / duration)  * correction, 
                                $"{volume}/{duration}");
        }

        public VolumeFlowUnit(VolumeUnit volume, DurationUnit duration, string NewSymbol, decimal correction = 1)
        {
            Unit = new UnitSystem((volume / duration) * correction,
                                  NewSymbol);
        }


        public VolumeFlowUnit(PreFix SI, VolumeFlowUnit unit) : base(SI, unit) {}
    }
}
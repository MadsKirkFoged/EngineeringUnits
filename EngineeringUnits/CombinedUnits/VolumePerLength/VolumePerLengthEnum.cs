using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VolumePerLengthUnit : Enumeration
    {

        public static readonly VolumePerLengthUnit SI = new VolumePerLengthUnit(VolumeUnit.CubicMeter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit CubicMeterPerMeter = new VolumePerLengthUnit(VolumeUnit.CubicMeter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit CubicYardPerFoot = new VolumePerLengthUnit(VolumeUnit.CubicYard, LengthUnit.Foot);
        public static readonly VolumePerLengthUnit CubicYardPerUsSurveyFoot = new VolumePerLengthUnit(VolumeUnit.CubicYard, LengthUnit.UsSurveyFoot);
        public static readonly VolumePerLengthUnit LiterPerKilometer = new VolumePerLengthUnit(VolumeUnit.Liter, LengthUnit.Kilometer);
        public static readonly VolumePerLengthUnit LiterPerMeter = new VolumePerLengthUnit(VolumeUnit.Liter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit LiterPerMillimeter = new VolumePerLengthUnit(VolumeUnit.Liter, LengthUnit.Millimeter);
        public static readonly VolumePerLengthUnit OilBarrelPerFoot = new VolumePerLengthUnit(VolumeUnit.OilBarrel, LengthUnit.Foot);




        public VolumePerLengthUnit(VolumeUnit volume, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = volume / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{volume}/{Length}");
        }

      

    }




}
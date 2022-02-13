using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class VolumePerLengthUnit : Enumeration
    {

        public static readonly VolumePerLengthUnit SI = new(VolumeUnit.SI, LengthUnit.SI);
        public static readonly VolumePerLengthUnit CubicMeterPerMeter = new(VolumeUnit.CubicMeter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit CubicYardPerFoot = new(VolumeUnit.CubicYard, LengthUnit.Foot);
        public static readonly VolumePerLengthUnit CubicYardPerUsSurveyFoot = new(VolumeUnit.CubicYard, LengthUnit.UsSurveyFoot);
        public static readonly VolumePerLengthUnit LiterPerKilometer = new(VolumeUnit.Liter, LengthUnit.Kilometer);
        public static readonly VolumePerLengthUnit LiterPerMeter = new(VolumeUnit.Liter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit LiterPerMillimeter = new(VolumeUnit.Liter, LengthUnit.Millimeter);
        public static readonly VolumePerLengthUnit OilBarrelPerFoot = new(VolumeUnit.OilBarrel, LengthUnit.Foot);




        public VolumePerLengthUnit(VolumeUnit volume, LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = volume / Length;
            SetNewSymbol(NewSymbol, $"{volume}/{Length}");
        }

      

    }




}
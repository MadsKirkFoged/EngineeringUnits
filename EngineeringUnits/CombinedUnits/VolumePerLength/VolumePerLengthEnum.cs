using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record VolumePerLengthUnit : UnitTypebase
    {

        public static readonly VolumePerLengthUnit SI = new(VolumeUnit.SI, LengthUnit.SI);
        public static readonly VolumePerLengthUnit CubicMeterPerMeter = new(VolumeUnit.CubicMeter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit CubicYardPerFoot = new(VolumeUnit.CubicYard, LengthUnit.Foot);
        public static readonly VolumePerLengthUnit CubicYardPerUsSurveyFoot = new(VolumeUnit.CubicYard, LengthUnit.UsSurveyFoot);
        public static readonly VolumePerLengthUnit LiterPerKilometer = new(VolumeUnit.Liter, LengthUnit.Kilometer);
        public static readonly VolumePerLengthUnit LiterPerMeter = new(VolumeUnit.Liter, LengthUnit.Meter);
        public static readonly VolumePerLengthUnit LiterPerMillimeter = new(VolumeUnit.Liter, LengthUnit.Millimeter);
        public static readonly VolumePerLengthUnit OilBarrelPerFoot = new(VolumeUnit.OilBarrel, LengthUnit.Foot);




        public VolumePerLengthUnit(VolumeUnit volume, LengthUnit Length)
        {
            Unit = new UnitSystem(volume / Length,
                               $"{volume}/{Length}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
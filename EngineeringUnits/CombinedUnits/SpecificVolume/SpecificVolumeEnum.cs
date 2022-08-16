using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record SpecificVolumeUnit : UnitTypebase
    {
        public static readonly SpecificVolumeUnit SI = new SpecificVolumeUnit(VolumeUnit.SI, MassUnit.SI);
        public static readonly SpecificVolumeUnit CubicMeterPerKilogram = new SpecificVolumeUnit(VolumeUnit.CubicMeter, MassUnit.Kilogram);

        public SpecificVolumeUnit(VolumeUnit volume, MassUnit mass)
        {
            base.Unit = new UnitSystem(volume / mass, $"{volume}/{mass}");
        }

        public SpecificVolumeUnit(VolumeUnit volume, MassUnit mass, string NewSymbol)
        {
            base.Unit = new UnitSystem(volume / mass, NewSymbol);
        }

        public override string ToString()
        {
            if (base.Unit.Symbol != null)
            {
                return base.Unit.Symbol ?? "";
            }

            return $"{base.Unit}";
        }


    }




}
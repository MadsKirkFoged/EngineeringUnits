using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class FuelEfficiencyUnit : Enumeration
    {

        public static readonly FuelEfficiencyUnit SI = new FuelEfficiencyUnit(LengthUnit.SI, VolumeUnit.SI);
        public static readonly FuelEfficiencyUnit KilometerPerLiter = new FuelEfficiencyUnit(LengthUnit.Kilometer, VolumeUnit.Liter);
        //public static readonly FuelEfficiencyUnit LiterPer100Kilometers = new FuelEfficiencyUnit(LengthUnit.Kilometer, VolumeUnit.Liter);
        public static readonly FuelEfficiencyUnit MilePerUkGallon = new FuelEfficiencyUnit(LengthUnit.Mile, VolumeUnit.ImperialGallon, "mpg (imp.)");
        public static readonly FuelEfficiencyUnit MilePerUsGallon = new FuelEfficiencyUnit(LengthUnit.Mile, VolumeUnit.UsGallon, "mpg (U.S.)");


        public FuelEfficiencyUnit(LengthUnit Length, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length / volume;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Length}/{volume}");
        }

    

    }




}
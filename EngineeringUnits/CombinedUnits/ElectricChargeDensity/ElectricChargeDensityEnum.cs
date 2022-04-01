using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record ElectricChargeDensityUnit : UnitTypebase
    {

        public static readonly ElectricChargeDensityUnit SI = new(ElectricChargeUnit.SI, VolumeUnit.SI);
        public static readonly ElectricChargeDensityUnit CoulombPerCubicMeter = new(ElectricChargeUnit.Coulomb, VolumeUnit.CubicMeter);




        public ElectricChargeDensityUnit(ElectricChargeUnit electricCharge, VolumeUnit volume)
        {
            Unit = new UnitSystem(electricCharge / volume, 
                               $"{electricCharge}/{volume}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
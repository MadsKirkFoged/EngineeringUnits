using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricChargeDensityUnit : Enumeration
    {

        public static readonly ElectricChargeDensityUnit SI = new ElectricChargeDensityUnit(ElectricChargeUnit.Coulomb, VolumeUnit.CubicMeter);
        public static readonly ElectricChargeDensityUnit CoulombPerCubicMeter = new ElectricChargeDensityUnit(ElectricChargeUnit.Coulomb, VolumeUnit.CubicMeter);




        public ElectricChargeDensityUnit(ElectricChargeUnit electricCharge, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCharge / volume;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricCharge}/{volume}");
        }

      

    }




}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricChargeDensityUnit : Enumeration
    {

        public static readonly ElectricChargeDensityUnit SI = new ElectricChargeDensityUnit(ElectricChargeUnit.Coulomb, VolumeUnit.CubicMeter);
        public static readonly ElectricChargeDensityUnit CoulombPerCubicMeter = new ElectricChargeDensityUnit(ElectricChargeUnit.Coulomb, VolumeUnit.CubicMeter);




        public ElectricChargeDensityUnit(ElectricChargeUnit electricCharge, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCharge.Unit / volume.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricCharge}/{volume}");
        }

      

    }




}
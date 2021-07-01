using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricSurfaceChargeDensityUnit : Enumeration
    {

        public static readonly ElectricSurfaceChargeDensityUnit SI = new ElectricSurfaceChargeDensityUnit(LengthUnit.Meter);
        public static readonly ElectricSurfaceChargeDensityUnit CubicMeter = new ElectricSurfaceChargeDensityUnit(LengthUnit.Meter);
        public static readonly ElectricSurfaceChargeDensityUnit HectocubicMeter = new ElectricSurfaceChargeDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricSurfaceChargeDensityUnit KilocubicMeter = new ElectricSurfaceChargeDensityUnit(PreFix.kilo, CubicMeter);



        public ElectricSurfaceChargeDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricSurfaceChargeDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricSurfaceChargeDensityUnit(PreFix SI, ElectricSurfaceChargeDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricSurfaceChargeDensityUnit(ElectricSurfaceChargeDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}
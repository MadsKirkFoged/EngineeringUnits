using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricChargeDensityUnit : Enumeration
    {

        public static readonly ElectricChargeDensityUnit SI = new ElectricChargeDensityUnit(LengthUnit.Meter);
        public static readonly ElectricChargeDensityUnit CubicMeter = new ElectricChargeDensityUnit(LengthUnit.Meter);
        public static readonly ElectricChargeDensityUnit HectocubicMeter = new ElectricChargeDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricChargeDensityUnit KilocubicMeter = new ElectricChargeDensityUnit(PreFix.kilo, CubicMeter);



        public ElectricChargeDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricChargeDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricChargeDensityUnit(PreFix SI, ElectricChargeDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricChargeDensityUnit(ElectricChargeDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}
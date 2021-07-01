using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MolarEnergyUnit : Enumeration
    {

        public static readonly MolarEnergyUnit SI = new MolarEnergyUnit(LengthUnit.Meter);
        public static readonly MolarEnergyUnit CubicMeter = new MolarEnergyUnit(LengthUnit.Meter);
        public static readonly MolarEnergyUnit HectocubicMeter = new MolarEnergyUnit(PreFix.hecto, CubicMeter);
        public static readonly MolarEnergyUnit KilocubicMeter = new MolarEnergyUnit(PreFix.kilo, CubicMeter);



        public MolarEnergyUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MolarEnergyUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MolarEnergyUnit(PreFix SI, MolarEnergyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MolarEnergyUnit(MolarEnergyUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}
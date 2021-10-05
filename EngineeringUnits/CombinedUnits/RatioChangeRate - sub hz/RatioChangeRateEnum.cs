using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class RatioChangeRateUnit : Enumeration
    {

        public static readonly RatioChangeRateUnit SI = new(LengthUnit.SI);
        public static readonly RatioChangeRateUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly RatioChangeRateUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly RatioChangeRateUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public RatioChangeRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RatioChangeRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RatioChangeRateUnit(PreFix SI, RatioChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RatioChangeRateUnit(RatioChangeRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RatioUnit : Enumeration
    {

        public static readonly RatioUnit SI = new RatioUnit();
        public static readonly RatioUnit DecimalFraction = new RatioUnit();
        public static readonly RatioUnit PartPerBillion = new RatioUnit("ppb", 1/1e9m);
        public static readonly RatioUnit PartPerMillion = new RatioUnit("ppm", 1 / 1e6m);
        public static readonly RatioUnit PartPerThousand = new RatioUnit("‰", 1 / 1e3m);
        public static readonly RatioUnit PartPerTrillion = new RatioUnit("ppt", 1 / 1e12m);
        public static readonly RatioUnit Percent = new RatioUnit("%", 1 / 1e2m);




        //public static readonly RatioUnit HectocubicMeter = new RatioUnit(PreFix.hecto, CubicMeter);




        public RatioUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RatioUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RatioUnit(PreFix SI, RatioUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RatioUnit(RatioUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}
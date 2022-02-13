using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class PowerRatioUnit : Enumeration
    {

        public static readonly PowerRatioUnit SI = new(LengthUnit.SI);
        public static readonly PowerRatioUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly PowerRatioUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly PowerRatioUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public PowerRatioUnit(LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetNewSymbol(NewSymbol);
        }

        public PowerRatioUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Area.Unit * Length.Unit;
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public PowerRatioUnit(PreFix SI, PowerRatioUnit unit) : base(SI, unit)
        {
        }

      

    }




}
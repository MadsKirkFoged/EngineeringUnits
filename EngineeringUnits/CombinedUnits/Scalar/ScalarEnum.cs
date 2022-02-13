using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ScalarUnit : Enumeration
    {

        public static readonly ScalarUnit SI = new(LengthUnit.SI);
        public static readonly ScalarUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly ScalarUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly ScalarUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public ScalarUnit(LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Length.Pow(3);
            SetNewSymbol(NewSymbol);
        }

        public ScalarUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Area * Length;
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ScalarUnit(PreFix SI, ScalarUnit unit) : base(SI, unit)
        {
        }

        public ScalarUnit(ScalarUnit unit, string NewSymbol = "Empty")
        {
            Unit = unit.Unit.Copy();
            SetNewSymbol(NewSymbol);
        }

    }




}
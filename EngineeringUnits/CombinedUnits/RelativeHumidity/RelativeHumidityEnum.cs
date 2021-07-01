using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RelativeHumidityUnit : Enumeration
    {

        public static readonly RelativeHumidityUnit SI = new RelativeHumidityUnit(LengthUnit.Meter);
        public static readonly RelativeHumidityUnit CubicMeter = new RelativeHumidityUnit(LengthUnit.Meter);
        public static readonly RelativeHumidityUnit HectocubicMeter = new RelativeHumidityUnit(PreFix.hecto, CubicMeter);
        public static readonly RelativeHumidityUnit KilocubicMeter = new RelativeHumidityUnit(PreFix.kilo, CubicMeter);



        public RelativeHumidityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RelativeHumidityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RelativeHumidityUnit(PreFix SI, RelativeHumidityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RelativeHumidityUnit(RelativeHumidityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}
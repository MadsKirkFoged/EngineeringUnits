using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class testUnit : Enumeration
    {

        public static testUnit SI = new testUnit(LengthUnit.Meter);
        public static testUnit CubicMeter = new testUnit(LengthUnit.Meter);
        public static testUnit HectocubicMeter = new testUnit(PreFix.hecto, CubicMeter);
        public static testUnit KilocubicMeter = new testUnit(PreFix.kilo, CubicMeter);







        public testUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "test";
            Unit = Length.Unit * Length.Unit * Length.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

        public testUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "test";
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public testUnit(PreFix SI, testUnit unit)
        {
            //Name = "test";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public testUnit(testUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "test";
            Unit = unit.Unit.Copy();

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public static IEnumerable<testUnit> List()
        {
            return new[] { SI };
        }





    }




}
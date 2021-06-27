using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class DynamicViscosityUnit : Enumeration
    {

        public static DynamicViscosityUnit SI = new DynamicViscosityUnit(PressureUnit.Pascal, DurationUnit.Second);

        public static DynamicViscosityUnit PascalSecond = new DynamicViscosityUnit(PressureUnit.Pascal, DurationUnit.Second);
        public static DynamicViscosityUnit MicropascalSecond = new DynamicViscosityUnit(PreFix.micro, PascalSecond);
        public static DynamicViscosityUnit MillipascalSecond = new DynamicViscosityUnit(PreFix.milli, PascalSecond);


        public static DynamicViscosityUnit PoundPerFootSecond = new DynamicViscosityUnit(MassUnit.Pound, LengthUnit.Foot, DurationUnit.Second);
        public static DynamicViscosityUnit Poise = new DynamicViscosityUnit(MassUnit.Gram, LengthUnit.Centimeter, DurationUnit.Second, "P");
        public static DynamicViscosityUnit Centipoise = new DynamicViscosityUnit(PreFix.centi, Poise);


        public static DynamicViscosityUnit NewtonSecondPerMeterSquared = new DynamicViscosityUnit(ForceUnit.Newton, DurationUnit.Second, AreaUnit.SI);
        public static DynamicViscosityUnit PoundForceSecondPerSquareFoot = new DynamicViscosityUnit(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareFoot);
        public static DynamicViscosityUnit PoundForceSecondPerSquareInch = new DynamicViscosityUnit(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareInch);

        public static DynamicViscosityUnit Reyn = new DynamicViscosityUnit(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareInch, "reyn");
        //public static DynamicViscosityUnit Reyn = new DynamicViscosityUnit(PressureUnit.Pascal, DurationUnit.Second, "reyn", 6.8947572931683613e3m);


        public DynamicViscosityUnit(PressureUnit Pressure, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "DynamicViscosity";
            Unit = Pressure.Unit * duration.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
            SetNewSymbol(NewSymbol, $"{Pressure}·{duration}");



        }

        public DynamicViscosityUnit(ForceUnit force, DurationUnit duration, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "DynamicViscosity";
            Unit = (force.Unit * duration.Unit) / area.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}·{duration}/{area}");
        }

        public DynamicViscosityUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "DynamicViscosity";
            Unit = mass.Unit /(  duration.Unit * length.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{length}·{duration}");
        }



        public DynamicViscosityUnit(PreFix SI, DynamicViscosityUnit unit)
        {
            //Name = "DynamicViscosity";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public DynamicViscosityUnit(DynamicViscosityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "DynamicViscosity";
            Unit = unit.Unit.Copy();

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public static IEnumerable<DynamicViscosityUnit> List()
        {
            return new[] { Centipoise, MicropascalSecond, MillipascalSecond, NewtonSecondPerMeterSquared, PascalSecond, Poise, PoundForceSecondPerSquareFoot, PoundForceSecondPerSquareInch, PoundPerFootSecond, Reyn, };
        }





    }




}
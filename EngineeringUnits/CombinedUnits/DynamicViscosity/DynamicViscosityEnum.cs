using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class DynamicViscosityUnit : Enumeration
    {

        public static readonly DynamicViscosityUnit SI =                             new(PressureUnit.SI, DurationUnit.SI);
        public static readonly DynamicViscosityUnit PascalSecond =                   new(PressureUnit.Pascal, DurationUnit.Second);
        public static readonly DynamicViscosityUnit MicropascalSecond =              new(PreFix.micro, PascalSecond);
        public static readonly DynamicViscosityUnit MillipascalSecond =              new(PreFix.milli, PascalSecond);
        public static readonly DynamicViscosityUnit PoundPerFootSecond =             new(MassUnit.Pound, LengthUnit.Foot, DurationUnit.Second);
        public static readonly DynamicViscosityUnit Poise =                          new(MassUnit.Gram, LengthUnit.Centimeter, DurationUnit.Second, "P");
        public static readonly DynamicViscosityUnit Centipoise =                     new(PreFix.centi, Poise);
        public static readonly DynamicViscosityUnit NewtonSecondPerMeterSquared =    new(ForceUnit.Newton, DurationUnit.Second, AreaUnit.SI);
        public static readonly DynamicViscosityUnit PoundForceSecondPerSquareFoot =  new(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareFoot);
        public static readonly DynamicViscosityUnit PoundForceSecondPerSquareInch =  new(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareInch);
        public static readonly DynamicViscosityUnit Reyn =                           new(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareInch, "reyn");



        public DynamicViscosityUnit(PressureUnit Pressure, DurationUnit duration, string NewSymbol = "Empty")
        {
            Unit = Pressure * duration;

            SetNewSymbol(NewSymbol);
            SetNewSymbol(NewSymbol, $"{Pressure}·{duration}");
        }

        public DynamicViscosityUnit(ForceUnit force, DurationUnit duration, AreaUnit area, string NewSymbol = "Empty")
        {
            Unit = (force * duration) / area;
            SetNewSymbol(NewSymbol, $"{force}·{duration}/{area}");
        }

        public DynamicViscosityUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol = "Empty")
        {
            Unit = mass /(  duration * length);
            SetNewSymbol(NewSymbol, $"{mass}/{length}·{duration}");
        }


        public DynamicViscosityUnit(PreFix SI, DynamicViscosityUnit unit)
        {
            Unit = unit.Unit.Copy() * PrefixSISize(SI);
            //SetCombined(SI);
            SetNewSymbol(SI);
        }

       


    }




}
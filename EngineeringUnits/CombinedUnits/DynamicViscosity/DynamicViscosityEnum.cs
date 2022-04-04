using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record DynamicViscosityUnit : UnitTypebase
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



        public DynamicViscosityUnit(PressureUnit Pressure, DurationUnit duration)
        {
            Unit = new UnitSystem(Pressure * duration, 
                               $"{Pressure}·{duration}");
        }

        public DynamicViscosityUnit(ForceUnit force, DurationUnit duration, AreaUnit area)
        {
            Unit = new UnitSystem((force * duration)/ area, 
                                $"{force}·{duration}/{area}");
        }

        public DynamicViscosityUnit(ForceUnit force, DurationUnit duration, AreaUnit area, string NewSymbol)
        {
            Unit = new UnitSystem((force * duration) / area, NewSymbol);
        }

        public DynamicViscosityUnit(MassUnit mass, LengthUnit length, DurationUnit duration)
        {
            Unit = new UnitSystem(mass /(length * duration), 
                               $"{mass}/{length}·{duration}");
        }

        public DynamicViscosityUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol)
        {
            Unit = new UnitSystem(mass / (length * duration), NewSymbol);
        }


        public DynamicViscosityUnit(PreFix SI, DynamicViscosityUnit unit) : base(SI, unit) {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }


    }




}
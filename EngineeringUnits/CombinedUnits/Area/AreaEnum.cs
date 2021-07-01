using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public class AreaUnit : Enumeration
    {

        public static readonly AreaUnit Acre                 = new AreaUnit(LengthUnit.Chain, "ac", 10);
        public static readonly AreaUnit Hectare              = new AreaUnit(LengthUnit.Hectometer, "ha");
        public static readonly AreaUnit SquareCentimeter     = new AreaUnit(LengthUnit.Centimeter);
        public static readonly AreaUnit SquareDecimeter      = new AreaUnit(LengthUnit.Decimeter);
        public static readonly AreaUnit SquareKilometer      = new AreaUnit(LengthUnit.Kilometer);
        public static readonly AreaUnit SquareMeter          = new AreaUnit(LengthUnit.Meter);
        public static readonly AreaUnit SquareMicrometer     = new AreaUnit(LengthUnit.Micrometer);
        public static readonly AreaUnit SI                   = new AreaUnit(LengthUnit.SI);
        public static readonly AreaUnit SquareMillimeter     = new AreaUnit(LengthUnit.Millimeter);
        public static readonly AreaUnit SquareNanometer      = new AreaUnit(LengthUnit.Nanometer);
        public static readonly AreaUnit SquareInch           = new AreaUnit(LengthUnit.Inch);
        public static readonly AreaUnit SquareFoot           = new AreaUnit(LengthUnit.Foot);
        public static readonly AreaUnit SquareYard           = new AreaUnit(LengthUnit.Yard);
        public static readonly AreaUnit SquareMile           = new AreaUnit(LengthUnit.Mile);
        public static readonly AreaUnit SquareNauticalMile   = new AreaUnit(LengthUnit.NauticalMile, "nmi²"); //TODO Length and Area have diff naming




        public AreaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }     

    }
}
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AreaUnit : Enumeration
    {

        public static readonly AreaUnit Acre                 = new(LengthUnit.Chain, "ac", 10);
        public static readonly AreaUnit Hectare              = new(LengthUnit.Hectometer, "ha");
        public static readonly AreaUnit SquareCentimeter     = new(LengthUnit.Centimeter);
        public static readonly AreaUnit SquareDecimeter      = new(LengthUnit.Decimeter);
        public static readonly AreaUnit SquareKilometer      = new(LengthUnit.Kilometer);
        public static readonly AreaUnit SquareMeter          = new(LengthUnit.Meter);
        public static readonly AreaUnit SquareMicrometer     = new(LengthUnit.Micrometer);
        public static readonly AreaUnit SI                   = new(LengthUnit.SI);
        public static readonly AreaUnit SquareMillimeter     = new(LengthUnit.Millimeter);
        public static readonly AreaUnit SquareNanometer      = new(LengthUnit.Nanometer);
        public static readonly AreaUnit SquareInch           = new(LengthUnit.Inch);
        public static readonly AreaUnit SquareFoot           = new(LengthUnit.Foot);
        public static readonly AreaUnit SquareYard           = new(LengthUnit.Yard);
        public static readonly AreaUnit SquareMile           = new(LengthUnit.Mile);
        public static readonly AreaUnit SquareNauticalMile   = new(LengthUnit.NauticalMile, "nmi²"); //TODO Length and Area have diff naming

        public static readonly AreaUnit SquareChain          = new(LengthUnit.Chain);




        public AreaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(2);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }     

    }
}
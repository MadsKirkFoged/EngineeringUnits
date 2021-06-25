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

        public static AreaUnit Acre                 = new AreaUnit(LengthUnit.Chain, "ac", 10);
        public static AreaUnit Hectare              = new AreaUnit(LengthUnit.Hectometer, "ha");
        public static AreaUnit SquareCentimeter     = new AreaUnit(LengthUnit.Centimeter);
        public static AreaUnit SquareDecimeter      = new AreaUnit(LengthUnit.Decimeter);
        public static AreaUnit SquareKilometer      = new AreaUnit(LengthUnit.Kilometer);
        public static AreaUnit SquareMeter          = new AreaUnit(LengthUnit.Meter);
        public static AreaUnit SquareMicrometer     = new AreaUnit(LengthUnit.Micrometer);
        public static AreaUnit SI                   = new AreaUnit(LengthUnit.SI);
        public static AreaUnit SquareMillimeter     = new AreaUnit(LengthUnit.Millimeter);
        public static AreaUnit SquareNanometer      = new AreaUnit(LengthUnit.Nanometer);
        public static AreaUnit SquareInch           = new AreaUnit(LengthUnit.Inch);
        public static AreaUnit SquareFoot           = new AreaUnit(LengthUnit.Foot);
        public static AreaUnit SquareYard           = new AreaUnit(LengthUnit.Yard);
        public static AreaUnit SquareMile           = new AreaUnit(LengthUnit.Mile);
        public static AreaUnit SquareNauticalMile   = new AreaUnit(LengthUnit.NauticalMile);




        public AreaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "Area";
            Unit = Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }



        public static IEnumerable<AreaUnit> List()
        {
            return new[] { 
                Acre,
                Hectare,
                SquareCentimeter,
                SquareDecimeter,
                SquareFoot,
                SquareInch,
                SquareKilometer,
                SquareMeter,
                SquareMicrometer,
                SquareMile,
                SquareMillimeter,
                SquareNauticalMile,
                SquareYard, 
            };
        }

        public static List<AreaUnit> ListOf()
        {
            List<AreaUnit> local = new List<AreaUnit>();

            foreach (var field in typeof(AreaUnit).GetFields(BindingFlags.Static | BindingFlags.Public))
            {

                AreaUnit localunit = (AreaUnit)field.GetValue(field);
                localunit.NameOf = field.Name;


                local.Add(localunit);

            }


            return local;
        }


    }




}
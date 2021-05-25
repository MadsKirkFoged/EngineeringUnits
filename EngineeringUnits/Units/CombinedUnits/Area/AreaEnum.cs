using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AreaUnit : Enumeration
    {


        public static AreaUnit SI = new AreaUnit(LengthUnit.SI);
        public static AreaUnit Yard2 = new AreaUnit(LengthUnit.Yard);


        public UnitSystem Unit { get; set; }


        public AreaUnit(LengthUnit length)
        {
            Name = "Area";

            Unit = new UnitSystem();

            Unit.Length = length;
            Unit.Length.Count = 2;

            A1 = Unit.SumOfA1ConstantsWithPow();
            A2 = Unit.SumOfA2ConstantsWithPow();
            B = Unit.SumOfBConstants();


        }



        protected AreaUnit() { }


        public AreaUnit(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
            Count = 1;

        }


        public AreaUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
            Count = 1;
        }


        //public static IEnumerable<LengthUnit> List()
        //{
        //    return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        //}
        // Other util methods


        public AreaUnit Copy()
        {

            AreaUnit local = new AreaUnit();


            local.Name = Name;
            local.Symbol = Symbol;
            local.A1 = A1;
            local.A2 = A2;
            local.B = B;
            local.Count = Count;
            local.ReversedA = ReversedA;

            return local;
        }


    }




}
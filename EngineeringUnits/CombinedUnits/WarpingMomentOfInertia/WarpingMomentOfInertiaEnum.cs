﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record WarpingMomentOfInertiaUnit : UnitTypebase
    {

        public static readonly WarpingMomentOfInertiaUnit MeterToTheSixth = new(LengthUnit.Meter);
        public static readonly WarpingMomentOfInertiaUnit MillimeterToTheSixth = new(LengthUnit.Millimeter);
        public static readonly WarpingMomentOfInertiaUnit InchToTheSixth = new(LengthUnit.Inch);
        public static readonly WarpingMomentOfInertiaUnit FootToTheSixth = new(LengthUnit.Foot);
        public static readonly WarpingMomentOfInertiaUnit DecimeterToTheSixth = new(LengthUnit.Decimeter);
        public static readonly WarpingMomentOfInertiaUnit CentimeterToTheSixth = new(LengthUnit.Centimeter);

        public static readonly WarpingMomentOfInertiaUnit SI = new(LengthUnit.SI);


        public WarpingMomentOfInertiaUnit(LengthUnit Length)
        {
            Unit = Length.Pow(6);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}
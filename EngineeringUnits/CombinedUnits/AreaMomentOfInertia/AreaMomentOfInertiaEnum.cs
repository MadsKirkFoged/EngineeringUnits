﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AreaMomentOfInertiaUnit : Enumeration
    {

        public static readonly AreaMomentOfInertiaUnit SI = new(LengthUnit.SI);
        public static readonly AreaMomentOfInertiaUnit MeterToTheFourth = new(LengthUnit.Meter);
        public static readonly AreaMomentOfInertiaUnit CentimeterToTheFourth = new(LengthUnit.Centimeter);
        public static readonly AreaMomentOfInertiaUnit DecimeterToTheFourth = new(LengthUnit.Decimeter);
        public static readonly AreaMomentOfInertiaUnit MillimeterToTheFourth = new(LengthUnit.Millimeter);


        public static readonly AreaMomentOfInertiaUnit InchToTheFourth = new(LengthUnit.Inch);
        public static readonly AreaMomentOfInertiaUnit FootToTheFourth = new(LengthUnit.Foot);



        public AreaMomentOfInertiaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(4);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }     

        public AreaMomentOfInertiaUnit(PreFix SI, AreaMomentOfInertiaUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }




}
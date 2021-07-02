using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AreaMomentOfInertiaUnit : Enumeration
    {

        public static readonly AreaMomentOfInertiaUnit SI = new AreaMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly AreaMomentOfInertiaUnit MeterToTheFourth = new AreaMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly AreaMomentOfInertiaUnit CentimeterToTheFourth = new AreaMomentOfInertiaUnit(LengthUnit.Centimeter);
        public static readonly AreaMomentOfInertiaUnit DecimeterToTheFourth = new AreaMomentOfInertiaUnit(LengthUnit.Decimeter);
        public static readonly AreaMomentOfInertiaUnit MillimeterToTheFourth = new AreaMomentOfInertiaUnit(LengthUnit.Millimeter);


        public static readonly AreaMomentOfInertiaUnit InchToTheFourth = new AreaMomentOfInertiaUnit(LengthUnit.Inch);
        public static readonly AreaMomentOfInertiaUnit FootToTheFourth = new AreaMomentOfInertiaUnit(LengthUnit.Foot);



        public AreaMomentOfInertiaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit * Length.Unit;
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
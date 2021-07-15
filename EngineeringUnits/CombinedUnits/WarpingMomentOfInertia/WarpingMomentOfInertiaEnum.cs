using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class WarpingMomentOfInertiaUnit : Enumeration
    {

        public static readonly WarpingMomentOfInertiaUnit MeterToTheSixth = new WarpingMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly WarpingMomentOfInertiaUnit MillimeterToTheSixth = new WarpingMomentOfInertiaUnit(LengthUnit.Millimeter);
        public static readonly WarpingMomentOfInertiaUnit InchToTheSixth = new WarpingMomentOfInertiaUnit(LengthUnit.Inch);
        public static readonly WarpingMomentOfInertiaUnit FootToTheSixth = new WarpingMomentOfInertiaUnit(LengthUnit.Foot);
        public static readonly WarpingMomentOfInertiaUnit DecimeterToTheSixth = new WarpingMomentOfInertiaUnit(LengthUnit.Decimeter);
        public static readonly WarpingMomentOfInertiaUnit CentimeterToTheSixth = new WarpingMomentOfInertiaUnit(LengthUnit.Centimeter);

        public static readonly WarpingMomentOfInertiaUnit SI = new WarpingMomentOfInertiaUnit(LengthUnit.SI);


        public WarpingMomentOfInertiaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            //Unit = Length.Unit * Length.Unit * Length.Unit* Length.Unit * Length.Unit * Length.Unit;
            Unit = Length.Pow(6);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }       

    }




}
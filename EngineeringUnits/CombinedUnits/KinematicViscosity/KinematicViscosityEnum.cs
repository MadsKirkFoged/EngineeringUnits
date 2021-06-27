using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class KinematicViscosityUnit : Enumeration
    {

        public static KinematicViscosityUnit SI = new KinematicViscosityUnit(AreaUnit.SquareMeter, DurationUnit.Second);
        public static KinematicViscosityUnit SquareMeterPerSecond = new KinematicViscosityUnit(AreaUnit.SquareMeter, DurationUnit.Second);

        public static KinematicViscosityUnit Stokes = new KinematicViscosityUnit(AreaUnit.SquareCentimeter, DurationUnit.Second, "St");
        public static KinematicViscosityUnit Centistokes = new KinematicViscosityUnit(PreFix.centi, Stokes);
        public static KinematicViscosityUnit Decistokes = new KinematicViscosityUnit(PreFix.deci, Stokes);
        public static KinematicViscosityUnit Kilostokes = new KinematicViscosityUnit(PreFix.kilo, Stokes);
        public static KinematicViscosityUnit Microstokes = new KinematicViscosityUnit(PreFix.micro, Stokes);
        public static KinematicViscosityUnit Millistokes = new KinematicViscosityUnit(PreFix.milli, Stokes);
        public static KinematicViscosityUnit Nanostokes = new KinematicViscosityUnit(PreFix.nano, Stokes);









        public KinematicViscosityUnit(AreaUnit Length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "KinematicViscosity";
            Unit = Length.Unit / duration.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

     

        public KinematicViscosityUnit(PreFix SI, KinematicViscosityUnit unit)
        {
            //Name = "KinematicViscosity";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }


        public static IEnumerable<KinematicViscosityUnit> List()
        {
            return new[] { Centistokes, Decistokes, Kilostokes, Microstokes, Millistokes, Nanostokes, SquareMeterPerSecond, Stokes, };
        }





    }




}
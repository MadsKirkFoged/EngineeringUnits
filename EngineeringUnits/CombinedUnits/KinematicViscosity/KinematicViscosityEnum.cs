using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class KinematicViscosityUnit : Enumeration
    {

        public static readonly KinematicViscosityUnit SI =                   new KinematicViscosityUnit(AreaUnit.SquareMeter, DurationUnit.Second);
        public static readonly KinematicViscosityUnit SquareMeterPerSecond = new KinematicViscosityUnit(AreaUnit.SquareMeter, DurationUnit.Second);
        public static readonly KinematicViscosityUnit Stokes =               new KinematicViscosityUnit(AreaUnit.SquareCentimeter, DurationUnit.Second, "St");
        public static readonly KinematicViscosityUnit Centistokes =          new KinematicViscosityUnit(PreFix.centi, Stokes);
        public static readonly KinematicViscosityUnit Decistokes =           new KinematicViscosityUnit(PreFix.deci, Stokes);
        public static readonly KinematicViscosityUnit Kilostokes =           new KinematicViscosityUnit(PreFix.kilo, Stokes);
        public static readonly KinematicViscosityUnit Microstokes =          new KinematicViscosityUnit(PreFix.micro, Stokes);
        public static readonly KinematicViscosityUnit Millistokes =          new KinematicViscosityUnit(PreFix.milli, Stokes);
        public static readonly KinematicViscosityUnit Nanostokes =           new KinematicViscosityUnit(PreFix.nano, Stokes);



        public KinematicViscosityUnit(AreaUnit Length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit / duration.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

     

        public KinematicViscosityUnit(PreFix SI, KinematicViscosityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }




}
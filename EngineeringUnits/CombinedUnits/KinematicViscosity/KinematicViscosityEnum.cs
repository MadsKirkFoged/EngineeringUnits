﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class KinematicViscosityUnit : Enumeration
    {

        public static readonly KinematicViscosityUnit SI =                   new(AreaUnit.SI, DurationUnit.SI);
        public static readonly KinematicViscosityUnit SquareMeterPerSecond = new(AreaUnit.SquareMeter, DurationUnit.Second);
        public static readonly KinematicViscosityUnit Stokes =               new(AreaUnit.SquareCentimeter, DurationUnit.Second, "St");
        public static readonly KinematicViscosityUnit Centistokes =          new(PreFix.centi, Stokes);
        public static readonly KinematicViscosityUnit Decistokes =           new(PreFix.deci, Stokes);
        public static readonly KinematicViscosityUnit Kilostokes =           new(PreFix.kilo, Stokes);
        public static readonly KinematicViscosityUnit Microstokes =          new(PreFix.micro, Stokes);
        public static readonly KinematicViscosityUnit Millistokes =          new(PreFix.milli, Stokes);
        public static readonly KinematicViscosityUnit Nanostokes =           new(PreFix.nano, Stokes);



        public KinematicViscosityUnit(AreaUnit Length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length / duration;
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
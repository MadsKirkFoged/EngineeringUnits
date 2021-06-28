﻿using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class KinematicViscosity : BaseUnit
    {

        public KinematicViscosity()
        {
            Name = "KinematicViscosity";
        }

        public KinematicViscosity(decimal value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(double value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(int value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static KinematicViscosity From(double value, KinematicViscosityUnit unit) => new KinematicViscosity(value, unit);
        public double As(KinematicViscosityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public KinematicViscosity ToUnit(KinematicViscosityUnit selectedUnit) => new KinematicViscosity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static KinematicViscosity Zero => new KinematicViscosity(0, KinematicViscosityUnit.SI);

        public static implicit operator KinematicViscosity(UnknownUnit Unit)
        {
            KinematicViscosity local = new KinematicViscosity(0, KinematicViscosityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
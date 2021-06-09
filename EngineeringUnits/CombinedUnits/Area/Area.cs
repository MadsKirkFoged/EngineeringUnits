using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {

        public Area()
        {
            Name = "Area";
        }

        public Area(double value, AreaUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;

            ValueLocalUnit = (decimal)value / (decimal)selectedUnit.Unit.GetActualC();
        }

        public double As(AreaUnit SquaredlengthUnit)
        {
            return (double)ToTheOutSide(SquaredlengthUnit.Unit);
        }

        //Every units needs this
        public static implicit operator Area(UnknownUnit Unit)
        {
            Area local = new Area(0, AreaUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

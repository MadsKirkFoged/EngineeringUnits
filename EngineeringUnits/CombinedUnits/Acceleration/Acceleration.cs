using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Acceleration : BaseUnit
    {

        public Acceleration()
        {
            Name = "Acceleration";
        }

        public Acceleration(decimal value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(double value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(int value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Acceleration From(double value, AccelerationUnit unit) => new Acceleration(value, unit);
        public double As(AccelerationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Acceleration ToUnit(AccelerationUnit selectedUnit) => new Acceleration(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public Acceleration Zero => new Acceleration(0, AccelerationUnit.SI);

        public static implicit operator Acceleration(UnknownUnit Unit)
        {
            Acceleration local = new Acceleration(0, AccelerationUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

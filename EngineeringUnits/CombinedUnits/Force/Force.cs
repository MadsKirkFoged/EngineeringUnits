using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Force : BaseUnit
    {

        public Force()
        {
            Name = "Force";
        }

        public Force(decimal value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(double value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(int value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Force From(double value, ForceUnit unit) => new Force(value, unit);
        public double As(ForceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Force ToUnit(ForceUnit selectedUnit) => new Force(ToTheOutSide(selectedUnit.Unit), selectedUnit);


        public static implicit operator Force(UnknownUnit Unit)
        {
            Force local = new Force(0, ForceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

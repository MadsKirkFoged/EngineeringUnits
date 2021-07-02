using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class AreaMomentOfInertia : BaseUnit
    {

        public AreaMomentOfInertia()
        {
            Unit = AreaMomentOfInertiaUnit.SI.Unit.Copy();
        }

        public AreaMomentOfInertia(decimal value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(double value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(int value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static AreaMomentOfInertia From(double value, AreaMomentOfInertiaUnit unit) => new AreaMomentOfInertia(value, unit);
        public double As(AreaMomentOfInertiaUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public AreaMomentOfInertia ToUnit(AreaMomentOfInertiaUnit selectedUnit) => new AreaMomentOfInertia(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AreaMomentOfInertia Zero => new AreaMomentOfInertia(0, AreaMomentOfInertiaUnit.SI);

        public static implicit operator AreaMomentOfInertia(UnknownUnit Unit)
        {
            AreaMomentOfInertia local = new AreaMomentOfInertia(0, AreaMomentOfInertiaUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

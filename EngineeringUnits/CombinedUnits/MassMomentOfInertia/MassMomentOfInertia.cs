using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MassMomentOfInertia : BaseUnit
    {

        public MassMomentOfInertia()
        {
            Unit = MassMomentOfInertiaUnit.SI.Unit.Copy();
        }

        public MassMomentOfInertia(decimal value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(double value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(int value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static MassMomentOfInertia From(double value, MassMomentOfInertiaUnit unit) => new MassMomentOfInertia(value, unit);
        public double As(MassMomentOfInertiaUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MassMomentOfInertia ToUnit(MassMomentOfInertiaUnit selectedUnit) => new MassMomentOfInertia(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassMomentOfInertia Zero => new MassMomentOfInertia(0, MassMomentOfInertiaUnit.SI);

        public static implicit operator MassMomentOfInertia(UnknownUnit Unit)
        {
            MassMomentOfInertia local = new MassMomentOfInertia(0, MassMomentOfInertiaUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

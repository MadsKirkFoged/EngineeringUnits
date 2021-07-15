using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class WarpingMomentOfInertia : BaseUnit
    {

        public WarpingMomentOfInertia()
        {
            Unit = WarpingMomentOfInertiaUnit.SI.Unit.Copy();
        }

        public WarpingMomentOfInertia(decimal value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(double value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(int value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static WarpingMomentOfInertia From(double value, WarpingMomentOfInertiaUnit unit) => new WarpingMomentOfInertia(value, unit);
        public double As(WarpingMomentOfInertiaUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public WarpingMomentOfInertia ToUnit(WarpingMomentOfInertiaUnit selectedUnit) => new WarpingMomentOfInertia(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static WarpingMomentOfInertia Zero => new WarpingMomentOfInertia(0, WarpingMomentOfInertiaUnit.SI);

        public static implicit operator WarpingMomentOfInertia(UnknownUnit Unit)
        {
            WarpingMomentOfInertia local = new WarpingMomentOfInertia(0, WarpingMomentOfInertiaUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

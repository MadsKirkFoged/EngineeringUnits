using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class WarpingMomentOfInertia : BaseUnit
    {

        public WarpingMomentOfInertia() { }
        public WarpingMomentOfInertia(decimal value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(double value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(int value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(UnknownUnit value) : base(value) { }

        public WarpingMomentOfInertia(UnknownUnit value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static WarpingMomentOfInertia From(double value, WarpingMomentOfInertiaUnit unit) => new(value, unit);
        public double As(WarpingMomentOfInertiaUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public WarpingMomentOfInertia ToUnit(WarpingMomentOfInertiaUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static WarpingMomentOfInertia Zero => new(0, WarpingMomentOfInertiaUnit.SI);

        public static implicit operator WarpingMomentOfInertia(UnknownUnit Unit) => new(Unit, WarpingMomentOfInertiaUnit.SI);




    }
}

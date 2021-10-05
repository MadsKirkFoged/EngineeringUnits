using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MassMomentOfInertia : BaseUnit
    {

        public MassMomentOfInertia() { }
        public MassMomentOfInertia(decimal value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(double value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(int value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(UnknownUnit value) : base(value) { }

        public MassMomentOfInertia(UnknownUnit value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MassMomentOfInertia From(double value, MassMomentOfInertiaUnit unit) => new(value, unit);
        public double As(MassMomentOfInertiaUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MassMomentOfInertia ToUnit(MassMomentOfInertiaUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassMomentOfInertia Zero => new(0, MassMomentOfInertiaUnit.SI);

        public static implicit operator MassMomentOfInertia(UnknownUnit Unit) => new(Unit, MassMomentOfInertiaUnit.SI);
    }
}

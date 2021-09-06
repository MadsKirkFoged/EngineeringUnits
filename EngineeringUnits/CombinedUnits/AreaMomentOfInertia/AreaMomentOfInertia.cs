using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class AreaMomentOfInertia : BaseUnit
    {

        public AreaMomentOfInertia() { }
        public AreaMomentOfInertia(decimal value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(double value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(int value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(UnknownUnit value) : base(value) { }

        public AreaMomentOfInertia(UnknownUnit value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static AreaMomentOfInertia From(double value, AreaMomentOfInertiaUnit unit) => new AreaMomentOfInertia(value, unit);
        public double As(AreaMomentOfInertiaUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public AreaMomentOfInertia ToUnit(AreaMomentOfInertiaUnit selectedUnit) => new AreaMomentOfInertia(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AreaMomentOfInertia Zero => new AreaMomentOfInertia(0, AreaMomentOfInertiaUnit.SI);

        public static implicit operator AreaMomentOfInertia(UnknownUnit Unit) => new AreaMomentOfInertia(Unit, AreaMomentOfInertiaUnit.SI);


    }
}

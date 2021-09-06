using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class Length : BaseUnit
    {

        public Length() { }
        public Length(decimal value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(double value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(int value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(UnknownUnit value) : base(value) { }

        public Length(UnknownUnit value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Length From(double value, LengthUnit unit) => new Length(value, unit);
        public double As(LengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Length ToUnit(LengthUnit selectedUnit) => new Length(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Length Zero => new Length(0, LengthUnit.SI);

        public static implicit operator Length(UnknownUnit Unit) => new Length(Unit, LengthUnit.SI);

    }
}

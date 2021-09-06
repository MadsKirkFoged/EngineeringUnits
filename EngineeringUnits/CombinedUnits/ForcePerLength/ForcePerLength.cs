using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ForcePerLength : BaseUnit
    {

        public ForcePerLength() { }
        public ForcePerLength(decimal value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(double value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(int value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(UnknownUnit value) : base(value) { }

        public ForcePerLength(UnknownUnit value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ForcePerLength From(double value, ForcePerLengthUnit unit) => new ForcePerLength(value, unit);
        public double As(ForcePerLengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ForcePerLength ToUnit(ForcePerLengthUnit selectedUnit) => new ForcePerLength(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ForcePerLength Zero => new ForcePerLength(0, ForcePerLengthUnit.SI);

        public static implicit operator ForcePerLength(UnknownUnit Unit) => new ForcePerLength(Unit, ForcePerLengthUnit.SI);

    }
}

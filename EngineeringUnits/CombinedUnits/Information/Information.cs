using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Information : BaseUnit
    {

        public Information() { }
        public Information(decimal value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(double value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(int value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(UnknownUnit value) : base(value) { }

        public Information(UnknownUnit value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Information From(double value, InformationUnit unit) => new(value, unit);
        public double As(InformationUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Information ToUnit(InformationUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Information Zero => new(0, InformationUnit.SI);

        public static implicit operator Information(UnknownUnit Unit) => new(Unit, InformationUnit.SI);

    }
}

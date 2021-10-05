using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Irradiation : BaseUnit
    {

        public Irradiation() { }
        public Irradiation(decimal value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiation(double value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiation(int value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiation(UnknownUnit value) : base(value) { }

        public Irradiation(UnknownUnit value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Irradiation From(double value, IrradiationUnit unit) => new(value, unit);
        public double As(IrradiationUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Irradiation ToUnit(IrradiationUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Irradiation Zero => new(0, IrradiationUnit.SI);

        public static implicit operator Irradiation(UnknownUnit Unit) => new(Unit, IrradiationUnit.SI);

    }
}

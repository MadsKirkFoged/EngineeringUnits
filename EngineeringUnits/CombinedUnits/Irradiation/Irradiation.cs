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

        public static Irradiation From(double value, IrradiationUnit unit) => new Irradiation(value, unit);
        public double As(IrradiationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Irradiation ToUnit(IrradiationUnit selectedUnit) => new Irradiation(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Irradiation Zero => new Irradiation(0, IrradiationUnit.SI);

        public static implicit operator Irradiation(UnknownUnit Unit) => new Irradiation(Unit, IrradiationUnit.SI);

    }
}

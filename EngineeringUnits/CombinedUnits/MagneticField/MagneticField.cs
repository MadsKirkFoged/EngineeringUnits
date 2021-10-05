using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MagneticField : BaseUnit
    {

        public MagneticField() { }
        public MagneticField(decimal value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticField(double value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticField(int value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticField(UnknownUnit value) : base(value) { }

        public MagneticField(UnknownUnit value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MagneticField From(double value, MagneticFieldUnit unit) => new(value, unit);
        public double As(MagneticFieldUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MagneticField ToUnit(MagneticFieldUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MagneticField Zero => new(0, MagneticFieldUnit.SI);

        public static implicit operator MagneticField(UnknownUnit Unit) => new(Unit, MagneticFieldUnit.SI);

    }
}

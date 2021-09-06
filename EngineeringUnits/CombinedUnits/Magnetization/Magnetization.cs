using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Magnetization : BaseUnit
    {

        public Magnetization() {}
        public Magnetization(decimal value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Magnetization(double value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Magnetization(int value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Magnetization(UnknownUnit value) : base(value) { }

        public Magnetization(UnknownUnit value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Magnetization From(double value, MagnetizationUnit unit) => new Magnetization(value, unit);
        public double As(MagnetizationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Magnetization ToUnit(MagnetizationUnit selectedUnit) => new Magnetization(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Magnetization Zero => new Magnetization(0, MagnetizationUnit.SI);

        public static implicit operator Magnetization(UnknownUnit Unit) => new Magnetization(Unit, MagnetizationUnit.SI);  

    }
}

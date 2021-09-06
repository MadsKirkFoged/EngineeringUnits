using Fractions;
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Permittivity : BaseUnit
    {

        public Permittivity() { }
        public Permittivity(decimal value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(double value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(int value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(UnknownUnit value) : base(value) { }

        public Permittivity(UnknownUnit value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Permittivity From(double value, PermittivityUnit unit) => new Permittivity(value, unit);
        public double As(PermittivityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Permittivity ToUnit(PermittivityUnit selectedUnit) => new Permittivity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Permittivity Zero => new Permittivity(0, PermittivityUnit.SI);

        public static implicit operator Permittivity(UnknownUnit Unit) => new Permittivity(Unit, PermittivityUnit.SI);
    }
}

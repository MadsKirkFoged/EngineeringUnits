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

        public static Permittivity From(double value, PermittivityUnit unit) => new(value, unit);
        public double As(PermittivityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Permittivity ToUnit(PermittivityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Permittivity Zero => new(0, PermittivityUnit.SI);

        public static implicit operator Permittivity(UnknownUnit Unit) => new(Unit, PermittivityUnit.SI);

        public static implicit operator Permittivity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}

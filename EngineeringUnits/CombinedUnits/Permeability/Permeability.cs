using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Permeability : BaseUnit
    {

        public Permeability() { }
        public Permeability(decimal value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permeability(double value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permeability(int value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permeability(UnknownUnit value) : base(value) { }

        public Permeability(UnknownUnit value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Permeability From(double value, PermeabilityUnit unit) => new(value, unit);
        public double As(PermeabilityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Permeability ToUnit(PermeabilityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Permeability Zero => new(0, PermeabilityUnit.SI);

        public static implicit operator Permeability(UnknownUnit Unit) => new(Unit, PermeabilityUnit.SI);
    }
}

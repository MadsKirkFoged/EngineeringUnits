using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class SpecificEnergy : BaseUnit
    {

        public SpecificEnergy() { }
        public SpecificEnergy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(UnknownUnit value) : base(value) { }

        public SpecificEnergy(UnknownUnit value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static SpecificEnergy From(double value, SpecificEnergyUnit unit) => new SpecificEnergy(value, unit);
        public double As(SpecificEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificEnergy ToUnit(SpecificEnergyUnit selectedUnit) => new SpecificEnergy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificEnergy Zero => new SpecificEnergy(0, SpecificEnergyUnit.SI);

        public static implicit operator SpecificEnergy(UnknownUnit Unit) => new SpecificEnergy(Unit, SpecificEnergyUnit.SI);

    }
}

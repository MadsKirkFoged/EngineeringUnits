using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ReactiveEnergy : BaseUnit
    {

        public ReactiveEnergy() { }
        public ReactiveEnergy(decimal value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(double value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(int value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(UnknownUnit value) : base(value) { }

        public ReactiveEnergy(UnknownUnit value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ReactiveEnergy From(double value, ReactiveEnergyUnit unit) => new(value, unit);
        public double As(ReactiveEnergyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ReactiveEnergy ToUnit(ReactiveEnergyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ReactiveEnergy Zero => new(0, ReactiveEnergyUnit.SI);

        public static implicit operator ReactiveEnergy(UnknownUnit Unit) => new(Unit, ReactiveEnergyUnit.SI);

        public static implicit operator Mass(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}

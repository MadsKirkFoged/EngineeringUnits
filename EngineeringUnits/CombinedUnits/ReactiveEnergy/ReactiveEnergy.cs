
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ReactiveEnergy : BaseUnit
    {

        public ReactiveEnergy() { }
        public ReactiveEnergy(decimal value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(double value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(int value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(UnknownUnit value) : base(value) { }

        public static ReactiveEnergy From(double value, ReactiveEnergyUnit unit) => new(value, unit);

        public static ReactiveEnergy From(double? value, ReactiveEnergyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ReactiveEnergyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ReactiveEnergy ToUnit(ReactiveEnergyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ReactiveEnergy Zero => new(0, ReactiveEnergyUnit.SI);

        public static implicit operator ReactiveEnergy(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(ReactiveEnergyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ReactiveEnergy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ReactiveEnergyUnit>(_unit);
	}
}


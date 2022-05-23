
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificEnergy : BaseUnit
    {

        public SpecificEnergy() { }
        public SpecificEnergy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(UnknownUnit value) : base(value) { }

        public static SpecificEnergy From(double value, SpecificEnergyUnit unit) => new(value, unit);

        public static SpecificEnergy From(double? value, SpecificEnergyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificEnergyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public SpecificEnergy ToUnit(SpecificEnergyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificEnergy Zero => new(0, SpecificEnergyUnit.SI);

        public static implicit operator SpecificEnergy(UnknownUnit Unit)
        {
            UnitCheck(Unit, SpecificEnergyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator SpecificEnergy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificEnergyUnit>(_unit);
	}
}


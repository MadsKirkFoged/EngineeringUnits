
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MolarEnergy : BaseUnit
    {

        public MolarEnergy() { }
        public MolarEnergy(decimal value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(double value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(int value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(UnknownUnit value) : base(value) { }

        public static MolarEnergy From(double value, MolarEnergyUnit unit) => new(value, unit);

        public static MolarEnergy From(double? value, MolarEnergyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MolarEnergyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public MolarEnergy ToUnit(MolarEnergyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MolarEnergy Zero => new(0, MolarEnergyUnit.SI);

        public static implicit operator MolarEnergy(UnknownUnit Unit)
        {
            UnitCheck(Unit, MolarEnergyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MolarEnergy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarEnergyUnit>(_unit);
	}
}


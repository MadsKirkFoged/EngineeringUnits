
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricPotential : BaseUnit
    {

        public ElectricPotential() { }
        public ElectricPotential(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(UnknownUnit value) : base(value) { }

        public static ElectricPotential From(double value, ElectricPotentialUnit unit) => new(value, unit);

        public static ElectricPotential From(double? value, ElectricPotentialUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricPotentialUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricPotential ToUnit(ElectricPotentialUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricPotential Zero => new(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotential(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(ElectricPotentialUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricPotential(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricPotentialUnit>(_unit);
	}
}


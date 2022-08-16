
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MolarFlow : BaseUnit
    {

        public MolarFlow() { }
        public MolarFlow(decimal value, MolarFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarFlow(double value, MolarFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarFlow(int value, MolarFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarFlow(UnknownUnit value) : base(value) { }

        public static MolarFlow From(double value, MolarFlowUnit unit) => new(value, unit);

        public static MolarFlow From(double? value, MolarFlowUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MolarFlowUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public MolarFlow ToUnit(MolarFlowUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MolarFlow Zero => new(0, MolarFlowUnit.SI);

        public static implicit operator MolarFlow(UnknownUnit Unit)
        {
            UnitCheck(Unit, MolarFlowUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MolarFlow(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarFlowUnit>(_unit);
	}
}


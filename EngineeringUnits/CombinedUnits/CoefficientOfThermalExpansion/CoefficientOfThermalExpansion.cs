
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class CoefficientOfThermalExpansion : BaseUnit
    {

        public CoefficientOfThermalExpansion() { }
        public CoefficientOfThermalExpansion(decimal value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(int value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(UnknownUnit value) : base(value) { }

        public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit unit) => new(value, unit);

        public static CoefficientOfThermalExpansion From(double? value, CoefficientOfThermalExpansionUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(CoefficientOfThermalExpansionUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static CoefficientOfThermalExpansion Zero => new(0, CoefficientOfThermalExpansionUnit.SI);

        public static implicit operator CoefficientOfThermalExpansion(UnknownUnit Unit)
        {
            UnitCheck(Unit, CoefficientOfThermalExpansionUnit.SI);
            return new(Unit);        
        }

        public static implicit operator CoefficientOfThermalExpansion(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<CoefficientOfThermalExpansionUnit>(_unit);
	}
}


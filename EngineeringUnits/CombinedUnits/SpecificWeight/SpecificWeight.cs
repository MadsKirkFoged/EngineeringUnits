
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificWeight : BaseUnit
    {

        public SpecificWeight() { }
        public SpecificWeight(decimal value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(double value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(int value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(UnknownUnit value) : base(value) { }

        public static SpecificWeight From(double value, SpecificWeightUnit unit) => new(value, unit);

        public static SpecificWeight From(double? value, SpecificWeightUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificWeightUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public SpecificWeight ToUnit(SpecificWeightUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificWeight Zero => new(0, SpecificWeightUnit.SI);
        public static SpecificWeight NaN => new(double.NaN, SpecificWeightUnit.SI);

        public static implicit operator SpecificWeight(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, SpecificWeightUnit.SI);
            return new(Unit);        
        }

        public static implicit operator SpecificWeight(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificWeightUnit>(_unit);
	}
}


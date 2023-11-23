
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MolarEntropy : BaseUnit
    {

        public MolarEntropy() { }
        public MolarEntropy(decimal value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(double value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(int value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(UnknownUnit value) : base(value) { }

        public static MolarEntropy From(double value, MolarEntropyUnit unit) => new(value, unit);

        public static MolarEntropy From(double? value, MolarEntropyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MolarEntropyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public MolarEntropy ToUnit(MolarEntropyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MolarEntropy Zero => new(0, MolarEntropyUnit.SI);
        public static MolarEntropy NaN => new(double.NaN, MolarEntropyUnit.SI);

        public static implicit operator MolarEntropy(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(MolarEntropyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MolarEntropy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarEntropyUnit>(_unit);
	}
}


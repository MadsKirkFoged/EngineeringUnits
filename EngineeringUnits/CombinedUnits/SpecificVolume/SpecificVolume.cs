
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificVolume : BaseUnit
    {

        public SpecificVolume() { }
        public SpecificVolume(decimal value, SpecificVolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificVolume(double value, SpecificVolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificVolume(int value, SpecificVolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificVolume(UnknownUnit value) : base(value) { }

        public static SpecificVolume From(double value, SpecificVolumeUnit unit) => new(value, unit);

        public static SpecificVolume From(double? value, SpecificVolumeUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificVolumeUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public SpecificVolume ToUnit(SpecificVolumeUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificVolume Zero => new(0, SpecificVolumeUnit.SI);
        public static SpecificVolume NaN => new(double.NaN, SpecificVolumeUnit.SI);

        public static implicit operator SpecificVolume(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(SpecificVolumeUnit.SI);
            return new(Unit);        
        }

        public static implicit operator SpecificVolume(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificVolumeUnit>(_unit);
	}
}


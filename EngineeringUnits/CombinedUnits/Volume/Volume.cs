
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Volume : BaseUnit
    {

        public Volume() { }
        public Volume(decimal value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Volume(double value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Volume(int value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Volume(UnknownUnit value) : base(value) { }

        public static Volume From(double value, VolumeUnit unit) => new(value, unit);

        public static Volume From(double? value, VolumeUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(VolumeUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public Volume ToUnit(VolumeUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Volume Zero => new(0, VolumeUnit.SI);
        public static Volume NaN => new(double.NaN, VolumeUnit.SI);

        public static implicit operator Volume(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, VolumeUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Volume(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumeUnit>(_unit);
	}
}



using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class VolumePerLength : BaseUnit
    {

        public VolumePerLength() { }
        public VolumePerLength(decimal value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumePerLength(double value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumePerLength(int value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumePerLength(UnknownUnit value) : base(value) { }

        public static VolumePerLength From(double value, VolumePerLengthUnit unit) => new(value, unit);

        public static VolumePerLength From(double? value, VolumePerLengthUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(VolumePerLengthUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public VolumePerLength ToUnit(VolumePerLengthUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static VolumePerLength Zero => new(0, VolumePerLengthUnit.SI);

        public static implicit operator VolumePerLength(UnknownUnit Unit) => new(Unit);

        public static implicit operator VolumePerLength(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumePerLengthUnit>(_unit);
	}
}


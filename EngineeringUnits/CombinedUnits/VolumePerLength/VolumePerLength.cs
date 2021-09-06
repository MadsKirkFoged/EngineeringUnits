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

        public VolumePerLength(UnknownUnit value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static VolumePerLength From(double value, VolumePerLengthUnit unit) => new VolumePerLength(value, unit);
        public double As(VolumePerLengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public VolumePerLength ToUnit(VolumePerLengthUnit selectedUnit) => new VolumePerLength(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static VolumePerLength Zero => new VolumePerLength(0, VolumePerLengthUnit.SI);

        public static implicit operator VolumePerLength(UnknownUnit Unit) => new VolumePerLength(Unit, VolumePerLengthUnit.SI);
    }
}

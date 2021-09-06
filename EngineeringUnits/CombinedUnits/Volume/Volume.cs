using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Volume : BaseUnit
    {

        public Volume() { }
        public Volume(decimal value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Volume(double value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Volume(int value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Volume(UnknownUnit value) : base(value) { }

        public Volume(UnknownUnit value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Volume From(double value, VolumeUnit unit) => new Volume(value, unit);
        public double As(VolumeUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Volume ToUnit(VolumeUnit selectedUnit) => new Volume(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Volume Zero => new Volume(0, VolumeUnit.SI);

        public static implicit operator Volume(UnknownUnit Unit) => new Volume(Unit, VolumeUnit.SI);
    }
}

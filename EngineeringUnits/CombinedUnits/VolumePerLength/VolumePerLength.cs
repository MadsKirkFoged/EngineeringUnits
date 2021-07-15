using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class VolumePerLength : BaseUnit
    {

        public VolumePerLength()
        {
            Unit = VolumePerLengthUnit.SI.Unit.Copy();
        }

        public VolumePerLength(decimal value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumePerLength(double value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumePerLength(int value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static VolumePerLength From(double value, VolumePerLengthUnit unit) => new VolumePerLength(value, unit);
        public double As(VolumePerLengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public VolumePerLength ToUnit(VolumePerLengthUnit selectedUnit) => new VolumePerLength(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static VolumePerLength Zero => new VolumePerLength(0, VolumePerLengthUnit.SI);

        public static implicit operator VolumePerLength(UnknownUnit Unit)
        {
            VolumePerLength local = new VolumePerLength(0, VolumePerLengthUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

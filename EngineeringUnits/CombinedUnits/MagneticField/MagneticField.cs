using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class MagneticField : BaseUnit
    {

        public MagneticField()
        {
            Unit = MagneticFieldUnit.SI.Unit.Copy();
        }

        public MagneticField(decimal value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticField(double value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticField(int value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static MagneticField From(double value, MagneticFieldUnit unit) => new MagneticField(value, unit);
        public double As(MagneticFieldUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MagneticField ToUnit(MagneticFieldUnit selectedUnit) => new MagneticField(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MagneticField Zero => new MagneticField(0, MagneticFieldUnit.SI);

        public static implicit operator MagneticField(UnknownUnit Unit)
        {
            MagneticField local = new MagneticField(0, MagneticFieldUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

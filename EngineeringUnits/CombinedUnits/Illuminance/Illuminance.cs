using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Illuminance : BaseUnit
    {

        public Illuminance()
        {
            Unit = IlluminanceUnit.SI.Unit.Copy();
        }

        public Illuminance(decimal value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(double value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(int value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Illuminance From(double value, IlluminanceUnit unit) => new Illuminance(value, unit);
        public double As(IlluminanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Illuminance ToUnit(IlluminanceUnit selectedUnit) => new Illuminance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Illuminance Zero => new Illuminance(0, IlluminanceUnit.SI);

        public static implicit operator Illuminance(UnknownUnit Unit)
        {
            Illuminance local = new Illuminance(0, IlluminanceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

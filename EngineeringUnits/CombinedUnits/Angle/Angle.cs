using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Angle : BaseUnit
    {

        public Angle()
        {
            Unit = AngleUnit.SI.Unit.Copy();
        }

        public Angle(decimal value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(double value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(int value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Angle From(double value, AngleUnit unit) => new Angle(value, unit);
        public double As(AngleUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Angle ToUnit(AngleUnit selectedUnit) => new Angle(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Angle Zero => new Angle(0, AngleUnit.SI);

        public static implicit operator Angle(UnknownUnit Unit)
        {
            Angle local = new Angle(0, AngleUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

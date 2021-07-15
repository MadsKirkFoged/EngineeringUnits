using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Information : BaseUnit
    {

        public Information()
        {
            Unit = InformationUnit.SI.Unit.Copy();
        }

        public Information(decimal value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(double value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(int value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Information From(double value, InformationUnit unit) => new Information(value, unit);
        public double As(InformationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Information ToUnit(InformationUnit selectedUnit) => new Information(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Information Zero => new Information(0, InformationUnit.SI);

        public static implicit operator Information(UnknownUnit Unit)
        {
            Information local = new Information(0, InformationUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class ElectricField : BaseUnit
    {

        public ElectricField()
        {
            Unit = ElectricFieldUnit.SI.Unit.Copy();
        }

        public ElectricField(decimal value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(double value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(int value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricField From(double value, ElectricFieldUnit unit) => new ElectricField(value, unit);
        public double As(ElectricFieldUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricField ToUnit(ElectricFieldUnit selectedUnit) => new ElectricField(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricField Zero => new ElectricField(0, ElectricFieldUnit.SI);

        public static implicit operator ElectricField(UnknownUnit Unit)
        {
            ElectricField local = new ElectricField(0, ElectricFieldUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricConductance : BaseUnit
    {

        public ElectricConductance()
        {
            Unit = ElectricConductanceUnit.SI.Unit.Copy();
        }

        public ElectricConductance(decimal value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductance(double value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductance(int value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricConductance From(double value, ElectricConductanceUnit unit) => new ElectricConductance(value, unit);
        public double As(ElectricConductanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricConductance ToUnit(ElectricConductanceUnit selectedUnit) => new ElectricConductance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricConductance Zero => new ElectricConductance(0, ElectricConductanceUnit.SI);

        public static implicit operator ElectricConductance(UnknownUnit Unit)
        {
            ElectricConductance local = new ElectricConductance(0, ElectricConductanceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

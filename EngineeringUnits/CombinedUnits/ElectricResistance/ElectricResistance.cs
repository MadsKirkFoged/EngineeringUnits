using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricResistance : BaseUnit
    {

        public ElectricResistance()
        {
            Unit = ElectricResistanceUnit.SI.Unit.Copy();
        }

        public ElectricResistance(decimal value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(double value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(int value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricResistance From(double value, ElectricResistanceUnit unit) => new ElectricResistance(value, unit);
        public double As(ElectricResistanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricResistance ToUnit(ElectricResistanceUnit selectedUnit) => new ElectricResistance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricResistance Zero => new ElectricResistance(0, ElectricResistanceUnit.SI);

        public static implicit operator ElectricResistance(UnknownUnit Unit)
        {
            ElectricResistance local = new ElectricResistance(0, ElectricResistanceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

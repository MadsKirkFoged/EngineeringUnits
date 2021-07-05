using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricInductance : BaseUnit
    {

        public ElectricInductance()
        {
            Unit = ElectricInductanceUnit.SI.Unit.Copy();
        }

        public ElectricInductance(decimal value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(double value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(int value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricInductance From(double value, ElectricInductanceUnit unit) => new ElectricInductance(value, unit);
        public double As(ElectricInductanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricInductance ToUnit(ElectricInductanceUnit selectedUnit) => new ElectricInductance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricInductance Zero => new ElectricInductance(0, ElectricInductanceUnit.SI);

        public static implicit operator ElectricInductance(UnknownUnit Unit)
        {
            ElectricInductance local = new ElectricInductance(0, ElectricInductanceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

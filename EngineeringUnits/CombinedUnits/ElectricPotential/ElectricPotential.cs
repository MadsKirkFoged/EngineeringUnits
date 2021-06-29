using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricPotential : BaseUnit
    {

        public ElectricPotential()
        {
            Unit = ElectricPotentialUnit.SI.Unit.Copy();
        }

        public ElectricPotential(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricPotential From(double value, ElectricPotentialUnit unit) => new ElectricPotential(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricPotential ToUnit(ElectricPotentialUnit selectedUnit) => new ElectricPotential(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotential Zero => new ElectricPotential(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotential(UnknownUnit Unit)
        {
            ElectricPotential local = new ElectricPotential(0, ElectricPotentialUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

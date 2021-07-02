using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ApparentEnergy : BaseUnit
    {

        public ApparentEnergy()
        {
            Unit = ApparentEnergyUnit.SI.Unit.Copy();
        }

        public ApparentEnergy(decimal value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentEnergy(double value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentEnergy(int value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ApparentEnergy From(double value, ApparentEnergyUnit unit) => new ApparentEnergy(value, unit);
        public double As(ApparentEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ApparentEnergy ToUnit(ApparentEnergyUnit selectedUnit) => new ApparentEnergy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ApparentEnergy Zero => new ApparentEnergy(0, ApparentEnergyUnit.SI);

        public static implicit operator ApparentEnergy(UnknownUnit Unit)
        {
            ApparentEnergy local = new ApparentEnergy(0, ApparentEnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

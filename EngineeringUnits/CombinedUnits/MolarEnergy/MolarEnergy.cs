using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MolarEnergy : BaseUnit
    {

        public MolarEnergy()
        {
            Unit = MolarEnergyUnit.SI.Unit.Copy();
        }

        public MolarEnergy(decimal value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(double value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(int value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static MolarEnergy From(double value, MolarEnergyUnit unit) => new MolarEnergy(value, unit);
        public double As(MolarEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MolarEnergy ToUnit(MolarEnergyUnit selectedUnit) => new MolarEnergy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MolarEnergy Zero => new MolarEnergy(0, MolarEnergyUnit.SI);

        public static implicit operator MolarEnergy(UnknownUnit Unit)
        {
            MolarEnergy local = new MolarEnergy(0, MolarEnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

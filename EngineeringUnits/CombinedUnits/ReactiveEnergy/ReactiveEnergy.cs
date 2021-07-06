using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ReactiveEnergy : BaseUnit
    {

        public ReactiveEnergy()
        {
            Unit = ReactiveEnergyUnit.SI.Unit.Copy();
        }

        public ReactiveEnergy(decimal value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(double value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactiveEnergy(int value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ReactiveEnergy From(double value, ReactiveEnergyUnit unit) => new ReactiveEnergy(value, unit);
        public double As(ReactiveEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ReactiveEnergy ToUnit(ReactiveEnergyUnit selectedUnit) => new ReactiveEnergy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ReactiveEnergy Zero => new ReactiveEnergy(0, ReactiveEnergyUnit.SI);

        public static implicit operator ReactiveEnergy(UnknownUnit Unit)
        {
            ReactiveEnergy local = new ReactiveEnergy(0, ReactiveEnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

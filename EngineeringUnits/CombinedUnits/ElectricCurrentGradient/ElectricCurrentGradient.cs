using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCurrentGradient : BaseUnit
    {

        public ElectricCurrentGradient()
        {
            Unit = ElectricCurrentGradientUnit.SI.Unit.Copy();
        }

        public ElectricCurrentGradient(decimal value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(double value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(int value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricCurrentGradient From(double value, ElectricCurrentGradientUnit unit) => new ElectricCurrentGradient(value, unit);
        public double As(ElectricCurrentGradientUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricCurrentGradient ToUnit(ElectricCurrentGradientUnit selectedUnit) => new ElectricCurrentGradient(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentGradient Zero => new ElectricCurrentGradient(0, ElectricCurrentGradientUnit.SI);

        public static implicit operator ElectricCurrentGradient(UnknownUnit Unit)
        {
            ElectricCurrentGradient local = new ElectricCurrentGradient(0, ElectricCurrentGradientUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

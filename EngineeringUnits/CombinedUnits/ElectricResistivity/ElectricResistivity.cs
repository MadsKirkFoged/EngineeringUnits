using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class ElectricResistivity : BaseUnit
    {

        public ElectricResistivity()
        {
            Unit = ElectricResistivityUnit.SI.Unit.Copy();
        }

        public ElectricResistivity(decimal value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(double value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(int value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricResistivity From(double value, ElectricResistivityUnit unit) => new ElectricResistivity(value, unit);
        public double As(ElectricResistivityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricResistivity ToUnit(ElectricResistivityUnit selectedUnit) => new ElectricResistivity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricResistivity Zero => new ElectricResistivity(0, ElectricResistivityUnit.SI);

        public static implicit operator ElectricResistivity(UnknownUnit Unit)
        {
            ElectricResistivity local = new ElectricResistivity(0, ElectricResistivityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ThermalResistance : BaseUnit
    {

        public ThermalResistance()
        {
            Unit = ThermalResistanceUnit.SI.Unit.Copy();
        }

        public ThermalResistance(decimal value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalResistance(double value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalResistance(int value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ThermalResistance From(double value, ThermalResistanceUnit unit) => new ThermalResistance(value, unit);
        public double As(ThermalResistanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ThermalResistance ToUnit(ThermalResistanceUnit selectedUnit) => new ThermalResistance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ThermalResistance Zero => new ThermalResistance(0, ThermalResistanceUnit.SI);

        public static implicit operator ThermalResistance(UnknownUnit Unit)
        {
            ThermalResistance local = new ThermalResistance(0, ThermalResistanceUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

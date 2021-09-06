using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Torque : BaseUnit
    {

        public Torque() { }
        public Torque(decimal value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Torque(double value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Torque(int value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Torque(UnknownUnit value) : base(value) { }

        public Torque(UnknownUnit value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Torque From(double value, TorqueUnit unit) => new Torque(value, unit);
        public double As(TorqueUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Torque ToUnit(TorqueUnit selectedUnit) => new Torque(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Torque Zero => new Torque(0, TorqueUnit.SI);

        public static implicit operator Torque(UnknownUnit Unit) => new Torque(Unit, TorqueUnit.SI);

    }
}

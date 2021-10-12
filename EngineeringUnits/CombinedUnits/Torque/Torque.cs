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

        public static Torque From(double value, TorqueUnit unit) => new(value, unit);
        public double As(TorqueUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Torque ToUnit(TorqueUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Torque Zero => new(0, TorqueUnit.SI);

        public static implicit operator Torque(UnknownUnit Unit) => new(Unit, TorqueUnit.SI);

        public static implicit operator Torque(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}

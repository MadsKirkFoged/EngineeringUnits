using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotential : BaseUnit
    {

        public ElectricPotential() { }
        public ElectricPotential(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(UnknownUnit value) : base(value) { }

        public ElectricPotential(UnknownUnit value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricPotential From(double value, ElectricPotentialUnit unit) => new ElectricPotential(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricPotential ToUnit(ElectricPotentialUnit selectedUnit) => new ElectricPotential(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotential Zero => new ElectricPotential(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotential(UnknownUnit Unit) => new ElectricPotential(Unit, ElectricPotentialUnit.SI);


    }
}

using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotentialDc : BaseUnit
    {


        public ElectricPotentialDc(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialDc(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialDc(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialDc(UnknownUnit value) : base(value) { }

        public static ElectricPotentialDc From(double value, ElectricPotentialUnit unit) => new(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricPotentialDc ToUnit(ElectricPotentialUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotentialDc Zero => new(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotentialDc(UnknownUnit Unit) => new(Unit);




    }
}

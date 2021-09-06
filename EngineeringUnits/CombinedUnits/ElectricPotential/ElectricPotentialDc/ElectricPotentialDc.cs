using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotentialDc : BaseUnit
    {

        public ElectricPotentialDc()
        {
            
        }

        public ElectricPotentialDc(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialDc(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialDc(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricPotentialDc From(double value, ElectricPotentialUnit unit) => new ElectricPotentialDc(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricPotentialDc ToUnit(ElectricPotentialUnit selectedUnit) => new ElectricPotentialDc(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotentialDc Zero => new ElectricPotentialDc(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotentialDc(UnknownUnit Unit)
        {
            ElectricPotentialDc local = new ElectricPotentialDc(0, ElectricPotentialUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

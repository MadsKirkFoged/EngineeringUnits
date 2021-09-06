using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotentialAc : BaseUnit
    {

        public ElectricPotentialAc()
        {
            Unit = ElectricPotentialUnit.SI.Unit.Copy();
        }

        public ElectricPotentialAc(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialAc(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialAc(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricPotentialAc From(double value, ElectricPotentialUnit unit) => new ElectricPotentialAc(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricPotentialAc ToUnit(ElectricPotentialUnit selectedUnit) => new ElectricPotentialAc(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotentialAc Zero => new ElectricPotentialAc(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotentialAc(UnknownUnit Unit)
        {
            ElectricPotentialAc local = new ElectricPotentialAc(0, ElectricPotentialUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}

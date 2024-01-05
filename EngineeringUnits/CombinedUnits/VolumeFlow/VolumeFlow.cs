
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class VolumeFlow : BaseUnit
    {

        public VolumeFlow() { }
        public VolumeFlow(decimal value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(double value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(int value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(UnknownUnit value) : base(value) { }

        public static VolumeFlow From(double value, VolumeFlowUnit unit) => new(value, unit);

        public static VolumeFlow From(double? value, VolumeFlowUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(VolumeFlowUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public VolumeFlow ToUnit(VolumeFlowUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static VolumeFlow Zero => new(0, VolumeFlowUnit.SI);
        public static VolumeFlow NaN => new(double.NaN, VolumeFlowUnit.SI);

        public static implicit operator VolumeFlow(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, VolumeFlowUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(VolumeFlow Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumeFlowUnit>(_unit);
        }
    }

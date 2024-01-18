
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MassCost : BaseUnit
    {

        public MassCost() { }
        public MassCost(decimal value, MassCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassCost(double value, MassCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassCost(int value, MassCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassCost(UnknownUnit value) : base(value) { }

        public static MassCost From(double value, MassCostUnit unit) => new(value, unit);

        public static MassCost From(double? value, MassCostUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MassCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public MassCost ToUnit(MassCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MassCost Zero => new(0, MassCostUnit.SI);
        public static MassCost NaN => new(double.NaN, MassCostUnit.SI);

        public static implicit operator MassCost(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, MassCostUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(MassCost Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassCostUnit>(_unit);
        }
    }

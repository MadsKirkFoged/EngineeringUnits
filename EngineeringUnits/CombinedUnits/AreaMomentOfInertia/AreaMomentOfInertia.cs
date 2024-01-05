
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class AreaMomentOfInertia : BaseUnit
    {

        public AreaMomentOfInertia() { }
        public AreaMomentOfInertia(decimal value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(double value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(int value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(UnknownUnit value) : base(value) { }

        public static AreaMomentOfInertia From(double value, AreaMomentOfInertiaUnit unit) => new(value, unit);

        public static AreaMomentOfInertia From(double? value, AreaMomentOfInertiaUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(AreaMomentOfInertiaUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public AreaMomentOfInertia ToUnit(AreaMomentOfInertiaUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static AreaMomentOfInertia Zero => new(0, AreaMomentOfInertiaUnit.SI);
        public static AreaMomentOfInertia NaN => new(double.NaN, AreaMomentOfInertiaUnit.SI);

        public static implicit operator AreaMomentOfInertia(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, AreaMomentOfInertiaUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(AreaMomentOfInertia Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaMomentOfInertiaUnit>(_unit);
        }
    }

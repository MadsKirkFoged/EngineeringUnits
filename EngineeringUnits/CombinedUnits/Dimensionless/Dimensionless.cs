
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Dimensionless : BaseUnit
    {

        public Dimensionless() { }
        public Dimensionless(decimal value, DimensionlessUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Dimensionless(double value, DimensionlessUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Dimensionless(int value, DimensionlessUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Dimensionless(UnknownUnit value) : base(value) { }

        public static Dimensionless From(double value, DimensionlessUnit unit) => new(value, unit);

        public static Dimensionless From(double? value, DimensionlessUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(DimensionlessUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public Dimensionless ToUnit(DimensionlessUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Dimensionless Zero => new(0, DimensionlessUnit.SI);
        public static Dimensionless NaN => new(double.NaN, DimensionlessUnit.SI);

        public static implicit operator Dimensionless(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, DimensionlessUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(Dimensionless Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DimensionlessUnit>(_unit);
        }
    }

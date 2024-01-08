
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Permittivity : BaseUnit
    {

        public Permittivity() { }
        public Permittivity(decimal value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(double value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(int value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(UnknownUnit value) : base(value) { }

        public static Permittivity From(double value, PermittivityUnit unit) => new(value, unit);

        public static Permittivity From(double? value, PermittivityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(PermittivityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public Permittivity ToUnit(PermittivityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Permittivity Zero => new(0, PermittivityUnit.SI);
        public static Permittivity NaN => new(double.NaN, PermittivityUnit.SI);

        public static implicit operator Permittivity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, PermittivityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(Permittivity Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PermittivityUnit>(_unit);
        }
    }

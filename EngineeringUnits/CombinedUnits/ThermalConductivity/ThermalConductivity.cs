
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ThermalConductivity : BaseUnit
    {

        public ThermalConductivity() { }
        public ThermalConductivity(decimal value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(double value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(int value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(UnknownUnit value) : base(value) { }

        public static ThermalConductivity From(double value, ThermalConductivityUnit unit) => new(value, unit);

        public static ThermalConductivity From(double? value, ThermalConductivityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ThermalConductivityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public ThermalConductivity ToUnit(ThermalConductivityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ThermalConductivity Zero => new(0, ThermalConductivityUnit.SI);
        public static ThermalConductivity NaN => new(double.NaN, ThermalConductivityUnit.SI);

        public static implicit operator ThermalConductivity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, ThermalConductivityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(ThermalConductivity Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ThermalConductivityUnit>(_unit);
        }
    }

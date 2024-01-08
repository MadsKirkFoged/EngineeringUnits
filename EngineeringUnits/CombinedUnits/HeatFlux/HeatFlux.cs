
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class HeatFlux : BaseUnit
    {

        public HeatFlux() { }
        public HeatFlux(decimal value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(double value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(int value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(UnknownUnit value) : base(value) { }

        public static HeatFlux From(double value, HeatFluxUnit unit) => new(value, unit);

        public static HeatFlux From(double? value, HeatFluxUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(HeatFluxUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public HeatFlux ToUnit(HeatFluxUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static HeatFlux Zero => new(0, HeatFluxUnit.SI);
        public static HeatFlux NaN => new(double.NaN, HeatFluxUnit.SI);

        public static implicit operator HeatFlux(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, HeatFluxUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(HeatFlux Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<HeatFluxUnit>(_unit);
        }
    }

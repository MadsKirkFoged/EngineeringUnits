
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MagneticFlux : BaseUnit
    {

        public MagneticFlux() { }
        public MagneticFlux(decimal value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(double value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(int value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(UnknownUnit value) : base(value) { }

        public static MagneticFlux From(double value, MagneticFluxUnit unit) => new(value, unit);

        public static MagneticFlux From(double? value, MagneticFluxUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MagneticFluxUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public MagneticFlux ToUnit(MagneticFluxUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MagneticFlux Zero => new(0, MagneticFluxUnit.SI);
        public static MagneticFlux NaN => new(double.NaN, MagneticFluxUnit.SI);

        public static implicit operator MagneticFlux(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, MagneticFluxUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(MagneticFlux Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MagneticFluxUnit>(_unit);
        }
    }

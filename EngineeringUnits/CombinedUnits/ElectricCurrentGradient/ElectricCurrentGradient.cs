
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricCurrentGradient : BaseUnit
    {

        public ElectricCurrentGradient() { }
        public ElectricCurrentGradient(decimal value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(double value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(int value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(UnknownUnit value) : base(value) { }

        public static ElectricCurrentGradient From(double value, ElectricCurrentGradientUnit unit) => new(value, unit);

        public static ElectricCurrentGradient From(double? value, ElectricCurrentGradientUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricCurrentGradientUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public ElectricCurrentGradient ToUnit(ElectricCurrentGradientUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentGradient Zero => new(0, ElectricCurrentGradientUnit.SI);
        public static ElectricCurrentGradient NaN => new(double.NaN, ElectricCurrentGradientUnit.SI);

        public static implicit operator ElectricCurrentGradient(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, ElectricCurrentGradientUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(ElectricCurrentGradient Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricCurrentGradientUnit>(_unit);
        }
    }

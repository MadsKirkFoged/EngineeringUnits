
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificEntropy : BaseUnit
    {

        public SpecificEntropy() { }
        public SpecificEntropy(decimal value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(double value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(int value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(UnknownUnit value) : base(value) { }

        public static SpecificEntropy From(double value, SpecificEntropyUnit unit) => new(value, unit);

        public static SpecificEntropy From(double? value, SpecificEntropyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificEntropyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public SpecificEntropy ToUnit(SpecificEntropyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificEntropy Zero => new(0, SpecificEntropyUnit.SI);
        public static SpecificEntropy NaN => new(double.NaN, SpecificEntropyUnit.SI);

        public static implicit operator SpecificEntropy(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, SpecificEntropyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(SpecificEntropy Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificEntropyUnit>(_unit);
        }
    }

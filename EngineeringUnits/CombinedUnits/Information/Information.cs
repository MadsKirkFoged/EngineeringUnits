
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Information : BaseUnit
    {

        public Information() { }
        public Information(decimal value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(double value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(int value, InformationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Information(UnknownUnit value) : base(value) { }

        public static Information From(double value, InformationUnit unit) => new(value, unit);

        public static Information From(double? value, InformationUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(InformationUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Information ToUnit(InformationUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Information Zero => new(0, InformationUnit.SI);
        public static Information NaN => new(double.NaN, InformationUnit.SI);

        public static implicit operator Information(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(InformationUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Information(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<InformationUnit>(_unit);
	}
}



using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Pressure : BaseUnit
    {

        public Pressure() { }
        public Pressure(decimal value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) 
        {
            Reference = selectedUnit.Reference;
        }
        public Pressure(double value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) 
        {
            Reference = selectedUnit.Reference;
        }
        public Pressure(int value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit)         
        {
            Reference = selectedUnit.Reference;
        }
        public Pressure(UnknownUnit value) : base(value) { }

        public static Pressure From(double value, PressureUnit unit) => new(value, unit);

        public static Pressure From(double? value, PressureUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(PressureUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit.Unit);
        public Pressure ToUnit(PressureUnit selectedUnit)
        {
            //Convert to the new unit
            Pressure result = new Pressure(this.GetValueAs(selectedUnit.Unit), selectedUnit, Reference);

            //Convert to the new Reference
            return result.ToUnit(selectedUnit.Reference);

            //return new(this.GetValueAs(selectedUnit.Unit), selectedUnit, Reference);
        } 

        
        
        public static Pressure Zero => new(0, PressureUnit.SI);
        public static Pressure NaN => new(double.NaN, PressureUnit.SI);

        public static implicit operator Pressure(UnknownUnit Unit)
        {
            if (Unit is null)
                return null;

            GuardAgainst.DifferentUnits(Unit, PressureUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(Pressure Unit)
        {
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public static implicit operator Pressure(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	//public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PressureUnit>(_unit);
	}
}


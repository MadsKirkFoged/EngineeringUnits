namespace EngineeringUnits.Units;

public partial record LuminousFluxUnit : UnitTypebase
{

    public static readonly LuminousFluxUnit SI = new(LuminousIntensityUnit.SI);
    public static readonly LuminousFluxUnit Lumen = new(LuminousIntensityUnit.Candela, "lm");

    //public LuminousFluxUnit(LuminousIntensityUnit unit, string NewSymbol = "Empty") : base(unit, NewSymbol, 1) { }

    public LuminousFluxUnit(LuminousIntensityUnit unit) : base() 
    {
        Unit = unit;
    }
    public LuminousFluxUnit(LuminousIntensityUnit unit,string NewSymbol) : base()
    {
        Unit = new UnitSystem(unit, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
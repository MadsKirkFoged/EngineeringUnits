namespace EngineeringUnits.Units;

public partial record LevelUnit : UnitTypebase
{

    public static readonly LevelUnit SI = new();
    public static readonly LevelUnit Decibel = new("dB");
    public static readonly LevelUnit Neper = new("Np", 1/0.115129254m);

    public LevelUnit(string? NewSymbol = null, decimal correction = 1)
    {
        Unit = new UnitSystem(correction, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
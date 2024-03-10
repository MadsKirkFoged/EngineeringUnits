namespace EngineeringUnits.Units;

public partial record MolarFlowUnit : UnitTypebase
{

    public static readonly MolarFlowUnit SI = new MolarFlowUnit(AmountOfSubstanceUnit.SI, DurationUnit.SI);
    public static readonly MolarFlowUnit MolePerSecond = new MolarFlowUnit(AmountOfSubstanceUnit.Mole, DurationUnit.Second);

    public MolarFlowUnit(AmountOfSubstanceUnit amountOfSubstance, DurationUnit duration, string NewSymbol)
    {
        base.Unit = new UnitSystem(amountOfSubstance / duration, NewSymbol);
    }

    public MolarFlowUnit(AmountOfSubstanceUnit amountOfSubstance, DurationUnit duration)
    {
        base.Unit = new UnitSystem(amountOfSubstance / duration, $"{amountOfSubstance}/{duration}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
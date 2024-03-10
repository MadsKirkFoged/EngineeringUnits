namespace EngineeringUnits.Units;

public partial record MassFlowUnit : UnitTypebase
{

    public static readonly MassFlowUnit CentigramPerDay = new(MassUnit.Centigram, DurationUnit.Day);
    public static readonly MassFlowUnit CentigramPerSecond = new(MassUnit.Centigram, DurationUnit.Second);
    public static readonly MassFlowUnit DecagramPerDay = new(MassUnit.Decagram, DurationUnit.Day);
    public static readonly MassFlowUnit DecagramPerSecond = new(MassUnit.Decagram, DurationUnit.Second);
    public static readonly MassFlowUnit DecigramPerDay = new(MassUnit.Decigram, DurationUnit.Day);
    public static readonly MassFlowUnit DecigramPerSecond = new(MassUnit.Decigram, DurationUnit.Second);
    public static readonly MassFlowUnit GramPerDay = new(MassUnit.Gram, DurationUnit.Day);
    public static readonly MassFlowUnit GramPerHour = new(MassUnit.Gram, DurationUnit.Hour);
    public static readonly MassFlowUnit GramPerSecond = new(MassUnit.Gram, DurationUnit.Second);
    public static readonly MassFlowUnit MegagramPerDay = new(PreFix.mega, GramPerDay);
    public static readonly MassFlowUnit MicrogramPerSecond = new(PreFix.micro, GramPerSecond);
    public static readonly MassFlowUnit MicrogramPerDay = new(PreFix.micro, GramPerDay);
    public static readonly MassFlowUnit MilligramPerSecond = new(PreFix.milli, GramPerSecond);
    public static readonly MassFlowUnit MilligramPerDay = new(PreFix.milli, GramPerDay);
    public static readonly MassFlowUnit NanogramPerSecond = new(PreFix.nano, GramPerSecond);
    public static readonly MassFlowUnit NanogramPerDay = new(PreFix.nano, GramPerDay);
    public static readonly MassFlowUnit HectogramPerDay = new(MassUnit.Hectogram, DurationUnit.Day);
    public static readonly MassFlowUnit HectogramPerSecond = new(MassUnit.Hectogram, DurationUnit.Second);
    public static readonly MassFlowUnit SI = new(MassUnit.SI, DurationUnit.SI);
    public static readonly MassFlowUnit KilogramPerSecond = new(MassUnit.Kilogram, DurationUnit.Second);
    public static readonly MassFlowUnit KilogramPerMinute = new(MassUnit.Kilogram, DurationUnit.Minute);
    public static readonly MassFlowUnit KilogramPerHour = new(MassUnit.Kilogram, DurationUnit.Hour);
    public static readonly MassFlowUnit KilogramPerDay = new(MassUnit.Kilogram, DurationUnit.Day);
    public static readonly MassFlowUnit PoundPerSecond = new(MassUnit.Pound, DurationUnit.SI);
    public static readonly MassFlowUnit PoundPerMinute = new(MassUnit.Pound, DurationUnit.Minute);
    public static readonly MassFlowUnit PoundPerHour = new(MassUnit.Pound, DurationUnit.Hour);
    public static readonly MassFlowUnit PoundPerDay = new(MassUnit.Pound, DurationUnit.Day);
    public static readonly MassFlowUnit MegapoundPerDay = new(PreFix.mega, PoundPerDay);
    public static readonly MassFlowUnit MegapoundPerHour = new(PreFix.mega, PoundPerHour);
    public static readonly MassFlowUnit MegapoundPerMinute = new(PreFix.mega, PoundPerMinute);
    public static readonly MassFlowUnit MegapoundPerSecond = new(PreFix.mega, PoundPerSecond);
    public static readonly MassFlowUnit ShortTonPerHour = new(MassUnit.ShortTon, DurationUnit.Hour, "short tn/h");
    public static readonly MassFlowUnit TonnePerDay = new(MassUnit.Tonne, DurationUnit.Day);
    public static readonly MassFlowUnit TonnePerHour = new(MassUnit.Tonne, DurationUnit.Hour);

    public MassFlowUnit(MassUnit mass, DurationUnit duration, string NewSymbol)
    {
        Unit = new UnitSystem(mass / duration, NewSymbol);
    }

    public MassFlowUnit(MassUnit mass, DurationUnit duration)
    {
        Unit = new UnitSystem(mass / duration,
                           $"{mass}/{duration}");
    }

    public MassFlowUnit(PreFix SI, MassFlowUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
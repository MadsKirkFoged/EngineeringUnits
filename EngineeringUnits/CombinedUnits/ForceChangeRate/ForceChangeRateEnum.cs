namespace EngineeringUnits.Units;

public partial record ForceChangeRateUnit : UnitTypebase
{

    public static readonly ForceChangeRateUnit SI = new(ForceUnit.SI, DurationUnit.SI);
    public static readonly ForceChangeRateUnit NewtonPerSecond = new(ForceUnit.Newton, DurationUnit.Second);
    public static readonly ForceChangeRateUnit NewtonPerMinute = new(ForceUnit.Newton, DurationUnit.Minute);

    public static readonly ForceChangeRateUnit PoundForcePerSecond = new(ForceUnit.PoundForce, DurationUnit.Second);
    public static readonly ForceChangeRateUnit PoundForcePerMinute = new(ForceUnit.PoundForce, DurationUnit.Minute);

    public static readonly ForceChangeRateUnit KilopoundForcePerSecond = new(PreFix.kilo, PoundForcePerSecond);

    public static readonly ForceChangeRateUnit KilopoundForcePerMinute = new(PreFix.kilo, PoundForcePerMinute);

    public static readonly ForceChangeRateUnit NanonewtonPerSecond = new(PreFix.nano, NewtonPerSecond);
    public static readonly ForceChangeRateUnit MillinewtonPerSecond = new(PreFix.milli, NewtonPerSecond);
    public static readonly ForceChangeRateUnit MicronewtonPerSecond = new(PreFix.micro, NewtonPerSecond);
    public static readonly ForceChangeRateUnit CentinewtonPerSecond = new(PreFix.centi, NewtonPerSecond);
    public static readonly ForceChangeRateUnit DecanewtonPerSecond = new(PreFix.deka, NewtonPerSecond);
    public static readonly ForceChangeRateUnit DecinewtonPerSecond = new(PreFix.deci, NewtonPerSecond);
    public static readonly ForceChangeRateUnit KilonewtonPerSecond = new(PreFix.kilo, NewtonPerSecond);

    public static readonly ForceChangeRateUnit DecanewtonPerMinute = new(PreFix.deka, NewtonPerMinute);
    public static readonly ForceChangeRateUnit KilonewtonPerMinute = new(PreFix.kilo, NewtonPerMinute);

    public ForceChangeRateUnit(ForceUnit force, DurationUnit duration)
    {
        Unit = new UnitSystem(force / duration,
                           $"{force}/{duration}");
    }

    public ForceChangeRateUnit(PreFix SI, ForceChangeRateUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
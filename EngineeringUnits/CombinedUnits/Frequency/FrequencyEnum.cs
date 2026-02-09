using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits.Units;

public partial record FrequencyUnit : UnitTypebase
{

    public static readonly FrequencyUnit SI = new(DurationUnit.Second, "Hz");

    [Synonyms(
        "hz",
        "hertz",
        "per second", "persecond"
    )]
    public static readonly FrequencyUnit Hertz = new(DurationUnit.Second, "Hz");

    [Synonyms(
        "khz",
        "kilohertz",
        "kilo hertz", "kilo-hertz"
    )]
    public static readonly FrequencyUnit Kilohertz = new(PreFix.kilo, Hertz);

    [Synonyms(
        "mhz",
        "megahertz",
        "mega hertz", "mega-hertz"
    )]
    public static readonly FrequencyUnit Megahertz = new(PreFix.mega, Hertz);

    [Synonyms(
        "ghz",
        "gigahertz",
        "giga hertz", "giga-hertz"
    )]
    public static readonly FrequencyUnit Gigahertz = new(PreFix.giga, Hertz);

    [Synonyms(
        "thz",
        "terahertz",
        "tera hertz", "tera-hertz"
    )]
    public static readonly FrequencyUnit Terahertz = new(PreFix.tera, Hertz);

    [Synonyms(
        "s^-1", "s-1", "s⁻¹",
        "1/s", "1 per second",
        "per second", "persecond",
        "sec^-1", "sec-1",
        "second^-1", "second-1"
    )]
    public static readonly FrequencyUnit PerSecond = new(DurationUnit.Second, "s⁻¹");

    [Synonyms(
        "bpm",
        "beat/min", "beats/min",
        "beat per minute", "beats per minute",
        "beatsperminute", "beatperminute"
    )]
    public static readonly FrequencyUnit BeatPerMinute = new(DurationUnit.Minute, "bpm");

    [Synonyms(
        "rpm", "r/min",
        "rev/min", "revs/min",
        "revolution/min", "revolutions/min",
        "revolution per minute", "revolutions per minute",
        "rev per minute", "revs per minute"
    )]
    public static readonly FrequencyUnit RevolutionsPerMinute = new(DurationUnit.Minute, "RPM");

    [Synonyms(
        "rpm", "r/min",
        "rev/min", "revs/min",
        "revolution per minute", "revolutions per minute"
    )]
    public static readonly FrequencyUnit RPM = new(DurationUnit.Minute, "RPM");

    [Synonyms(
        "cph",
        "cycle/hour", "cycles/hour",
        "cycle per hour", "cycles per hour",
        "cyclesperhour", "cycleperhour",
        "1/h", "h^-1", "h-1",
        "per hour", "perhour"
    )]
    public static readonly FrequencyUnit CyclePerHour = new(DurationUnit.Hour, "cph");

    [Synonyms(
        "cpm",
        "cycle/min", "cycles/min",
        "cycle per minute", "cycles per minute",
        "cyclesperminute", "cycleperminute",
        "1/min", "min^-1", "min-1",
        "per minute", "perminute"
    )]
    public static readonly FrequencyUnit CyclePerMinute = new(DurationUnit.Minute, "cpm");

    [Synonyms(
        "rad/s", "rad per second", "radian per second", "radians per second",
        "rad/s^-1", // optional if your users type odd formats
        "rad·s^-1", "rad s^-1"
    )]
    public static readonly FrequencyUnit RadianPerSecond =
        new(DurationUnit.Second, "rad/s", 1 / (2 * (decimal)Math.PI));

    public FrequencyUnit(DurationUnit duration, string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(duration.Pow(-1) * correction, NewSymbol);
    }

    public FrequencyUnit(PreFix SI, FrequencyUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
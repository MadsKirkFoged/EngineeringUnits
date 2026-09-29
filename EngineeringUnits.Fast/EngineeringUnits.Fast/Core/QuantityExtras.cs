using System;

namespace EngineeringUnits.Fast;

// The hand-written extras EngineeringUnits has on a few quantities (PipeSizeExtended.cs, Duration.extra.cs, Amount.extra.cs,
// RatioExtra.cs) - same names and behaviour, so code keeps compiling after the using swap.

public readonly partial struct PipeSize
{
    /// <summary>The DN number, e.g. 50 for DN50.</summary>
    public int DNValve => (int)_si;

    /// <summary>Outside diameter of a DN pipe (ASME B36.10/19 table), null for a DN that isn't in the table.</summary>
    public Length? GetOutsideDiameter => DNtoOD.GetOutsideDiameter(DNValve);

    // EngineeringUnits keeps the schedule in a settable property on the value (pipeSize.PipeSchedule = ...). A PipeSize here is a
    // single double, so the schedule is passed in instead
    public Length? GetWallThickness(PipeScheduleEnum schedule) => schedule switch
    {
        PipeScheduleEnum.SCH_5s => DNtoOD.GetSchedule5s(DNValve),
        PipeScheduleEnum.SCH_10 => DNtoOD.GetSchedule10(DNValve),
        PipeScheduleEnum.SCH_10s => DNtoOD.GetSchedule10s(DNValve),
        PipeScheduleEnum.SCH_30 => DNtoOD.GetSchedule30(DNValve),
        PipeScheduleEnum.SCH_40 => DNtoOD.GetSchedule40(DNValve),
        PipeScheduleEnum.SCH_40s => DNtoOD.GetSchedule40s(DNValve),
        PipeScheduleEnum.Std => DNtoOD.GetScheduleSTD(DNValve),
        PipeScheduleEnum.SCH_80 => DNtoOD.GetSchedule80(DNValve),
        PipeScheduleEnum.SCH_80s => DNtoOD.GetSchedule80s(DNValve),
        PipeScheduleEnum.XS => DNtoOD.GetScheduleXS(DNValve),
        PipeScheduleEnum.SCH_120 => DNtoOD.GetSchedule120(DNValve),
        PipeScheduleEnum.SCH_160 => DNtoOD.GetSchedule160(DNValve),
        PipeScheduleEnum.XXS => DNtoOD.GetScheduleXXS(DNValve),
        _ => throw new NotImplementedException(),
    };

    public Length? GetInsideDiameter(PipeScheduleEnum schedule) => GetOutsideDiameter - 2 * GetWallThickness(schedule);

    public Area? GetInsideCrossSection(PipeScheduleEnum schedule) => Area.FromCircleDiameter(GetInsideDiameter(schedule));
}

public readonly partial struct Duration
{
    /// <summary>The same time as a TimeSpan. Throws if it doesn't fit in one.</summary>
    public TimeSpan ToTimeSpan()
    {
        if (Second > TimeSpan.MaxValue.TotalSeconds || Second < TimeSpan.MinValue.TotalSeconds)
            throw new ArgumentOutOfRangeException(nameof(Duration), "The duration is too large or small to fit in a TimeSpan");
        return TimeSpan.FromSeconds(Second);
    }

    public static DateTime operator +(DateTime time, Duration duration) => time.AddSeconds(duration.Second);
    public static DateTime operator -(DateTime time, Duration duration) => time.AddSeconds(-duration.Second);

    public static explicit operator TimeSpan(Duration duration) => duration.ToTimeSpan();
    public static explicit operator Duration(TimeSpan duration) => FromSecond(duration.TotalSeconds);

    public static bool operator <(Duration duration, TimeSpan timeSpan) => duration.Second < timeSpan.TotalSeconds;
    public static bool operator >(Duration duration, TimeSpan timeSpan) => duration.Second > timeSpan.TotalSeconds;
    public static bool operator <=(Duration duration, TimeSpan timeSpan) => duration.Second <= timeSpan.TotalSeconds;
    public static bool operator >=(Duration duration, TimeSpan timeSpan) => duration.Second >= timeSpan.TotalSeconds;
    public static bool operator <(TimeSpan timeSpan, Duration duration) => timeSpan.TotalSeconds < duration.Second;
    public static bool operator >(TimeSpan timeSpan, Duration duration) => timeSpan.TotalSeconds > duration.Second;
    public static bool operator <=(TimeSpan timeSpan, Duration duration) => timeSpan.TotalSeconds <= duration.Second;
    public static bool operator >=(TimeSpan timeSpan, Duration duration) => timeSpan.TotalSeconds >= duration.Second;
}

public readonly partial struct AmountOfSubstance
{
    /// <summary>Particles per mole: exactly 6.02214076e23 (SI 2019).</summary>
    public static double AvogadroConstant { get; } = 6.02214076e23;

    /// <summary>The number of particles (atoms or molecules) in this amount of substance.</summary>
    public double NumberOfParticles() => AvogadroConstant * Mole;

    public static AmountOfSubstance FromMass(Mass mass, MolarMass molarMass) => mass / molarMass;
    public static AmountOfSubstance? FromMass(Mass? mass, MolarMass? molarMass) => mass is { } m && molarMass is { } mm ? FromMass(m, mm) : null;
}

public readonly partial struct Ratio
{
    // A ratio is a plain number, so it converts to and from one (EngineeringUnits: RatioExtra.cs)
    public static explicit operator Ratio(double value) => new(value);
    public static explicit operator Ratio(int value) => new(value);
    public static explicit operator Ratio(decimal value) => new((double)value);
    public static explicit operator double(Ratio ratio) => ratio._si;
    public static explicit operator int(Ratio ratio) => (int)ratio._si;
    public static explicit operator decimal(Ratio ratio) => (decimal)ratio._si;
}

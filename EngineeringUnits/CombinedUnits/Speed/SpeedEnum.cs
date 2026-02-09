using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record SpeedUnit : UnitTypebase
{

    // SpeedUnit synonyms (case-insensitive-safe)

    // --- centimeter ---
    [Synonyms(
        "cm/h", "cm/hr", "cm per hour",
        "centimeter per hour", "centimeters per hour",
        "centimeterperhour", "centimetersperhour"
    )]
    public static readonly SpeedUnit CentimeterPerHour = new(LengthUnit.Centimeter, DurationUnit.Hour);

    [Synonyms(
        "cm/min", "cm per minute",
        "centimeter per minute", "centimeters per minute",
        "centimeterperminute", "centimetersperminute"
    )]
    public static readonly SpeedUnit CentimeterPerMinute = new(LengthUnit.Centimeter, DurationUnit.Minute);

    [Synonyms(
        "cm/s", "cm/sec", "cm per second",
        "centimeter per second", "centimeters per second",
        "centimeterpersecond", "centimeterspersecond"
    )]
    public static readonly SpeedUnit CentimeterPerSecond = new(LengthUnit.Centimeter, DurationUnit.Second);

    // --- decimeter ---
    [Synonyms(
        "dm/min", "dm per minute",
        "decimeter per minute", "decimeters per minute",
        "decimeterperminute", "decimetersperminute"
    )]
    public static readonly SpeedUnit DecimeterPerMinute = new(LengthUnit.Decimeter, DurationUnit.Minute);

    [Synonyms(
        "dm/s", "dm/sec", "dm per second",
        "decimeter per second", "decimeters per second",
        "decimeterpersecond", "decimeterspersecond"
    )]
    public static readonly SpeedUnit DecimeterPerSecond = new(LengthUnit.Decimeter, DurationUnit.Second);

    // --- foot ---
    [Synonyms(
        "ft/h", "ft/hr", "ft per hour",
        "foot per hour", "feet per hour",
        "footperhour", "feetperhour"
    )]
    public static readonly SpeedUnit FootPerHour = new(LengthUnit.Foot, DurationUnit.Hour);

    [Synonyms(
        "ft/min", "ft per minute",
        "foot per minute", "feet per minute",
        "footperminute", "feeperminute" // (optional typo-robustness)
    )]
    public static readonly SpeedUnit FootPerMinute = new(LengthUnit.Foot, DurationUnit.Minute);

    [Synonyms(
        "ft/s", "ft/sec", "fps", "ft per second",
        "foot per second", "feet per second",
        "footpersecond", "feetpersecond"
    )]
    public static readonly SpeedUnit FootPerSecond = new(LengthUnit.Foot, DurationUnit.Second);

    // --- inch ---
    [Synonyms(
        "in/h", "in/hr", "inch per hour", "inches per hour",
        "inchperhour", "inchesperhour"
    )]
    public static readonly SpeedUnit InchPerHour = new(LengthUnit.Inch, DurationUnit.Hour);

    [Synonyms(
        "in/min", "inch per minute", "inches per minute",
        "inchperminute", "inchesperminute"
    )]
    public static readonly SpeedUnit InchPerMinute = new(LengthUnit.Inch, DurationUnit.Minute);

    [Synonyms(
        "in/s", "in/sec", "ips",
        "inch per second", "inches per second",
        "inchpersecond", "inchespersecond"
    )]
    public static readonly SpeedUnit InchPerSecond = new(LengthUnit.Inch, DurationUnit.Second);

    // --- kilometer ---
    [Synonyms(
        "km/h", "km/hr", "kph",
        "kilometer per hour", "kilometers per hour",
        "kilometre per hour", "kilometres per hour",
        "kilometerperhour", "kilometersperhour",
        "kilometreperhour", "kilometresperhour"
    )]
    public static readonly SpeedUnit KilometerPerHour = new(LengthUnit.Kilometer, DurationUnit.Hour);

    [Synonyms(
        "km/min", "km per minute",
        "kilometer per minute", "kilometers per minute",
        "kilometre per minute", "kilometres per minute",
        "kilometerperminute", "kilometersperminute",
        "kilometreperminute", "kilometresperminute"
    )]
    public static readonly SpeedUnit KilometerPerMinute = new(LengthUnit.Kilometer, DurationUnit.Minute);

    [Synonyms(
        "km/s", "km/sec", "km per second",
        "kilometer per second", "kilometers per second",
        "kilometre per second", "kilometres per second",
        "kilometerpersecond", "kilometerspersecond",
        "kilometrepersecond", "kilometrespersecond"
    )]
    public static readonly SpeedUnit KilometerPerSecond = new(LengthUnit.Kilometer, DurationUnit.Second);

    // --- knot ---
    // NOTE: I intentionally avoid "kn" here to reduce collisions with kilonewton (kN) in other dimensions.
    // Add "kn" back if you prefer knots to be parsed from "kn".
    [Synonyms(
        "kt", "kts",
        "knot", "knots",
        "nautical mile per hour", "nautical miles per hour",
        "nauticalmileperhour", "nauticalmilesperhour"
    )]
    public static readonly SpeedUnit Knot = new(LengthUnit.NauticalMile, DurationUnit.Hour, "kn");

    // --- meter ---
    [Synonyms(
        "m/h", "m/hr", "m per hour",
        "meter per hour", "meters per hour",
        "metre per hour", "metres per hour",
        "meterperhour", "metersperhour",
        "metreperhour", "metresperhour"
    )]
    public static readonly SpeedUnit MeterPerHour = new(LengthUnit.Meter, DurationUnit.Hour);

    [Synonyms(
        "m/min", "m per minute",
        "meter per minute", "meters per minute",
        "metre per minute", "metres per minute",
        "meterperminute", "metersperminute",
        "metreperminute", "metresperminute"
    )]
    public static readonly SpeedUnit MeterPerMinute = new(LengthUnit.Meter, DurationUnit.Minute);

    [Synonyms(
        "m/s", "m/sec", "mps",
        "meter per second", "meters per second",
        "metre per second", "metres per second",
        "meterpersecond", "meterspersecond",
        "metrepersecond", "metrespersecond"
    )]
    public static readonly SpeedUnit MeterPerSecond = new(LengthUnit.Meter, DurationUnit.Second);

    // --- micrometer ---
    [Synonyms(
        "um/min", "µm/min", "um per minute", "micrometer per minute", "micrometers per minute",
        "micrometre per minute", "micrometres per minute",
        "micrometerperminute", "micrometersperminute"
    )]
    public static readonly SpeedUnit MicrometerPerMinute = new(LengthUnit.Micrometer, DurationUnit.Minute);

    [Synonyms(
        "um/s", "um/sec", "µm/s", "µm/sec",
        "um per second",
        "micrometer per second", "micrometers per second",
        "micrometre per second", "micrometres per second",
        "micrometerpersecond", "micrometerspersecond"
    )]
    public static readonly SpeedUnit MicrometerPerSecond = new(LengthUnit.Micrometer, DurationUnit.Second);

    // --- mile ---
    [Synonyms(
        "mph",
        "mi/h", "mi/hr", "mile per hour", "miles per hour",
        "mileperhour", "milesperhour"
    )]
    public static readonly SpeedUnit MilePerHour = new(LengthUnit.Mile, DurationUnit.Hour, "mph");

    // --- millimeter ---
    [Synonyms(
        "mm/h", "mm/hr", "mm per hour",
        "millimeter per hour", "millimeters per hour",
        "millimetre per hour", "millimetres per hour",
        "millimeterperhour", "millimetersperhour"
    )]
    public static readonly SpeedUnit MillimeterPerHour = new(LengthUnit.Millimeter, DurationUnit.Hour);

    [Synonyms(
        "mm/min", "mm per minute",
        "millimeter per minute", "millimeters per minute",
        "millimetre per minute", "millimetres per minute",
        "millimeterperminute", "millimetersperminute"
    )]
    public static readonly SpeedUnit MillimeterPerMinute = new(LengthUnit.Millimeter, DurationUnit.Minute);

    [Synonyms(
        "mm/s", "mm/sec", "mm per second",
        "millimeter per second", "millimeters per second",
        "millimetre per second", "millimetres per second",
        "millimeterpersecond", "millimeterspersecond"
    )]
    public static readonly SpeedUnit MillimeterPerSecond = new(LengthUnit.Millimeter, DurationUnit.Second);

    // --- nanometer ---
    [Synonyms(
        "nm/min", "nm per minute",
        "nanometer per minute", "nanometers per minute",
        "nanometre per minute", "nanometres per minute",
        "nanometerperminute", "nanometersperminute"
    )]
    public static readonly SpeedUnit NanometerPerMinute = new(LengthUnit.Nanometer, DurationUnit.Minute);

    [Synonyms(
        "nm/s", "nm/sec", "nm per second",
        "nanometer per second", "nanometers per second",
        "nanometre per second", "nanometres per second",
        "nanometerpersecond", "nanometerspersecond"
    )]
    public static readonly SpeedUnit NanometerPerSecond = new(LengthUnit.Nanometer, DurationUnit.Second);

    // --- US survey foot ---
    [Synonyms(
        "us survey ft/h", "us survey ft/hr", "usft/h", "usft/hr",
        "survey foot per hour", "survey feet per hour",
        "us survey foot per hour", "us survey feet per hour",
        "ussurveyfootperhour", "ussurveyfeetperhour"
    )]
    public static readonly SpeedUnit UsSurveyFootPerHour = new(LengthUnit.UsSurveyFoot, DurationUnit.Hour);

    [Synonyms(
        "us survey ft/min", "usft/min",
        "survey foot per minute", "survey feet per minute",
        "us survey foot per minute", "us survey feet per minute",
        "ussurveyfootperminute", "ussurveyfeetperminute"
    )]
    public static readonly SpeedUnit UsSurveyFootPerMinute = new(LengthUnit.UsSurveyFoot, DurationUnit.Minute);

    [Synonyms(
        "us survey ft/s", "us survey ft/sec", "usft/s", "usft/sec",
        "survey foot per second", "survey feet per second",
        "us survey foot per second", "us survey feet per second",
        "ussurveyfootpersecond", "ussurveyfeetpersecond"
    )]
    public static readonly SpeedUnit UsSurveyFootPerSecond = new(LengthUnit.UsSurveyFoot, DurationUnit.Second);

    // --- yard ---
    [Synonyms(
        "yd/h", "yd/hr", "yard per hour", "yards per hour",
        "yardperhour", "yardsperhour"
    )]
    public static readonly SpeedUnit YardPerHour = new(LengthUnit.Yard, DurationUnit.Hour);

    [Synonyms(
        "yd/min", "yard per minute", "yards per minute",
        "yardperminute", "yardsperminute"
    )]
    public static readonly SpeedUnit YardPerMinute = new(LengthUnit.Yard, DurationUnit.Minute);

    [Synonyms(
        "yd/s", "yd/sec", "yard per second", "yards per second",
        "yardpersecond", "yardspersecond"
    )]
    public static readonly SpeedUnit YardPerSecond = new(LengthUnit.Yard, DurationUnit.Second);

    // --- duplicate spelling variant (KilometerPerhour) ---
    [Synonyms(
        "km/h", "km/hr", "kph",
        "kilometer per hour", "kilometers per hour",
        "kilometre per hour", "kilometres per hour",
        "kilometerperhour", "kilometersperhour",
        "kilometreperhour", "kilometresperhour"
    )]
    public static readonly SpeedUnit KilometerPerhour = new(LengthUnit.Kilometer, DurationUnit.Hour);

    // --- SI ---
    [Synonyms(
        "m/s", "m/sec", "mps",
        "meter per second", "meters per second",
        "metre per second", "metres per second",
        "si", "si unit", "si speed", "sispeed"
    )]
    public static readonly SpeedUnit SI = new(LengthUnit.SI, DurationUnit.SI);

    // --- mile per second ---
    [Synonyms(
        "mi/s", "mi/sec", "mile per second", "miles per second",
        "milepersecond", "milespersecond"
    )]
    public static readonly SpeedUnit MilePerSecond = new(LengthUnit.Mile, DurationUnit.Second);

    public SpeedUnit(LengthUnit length, DurationUnit time)
    {
        Unit = length / time;
    }

    public SpeedUnit(LengthUnit length, DurationUnit time, string NewSymbol)
    {
        Unit = new UnitSystem(length / time, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
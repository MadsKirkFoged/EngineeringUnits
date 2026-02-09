using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits.Units;

public partial record AngleUnit : UnitTypebase
{
    public static readonly AngleUnit SI = new("°", 1m);

    [Synonyms("arcminute", "arcminutes", "minute of arc", "minutes of arc")]
    public static readonly AngleUnit Arcminute = new("'", 1 / 60m);

    [Synonyms("arcsecond", "arcseconds", "second of arc", "seconds of arc")]
    public static readonly AngleUnit Arcsecond = new("″", 1 / 3600m);

    [Synonyms("gradian", "gradians", "gon", "gons")]
    public static readonly AngleUnit Gradian = new("g", 0.9m);

    [Synonyms("radian", "radians", "rad")]
    public static readonly AngleUnit Radian = new("rad", (decimal)(180 / Math.PI));

    public static readonly AngleUnit Centiradian = new(PreFix.centi, Radian);
    public static readonly AngleUnit Deciradian = new(PreFix.deci, Radian);
    public static readonly AngleUnit Microradian = new(PreFix.micro, Radian);
    public static readonly AngleUnit Milliradian = new(PreFix.milli, Radian);
    public static readonly AngleUnit Nanoradian = new(PreFix.nano, Radian);

    [Synonyms("degree", "degrees", "deg")]
    public static readonly AngleUnit Degree = new("°", 1m);

    public static readonly AngleUnit Microdegree = new(PreFix.micro, Degree);
    public static readonly AngleUnit Millidegree = new(PreFix.milli, Degree);
    public static readonly AngleUnit Nanodegree = new(PreFix.nano, Degree);

    // Skipping short token "r" (too ambiguous). Use words only.
    [Synonyms("revolution", "revolutions", "turn", "turns")]
    public static readonly AngleUnit Revolution = new("r", 360m);
    //public static readonly AngleUnit Tilt = new AngleUnit("", Math.Asin(_value)*180/Math.PI); //TODO How do we do this?

    public AngleUnit(string NewSymbol, decimal correction)
    {
        Unit = new UnitSystem(correction, NewSymbol);
    }

    public AngleUnit(PreFix SI, AngleUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
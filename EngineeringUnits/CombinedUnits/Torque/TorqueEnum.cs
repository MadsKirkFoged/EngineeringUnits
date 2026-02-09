using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record TorqueUnit : UnitTypebase
{

    // TorqueUnit synonyms (case-insensitive-safe; avoids case-dependent prefix symbols like m vs M)

    // SI / base (same physical unit as N·m)
    [Synonyms(
        "n*m", "n·m", "n m", "n-m", "nm",
        "newton meter", "newton meters",
        "newton metre", "newton metres",
        "newton-meter", "newton-metre",
        "newtonmeter", "newtonmetre"
    )]
    public static readonly TorqueUnit SI = new(ForceUnit.SI, LengthUnit.SI);

    [Synonyms(
        "n*m", "n·m", "n m", "n-m", "nm",
        "newton meter", "newton meters",
        "newton metre", "newton metres",
        "newton-meter", "newton-metre",
        "newtonmeter", "newtonmetre"
    )]
    public static readonly TorqueUnit NewtonMeter = new(ForceUnit.Newton, LengthUnit.Meter);

    // kilo-newton meter (k is safe even with case-insensitive parsing)
    [Synonyms(
        "kn*m", "kn·m", "kn m", "kn-m", "knm",
        "kilonewton meter", "kilonewton meters",
        "kilonewton metre", "kilonewton metres",
        "kilonewton-meter", "kilonewton-metre",
        "kilonewtonmeter", "kilonewtonmetre"
    )]
    public static readonly TorqueUnit KilonewtonMeter = new(PreFix.kilo, NewtonMeter);

    // mega-newton meter (avoid symbol forms like MN·m if case-insensitive)
    [Synonyms(
        "meganewton meter", "meganewton meters",
        "meganewton metre", "meganewton metres",
        "mega newton meter", "mega newton metres",
        "meganewton-meter", "meganewton-metre",
        "meganewtonmeter", "meganewtonmetre"
    )]
    public static readonly TorqueUnit MeganewtonMeter = new(PreFix.mega, NewtonMeter);

    // newton millimeter
    [Synonyms(
        "n*mm", "n·mm", "n mm", "n-mm", "nmm",
        "newton millimeter", "newton millimeters",
        "newton millimetre", "newton millimetres",
        "newton-millimeter", "newton-millimetre",
        "newtonmillimeter", "newtonmillimetre"
    )]
    public static readonly TorqueUnit NewtonMillimeter = new(ForceUnit.Newton, LengthUnit.Millimeter);

    // kilo-newton millimeter
    [Synonyms(
        "kn*mm", "kn·mm", "kn mm", "kn-mm", "knmm",
        "kilonewton millimeter", "kilonewton millimeters",
        "kilonewton millimetre", "kilonewton millimetres",
        "kilonewton-millimeter", "kilonewton-millimetre",
        "kilonewtonmillimeter", "kilonewtonmillimetre"
    )]
    public static readonly TorqueUnit KilonewtonMillimeter = new(PreFix.kilo, NewtonMillimeter);

    // mega-newton millimeter (avoid MNmm symbol)
    [Synonyms(
        "meganewton millimeter", "meganewton millimeters",
        "meganewton millimetre", "meganewton millimetres",
        "mega newton millimeter", "mega newton millimetres",
        "meganewton-millimeter", "meganewton-millimetre",
        "meganewtonmillimeter", "meganewtonmillimetre"
    )]
    public static readonly TorqueUnit MeganewtonMillimeter = new(PreFix.mega, NewtonMillimeter);

    // newton centimeter
    [Synonyms(
        "n*cm", "n·cm", "n cm", "n-cm", "ncm",
        "newton centimeter", "newton centimeters",
        "newton centimetre", "newton centimetres",
        "newton-centimeter", "newton-centimetre",
        "newtoncentimeter", "newtoncentimetre"
    )]
    public static readonly TorqueUnit NewtonCentimeter = new(ForceUnit.Newton, LengthUnit.Centimeter);

    // mega-newton centimeter (avoid MNcm symbol)
    [Synonyms(
        "meganewton centimeter", "meganewton centimeters",
        "meganewton centimetre", "meganewton centimetres",
        "mega newton centimeter", "mega newton centimetres",
        "meganewton-centimeter", "meganewton-centimetre",
        "meganewtoncentimeter", "meganewtoncentimetre"
    )]
    public static readonly TorqueUnit MeganewtonCentimeter = new(PreFix.mega, NewtonCentimeter);

    // poundal-foot
    [Synonyms(
        "pdl*ft", "pdl·ft", "pdl ft", "pdl-ft",
        "poundal foot", "poundal feet",
        "poundal-foot", "poundalfoot"
    )]
    public static readonly TorqueUnit PoundalFoot = new(ForceUnit.Poundal, LengthUnit.Foot);

    // pound-force foot (lb-ft is common; keep it, but avoid generic "pound foot")
    [Synonyms(
        "lbf*ft", "lbf·ft", "lbf ft", "lbf-ft",
        "lb-ft", "lb*ft", "lb·ft", "lbft",
        "pound-force foot", "pound-force feet",
        "pound force foot", "pound force feet",
        "poundforcefoot", "poundforcefeet"
    )]
    public static readonly TorqueUnit PoundForceFoot = new(ForceUnit.PoundForce, LengthUnit.Foot);

    // pound-force inch
    [Synonyms(
        "lbf*in", "lbf·in", "lbf in", "lbf-in",
        "lb-in", "lb*in", "lb·in", "lbin",
        "pound-force inch", "pound-force inches",
        "pound force inch", "pound force inches",
        "poundforceinch", "poundforceinches"
    )]
    public static readonly TorqueUnit PoundForceInch = new(ForceUnit.PoundForce, LengthUnit.Inch);

    // tonne-force centimeter (avoid ambiguous tf-only shorthand; use words)
    [Synonyms(
        "tonne-force centimeter", "tonne-force centimeters",
        "tonne force centimeter", "tonne force centimeters",
        "metric ton-force centimeter", "metric ton-force centimeters",
        "tonneforcecentimeter", "tonneforcecentimeters"
    )]
    public static readonly TorqueUnit TonneForceCentimeter = new(ForceUnit.TonneForce, LengthUnit.Centimeter);

    // tonne-force meter
    [Synonyms(
        "tonne-force meter", "tonne-force meters",
        "tonne force meter", "tonne force meters",
        "metric ton-force meter", "metric ton-force meters",
        "tonneforcemeter", "tonneforcemeters"
    )]
    public static readonly TorqueUnit TonneForceMeter = new(ForceUnit.TonneForce, LengthUnit.Meter);

    // tonne-force millimeter
    [Synonyms(
        "tonne-force millimeter", "tonne-force millimeters",
        "tonne force millimeter", "tonne force millimeters",
        "metric ton-force millimeter", "metric ton-force millimeters",
        "tonneforcemillimeter", "tonneforcemillimeters"
    )]
    public static readonly TorqueUnit TonneForceMillimeter = new(ForceUnit.TonneForce, LengthUnit.Millimeter);

    // kilo-newton centimeter
    [Synonyms(
        "kn*cm", "kn·cm", "kn cm", "kn-cm", "kncm",
        "kilonewton centimeter", "kilonewton centimeters",
        "kilonewton centimetre", "kilonewton centimetres",
        "kilonewton-centimeter", "kilonewton-centimetre",
        "kilonewtoncentimeter", "kilonewtoncentimetre"
    )]
    public static readonly TorqueUnit KilonewtonCentimeter = new(PreFix.kilo, NewtonCentimeter);

    // kilogram-force centimeter
    [Synonyms(
        "kgf*cm", "kgf·cm", "kgf cm", "kgf-cm",
        "kilogram-force centimeter", "kilogram-force centimeters",
        "kilogram force centimeter", "kilogram force centimeters",
        "kilogramforcecentimeter", "kilogramforcecentimeters",
        "kp*cm", "kp·cm", "kp cm", "kp-cm" // kp = kilopond (common legacy)
    )]
    public static readonly TorqueUnit KilogramForceCentimeter = new(ForceUnit.KilogramForce, LengthUnit.Centimeter);

    // kilogram-force meter
    [Synonyms(
        "kgf*m", "kgf·m", "kgf m", "kgf-m", "kgfm",
        "kilogram-force meter", "kilogram-force meters",
        "kilogram force meter", "kilogram force meters",
        "kilogramforcemeter", "kilogramforcemeters",
        "kp*m", "kp·m", "kp m", "kp-m", "kpm"
    )]
    public static readonly TorqueUnit KilogramForceMeter = new(ForceUnit.KilogramForce, LengthUnit.Meter);

    // kilogram-force millimeter
    [Synonyms(
        "kgf*mm", "kgf·mm", "kgf mm", "kgf-mm", "kgfmm",
        "kilogram-force millimeter", "kilogram-force millimeters",
        "kilogram force millimeter", "kilogram force millimeters",
        "kilogramforcemillimeter", "kilogramforcemillimeters",
        "kp*mm", "kp·mm", "kp mm", "kp-mm"
    )]
    public static readonly TorqueUnit KilogramForceMillimeter = new(ForceUnit.KilogramForce, LengthUnit.Millimeter);

    // kilopound-force foot (kip-ft is common)
    [Synonyms(
        "kip*ft", "kip·ft", "kip ft", "kip-ft", "kipft",
        "kilopound-force foot", "kilopound-force feet",
        "kilopound force foot", "kilopound force feet",
        "kilopoundforcefoot", "kilopoundforcefeet"
    )]
    public static readonly TorqueUnit KilopoundForceFoot = new(ForceUnit.KilopoundForce, LengthUnit.Foot);

    // megapound-force foot (use words to avoid any case-dependent abbreviation conventions)
    [Synonyms(
        "megapound-force foot", "megapound-force feet",
        "megapound force foot", "megapound force feet",
        "million pound-force foot", "million pound-force feet",
        "megapoundforcefoot", "megapoundforcefeet"
    )]
    public static readonly TorqueUnit MegapoundForceFoot = new(ForceUnit.MegapoundForce, LengthUnit.Foot);

    // kilopound-force inch (kip-in is common)
    [Synonyms(
        "kip*in", "kip·in", "kip in", "kip-in", "kipin",
        "kilopound-force inch", "kilopound-force inches",
        "kilopound force inch", "kilopound force inches",
        "kilopoundforceinch", "kilopoundforceinches"
    )]
    public static readonly TorqueUnit KilopoundForceInch = new(ForceUnit.KilopoundForce, LengthUnit.Inch);

    // megapound-force inch
    [Synonyms(
        "megapound-force inch", "megapound-force inches",
        "megapound force inch", "megapound force inches",
        "million pound-force inch", "million pound-force inches",
        "megapoundforceinch", "megapoundforceinches"
    )]
    public static readonly TorqueUnit MegapoundForceInch = new(ForceUnit.MegapoundForce, LengthUnit.Inch);

    public TorqueUnit(ForceUnit force, LengthUnit length)
    {
        Unit = new UnitSystem(force * length,
                           $"{force}·{length}");
    }

    public TorqueUnit(PreFix SI, TorqueUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
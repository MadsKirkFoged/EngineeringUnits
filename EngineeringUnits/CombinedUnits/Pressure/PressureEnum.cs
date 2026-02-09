using EngineeringUnits.Parsing;
using Fractions;
using System;
using System.Linq;

namespace EngineeringUnits.Units;

public partial record PressureUnit : UnitTypebase
{
    // PressureUnit synonyms (case-insensitive-safe; no case-dependent symbols)

    // Base / SI
    [Synonyms(
        "pa",
        "pascal", "pascals",
        "n/m2", "n/m^2", "n/m²",
        "newton per square meter", "newtons per square meter",
        "newtonpersquaremeter", "newtonspersquaremeter"
    )]
    public static readonly PressureUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");

    [Synonyms(
        "pa",
        "pascal", "pascals",
        "n/m2", "n/m^2", "n/m²",
        "newton per square meter", "newtons per square meter",
        "newtonpersquaremeter", "newtonspersquaremeter"
    )]
    public static readonly PressureUnit Pascal = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");

    // Prefixed pascals (avoid symbol collisions like mpa = milli/mega if case-insensitive)
    [Synonyms(
        "upa", "µpa", "u pa", "micro pa",
        "micropascal", "micropascals",
        "micro-pascal", "micro-pascals"
    )]
    public static readonly PressureUnit Micropascal = new(PreFix.micro, Pascal);

    [Synonyms(
        "milli pascal",
        "millipascal", "millipascals",
        "milli-pascal", "milli-pascals"
    )]
    public static readonly PressureUnit Millipascal = new(PreFix.milli, Pascal);

    [Synonyms(
        "dapa", "da pa", "deka pa",
        "decapascal", "decapascals",
        "deka-pascal", "deka-pascals"
    )]
    public static readonly PressureUnit Decapascal = new(PreFix.deka, Pascal);

    [Synonyms(
        "hpa",
        "hectopascal", "hectopascals",
        "hecto-pascal", "hecto-pascals"
    // NOTE: hPa == mbar in magnitude. If you want strict 1:1 mapping, don't cross-alias.
    )]
    public static readonly PressureUnit Hectopascal = new(PreFix.hecto, Pascal);

    [Synonyms(
        "kpa",
        "kilopascal", "kilopascals",
        "kilo-pascal", "kilo-pascals"
    )]
    public static readonly PressureUnit Kilopascal = new(PreFix.kilo, Pascal);

    [Synonyms(
        "megapascal", "megapascals",
        "mega pascal", "mega pascals",
        "mega-pascal", "mega-pascals"
    )]
    public static readonly PressureUnit Megapascal = new(PreFix.mega, Pascal);

    [Synonyms(
        "gpa",
        "gigapascal", "gigapascals",
        "giga-pascal", "giga-pascals"
    )]
    public static readonly PressureUnit Gigapascal = new(PreFix.giga, Pascal);

    // Common non-SI pressure units
    [Synonyms(
        "atm",
        "atmosphere", "atmospheres",
        "standard atmosphere", "standard atmospheres",
        "std atm", "satm"
    )]
    public static readonly PressureUnit Atmosphere = new(Pascal, "atm", 101325m);

    [Synonyms(
        "ft of head", "ft head",
        "ft of water", "ft water",
        "ft h2o", "fth2o", "ft h₂o",
        "foot of head", "feet of head",
        "foot of water", "feet of water"
    )]
    public static readonly PressureUnit FootOfHead = new(Pascal, "ft of head", 2989.0669m);

    [Synonyms(
        "inhg", "in hg",
        "inch of mercury", "inches of mercury",
        "in. hg", "\"hg"
    )]
    public static readonly PressureUnit InchOfMercury = new(Pascal, "inHg", 1 / 0.000295299830714159m);

    [Synonyms(
        "inh2o", "in h2o",
        "in wc", "in.wc", "in w.c.", "iwc",
        "inch of water", "inches of water",
        "inch of water column", "inches of water column"
    )]
    public static readonly PressureUnit InchOfWaterColumn = new(Pascal, "inH2O", 249.08890833333m);

    [Synonyms(
        "m of head", "m head",
        "m of water", "m water",
        "m h2o", "mh2o", "m h₂o",
        "meter of head", "meters of head",
        "meter of water", "meters of water"
    )]
    public static readonly PressureUnit MeterOfHead = new(Pascal, "m of head", 9804.139432m);

    [Synonyms(
        "mmhg", "mm hg",
        "millimeter of mercury", "millimeters of mercury"
    )]
    public static readonly PressureUnit MillimeterOfMercury = new(Pascal, "mmHg", 1 / 7.50061561302643e-3m);

    [Synonyms(
        "at",
        "technical atmosphere", "technical atmospheres",
        "atmosphere technical"
    )]
    public static readonly PressureUnit TechnicalAtmosphere = new(Pascal, "at", 9.80680592331m * 1e4m);

    [Synonyms(
        "torr",
        "tor"
    )]
    public static readonly PressureUnit Torr = new(Pascal, "torr", 1.3332266752m * 1e2m);

    // Bar family (avoid mbar/Mbar collision: keep mbar for millibar, use words only for megabar)
    [Synonyms(
        "bar",
        "bars"
    )]
    public static readonly PressureUnit Bar = new(Pascal, "bar", 100000m);

    [Synonyms(
        "ubar", "µbar", "u bar", "micro bar",
        "microbar", "microbars",
        "micro-bar", "micro-bars"
    )]
    public static readonly PressureUnit Microbar = new(PreFix.micro, Bar);

    [Synonyms(
        "mbar",
        "millibar", "millibars",
        "milli-bar", "milli-bars"
    )]
    public static readonly PressureUnit Millibar = new(PreFix.milli, Bar);

    [Synonyms(
        "cbar",
        "centibar", "centibars",
        "centi-bar", "centi-bars"
    )]
    public static readonly PressureUnit Centibar = new(PreFix.centi, Bar);

    [Synonyms(
        "dbar",
        "decibar", "decibars",
        "deci-bar", "deci-bars"
    )]
    public static readonly PressureUnit Decibar = new(PreFix.deci, Bar);

    [Synonyms(
        "kbar",
        "kilobar", "kilobars",
        "kilo-bar", "kilo-bars"
    )]
    public static readonly PressureUnit Kilobar = new(PreFix.kilo, Bar);

    [Synonyms(
        "megabar", "megabars",
        "mega-bar", "mega-bars"
    )]
    public static readonly PressureUnit Megabar = new(PreFix.mega, Bar);

    // Force / area forms (case-insensitive-safe; use lowercase symbols)
    [Synonyms(
        "dyn/cm2", "dyn/cm^2", "dyn/cm²",
        "dyne/cm2", "dyne/cm^2", "dyne/cm²",
        "dyne per square centimeter", "dynes per square centimeter"
    )]
    public static readonly PressureUnit DynePerSquareCentimeter = new(ForceUnit.Dyn, AreaUnit.SquareCentimeter);

    [Synonyms(
        "kgf/cm2", "kgf/cm^2", "kgf/cm²",
        "kilogram-force per square centimeter", "kilogram force per square centimeter",
        "kp/cm2", "kp/cm^2", "kp/cm²"
    )]
    public static readonly PressureUnit KilogramForcePerSquareCentimeter = new(ForceUnit.KilogramForce, AreaUnit.SquareCentimeter);

    [Synonyms(
        "kgf/m2", "kgf/m^2", "kgf/m²",
        "kilogram-force per square meter", "kilogram force per square meter"
    )]
    public static readonly PressureUnit KilogramForcePerSquareMeter = new(ForceUnit.KilogramForce, AreaUnit.SquareMeter);

    [Synonyms(
        "kgf/mm2", "kgf/mm^2", "kgf/mm²",
        "kilogram-force per square millimeter", "kilogram force per square millimeter"
    )]
    public static readonly PressureUnit KilogramForcePerSquareMillimeter = new(ForceUnit.KilogramForce, AreaUnit.SquareMillimeter);

    [Synonyms(
        "kn/cm2", "kn/cm^2", "kn/cm²",
        "kilonewton per square centimeter", "kilonewtons per square centimeter"
    )]
    public static readonly PressureUnit KilonewtonPerSquareCentimeter = new(ForceUnit.Kilonewton, AreaUnit.SquareCentimeter);

    [Synonyms(
        "kn/m2", "kn/m^2", "kn/m²",
        "kilonewton per square meter", "kilonewtons per square meter"
    )]
    public static readonly PressureUnit KilonewtonPerSquareMeter = new(ForceUnit.Kilonewton, AreaUnit.SquareMeter);

    [Synonyms(
        "kn/mm2", "kn/mm^2", "kn/mm²",
        "kilonewton per square millimeter", "kilonewtons per square millimeter"
    )]
    public static readonly PressureUnit KilonewtonPerSquareMillimeter = new(ForceUnit.Kilonewton, AreaUnit.SquareMillimeter);

    [Synonyms(
        "meganewton per square meter", "meganewtons per square meter",
        "mega newton per square meter", "mega newtons per square meter"
    )]
    public static readonly PressureUnit MeganewtonPerSquareMeter = new(ForceUnit.Meganewton, AreaUnit.SquareMeter);

    [Synonyms(
        "tf/cm2", "tf/cm^2", "tf/cm²",
        "tonne-force per square centimeter", "tonne force per square centimeter",
        "metric ton-force per square centimeter"
    )]
    public static readonly PressureUnit TonneForcePerSquareCentimeter = new(ForceUnit.TonneForce, AreaUnit.SquareCentimeter);

    [Synonyms(
        "tf/m2", "tf/m^2", "tf/m²",
        "tonne-force per square meter", "tonne force per square meter",
        "metric ton-force per square meter"
    )]
    public static readonly PressureUnit TonneForcePerSquareMeter = new(ForceUnit.TonneForce, AreaUnit.SquareMeter);

    [Synonyms(
        "tf/mm2", "tf/mm^2", "tf/mm²",
        "tonne-force per square millimeter", "tonne force per square millimeter",
        "metric ton-force per square millimeter"
    )]
    public static readonly PressureUnit TonneForcePerSquareMillimeter = new(ForceUnit.TonneForce, AreaUnit.SquareMillimeter);

    // Newton / area
    [Synonyms(
        "n/mm2", "n/mm^2", "n/mm²",
        "newton per square millimeter", "newtons per square millimeter"
    )]
    public static readonly PressureUnit NewtonPerSquareMillimeter = new(ForceUnit.Newton, AreaUnit.SquareMillimeter);

    [Synonyms(
        "n/cm2", "n/cm^2", "n/cm²",
        "newton per square centimeter", "newtons per square centimeter"
    )]
    public static readonly PressureUnit NewtonPerSquareCentimeter = new(ForceUnit.Newton, AreaUnit.SquareCentimeter);

    [Synonyms(
        "n/m2", "n/m^2", "n/m²",
        "newton per square meter", "newtons per square meter"
    )]
    public static readonly PressureUnit NewtonPerSquareMeter = new(ForceUnit.Newton, AreaUnit.SquareMeter);

    // Imperial pressure units (case-insensitive-safe; lowercase symbols)
    [Synonyms(
        "ksf",
        "kip/ft2", "kip/ft^2", "kip/ft²",
        "kip per square foot", "kips per square foot",
        "klbf/ft2", "klbf/ft^2", "klbf/ft²",
        "kilopound-force per square foot", "kilopound force per square foot"
    )]
    public static readonly PressureUnit KilopoundForcePerSquareFoot = new(ForceUnit.KilopoundForce, AreaUnit.SquareFoot);

    [Synonyms(
        "ksi",
        "kip/in2", "kip/in^2", "kip/in²",
        "kip per square inch", "kips per square inch",
        "klbf/in2", "klbf/in^2", "klbf/in²",
        "kilopound-force per square inch", "kilopound force per square inch"
    )]
    public static readonly PressureUnit KilopoundForcePerSquareInch = new(ForceUnit.KilopoundForce, AreaUnit.SquareInch, "ksi");

    [Synonyms(
        "lb/ft2", "lb/ft^2", "lb/ft²",
        "lbf/ft2", "lbf/ft^2", "lbf/ft²",
        "psf",
        "pound-force per square foot", "pound force per square foot"
    )]
    public static readonly PressureUnit PoundForcePerSquareFoot = new(ForceUnit.PoundForce, AreaUnit.SquareFoot, "lb/ft²");

    [Synonyms(
        "psi",
        "lb/in2", "lb/in^2", "lb/in²",
        "lbf/in2", "lbf/in^2", "lbf/in²",
        "pound-force per square inch", "pound force per square inch"
    )]
    public static readonly PressureUnit PoundForcePerSquareInch = new(ForceUnit.PoundForce, AreaUnit.SquareInch, "psi");

    // lbm/(in·s²) (variants)
    [Synonyms(
        "lbm/(in*s^2)", "lbm/(in*s2)", "lbm/(in·s^2)", "lbm/(in·s²)",
        "lbm/(in s^2)", "lbm/(in s²)",
        "lbm per inch second squared", "pound mass per inch second squared"
    )]
    public static readonly PressureUnit PoundPerInchSecondSquared = new(Pascal, "lbm/(in·s²)", 1.785796732283465e1m);

    // Pressure reference variants (absolute / gauge)
    [Synonyms(
        "bara", "bar(a)", "bar abs", "bar absolute", "bar absolute pressure",
        "bar a"
    )]
    public static readonly PressureUnit BarA = new(Bar, PressureReference.Absolute);

    [Synonyms(
        "barg", "bar(g)", "bar g", "bar gauge", "bar gauge pressure"
    )]
    public static readonly PressureUnit BarG = new(Bar, PressureReference.Gauge);

    public PressureReference Reference { get; private set; }

    public PressureUnit(PressureUnit pressureunit, PressureReference Reference)
    {
        this.Reference = Reference;
        System.Collections.Generic.IEnumerable<RawUnit> ListOfUnits = pressureunit.Unit.ListOfUnits;

        var NewSymbol = Reference switch
        {
            PressureReference.Absolute => pressureunit.Unit.Symbol + "a",
            PressureReference.Gauge => pressureunit.Unit.Symbol + "g",
            _ => throw new NotImplementedException()
        };

        if (Reference is not PressureReference.Absolute)
        {
            var dimensionless = new RawUnit()
            {
                Symbol=null,
                A = Fraction.One,
                UnitType = BaseunitType.CombinedUnit,
                B = Fraction.FromDecimal(101325m),
                Count = 1,
            };

            var test = ListOfUnits.ToList();
            test.Add(dimensionless);

            ListOfUnits = test.AsEnumerable();
        }

        Unit = new UnitSystem([.. ListOfUnits], NewSymbol);
    }

    public PressureUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol)
    {
        Unit = new UnitSystem(mass / (length * duration.Pow(2)), NewSymbol);
        Reference = PressureReference.Undefined;
    }

    public PressureUnit(ForceUnit force, AreaUnit area)
    {
        Unit = new UnitSystem(force / area,
                            $"{force}/{area}");

        Reference = PressureReference.Undefined;
    }

    public PressureUnit(ForceUnit force, AreaUnit area, string NewSymbol)
    {
        Unit = new UnitSystem(force / area, NewSymbol);

        Reference = PressureReference.Undefined;
    }
    public PressureUnit(PreFix SI, PressureUnit unit) : base(SI, unit)
    {
        Reference = PressureReference.Undefined;
    }
    public PressureUnit(PressureUnit unit, string NewSymbol = "Empty", decimal correction = 1) : base(unit, NewSymbol, correction)
    {
        Reference = PressureReference.Undefined;
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
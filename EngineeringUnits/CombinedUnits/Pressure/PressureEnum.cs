using Fractions;
using System;
using System.Collections.Immutable;

namespace EngineeringUnits.Units;

public partial record PressureUnit : UnitTypebase
{
    public static readonly PressureUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
    public static readonly PressureUnit Pascal = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
    public static readonly PressureUnit Micropascal = new(PreFix.micro, Pascal);
    public static readonly PressureUnit Millipascal = new(PreFix.milli, Pascal);
    public static readonly PressureUnit Decapascal = new(PreFix.deka, Pascal);
    public static readonly PressureUnit Hectopascal = new(PreFix.hecto, Pascal);
    public static readonly PressureUnit Kilopascal = new(PreFix.kilo, Pascal);
    public static readonly PressureUnit Megapascal = new(PreFix.mega, Pascal);
    public static readonly PressureUnit Gigapascal = new(PreFix.giga, Pascal);
    public static readonly PressureUnit Atmosphere = new(Pascal, "atm", 101325m);
    public static readonly PressureUnit FootOfHead = new(Pascal, "ft of head", 2989.0669m);
    public static readonly PressureUnit InchOfMercury = new(Pascal, "inHg", 1/0.000295299830714159m);
    public static readonly PressureUnit InchOfWaterColumn = new(Pascal, "inH2O", 249.08890833333m);
    public static readonly PressureUnit MeterOfHead = new(Pascal, "m of head", 9804.139432m);
    public static readonly PressureUnit MillimeterOfMercury = new(Pascal, "mmHg", 1/7.50061561302643e-3m);
    public static readonly PressureUnit TechnicalAtmosphere = new(Pascal, "at", 9.80680592331m * 1e4m);
    public static readonly PressureUnit Torr = new(Pascal, "torr", 1.3332266752m * 1e2m);
    public static readonly PressureUnit Bar = new(Pascal, "bar", 100000m);
    public static readonly PressureUnit Microbar = new(PreFix.micro, Bar);
    public static readonly PressureUnit Millibar = new(PreFix.milli, Bar);
    public static readonly PressureUnit Centibar = new(PreFix.centi, Bar);
    public static readonly PressureUnit Decibar = new(PreFix.deci, Bar);
    public static readonly PressureUnit Kilobar = new(PreFix.kilo, Bar);
    public static readonly PressureUnit Megabar = new(PreFix.mega, Bar);
    public static readonly PressureUnit DynePerSquareCentimeter = new(ForceUnit.Dyn, AreaUnit.SquareCentimeter);
    public static readonly PressureUnit KilogramForcePerSquareCentimeter = new(ForceUnit.KilogramForce, AreaUnit.SquareCentimeter);
    public static readonly PressureUnit KilogramForcePerSquareMeter = new(ForceUnit.KilogramForce, AreaUnit.SquareMeter);
    public static readonly PressureUnit KilogramForcePerSquareMillimeter = new(ForceUnit.KilogramForce, AreaUnit.SquareMillimeter);
    public static readonly PressureUnit KilonewtonPerSquareCentimeter = new(ForceUnit.Kilonewton, AreaUnit.SquareCentimeter);
    public static readonly PressureUnit KilonewtonPerSquareMeter = new(ForceUnit.Kilonewton, AreaUnit.SquareMeter);
    public static readonly PressureUnit KilonewtonPerSquareMillimeter = new(ForceUnit.Kilonewton, AreaUnit.SquareMillimeter);
    public static readonly PressureUnit MeganewtonPerSquareMeter = new(ForceUnit.Meganewton, AreaUnit.SquareMeter);
    public static readonly PressureUnit TonneForcePerSquareCentimeter = new(ForceUnit.TonneForce, AreaUnit.SquareCentimeter);
    public static readonly PressureUnit TonneForcePerSquareMeter = new(ForceUnit.TonneForce, AreaUnit.SquareMeter);
    public static readonly PressureUnit TonneForcePerSquareMillimeter = new(ForceUnit.TonneForce, AreaUnit.SquareMillimeter);
    public static readonly PressureUnit NewtonPerSquareMillimeter = new(ForceUnit.Newton, AreaUnit.SquareMillimeter);
    public static readonly PressureUnit NewtonPerSquareCentimeter = new(ForceUnit.Newton, AreaUnit.SquareCentimeter);
    public static readonly PressureUnit NewtonPerSquareMeter = new(ForceUnit.Newton, AreaUnit.SquareMeter);
    public static readonly PressureUnit KilopoundForcePerSquareFoot = new(ForceUnit.KilopoundForce, AreaUnit.SquareFoot);
    public static readonly PressureUnit KilopoundForcePerSquareInch = new(ForceUnit.KilopoundForce, AreaUnit.SquareInch, "ksi");
    public static readonly PressureUnit PoundForcePerSquareFoot = new(ForceUnit.PoundForce, AreaUnit.SquareFoot, "lb/ft²");
    public static readonly PressureUnit PoundForcePerSquareInch = new(ForceUnit.PoundForce, AreaUnit.SquareInch, "psi");
    public static readonly PressureUnit PoundPerInchSecondSquared = new(Pascal, "lbm/(in·s²)", 1.785796732283465e1m);

    public static readonly PressureUnit BarA = new(Bar, PressureReference.Absolute);
    public static readonly PressureUnit BarG = new(Bar, PressureReference.Gauge);

    public PressureReference Reference { get; private set; }

    public PressureUnit(PressureUnit pressureunit, PressureReference Reference)
    {
        this.Reference = Reference;
        ImmutableList<RawUnit> ListOfUnits = pressureunit.Unit.ListOfUnits;

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

            ListOfUnits = ListOfUnits.Add(dimensionless);
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
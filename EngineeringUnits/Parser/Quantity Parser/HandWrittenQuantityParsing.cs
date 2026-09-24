using EngineeringUnits.Parsing;
using EngineeringUnits.Units;
using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// Parse/TryParse for quantity classes that are not produced by CodeGen's UnitGenerator
// (the generated ones get the same two methods from the generator template).

public partial class ApparentEnergy
{
    public static ApparentEnergy Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<ApparentEnergy, ApparentEnergyUnit>(input, (v, u) => new ApparentEnergy(v, u), ApparentEnergyUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out ApparentEnergy? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<ApparentEnergy, ApparentEnergyUnit>(input, (v, u) => new ApparentEnergy(v, u), ApparentEnergyUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class MassConcentration
{
    public static MassConcentration Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<MassConcentration, DensityUnit>(input, (v, u) => new MassConcentration(v, u), DensityUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out MassConcentration? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<MassConcentration, DensityUnit>(input, (v, u) => new MassConcentration(v, u), DensityUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class Dimensionless
{
    public static Dimensionless Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<Dimensionless, DimensionlessUnit>(input, (v, u) => new Dimensionless(v, u), DimensionlessUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out Dimensionless? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<Dimensionless, DimensionlessUnit>(input, (v, u) => new Dimensionless(v, u), DimensionlessUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class ElectricConductance
{
    public static ElectricConductance Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<ElectricConductance, ElectricConductanceUnit>(input, (v, u) => new ElectricConductance(v, u), ElectricConductanceUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out ElectricConductance? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<ElectricConductance, ElectricConductanceUnit>(input, (v, u) => new ElectricConductance(v, u), ElectricConductanceUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class ElectricPotentialAc
{
    public static ElectricPotentialAc Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<ElectricPotentialAc, ElectricPotentialUnit>(input, (v, u) => new ElectricPotentialAc(v, u), ElectricPotentialUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out ElectricPotentialAc? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<ElectricPotentialAc, ElectricPotentialUnit>(input, (v, u) => new ElectricPotentialAc(v, u), ElectricPotentialUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class ElectricPotentialDc
{
    public static ElectricPotentialDc Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<ElectricPotentialDc, ElectricPotentialUnit>(input, (v, u) => new ElectricPotentialDc(v, u), ElectricPotentialUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out ElectricPotentialDc? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<ElectricPotentialDc, ElectricPotentialUnit>(input, (v, u) => new ElectricPotentialDc(v, u), ElectricPotentialUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class Level
{
    public static Level Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<Level, LevelUnit>(input, (v, u) => new Level(v, u), LevelUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out Level? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<Level, LevelUnit>(input, (v, u) => new Level(v, u), LevelUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

public partial class Luminosity
{
    public static Luminosity Parse(string? input, IFormatProvider? culture = null)
        => QuantityParser.Parse<Luminosity, PowerUnit>(input, (v, u) => new Luminosity(v, u), PowerUnit.SI, culture);

    public static bool TryParse(string? input, [NotNullWhen(true)] out Luminosity? result, IFormatProvider? culture = null)
    {
        var ok = QuantityParser.TryParse<Luminosity, PowerUnit>(input, (v, u) => new Luminosity(v, u), PowerUnit.SI, out var value, culture);
        result = ok ? value : null;
        return ok;
    }
}

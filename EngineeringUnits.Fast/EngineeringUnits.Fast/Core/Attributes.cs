using System;

namespace EngineeringUnits.Fast;

/// <summary>The SI base dimensions. Same names as in EngineeringUnits, the analyzer uses them for its messages.</summary>
public enum BaseunitType
{
    time,
    length,
    mass,
    electricCurrent,
    temperature,
    amountOfSubstance,
    luminousIntensity,
    Cost,
    CombinedUnit
}

/// <summary>
/// The dimension of a quantity, as flat (<see cref="BaseunitType"/>, exponent) pairs. No pairs means dimensionless.<br></br>
/// On a quantity struct it is the dimension of the type. On a field, property, parameter or return value of type
/// <see cref="UnknownUnit"/> it tells the analyzer (EUF0001/EUF0007) what dimension that value has, so it can be checked where
/// it is written and trusted where it is read.
/// </summary>
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
public sealed class UnitDimensionAttribute : Attribute
{
    public UnitDimensionAttribute() { }
    public UnitDimensionAttribute(BaseunitType t1, int e1) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3, BaseunitType t4, int e4) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3, BaseunitType t4, int e4, BaseunitType t5, int e5) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3, BaseunitType t4, int e4, BaseunitType t5, int e5, BaseunitType t6, int e6) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3, BaseunitType t4, int e4, BaseunitType t5, int e5, BaseunitType t6, int e6, BaseunitType t7, int e7) { }
    public UnitDimensionAttribute(BaseunitType t1, int e1, BaseunitType t2, int e2, BaseunitType t3, int e3, BaseunitType t4, int e4, BaseunitType t5, int e5, BaseunitType t6, int e6, BaseunitType t7, int e7, BaseunitType t8, int e8) { }
}

/// <summary>
/// Marks parameters that must all have the same unit (dimension). Checked at compile time only (EUF0005).
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class SameDimensionAttribute : Attribute
{
    public SameDimensionAttribute() : this("") { }
    public SameDimensionAttribute(string group) => Group = group;
    public string Group { get; }
}

/// <summary>
/// Tells the analyzer which dimension a method returns, based on one of its parameters.
/// </summary>
[AttributeUsage(AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
public sealed class DimensionOfAttribute : Attribute
{
    public DimensionOfAttribute(string parameterName) => ParameterName = parameterName;

    /// <summary>
    /// The parameter whose unit the result is based on - or a type parameter: then the result has the dimension of the unit
    /// or quantity type passed for it, e.g. <c>[return: DimensionOf(nameof(T))] UnknownUnit AddUnit&lt;T&gt;(...)</c>.
    /// </summary>
    public string ParameterName { get; }

    /// <summary>Name of an <see langword="int"/> parameter that the unit is raised to the power of.</summary>
    public string? PowerParameter { get; set; }

    /// <summary>The result is this root of the unit, e.g. 2 for a square root.</summary>
    public int Root { get; set; } = 1;
}

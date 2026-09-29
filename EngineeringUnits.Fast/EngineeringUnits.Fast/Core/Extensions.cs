namespace EngineeringUnits.Fast;

/// <summary>Same as EngineeringUnits' Extensions.AddUnit.</summary>
public static class Extensions
{
    /// <summary>
    /// A value from a database with its unit name next to it: <c>row.Capacity.AddUnit&lt;PowerUnit&gt;(row.Capacity_uom)</c>.<br></br>
    /// The unit NAME is looked up at runtime (<see cref="UnitTypebase.GetUnitByString{T}"/>). The dimension comes from
    /// <typeparamref name="T"/>, so the analyzer checks the result: <c>Pressure? p = x.AddUnit&lt;PowerUnit&gt;(uom)</c> is EUF0001.
    /// </summary>
    [return: DimensionOf(nameof(T))]
    public static UnknownUnit AddUnit<T>(this double value, string UnitOfMeasure) where T : UnitTypebase
        => new(UnitTypebase.GetUnitByString<T>(UnitOfMeasure).ToSI(value));

    /// <inheritdoc cref="AddUnit{T}(double, string)"/>
    [return: DimensionOf(nameof(T))]
    public static UnknownUnit? AddUnit<T>(this double? value, string UnitOfMeasure) where T : UnitTypebase
        => value is { } v ? v.AddUnit<T>(UnitOfMeasure) : null;

    /// <inheritdoc cref="AddUnit{T}(double, string)"/>
    [return: DimensionOf(nameof(T))]
    public static UnknownUnit AddUnit<T>(this int value, string UnitOfMeasure) where T : UnitTypebase
        => ((double)value).AddUnit<T>(UnitOfMeasure);

    /// <inheritdoc cref="AddUnit{T}(double, string)"/>
    [return: DimensionOf(nameof(T))]
    public static UnknownUnit? AddUnit<T>(this int? value, string UnitOfMeasure) where T : UnitTypebase
        => value is { } v ? ((double)v).AddUnit<T>(UnitOfMeasure) : null;
}

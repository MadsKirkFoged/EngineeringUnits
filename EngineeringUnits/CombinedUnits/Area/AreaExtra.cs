using System;

namespace EngineeringUnits;

public partial class Area
{
    /// <summary>Get circle area from a diameter.</summary>
    public static Area FromCircleDiameter(Length diameter) => FromCircleRadius(diameter / 2);

    /// <summary>Get circle area from a radius.</summary>
    public static Area FromCircleRadius(Length radius) => radius * radius * Math.PI;

}

public static class AreaExtra
{

    /// <summary>Get circle area from a diameter.</summary>
    public static Area FromCircleDiameter(this Length diameter) => FromCircleRadius(diameter / 2);

    /// <summary>Get circle area from a radius.</summary>
    public static Area FromCircleRadius(this Length radius) => radius * radius * Math.PI;

}

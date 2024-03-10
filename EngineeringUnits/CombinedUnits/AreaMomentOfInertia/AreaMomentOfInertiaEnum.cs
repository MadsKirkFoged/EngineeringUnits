﻿namespace EngineeringUnits.Units;

public partial record AreaMomentOfInertiaUnit : UnitTypebase
{

    public static readonly AreaMomentOfInertiaUnit SI = new(LengthUnit.SI);
    public static readonly AreaMomentOfInertiaUnit MeterToTheFourth = new(LengthUnit.Meter);
    public static readonly AreaMomentOfInertiaUnit CentimeterToTheFourth = new(LengthUnit.Centimeter);
    public static readonly AreaMomentOfInertiaUnit DecimeterToTheFourth = new(LengthUnit.Decimeter);
    public static readonly AreaMomentOfInertiaUnit MillimeterToTheFourth = new(LengthUnit.Millimeter);

    public static readonly AreaMomentOfInertiaUnit InchToTheFourth = new(LengthUnit.Inch);
    public static readonly AreaMomentOfInertiaUnit FootToTheFourth = new(LengthUnit.Foot);

    public AreaMomentOfInertiaUnit(LengthUnit Length)
    {
        Unit = Length.Pow(4);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
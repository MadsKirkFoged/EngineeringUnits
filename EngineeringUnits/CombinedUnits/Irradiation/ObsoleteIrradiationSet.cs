﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Irradiation
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Irradiation FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Irradiation(value, IrradiationUnit.SI);
    //}

    /// <summary>
    ///     Get Irradiation from JoulesPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerSquareCentimeter->FromJoulePerSquareCentimeter")]
    public static Irradiation FromJoulesPerSquareCentimeter(double joulespersquarecentimeter)
    {
        var value = (double)joulespersquarecentimeter;
        return new Irradiation(value, IrradiationUnit.JoulePerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiation from JoulesPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerSquareMeter->FromJoulePerSquareMeter")]
    public static Irradiation FromJoulesPerSquareMeter(double joulespersquaremeter)
    {
        var value = (double)joulespersquaremeter;
        return new Irradiation(value, IrradiationUnit.JoulePerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiation from JoulesPerSquareMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerSquareMillimeter->FromJoulePerSquareMillimeter")]
    public static Irradiation FromJoulesPerSquareMillimeter(double joulespersquaremillimeter)
    {
        var value = (double)joulespersquaremillimeter;
        return new Irradiation(value, IrradiationUnit.JoulePerSquareMillimeter);
    }

    /// <summary>
    ///     Get Irradiation from KilojoulesPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerSquareMeter->FromKilojoulePerSquareMeter")]
    public static Irradiation FromKilojoulesPerSquareMeter(double kilojoulespersquaremeter)
    {
        var value = (double)kilojoulespersquaremeter;
        return new Irradiation(value, IrradiationUnit.KilojoulePerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiation from KilowattHoursPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattHoursPerSquareMeter->FromKilowattHourPerSquareMeter")]
    public static Irradiation FromKilowattHoursPerSquareMeter(double kilowatthourspersquaremeter)
    {
        var value = (double)kilowatthourspersquaremeter;
        return new Irradiation(value, IrradiationUnit.KilowattHourPerSquareMeter);
    }

    /// <summary>
    ///     Get Irradiation from MillijoulesPerSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillijoulesPerSquareCentimeter->FromMillijoulePerSquareCentimeter")]
    public static Irradiation FromMillijoulesPerSquareCentimeter(double millijoulespersquarecentimeter)
    {
        var value = (double)millijoulespersquarecentimeter;
        return new Irradiation(value, IrradiationUnit.MillijoulePerSquareCentimeter);
    }

    /// <summary>
    ///     Get Irradiation from WattHoursPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattHoursPerSquareMeter->FromWattHourPerSquareMeter")]
    public static Irradiation FromWattHoursPerSquareMeter(double watthourspersquaremeter)
    {
        var value = (double)watthourspersquaremeter;
        return new Irradiation(value, IrradiationUnit.WattHourPerSquareMeter);
    }
}

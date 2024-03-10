﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class HeatFlux
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static HeatFlux FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new HeatFlux(value, HeatFluxUnit.SI);
    //}

    /// <summary>
    ///     Get HeatFlux from BtusPerHourSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBtusPerHourSquareFoot->FromBtuPerHourSquareFoot")]
    public static HeatFlux FromBtusPerHourSquareFoot(double btusperhoursquarefoot)
    {
        var value = (double)btusperhoursquarefoot;
        return new HeatFlux(value, HeatFluxUnit.BtuPerHourSquareFoot);
    }
    /// <summary>
    ///     Get HeatFlux from BtusPerMinuteSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBtusPerMinuteSquareFoot->FromBtuPerMinuteSquareFoot")]
    public static HeatFlux FromBtusPerMinuteSquareFoot(double btusperminutesquarefoot)
    {
        var value = (double)btusperminutesquarefoot;
        return new HeatFlux(value, HeatFluxUnit.BtuPerMinuteSquareFoot);
    }
    /// <summary>
    ///     Get HeatFlux from BtusPerSecondSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBtusPerSecondSquareFoot->FromBtuPerSecondSquareFoot")]
    public static HeatFlux FromBtusPerSecondSquareFoot(double btuspersecondsquarefoot)
    {
        var value = (double)btuspersecondsquarefoot;
        return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareFoot);
    }
    /// <summary>
    ///     Get HeatFlux from BtusPerSecondSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBtusPerSecondSquareInch->FromBtuPerSecondSquareInch")]
    public static HeatFlux FromBtusPerSecondSquareInch(double btuspersecondsquareinch)
    {
        var value = (double)btuspersecondsquareinch;
        return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareInch);
    }
    /// <summary>
    ///     Get HeatFlux from CaloriesPerSecondSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCaloriesPerSecondSquareCentimeter->FromCaloriePerSecondSquareCentimeter")]
    public static HeatFlux FromCaloriesPerSecondSquareCentimeter(double caloriespersecondsquarecentimeter)
    {
        var value = (double)caloriespersecondsquarecentimeter;
        return new HeatFlux(value, HeatFluxUnit.CaloriePerSecondSquareCentimeter);
    }
    /// <summary>
    ///     Get HeatFlux from CentiwattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentiwattsPerSquareMeter->FromCentiwattPerSquareMeter")]
    public static HeatFlux FromCentiwattsPerSquareMeter(double centiwattspersquaremeter)
    {
        var value = (double)centiwattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.CentiwattPerSquareMeter);
    }
    /// <summary>
    ///     Get HeatFlux from DeciwattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDeciwattsPerSquareMeter->FromDeciwattPerSquareMeter")]
    public static HeatFlux FromDeciwattsPerSquareMeter(double deciwattspersquaremeter)
    {
        var value = (double)deciwattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.DeciwattPerSquareMeter);
    }

    /// <summary>
    ///     Get HeatFlux from KilocaloriesPerHourSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilocaloriesPerHourSquareMeter->FromKilocaloriePerHourSquareMeter")]
    public static HeatFlux FromKilocaloriesPerHourSquareMeter(double kilocaloriesperhoursquaremeter)
    {
        var value = (double)kilocaloriesperhoursquaremeter;
        return new HeatFlux(value, HeatFluxUnit.KilocaloriePerHourSquareMeter);
    }
    /// <summary>
    ///     Get HeatFlux from KilocaloriesPerSecondSquareCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilocaloriesPerSecondSquareCentimeter->FromKilocaloriePerSecondSquareCentimeter")]
    public static HeatFlux FromKilocaloriesPerSecondSquareCentimeter(double kilocaloriespersecondsquarecentimeter)
    {
        var value = (double)kilocaloriespersecondsquarecentimeter;
        return new HeatFlux(value, HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);
    }
    /// <summary>
    ///     Get HeatFlux from KilowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilowattsPerSquareMeter->FromKilowattPerSquareMeter")]
    public static HeatFlux FromKilowattsPerSquareMeter(double kilowattspersquaremeter)
    {
        var value = (double)kilowattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.KilowattPerSquareMeter);
    }
    /// <summary>
    ///     Get HeatFlux from MicrowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrowattsPerSquareMeter->FromMicrowattPerSquareMeter")]
    public static HeatFlux FromMicrowattsPerSquareMeter(double microwattspersquaremeter)
    {
        var value = (double)microwattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.MicrowattPerSquareMeter);
    }

    /// <summary>
    ///     Get HeatFlux from MilliwattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilliwattsPerSquareMeter->FromMilliwattPerSquareMeter")]
    public static HeatFlux FromMilliwattsPerSquareMeter(double milliwattspersquaremeter)
    {
        var value = (double)milliwattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.MilliwattPerSquareMeter);
    }
    /// <summary>
    ///     Get HeatFlux from NanowattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanowattsPerSquareMeter->FromNanowattPerSquareMeter")]
    public static HeatFlux FromNanowattsPerSquareMeter(double nanowattspersquaremeter)
    {
        var value = (double)nanowattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.NanowattPerSquareMeter);
    }
    /// <summary>
    ///     Get HeatFlux from PoundsForcePerFootSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerFootSecond->FromPoundForcePerFootSecond")]
    public static HeatFlux FromPoundsForcePerFootSecond(double poundsforceperfootsecond)
    {
        var value = (double)poundsforceperfootsecond;
        return new HeatFlux(value, HeatFluxUnit.PoundForcePerFootSecond);
    }
    /// <summary>
    ///     Get HeatFlux from PoundsPerSecondCubed.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerSecondCubed->FromPoundPerSecondCubed")]
    public static HeatFlux FromPoundsPerSecondCubed(double poundspersecondcubed)
    {
        var value = (double)poundspersecondcubed;
        return new HeatFlux(value, HeatFluxUnit.PoundPerSecondCubed);
    }
    /// <summary>
    ///     Get HeatFlux from WattsPerSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerSquareFoot->FromWattPerSquareFoot")]
    public static HeatFlux FromWattsPerSquareFoot(double wattspersquarefoot)
    {
        var value = (double)wattspersquarefoot;
        return new HeatFlux(value, HeatFluxUnit.WattPerSquareFoot);
    }
    /// <summary>
    ///     Get HeatFlux from WattsPerSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerSquareInch->FromWattPerSquareInch")]
    public static HeatFlux FromWattsPerSquareInch(double wattspersquareinch)
    {
        var value = (double)wattspersquareinch;
        return new HeatFlux(value, HeatFluxUnit.WattPerSquareInch);
    }
    /// <summary>
    ///     Get HeatFlux from WattsPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromWattsPerSquareMeter->FromWattPerSquareMeter")]
    public static HeatFlux FromWattsPerSquareMeter(double wattspersquaremeter)
    {
        var value = (double)wattspersquaremeter;
        return new HeatFlux(value, HeatFluxUnit.WattPerSquareMeter);
    }
}

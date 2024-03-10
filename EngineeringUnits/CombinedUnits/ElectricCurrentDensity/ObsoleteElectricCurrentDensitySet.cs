using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricCurrentDensity
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricCurrentDensity FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricCurrentDensity from AmperesPerSquareFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerSquareFoot->FromAmperePerSquareFoot")]
    public static ElectricCurrentDensity FromAmperesPerSquareFoot(double amperespersquarefoot)
    {
        var value = (double)amperespersquarefoot;
        return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareFoot);
    }
    /// <summary>
    ///     Get ElectricCurrentDensity from AmperesPerSquareInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerSquareInch->FromAmperePerSquareInch")]
    public static ElectricCurrentDensity FromAmperesPerSquareInch(double amperespersquareinch)
    {
        var value = (double)amperespersquareinch;
        return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareInch);
    }
    /// <summary>
    ///     Get ElectricCurrentDensity from AmperesPerSquareMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerSquareMeter->FromAmperePerSquareMeter")]
    public static ElectricCurrentDensity FromAmperesPerSquareMeter(double amperespersquaremeter)
    {
        var value = (double)amperespersquaremeter;
        return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareMeter);
    }
}

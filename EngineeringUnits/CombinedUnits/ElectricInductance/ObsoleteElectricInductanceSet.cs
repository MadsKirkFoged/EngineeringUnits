﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricInductance
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricInductance FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricInductance(value, ElectricInductanceUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricInductance from Henries.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHenries->FromHenry")]
    public static ElectricInductance FromHenries(double henries)
    {
        var value = (double)henries;
        return new ElectricInductance(value, ElectricInductanceUnit.Henry);
    }
    /// <summary>
    ///     Get ElectricInductance from Microhenries.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrohenries->FromMicrohenry")]
    public static ElectricInductance FromMicrohenries(double microhenries)
    {
        var value = (double)microhenries;
        return new ElectricInductance(value, ElectricInductanceUnit.Microhenry);
    }
    /// <summary>
    ///     Get ElectricInductance from Millihenries.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillihenries->FromMillihenry")]
    public static ElectricInductance FromMillihenries(double millihenries)
    {
        var value = (double)millihenries;
        return new ElectricInductance(value, ElectricInductanceUnit.Millihenry);
    }
    /// <summary>
    ///     Get ElectricInductance from Nanohenries.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanohenries->FromNanohenry")]
    public static ElectricInductance FromNanohenries(double nanohenries)
    {
        var value = (double)nanohenries;
        return new ElectricInductance(value, ElectricInductanceUnit.Nanohenry);
    }
}

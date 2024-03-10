using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class MagneticField
{
    /// <summary>
    ///     Get MagneticField in Gausses.
    /// </summary>
    [Obsolete("Use without the 's' - Gausses->Gauss")]
    public double Gausses => As(MagneticFieldUnit.Gauss);

    /// <summary>
    ///     Get MagneticField in Microteslas.
    /// </summary>
    [Obsolete("Use without the 's' - Microteslas->Microtesla")]
    public double Microteslas => As(MagneticFieldUnit.Microtesla);

    /// <summary>
    ///     Get MagneticField in Milligausses.
    /// </summary>
    [Obsolete("Use without the 's' - Milligausses->Milligauss")]
    public double Milligausses => As(MagneticFieldUnit.Milligauss);

    /// <summary>
    ///     Get MagneticField in Milliteslas.
    /// </summary>
    [Obsolete("Use without the 's' - Milliteslas->Millitesla")]
    public double Milliteslas => As(MagneticFieldUnit.Millitesla);

    /// <summary>
    ///     Get MagneticField in Nanoteslas.
    /// </summary>
    [Obsolete("Use without the 's' - Nanoteslas->Nanotesla")]
    public double Nanoteslas => As(MagneticFieldUnit.Nanotesla);

    /// <summary>
    ///     Get MagneticField in Teslas.
    /// </summary>
    [Obsolete("Use without the 's' - Teslas->Tesla")]
    public double Teslas => As(MagneticFieldUnit.Tesla);

    /// <summary>
    ///     Get MagneticField in SI Unit (Teslas).
    /// </summary>
    //public double SI => As(MagneticFieldUnit.SI);

}

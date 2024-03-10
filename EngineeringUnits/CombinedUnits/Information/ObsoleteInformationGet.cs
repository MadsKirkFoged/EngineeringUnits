using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Information
{
    /// <summary>
    ///     Get Information in Bits.
    /// </summary>
    [Obsolete("Use without the 's' - Bits->Bit")]
    public double Bits => As(InformationUnit.Bit);

    /// <summary>
    ///     Get Information in SI Unit (Bits).
    /// </summary>
   // public double SI => As(InformationUnit.SI);

    /// <summary>
    ///     Get Information in Bytes.
    /// </summary>
    [Obsolete("Use without the 's' - Bytes->Byte")]
    public double Bytes => As(InformationUnit.Byte);

    /// <summary>
    ///     Get Information in Exabits.
    /// </summary>
    [Obsolete("Use without the 's' - Exabits->Exabit")]
    public double Exabits => As(InformationUnit.Exabit);

    /// <summary>
    ///     Get Information in Exabytes.
    /// </summary>
    [Obsolete("Use without the 's' - Exabytes->Exabyte")]
    public double Exabytes => As(InformationUnit.Exabyte);

    /// <summary>
    ///     Get Information in Exbibits.
    /// </summary>
    [Obsolete("Use without the 's' - Exbibits->Exbibit")]
    public double Exbibits => As(InformationUnit.Exbibit);

    /// <summary>
    ///     Get Information in Exbibytes.
    /// </summary>
    [Obsolete("Use without the 's' - Exbibytes->Exbibyte")]
    public double Exbibytes => As(InformationUnit.Exbibyte);

    /// <summary>
    ///     Get Information in Gibibits.
    /// </summary>
    [Obsolete("Use without the 's' - Gibibits->Gibibit")]
    public double Gibibits => As(InformationUnit.Gibibit);

    /// <summary>
    ///     Get Information in Gibibytes.
    /// </summary>
    [Obsolete("Use without the 's' - Gibibytes->Gibibyte")]
    public double Gibibytes => As(InformationUnit.Gibibyte);

    /// <summary>
    ///     Get Information in Gigabits.
    /// </summary>
    [Obsolete("Use without the 's' - Gigabits->Gigabit")]
    public double Gigabits => As(InformationUnit.Gigabit);

    /// <summary>
    ///     Get Information in Gigabytes.
    /// </summary>
    [Obsolete("Use without the 's' - Gigabytes->Gigabyte")]
    public double Gigabytes => As(InformationUnit.Gigabyte);

    /// <summary>
    ///     Get Information in Kibibits.
    /// </summary>
    [Obsolete("Use without the 's' - Kibibits->Kibibit")]
    public double Kibibits => As(InformationUnit.Kibibit);

    /// <summary>
    ///     Get Information in Kibibytes.
    /// </summary>
    [Obsolete("Use without the 's' - Kibibytes->Kibibyte")]
    public double Kibibytes => As(InformationUnit.Kibibyte);

    /// <summary>
    ///     Get Information in Kilobits.
    /// </summary>
    [Obsolete("Use without the 's' - Kilobits->Kilobit")]
    public double Kilobits => As(InformationUnit.Kilobit);

    /// <summary>
    ///     Get Information in Kilobytes.
    /// </summary>
    [Obsolete("Use without the 's' - Kilobytes->Kilobyte")]
    public double Kilobytes => As(InformationUnit.Kilobyte);

    /// <summary>
    ///     Get Information in Mebibits.
    /// </summary>
    [Obsolete("Use without the 's' - Mebibits->Mebibit")]
    public double Mebibits => As(InformationUnit.Mebibit);

    /// <summary>
    ///     Get Information in Mebibytes.
    /// </summary>
    [Obsolete("Use without the 's' - Mebibytes->Mebibyte")]
    public double Mebibytes => As(InformationUnit.Mebibyte);

    /// <summary>
    ///     Get Information in Megabits.
    /// </summary>
    [Obsolete("Use without the 's' - Megabits->Megabit")]
    public double Megabits => As(InformationUnit.Megabit);

    /// <summary>
    ///     Get Information in Megabytes.
    /// </summary>
    [Obsolete("Use without the 's' - Megabytes->Megabyte")]
    public double Megabytes => As(InformationUnit.Megabyte);

    /// <summary>
    ///     Get Information in Pebibits.
    /// </summary>
    [Obsolete("Use without the 's' - Pebibits->Pebibit")]
    public double Pebibits => As(InformationUnit.Pebibit);

    /// <summary>
    ///     Get Information in Pebibytes.
    /// </summary>
    [Obsolete("Use without the 's' - Pebibytes->Pebibyte")]
    public double Pebibytes => As(InformationUnit.Pebibyte);

    /// <summary>
    ///     Get Information in Petabits.
    /// </summary>
    [Obsolete("Use without the 's' - Petabits->Petabit")]
    public double Petabits => As(InformationUnit.Petabit);

    /// <summary>
    ///     Get Information in Petabytes.
    /// </summary>
    [Obsolete("Use without the 's' - Petabytes->Petabyte")]
    public double Petabytes => As(InformationUnit.Petabyte);

    /// <summary>
    ///     Get Information in Tebibits.
    /// </summary>
    [Obsolete("Use without the 's' - Tebibits->Tebibit")]
    public double Tebibits => As(InformationUnit.Tebibit);

    /// <summary>
    ///     Get Information in Tebibytes.
    /// </summary>
    [Obsolete("Use without the 's' - Tebibytes->Tebibyte")]
    public double Tebibytes => As(InformationUnit.Tebibyte);

    /// <summary>
    ///     Get Information in Terabits.
    /// </summary>
    [Obsolete("Use without the 's' - Terabits->Terabit")]
    public double Terabits => As(InformationUnit.Terabit);

    /// <summary>
    ///     Get Information in Terabytes.
    /// </summary>
    [Obsolete("Use without the 's' - Terabytes->Terabyte")]
    public double Terabytes => As(InformationUnit.Terabyte);

}

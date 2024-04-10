using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class Information
{

    /// <summary>
    /// Get Information from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Information? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Information((double)SI, InformationUnit.SI);
    }
    /// <summary>
    /// Get Information from Byte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Byte))]
    public static Information? FromByte(double? Byte)
    {
        if (Byte is null)
            return null;
        
        return new Information((double)Byte, InformationUnit.Byte);
    }
    /// <summary>
    /// Get Information from Bit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Bit))]
    public static Information? FromBit(double? Bit)
    {
        if (Bit is null)
            return null;
        
        return new Information((double)Bit, InformationUnit.Bit);
    }
    /// <summary>
    /// Get Information from Kibibit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kibibit))]
    public static Information? FromKibibit(double? Kibibit)
    {
        if (Kibibit is null)
            return null;
        
        return new Information((double)Kibibit, InformationUnit.Kibibit);
    }
    /// <summary>
    /// Get Information from Mebibit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Mebibit))]
    public static Information? FromMebibit(double? Mebibit)
    {
        if (Mebibit is null)
            return null;
        
        return new Information((double)Mebibit, InformationUnit.Mebibit);
    }
    /// <summary>
    /// Get Information from Gibibit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gibibit))]
    public static Information? FromGibibit(double? Gibibit)
    {
        if (Gibibit is null)
            return null;
        
        return new Information((double)Gibibit, InformationUnit.Gibibit);
    }
    /// <summary>
    /// Get Information from Tebibit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Tebibit))]
    public static Information? FromTebibit(double? Tebibit)
    {
        if (Tebibit is null)
            return null;
        
        return new Information((double)Tebibit, InformationUnit.Tebibit);
    }
    /// <summary>
    /// Get Information from Pebibit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Pebibit))]
    public static Information? FromPebibit(double? Pebibit)
    {
        if (Pebibit is null)
            return null;
        
        return new Information((double)Pebibit, InformationUnit.Pebibit);
    }
    /// <summary>
    /// Get Information from Exbibit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Exbibit))]
    public static Information? FromExbibit(double? Exbibit)
    {
        if (Exbibit is null)
            return null;
        
        return new Information((double)Exbibit, InformationUnit.Exbibit);
    }
    /// <summary>
    /// Get Information from Kibibyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kibibyte))]
    public static Information? FromKibibyte(double? Kibibyte)
    {
        if (Kibibyte is null)
            return null;
        
        return new Information((double)Kibibyte, InformationUnit.Kibibyte);
    }
    /// <summary>
    /// Get Information from Mebibyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Mebibyte))]
    public static Information? FromMebibyte(double? Mebibyte)
    {
        if (Mebibyte is null)
            return null;
        
        return new Information((double)Mebibyte, InformationUnit.Mebibyte);
    }
    /// <summary>
    /// Get Information from Gibibyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gibibyte))]
    public static Information? FromGibibyte(double? Gibibyte)
    {
        if (Gibibyte is null)
            return null;
        
        return new Information((double)Gibibyte, InformationUnit.Gibibyte);
    }
    /// <summary>
    /// Get Information from Tebibyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Tebibyte))]
    public static Information? FromTebibyte(double? Tebibyte)
    {
        if (Tebibyte is null)
            return null;
        
        return new Information((double)Tebibyte, InformationUnit.Tebibyte);
    }
    /// <summary>
    /// Get Information from Pebibyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Pebibyte))]
    public static Information? FromPebibyte(double? Pebibyte)
    {
        if (Pebibyte is null)
            return null;
        
        return new Information((double)Pebibyte, InformationUnit.Pebibyte);
    }
    /// <summary>
    /// Get Information from Exbibyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Exbibyte))]
    public static Information? FromExbibyte(double? Exbibyte)
    {
        if (Exbibyte is null)
            return null;
        
        return new Information((double)Exbibyte, InformationUnit.Exbibyte);
    }
    /// <summary>
    /// Get Information from Kilobyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kilobyte))]
    public static Information? FromKilobyte(double? Kilobyte)
    {
        if (Kilobyte is null)
            return null;
        
        return new Information((double)Kilobyte, InformationUnit.Kilobyte);
    }
    /// <summary>
    /// Get Information from Megabyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Megabyte))]
    public static Information? FromMegabyte(double? Megabyte)
    {
        if (Megabyte is null)
            return null;
        
        return new Information((double)Megabyte, InformationUnit.Megabyte);
    }
    /// <summary>
    /// Get Information from Gigabyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gigabyte))]
    public static Information? FromGigabyte(double? Gigabyte)
    {
        if (Gigabyte is null)
            return null;
        
        return new Information((double)Gigabyte, InformationUnit.Gigabyte);
    }
    /// <summary>
    /// Get Information from Terabyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Terabyte))]
    public static Information? FromTerabyte(double? Terabyte)
    {
        if (Terabyte is null)
            return null;
        
        return new Information((double)Terabyte, InformationUnit.Terabyte);
    }
    /// <summary>
    /// Get Information from Petabyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Petabyte))]
    public static Information? FromPetabyte(double? Petabyte)
    {
        if (Petabyte is null)
            return null;
        
        return new Information((double)Petabyte, InformationUnit.Petabyte);
    }
    /// <summary>
    /// Get Information from Exabyte.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Exabyte))]
    public static Information? FromExabyte(double? Exabyte)
    {
        if (Exabyte is null)
            return null;
        
        return new Information((double)Exabyte, InformationUnit.Exabyte);
    }
    /// <summary>
    /// Get Information from Kilobit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kilobit))]
    public static Information? FromKilobit(double? Kilobit)
    {
        if (Kilobit is null)
            return null;
        
        return new Information((double)Kilobit, InformationUnit.Kilobit);
    }
    /// <summary>
    /// Get Information from Megabit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Megabit))]
    public static Information? FromMegabit(double? Megabit)
    {
        if (Megabit is null)
            return null;
        
        return new Information((double)Megabit, InformationUnit.Megabit);
    }
    /// <summary>
    /// Get Information from Gigabit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Gigabit))]
    public static Information? FromGigabit(double? Gigabit)
    {
        if (Gigabit is null)
            return null;
        
        return new Information((double)Gigabit, InformationUnit.Gigabit);
    }
    /// <summary>
    /// Get Information from Terabit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Terabit))]
    public static Information? FromTerabit(double? Terabit)
    {
        if (Terabit is null)
            return null;
        
        return new Information((double)Terabit, InformationUnit.Terabit);
    }
    /// <summary>
    /// Get Information from Petabit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Petabit))]
    public static Information? FromPetabit(double? Petabit)
    {
        if (Petabit is null)
            return null;
        
        return new Information((double)Petabit, InformationUnit.Petabit);
    }
    /// <summary>
    /// Get Information from Exabit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Exabit))]
    public static Information? FromExabit(double? Exabit)
    {
        if (Exabit is null)
            return null;
        
        return new Information((double)Exabit, InformationUnit.Exabit);
    }

}
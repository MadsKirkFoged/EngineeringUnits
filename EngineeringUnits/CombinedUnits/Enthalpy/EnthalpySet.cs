using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Enthalpy
{

    /// <summary>
    /// Get Enthalpy from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Enthalpy? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Enthalpy((double)SI, EnthalpyUnit.SI);
    }
    /// <summary>
    /// Get Enthalpy from JoulePerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(JoulePerKilogram))]
    public static Enthalpy? FromJoulePerKilogram(double? JoulePerKilogram)
    {
        if (JoulePerKilogram is null)
            return null;
        
        return new Enthalpy((double)JoulePerKilogram, EnthalpyUnit.JoulePerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from KilojoulePerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilojoulePerKilogram))]
    public static Enthalpy? FromKilojoulePerKilogram(double? KilojoulePerKilogram)
    {
        if (KilojoulePerKilogram is null)
            return null;
        
        return new Enthalpy((double)KilojoulePerKilogram, EnthalpyUnit.KilojoulePerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from MegajoulePerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegajoulePerKilogram))]
    public static Enthalpy? FromMegajoulePerKilogram(double? MegajoulePerKilogram)
    {
        if (MegajoulePerKilogram is null)
            return null;
        
        return new Enthalpy((double)MegajoulePerKilogram, EnthalpyUnit.MegajoulePerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from BtuPerPound.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(BtuPerPound))]
    public static Enthalpy? FromBtuPerPound(double? BtuPerPound)
    {
        if (BtuPerPound is null)
            return null;
        
        return new Enthalpy((double)BtuPerPound, EnthalpyUnit.BtuPerPound);
    }
    /// <summary>
    /// Get Enthalpy from CaloriePerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CaloriePerGram))]
    public static Enthalpy? FromCaloriePerGram(double? CaloriePerGram)
    {
        if (CaloriePerGram is null)
            return null;
        
        return new Enthalpy((double)CaloriePerGram, EnthalpyUnit.CaloriePerGram);
    }
    /// <summary>
    /// Get Enthalpy from KilocaloriePerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilocaloriePerGram))]
    public static Enthalpy? FromKilocaloriePerGram(double? KilocaloriePerGram)
    {
        if (KilocaloriePerGram is null)
            return null;
        
        return new Enthalpy((double)KilocaloriePerGram, EnthalpyUnit.KilocaloriePerGram);
    }
    /// <summary>
    /// Get Enthalpy from WattDayPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattDayPerKilogram))]
    public static Enthalpy? FromWattDayPerKilogram(double? WattDayPerKilogram)
    {
        if (WattDayPerKilogram is null)
            return null;
        
        return new Enthalpy((double)WattDayPerKilogram, EnthalpyUnit.WattDayPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from KilowattDayPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattDayPerKilogram))]
    public static Enthalpy? FromKilowattDayPerKilogram(double? KilowattDayPerKilogram)
    {
        if (KilowattDayPerKilogram is null)
            return null;
        
        return new Enthalpy((double)KilowattDayPerKilogram, EnthalpyUnit.KilowattDayPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from MegawattDayPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegawattDayPerKilogram))]
    public static Enthalpy? FromMegawattDayPerKilogram(double? MegawattDayPerKilogram)
    {
        if (MegawattDayPerKilogram is null)
            return null;
        
        return new Enthalpy((double)MegawattDayPerKilogram, EnthalpyUnit.MegawattDayPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from GigawattDayPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GigawattDayPerKilogram))]
    public static Enthalpy? FromGigawattDayPerKilogram(double? GigawattDayPerKilogram)
    {
        if (GigawattDayPerKilogram is null)
            return null;
        
        return new Enthalpy((double)GigawattDayPerKilogram, EnthalpyUnit.GigawattDayPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from TerawattDayPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(TerawattDayPerKilogram))]
    public static Enthalpy? FromTerawattDayPerKilogram(double? TerawattDayPerKilogram)
    {
        if (TerawattDayPerKilogram is null)
            return null;
        
        return new Enthalpy((double)TerawattDayPerKilogram, EnthalpyUnit.TerawattDayPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from WattHourPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattHourPerKilogram))]
    public static Enthalpy? FromWattHourPerKilogram(double? WattHourPerKilogram)
    {
        if (WattHourPerKilogram is null)
            return null;
        
        return new Enthalpy((double)WattHourPerKilogram, EnthalpyUnit.WattHourPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from KilowattHourPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattHourPerKilogram))]
    public static Enthalpy? FromKilowattHourPerKilogram(double? KilowattHourPerKilogram)
    {
        if (KilowattHourPerKilogram is null)
            return null;
        
        return new Enthalpy((double)KilowattHourPerKilogram, EnthalpyUnit.KilowattHourPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from MegawattHourPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegawattHourPerKilogram))]
    public static Enthalpy? FromMegawattHourPerKilogram(double? MegawattHourPerKilogram)
    {
        if (MegawattHourPerKilogram is null)
            return null;
        
        return new Enthalpy((double)MegawattHourPerKilogram, EnthalpyUnit.MegawattHourPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from GigawattHourPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GigawattHourPerKilogram))]
    public static Enthalpy? FromGigawattHourPerKilogram(double? GigawattHourPerKilogram)
    {
        if (GigawattHourPerKilogram is null)
            return null;
        
        return new Enthalpy((double)GigawattHourPerKilogram, EnthalpyUnit.GigawattHourPerKilogram);
    }
    /// <summary>
    /// Get Enthalpy from WattDayPerTonne.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattDayPerTonne))]
    public static Enthalpy? FromWattDayPerTonne(double? WattDayPerTonne)
    {
        if (WattDayPerTonne is null)
            return null;
        
        return new Enthalpy((double)WattDayPerTonne, EnthalpyUnit.WattDayPerTonne);
    }
    /// <summary>
    /// Get Enthalpy from KilowattDayPerTonne.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattDayPerTonne))]
    public static Enthalpy? FromKilowattDayPerTonne(double? KilowattDayPerTonne)
    {
        if (KilowattDayPerTonne is null)
            return null;
        
        return new Enthalpy((double)KilowattDayPerTonne, EnthalpyUnit.KilowattDayPerTonne);
    }
    /// <summary>
    /// Get Enthalpy from MegawattDayPerTonne.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegawattDayPerTonne))]
    public static Enthalpy? FromMegawattDayPerTonne(double? MegawattDayPerTonne)
    {
        if (MegawattDayPerTonne is null)
            return null;
        
        return new Enthalpy((double)MegawattDayPerTonne, EnthalpyUnit.MegawattDayPerTonne);
    }
    /// <summary>
    /// Get Enthalpy from GigawattDayPerTonne.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GigawattDayPerTonne))]
    public static Enthalpy? FromGigawattDayPerTonne(double? GigawattDayPerTonne)
    {
        if (GigawattDayPerTonne is null)
            return null;
        
        return new Enthalpy((double)GigawattDayPerTonne, EnthalpyUnit.GigawattDayPerTonne);
    }
    /// <summary>
    /// Get Enthalpy from TerawattDayPerTonne.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(TerawattDayPerTonne))]
    public static Enthalpy? FromTerawattDayPerTonne(double? TerawattDayPerTonne)
    {
        if (TerawattDayPerTonne is null)
            return null;
        
        return new Enthalpy((double)TerawattDayPerTonne, EnthalpyUnit.TerawattDayPerTonne);
    }
    /// <summary>
    /// Get Enthalpy from WattDayPerShortTon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(WattDayPerShortTon))]
    public static Enthalpy? FromWattDayPerShortTon(double? WattDayPerShortTon)
    {
        if (WattDayPerShortTon is null)
            return null;
        
        return new Enthalpy((double)WattDayPerShortTon, EnthalpyUnit.WattDayPerShortTon);
    }
    /// <summary>
    /// Get Enthalpy from KilowattDayPerShortTon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilowattDayPerShortTon))]
    public static Enthalpy? FromKilowattDayPerShortTon(double? KilowattDayPerShortTon)
    {
        if (KilowattDayPerShortTon is null)
            return null;
        
        return new Enthalpy((double)KilowattDayPerShortTon, EnthalpyUnit.KilowattDayPerShortTon);
    }
    /// <summary>
    /// Get Enthalpy from MegawattDayPerShortTon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegawattDayPerShortTon))]
    public static Enthalpy? FromMegawattDayPerShortTon(double? MegawattDayPerShortTon)
    {
        if (MegawattDayPerShortTon is null)
            return null;
        
        return new Enthalpy((double)MegawattDayPerShortTon, EnthalpyUnit.MegawattDayPerShortTon);
    }
    /// <summary>
    /// Get Enthalpy from GigawattDayPerShortTon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GigawattDayPerShortTon))]
    public static Enthalpy? FromGigawattDayPerShortTon(double? GigawattDayPerShortTon)
    {
        if (GigawattDayPerShortTon is null)
            return null;
        
        return new Enthalpy((double)GigawattDayPerShortTon, EnthalpyUnit.GigawattDayPerShortTon);
    }
    /// <summary>
    /// Get Enthalpy from TerawattDayPerShortTon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(TerawattDayPerShortTon))]
    public static Enthalpy? FromTerawattDayPerShortTon(double? TerawattDayPerShortTon)
    {
        if (TerawattDayPerShortTon is null)
            return null;
        
        return new Enthalpy((double)TerawattDayPerShortTon, EnthalpyUnit.TerawattDayPerShortTon);
    }

}
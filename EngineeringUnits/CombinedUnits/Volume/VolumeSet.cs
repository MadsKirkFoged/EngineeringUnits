using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Volume
{

    /// <summary>
    /// Get Volume from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Volume? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Volume((double)SI, VolumeUnit.SI);
    }
    /// <summary>
    /// Get Volume from CubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicMeter))]
    public static Volume? FromCubicMeter(double? CubicMeter)
    {
        if (CubicMeter is null)
            return null;
        
        return new Volume((double)CubicMeter, VolumeUnit.CubicMeter);
    }
    /// <summary>
    /// Get Volume from HectocubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HectocubicMeter))]
    public static Volume? FromHectocubicMeter(double? HectocubicMeter)
    {
        if (HectocubicMeter is null)
            return null;
        
        return new Volume((double)HectocubicMeter, VolumeUnit.HectocubicMeter);
    }
    /// <summary>
    /// Get Volume from KilocubicMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilocubicMeter))]
    public static Volume? FromKilocubicMeter(double? KilocubicMeter)
    {
        if (KilocubicMeter is null)
            return null;
        
        return new Volume((double)KilocubicMeter, VolumeUnit.KilocubicMeter);
    }
    /// <summary>
    /// Get Volume from CubicKilometer.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicKilometer))]
    public static Volume? FromCubicKilometer(double? CubicKilometer)
    {
        if (CubicKilometer is null)
            return null;
        
        return new Volume((double)CubicKilometer, VolumeUnit.CubicKilometer);
    }
    /// <summary>
    /// Get Volume from CubicMicrometer.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicMicrometer))]
    public static Volume? FromCubicMicrometer(double? CubicMicrometer)
    {
        if (CubicMicrometer is null)
            return null;
        
        return new Volume((double)CubicMicrometer, VolumeUnit.CubicMicrometer);
    }
    /// <summary>
    /// Get Volume from CubicMile.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicMile))]
    public static Volume? FromCubicMile(double? CubicMile)
    {
        if (CubicMile is null)
            return null;
        
        return new Volume((double)CubicMile, VolumeUnit.CubicMile);
    }
    /// <summary>
    /// Get Volume from CubicMillimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicMillimeter))]
    public static Volume? FromCubicMillimeter(double? CubicMillimeter)
    {
        if (CubicMillimeter is null)
            return null;
        
        return new Volume((double)CubicMillimeter, VolumeUnit.CubicMillimeter);
    }
    /// <summary>
    /// Get Volume from CubicYard.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicYard))]
    public static Volume? FromCubicYard(double? CubicYard)
    {
        if (CubicYard is null)
            return null;
        
        return new Volume((double)CubicYard, VolumeUnit.CubicYard);
    }
    /// <summary>
    /// Get Volume from CubicInch.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicInch))]
    public static Volume? FromCubicInch(double? CubicInch)
    {
        if (CubicInch is null)
            return null;
        
        return new Volume((double)CubicInch, VolumeUnit.CubicInch);
    }
    /// <summary>
    /// Get Volume from CubicHectometer.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicHectometer))]
    public static Volume? FromCubicHectometer(double? CubicHectometer)
    {
        if (CubicHectometer is null)
            return null;
        
        return new Volume((double)CubicHectometer, VolumeUnit.CubicHectometer);
    }
    /// <summary>
    /// Get Volume from CubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicFoot))]
    public static Volume? FromCubicFoot(double? CubicFoot)
    {
        if (CubicFoot is null)
            return null;
        
        return new Volume((double)CubicFoot, VolumeUnit.CubicFoot);
    }
    /// <summary>
    /// Get Volume from HectocubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HectocubicFoot))]
    public static Volume? FromHectocubicFoot(double? HectocubicFoot)
    {
        if (HectocubicFoot is null)
            return null;
        
        return new Volume((double)HectocubicFoot, VolumeUnit.HectocubicFoot);
    }
    /// <summary>
    /// Get Volume from KilocubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilocubicFoot))]
    public static Volume? FromKilocubicFoot(double? KilocubicFoot)
    {
        if (KilocubicFoot is null)
            return null;
        
        return new Volume((double)KilocubicFoot, VolumeUnit.KilocubicFoot);
    }
    /// <summary>
    /// Get Volume from MegacubicFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegacubicFoot))]
    public static Volume? FromMegacubicFoot(double? MegacubicFoot)
    {
        if (MegacubicFoot is null)
            return null;
        
        return new Volume((double)MegacubicFoot, VolumeUnit.MegacubicFoot);
    }
    /// <summary>
    /// Get Volume from CubicDecimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicDecimeter))]
    public static Volume? FromCubicDecimeter(double? CubicDecimeter)
    {
        if (CubicDecimeter is null)
            return null;
        
        return new Volume((double)CubicDecimeter, VolumeUnit.CubicDecimeter);
    }
    /// <summary>
    /// Get Volume from CubicCentimeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CubicCentimeter))]
    public static Volume? FromCubicCentimeter(double? CubicCentimeter)
    {
        if (CubicCentimeter is null)
            return null;
        
        return new Volume((double)CubicCentimeter, VolumeUnit.CubicCentimeter);
    }
    /// <summary>
    /// Get Volume from Liter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Liter))]
    public static Volume? FromLiter(double? Liter)
    {
        if (Liter is null)
            return null;
        
        return new Volume((double)Liter, VolumeUnit.Liter);
    }
    /// <summary>
    /// Get Volume from Nanoliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Nanoliter))]
    public static Volume? FromNanoliter(double? Nanoliter)
    {
        if (Nanoliter is null)
            return null;
        
        return new Volume((double)Nanoliter, VolumeUnit.Nanoliter);
    }
    /// <summary>
    /// Get Volume from Microliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microliter))]
    public static Volume? FromMicroliter(double? Microliter)
    {
        if (Microliter is null)
            return null;
        
        return new Volume((double)Microliter, VolumeUnit.Microliter);
    }
    /// <summary>
    /// Get Volume from Milliliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Milliliter))]
    public static Volume? FromMilliliter(double? Milliliter)
    {
        if (Milliliter is null)
            return null;
        
        return new Volume((double)Milliliter, VolumeUnit.Milliliter);
    }
    /// <summary>
    /// Get Volume from Deciliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Deciliter))]
    public static Volume? FromDeciliter(double? Deciliter)
    {
        if (Deciliter is null)
            return null;
        
        return new Volume((double)Deciliter, VolumeUnit.Deciliter);
    }
    /// <summary>
    /// Get Volume from Centiliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Centiliter))]
    public static Volume? FromCentiliter(double? Centiliter)
    {
        if (Centiliter is null)
            return null;
        
        return new Volume((double)Centiliter, VolumeUnit.Centiliter);
    }
    /// <summary>
    /// Get Volume from Hectoliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Hectoliter))]
    public static Volume? FromHectoliter(double? Hectoliter)
    {
        if (Hectoliter is null)
            return null;
        
        return new Volume((double)Hectoliter, VolumeUnit.Hectoliter);
    }
    /// <summary>
    /// Get Volume from Kiloliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kiloliter))]
    public static Volume? FromKiloliter(double? Kiloliter)
    {
        if (Kiloliter is null)
            return null;
        
        return new Volume((double)Kiloliter, VolumeUnit.Kiloliter);
    }
    /// <summary>
    /// Get Volume from Megaliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Megaliter))]
    public static Volume? FromMegaliter(double? Megaliter)
    {
        if (Megaliter is null)
            return null;
        
        return new Volume((double)Megaliter, VolumeUnit.Megaliter);
    }
    /// <summary>
    /// Get Volume from Picoliter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Picoliter))]
    public static Volume? FromPicoliter(double? Picoliter)
    {
        if (Picoliter is null)
            return null;
        
        return new Volume((double)Picoliter, VolumeUnit.Picoliter);
    }
    /// <summary>
    /// Get Volume from AcreFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(AcreFoot))]
    public static Volume? FromAcreFoot(double? AcreFoot)
    {
        if (AcreFoot is null)
            return null;
        
        return new Volume((double)AcreFoot, VolumeUnit.AcreFoot);
    }
    /// <summary>
    /// Get Volume from BoardFoot.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(BoardFoot))]
    public static Volume? FromBoardFoot(double? BoardFoot)
    {
        if (BoardFoot is null)
            return null;
        
        return new Volume((double)BoardFoot, VolumeUnit.BoardFoot);
    }
    /// <summary>
    /// Get Volume from AuTablespoon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(AuTablespoon))]
    public static Volume? FromAuTablespoon(double? AuTablespoon)
    {
        if (AuTablespoon is null)
            return null;
        
        return new Volume((double)AuTablespoon, VolumeUnit.AuTablespoon);
    }
    /// <summary>
    /// Get Volume from ImperialBeerBarrel.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(ImperialBeerBarrel))]
    public static Volume? FromImperialBeerBarrel(double? ImperialBeerBarrel)
    {
        if (ImperialBeerBarrel is null)
            return null;
        
        return new Volume((double)ImperialBeerBarrel, VolumeUnit.ImperialBeerBarrel);
    }
    /// <summary>
    /// Get Volume from MetricTeaspoon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MetricTeaspoon))]
    public static Volume? FromMetricTeaspoon(double? MetricTeaspoon)
    {
        if (MetricTeaspoon is null)
            return null;
        
        return new Volume((double)MetricTeaspoon, VolumeUnit.MetricTeaspoon);
    }
    /// <summary>
    /// Get Volume from MetricCup.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MetricCup))]
    public static Volume? FromMetricCup(double? MetricCup)
    {
        if (MetricCup is null)
            return null;
        
        return new Volume((double)MetricCup, VolumeUnit.MetricCup);
    }
    /// <summary>
    /// Get Volume from ImperialGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(ImperialGallon))]
    public static Volume? FromImperialGallon(double? ImperialGallon)
    {
        if (ImperialGallon is null)
            return null;
        
        return new Volume((double)ImperialGallon, VolumeUnit.ImperialGallon);
    }
    /// <summary>
    /// Get Volume from KiloimperialGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KiloimperialGallon))]
    public static Volume? FromKiloimperialGallon(double? KiloimperialGallon)
    {
        if (KiloimperialGallon is null)
            return null;
        
        return new Volume((double)KiloimperialGallon, VolumeUnit.KiloimperialGallon);
    }
    /// <summary>
    /// Get Volume from MegaimperialGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegaimperialGallon))]
    public static Volume? FromMegaimperialGallon(double? MegaimperialGallon)
    {
        if (MegaimperialGallon is null)
            return null;
        
        return new Volume((double)MegaimperialGallon, VolumeUnit.MegaimperialGallon);
    }
    /// <summary>
    /// Get Volume from ImperialOunce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(ImperialOunce))]
    public static Volume? FromImperialOunce(double? ImperialOunce)
    {
        if (ImperialOunce is null)
            return null;
        
        return new Volume((double)ImperialOunce, VolumeUnit.ImperialOunce);
    }
    /// <summary>
    /// Get Volume from ImperialPint.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(ImperialPint))]
    public static Volume? FromImperialPint(double? ImperialPint)
    {
        if (ImperialPint is null)
            return null;
        
        return new Volume((double)ImperialPint, VolumeUnit.ImperialPint);
    }
    /// <summary>
    /// Get Volume from UsCustomaryCup.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsCustomaryCup))]
    public static Volume? FromUsCustomaryCup(double? UsCustomaryCup)
    {
        if (UsCustomaryCup is null)
            return null;
        
        return new Volume((double)UsCustomaryCup, VolumeUnit.UsCustomaryCup);
    }
    /// <summary>
    /// Get Volume from UsBeerBarrel.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsBeerBarrel))]
    public static Volume? FromUsBeerBarrel(double? UsBeerBarrel)
    {
        if (UsBeerBarrel is null)
            return null;
        
        return new Volume((double)UsBeerBarrel, VolumeUnit.UsBeerBarrel);
    }
    /// <summary>
    /// Get Volume from UkTablespoon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UkTablespoon))]
    public static Volume? FromUkTablespoon(double? UkTablespoon)
    {
        if (UkTablespoon is null)
            return null;
        
        return new Volume((double)UkTablespoon, VolumeUnit.UkTablespoon);
    }
    /// <summary>
    /// Get Volume from UsOunce.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsOunce))]
    public static Volume? FromUsOunce(double? UsOunce)
    {
        if (UsOunce is null)
            return null;
        
        return new Volume((double)UsOunce, VolumeUnit.UsOunce);
    }
    /// <summary>
    /// Get Volume from UsGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsGallon))]
    public static Volume? FromUsGallon(double? UsGallon)
    {
        if (UsGallon is null)
            return null;
        
        return new Volume((double)UsGallon, VolumeUnit.UsGallon);
    }
    /// <summary>
    /// Get Volume from KilousGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilousGallon))]
    public static Volume? FromKilousGallon(double? KilousGallon)
    {
        if (KilousGallon is null)
            return null;
        
        return new Volume((double)KilousGallon, VolumeUnit.KilousGallon);
    }
    /// <summary>
    /// Get Volume from MegausGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MegausGallon))]
    public static Volume? FromMegausGallon(double? MegausGallon)
    {
        if (MegausGallon is null)
            return null;
        
        return new Volume((double)MegausGallon, VolumeUnit.MegausGallon);
    }
    /// <summary>
    /// Get Volume from DecausGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecausGallon))]
    public static Volume? FromDecausGallon(double? DecausGallon)
    {
        if (DecausGallon is null)
            return null;
        
        return new Volume((double)DecausGallon, VolumeUnit.DecausGallon);
    }
    /// <summary>
    /// Get Volume from DeciusGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DeciusGallon))]
    public static Volume? FromDeciusGallon(double? DeciusGallon)
    {
        if (DeciusGallon is null)
            return null;
        
        return new Volume((double)DeciusGallon, VolumeUnit.DeciusGallon);
    }
    /// <summary>
    /// Get Volume from HectousGallon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HectousGallon))]
    public static Volume? FromHectousGallon(double? HectousGallon)
    {
        if (HectousGallon is null)
            return null;
        
        return new Volume((double)HectousGallon, VolumeUnit.HectousGallon);
    }
    /// <summary>
    /// Get Volume from OilBarrel.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(OilBarrel))]
    public static Volume? FromOilBarrel(double? OilBarrel)
    {
        if (OilBarrel is null)
            return null;
        
        return new Volume((double)OilBarrel, VolumeUnit.OilBarrel);
    }
    /// <summary>
    /// Get Volume from UsLegalCup.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsLegalCup))]
    public static Volume? FromUsLegalCup(double? UsLegalCup)
    {
        if (UsLegalCup is null)
            return null;
        
        return new Volume((double)UsLegalCup, VolumeUnit.UsLegalCup);
    }
    /// <summary>
    /// Get Volume from UsPint.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsPint))]
    public static Volume? FromUsPint(double? UsPint)
    {
        if (UsPint is null)
            return null;
        
        return new Volume((double)UsPint, VolumeUnit.UsPint);
    }
    /// <summary>
    /// Get Volume from UsQuart.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsQuart))]
    public static Volume? FromUsQuart(double? UsQuart)
    {
        if (UsQuart is null)
            return null;
        
        return new Volume((double)UsQuart, VolumeUnit.UsQuart);
    }
    /// <summary>
    /// Get Volume from UsTablespoon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsTablespoon))]
    public static Volume? FromUsTablespoon(double? UsTablespoon)
    {
        if (UsTablespoon is null)
            return null;
        
        return new Volume((double)UsTablespoon, VolumeUnit.UsTablespoon);
    }
    /// <summary>
    /// Get Volume from UsTeaspoon.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(UsTeaspoon))]
    public static Volume? FromUsTeaspoon(double? UsTeaspoon)
    {
        if (UsTeaspoon is null)
            return null;
        
        return new Volume((double)UsTeaspoon, VolumeUnit.UsTeaspoon);
    }

}
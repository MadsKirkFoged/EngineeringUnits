
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Volume
    {

 

            /// <summary>
            ///     Get Volume from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromSI(double SI)
            {
                double value= (double)SI;
                return new Volume(value, VolumeUnit.SI);
            }
            /// <summary>
            ///     Get Volume from CubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicMeter(double CubicMeter)
            {
                double value= (double)CubicMeter;
                return new Volume(value, VolumeUnit.CubicMeter);
            }
            /// <summary>
            ///     Get Volume from HectocubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromHectocubicMeter(double HectocubicMeter)
            {
                double value= (double)HectocubicMeter;
                return new Volume(value, VolumeUnit.HectocubicMeter);
            }
            /// <summary>
            ///     Get Volume from KilocubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromKilocubicMeter(double KilocubicMeter)
            {
                double value= (double)KilocubicMeter;
                return new Volume(value, VolumeUnit.KilocubicMeter);
            }
            /// <summary>
            ///     Get Volume from CubicKilometer.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicKilometer(double CubicKilometer)
            {
                double value= (double)CubicKilometer;
                return new Volume(value, VolumeUnit.CubicKilometer);
            }
            /// <summary>
            ///     Get Volume from CubicMicrometer.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicMicrometer(double CubicMicrometer)
            {
                double value= (double)CubicMicrometer;
                return new Volume(value, VolumeUnit.CubicMicrometer);
            }
            /// <summary>
            ///     Get Volume from CubicMile.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicMile(double CubicMile)
            {
                double value= (double)CubicMile;
                return new Volume(value, VolumeUnit.CubicMile);
            }
            /// <summary>
            ///     Get Volume from CubicMillimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicMillimeter(double CubicMillimeter)
            {
                double value= (double)CubicMillimeter;
                return new Volume(value, VolumeUnit.CubicMillimeter);
            }
            /// <summary>
            ///     Get Volume from CubicYard.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicYard(double CubicYard)
            {
                double value= (double)CubicYard;
                return new Volume(value, VolumeUnit.CubicYard);
            }
            /// <summary>
            ///     Get Volume from CubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicInch(double CubicInch)
            {
                double value= (double)CubicInch;
                return new Volume(value, VolumeUnit.CubicInch);
            }
            /// <summary>
            ///     Get Volume from CubicHectometer.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicHectometer(double CubicHectometer)
            {
                double value= (double)CubicHectometer;
                return new Volume(value, VolumeUnit.CubicHectometer);
            }
            /// <summary>
            ///     Get Volume from CubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicFoot(double CubicFoot)
            {
                double value= (double)CubicFoot;
                return new Volume(value, VolumeUnit.CubicFoot);
            }
            /// <summary>
            ///     Get Volume from HectocubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromHectocubicFoot(double HectocubicFoot)
            {
                double value= (double)HectocubicFoot;
                return new Volume(value, VolumeUnit.HectocubicFoot);
            }
            /// <summary>
            ///     Get Volume from KilocubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromKilocubicFoot(double KilocubicFoot)
            {
                double value= (double)KilocubicFoot;
                return new Volume(value, VolumeUnit.KilocubicFoot);
            }
            /// <summary>
            ///     Get Volume from MegacubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMegacubicFoot(double MegacubicFoot)
            {
                double value= (double)MegacubicFoot;
                return new Volume(value, VolumeUnit.MegacubicFoot);
            }
            /// <summary>
            ///     Get Volume from CubicDecimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicDecimeter(double CubicDecimeter)
            {
                double value= (double)CubicDecimeter;
                return new Volume(value, VolumeUnit.CubicDecimeter);
            }
            /// <summary>
            ///     Get Volume from CubicCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCubicCentimeter(double CubicCentimeter)
            {
                double value= (double)CubicCentimeter;
                return new Volume(value, VolumeUnit.CubicCentimeter);
            }
            /// <summary>
            ///     Get Volume from Liter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromLiter(double Liter)
            {
                double value= (double)Liter;
                return new Volume(value, VolumeUnit.Liter);
            }
            /// <summary>
            ///     Get Volume from Nanoliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromNanoliter(double Nanoliter)
            {
                double value= (double)Nanoliter;
                return new Volume(value, VolumeUnit.Nanoliter);
            }
            /// <summary>
            ///     Get Volume from Microliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMicroliter(double Microliter)
            {
                double value= (double)Microliter;
                return new Volume(value, VolumeUnit.Microliter);
            }
            /// <summary>
            ///     Get Volume from Milliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMilliliter(double Milliliter)
            {
                double value= (double)Milliliter;
                return new Volume(value, VolumeUnit.Milliliter);
            }
            /// <summary>
            ///     Get Volume from Deciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromDeciliter(double Deciliter)
            {
                double value= (double)Deciliter;
                return new Volume(value, VolumeUnit.Deciliter);
            }
            /// <summary>
            ///     Get Volume from Centiliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromCentiliter(double Centiliter)
            {
                double value= (double)Centiliter;
                return new Volume(value, VolumeUnit.Centiliter);
            }
            /// <summary>
            ///     Get Volume from Hectoliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromHectoliter(double Hectoliter)
            {
                double value= (double)Hectoliter;
                return new Volume(value, VolumeUnit.Hectoliter);
            }
            /// <summary>
            ///     Get Volume from Kiloliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromKiloliter(double Kiloliter)
            {
                double value= (double)Kiloliter;
                return new Volume(value, VolumeUnit.Kiloliter);
            }
            /// <summary>
            ///     Get Volume from Megaliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMegaliter(double Megaliter)
            {
                double value= (double)Megaliter;
                return new Volume(value, VolumeUnit.Megaliter);
            }
            /// <summary>
            ///     Get Volume from Picoliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromPicoliter(double Picoliter)
            {
                double value= (double)Picoliter;
                return new Volume(value, VolumeUnit.Picoliter);
            }
            /// <summary>
            ///     Get Volume from AcreFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromAcreFoot(double AcreFoot)
            {
                double value= (double)AcreFoot;
                return new Volume(value, VolumeUnit.AcreFoot);
            }
            /// <summary>
            ///     Get Volume from BoardFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromBoardFoot(double BoardFoot)
            {
                double value= (double)BoardFoot;
                return new Volume(value, VolumeUnit.BoardFoot);
            }
            /// <summary>
            ///     Get Volume from AuTablespoon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromAuTablespoon(double AuTablespoon)
            {
                double value= (double)AuTablespoon;
                return new Volume(value, VolumeUnit.AuTablespoon);
            }
            /// <summary>
            ///     Get Volume from ImperialBeerBarrel.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromImperialBeerBarrel(double ImperialBeerBarrel)
            {
                double value= (double)ImperialBeerBarrel;
                return new Volume(value, VolumeUnit.ImperialBeerBarrel);
            }
            /// <summary>
            ///     Get Volume from MetricTeaspoon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMetricTeaspoon(double MetricTeaspoon)
            {
                double value= (double)MetricTeaspoon;
                return new Volume(value, VolumeUnit.MetricTeaspoon);
            }
            /// <summary>
            ///     Get Volume from MetricCup.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMetricCup(double MetricCup)
            {
                double value= (double)MetricCup;
                return new Volume(value, VolumeUnit.MetricCup);
            }
            /// <summary>
            ///     Get Volume from ImperialGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromImperialGallon(double ImperialGallon)
            {
                double value= (double)ImperialGallon;
                return new Volume(value, VolumeUnit.ImperialGallon);
            }
            /// <summary>
            ///     Get Volume from KiloimperialGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromKiloimperialGallon(double KiloimperialGallon)
            {
                double value= (double)KiloimperialGallon;
                return new Volume(value, VolumeUnit.KiloimperialGallon);
            }
            /// <summary>
            ///     Get Volume from MegaimperialGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMegaimperialGallon(double MegaimperialGallon)
            {
                double value= (double)MegaimperialGallon;
                return new Volume(value, VolumeUnit.MegaimperialGallon);
            }
            /// <summary>
            ///     Get Volume from ImperialOunce.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromImperialOunce(double ImperialOunce)
            {
                double value= (double)ImperialOunce;
                return new Volume(value, VolumeUnit.ImperialOunce);
            }
            /// <summary>
            ///     Get Volume from ImperialPint.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromImperialPint(double ImperialPint)
            {
                double value= (double)ImperialPint;
                return new Volume(value, VolumeUnit.ImperialPint);
            }
            /// <summary>
            ///     Get Volume from UsCustomaryCup.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsCustomaryCup(double UsCustomaryCup)
            {
                double value= (double)UsCustomaryCup;
                return new Volume(value, VolumeUnit.UsCustomaryCup);
            }
            /// <summary>
            ///     Get Volume from UsBeerBarrel.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsBeerBarrel(double UsBeerBarrel)
            {
                double value= (double)UsBeerBarrel;
                return new Volume(value, VolumeUnit.UsBeerBarrel);
            }
            /// <summary>
            ///     Get Volume from UkTablespoon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUkTablespoon(double UkTablespoon)
            {
                double value= (double)UkTablespoon;
                return new Volume(value, VolumeUnit.UkTablespoon);
            }
            /// <summary>
            ///     Get Volume from UsOunce.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsOunce(double UsOunce)
            {
                double value= (double)UsOunce;
                return new Volume(value, VolumeUnit.UsOunce);
            }
            /// <summary>
            ///     Get Volume from UsGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsGallon(double UsGallon)
            {
                double value= (double)UsGallon;
                return new Volume(value, VolumeUnit.UsGallon);
            }
            /// <summary>
            ///     Get Volume from KilousGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromKilousGallon(double KilousGallon)
            {
                double value= (double)KilousGallon;
                return new Volume(value, VolumeUnit.KilousGallon);
            }
            /// <summary>
            ///     Get Volume from MegausGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromMegausGallon(double MegausGallon)
            {
                double value= (double)MegausGallon;
                return new Volume(value, VolumeUnit.MegausGallon);
            }
            /// <summary>
            ///     Get Volume from DecausGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromDecausGallon(double DecausGallon)
            {
                double value= (double)DecausGallon;
                return new Volume(value, VolumeUnit.DecausGallon);
            }
            /// <summary>
            ///     Get Volume from DeciusGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromDeciusGallon(double DeciusGallon)
            {
                double value= (double)DeciusGallon;
                return new Volume(value, VolumeUnit.DeciusGallon);
            }
            /// <summary>
            ///     Get Volume from HectousGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromHectousGallon(double HectousGallon)
            {
                double value= (double)HectousGallon;
                return new Volume(value, VolumeUnit.HectousGallon);
            }
            /// <summary>
            ///     Get Volume from OilBarrel.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromOilBarrel(double OilBarrel)
            {
                double value= (double)OilBarrel;
                return new Volume(value, VolumeUnit.OilBarrel);
            }
            /// <summary>
            ///     Get Volume from UsLegalCup.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsLegalCup(double UsLegalCup)
            {
                double value= (double)UsLegalCup;
                return new Volume(value, VolumeUnit.UsLegalCup);
            }
            /// <summary>
            ///     Get Volume from UsPint.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsPint(double UsPint)
            {
                double value= (double)UsPint;
                return new Volume(value, VolumeUnit.UsPint);
            }
            /// <summary>
            ///     Get Volume from UsQuart.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsQuart(double UsQuart)
            {
                double value= (double)UsQuart;
                return new Volume(value, VolumeUnit.UsQuart);
            }
            /// <summary>
            ///     Get Volume from UsTablespoon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsTablespoon(double UsTablespoon)
            {
                double value= (double)UsTablespoon;
                return new Volume(value, VolumeUnit.UsTablespoon);
            }
            /// <summary>
            ///     Get Volume from UsTeaspoon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Volume FromUsTeaspoon(double UsTeaspoon)
            {
                double value= (double)UsTeaspoon;
                return new Volume(value, VolumeUnit.UsTeaspoon);
            }
    }
}



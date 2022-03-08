
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class VolumeFlow
    {

 

            /// <summary>
            ///     Get VolumeFlow from AcreFootPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromAcreFootPerDay(double AcreFootPerDay)
            {
                double value= (double)AcreFootPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from AcreFootPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromAcreFootPerHour(double AcreFootPerHour)
            {
                double value= (double)AcreFootPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from AcreFootPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromAcreFootPerMinute(double AcreFootPerMinute)
            {
                double value= (double)AcreFootPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from AcreFootPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromAcreFootPerSecond(double AcreFootPerSecond)
            {
                double value= (double)AcreFootPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from CentiliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCentiliterPerDay(double CentiliterPerDay)
            {
                double value= (double)CentiliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from CentiliterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCentiliterPerMinute(double CentiliterPerMinute)
            {
                double value= (double)CentiliterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from CentiliterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCentiliterPerSecond(double CentiliterPerSecond)
            {
                double value= (double)CentiliterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicCentimeterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicCentimeterPerMinute(double CubicCentimeterPerMinute)
            {
                double value= (double)CubicCentimeterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.CubicCentimeterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicDecimeterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicDecimeterPerMinute(double CubicDecimeterPerMinute)
            {
                double value= (double)CubicDecimeterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.CubicDecimeterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicFootPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicFootPerHour(double CubicFootPerHour)
            {
                double value= (double)CubicFootPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicFootPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicFootPerMinute(double CubicFootPerMinute)
            {
                double value= (double)CubicFootPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicFootPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicFootPerSecond(double CubicFootPerSecond)
            {
                double value= (double)CubicFootPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicMeterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicMeterPerDay(double CubicMeterPerDay)
            {
                double value= (double)CubicMeterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicMeterPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicMeterPerHour(double CubicMeterPerHour)
            {
                double value= (double)CubicMeterPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicMeterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicMeterPerMinute(double CubicMeterPerMinute)
            {
                double value= (double)CubicMeterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicMeterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicMeterPerSecond(double CubicMeterPerSecond)
            {
                double value= (double)CubicMeterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromSI(double SI)
            {
                double value= (double)SI;
                return new VolumeFlow(value, VolumeFlowUnit.SI);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicMillimeterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicMillimeterPerSecond(double CubicMillimeterPerSecond)
            {
                double value= (double)CubicMillimeterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.CubicMillimeterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicYardPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicYardPerDay(double CubicYardPerDay)
            {
                double value= (double)CubicYardPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicYardPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicYardPerHour(double CubicYardPerHour)
            {
                double value= (double)CubicYardPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicYardPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicYardPerMinute(double CubicYardPerMinute)
            {
                double value= (double)CubicYardPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from CubicYardPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromCubicYardPerSecond(double CubicYardPerSecond)
            {
                double value= (double)CubicYardPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from DeciliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromDeciliterPerDay(double DeciliterPerDay)
            {
                double value= (double)DeciliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from DeciliterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromDeciliterPerMinute(double DeciliterPerMinute)
            {
                double value= (double)DeciliterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from DeciliterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromDeciliterPerSecond(double DeciliterPerSecond)
            {
                double value= (double)DeciliterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from KiloliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromKiloliterPerDay(double KiloliterPerDay)
            {
                double value= (double)KiloliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from KiloliterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromKiloliterPerMinute(double KiloliterPerMinute)
            {
                double value= (double)KiloliterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from KiloliterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromKiloliterPerSecond(double KiloliterPerSecond)
            {
                double value= (double)KiloliterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from KilousGallonPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromKilousGallonPerMinute(double KilousGallonPerMinute)
            {
                double value= (double)KilousGallonPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.KilousGallonPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from LiterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromLiterPerDay(double LiterPerDay)
            {
                double value= (double)LiterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.LiterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from LiterPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromLiterPerHour(double LiterPerHour)
            {
                double value= (double)LiterPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.LiterPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from LiterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromLiterPerMinute(double LiterPerMinute)
            {
                double value= (double)LiterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.LiterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from LiterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromLiterPerSecond(double LiterPerSecond)
            {
                double value= (double)LiterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.LiterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from MegaliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMegaliterPerDay(double MegaliterPerDay)
            {
                double value= (double)MegaliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.MegaliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from MicroliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMicroliterPerDay(double MicroliterPerDay)
            {
                double value= (double)MicroliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from MicroliterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMicroliterPerMinute(double MicroliterPerMinute)
            {
                double value= (double)MicroliterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from MicroliterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMicroliterPerSecond(double MicroliterPerSecond)
            {
                double value= (double)MicroliterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from MilliliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMilliliterPerDay(double MilliliterPerDay)
            {
                double value= (double)MilliliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from MilliliterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMilliliterPerMinute(double MilliliterPerMinute)
            {
                double value= (double)MilliliterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from MilliliterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMilliliterPerSecond(double MilliliterPerSecond)
            {
                double value= (double)MilliliterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from MillionUsGallonsPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMillionUsGallonsPerDay(double MillionUsGallonsPerDay)
            {
                double value= (double)MillionUsGallonsPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.MillionUsGallonsPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from NanoliterPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromNanoliterPerDay(double NanoliterPerDay)
            {
                double value= (double)NanoliterPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from NanoliterPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromNanoliterPerMinute(double NanoliterPerMinute)
            {
                double value= (double)NanoliterPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from NanoliterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromNanoliterPerSecond(double NanoliterPerSecond)
            {
                double value= (double)NanoliterPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from OilBarrelPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromOilBarrelPerDay(double OilBarrelPerDay)
            {
                double value= (double)OilBarrelPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from OilBarrelPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromOilBarrelPerHour(double OilBarrelPerHour)
            {
                double value= (double)OilBarrelPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from OilBarrelPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromOilBarrelPerMinute(double OilBarrelPerMinute)
            {
                double value= (double)OilBarrelPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from OilBarrelPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromOilBarrelPerSecond(double OilBarrelPerSecond)
            {
                double value= (double)OilBarrelPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from UkGallonPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUkGallonPerDay(double UkGallonPerDay)
            {
                double value= (double)UkGallonPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from UkGallonPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUkGallonPerHour(double UkGallonPerHour)
            {
                double value= (double)UkGallonPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from UkGallonPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUkGallonPerMinute(double UkGallonPerMinute)
            {
                double value= (double)UkGallonPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from UkGallonPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUkGallonPerSecond(double UkGallonPerSecond)
            {
                double value= (double)UkGallonPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from UsGallonPerDay.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUsGallonPerDay(double UsGallonPerDay)
            {
                double value= (double)UsGallonPerDay;
                return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerDay);
            }
            /// <summary>
            ///     Get VolumeFlow from UsGallonPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUsGallonPerHour(double UsGallonPerHour)
            {
                double value= (double)UsGallonPerHour;
                return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerHour);
            }
            /// <summary>
            ///     Get VolumeFlow from UsGallonPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUsGallonPerMinute(double UsGallonPerMinute)
            {
                double value= (double)UsGallonPerMinute;
                return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerMinute);
            }
            /// <summary>
            ///     Get VolumeFlow from UsGallonPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromUsGallonPerSecond(double UsGallonPerSecond)
            {
                double value= (double)UsGallonPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerSecond);
            }
            /// <summary>
            ///     Get VolumeFlow from MegaukGallonPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static VolumeFlow FromMegaukGallonPerSecond(double MegaukGallonPerSecond)
            {
                double value= (double)MegaukGallonPerSecond;
                return new VolumeFlow(value, VolumeFlowUnit.MegaukGallonPerSecond);
            }
    }
}



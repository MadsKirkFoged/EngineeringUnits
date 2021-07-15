using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class VolumeFlow
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromSI(double si)
        {
            double value = (double)si;
            return new VolumeFlow(value, VolumeFlowUnit.SI);
        }


        /// <summary>
        ///     Get VolumeFlow from AcreFeetPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromAcreFeetPerDay(double acrefeetperday)
        {
            double value = (double)acrefeetperday;
            return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from AcreFeetPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromAcreFeetPerHour(double acrefeetperhour)
        {
            double value = (double)acrefeetperhour;
            return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from AcreFeetPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromAcreFeetPerMinute(double acrefeetperminute)
        {
            double value = (double)acrefeetperminute;
            return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from AcreFeetPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromAcreFeetPerSecond(double acrefeetpersecond)
        {
            double value = (double)acrefeetpersecond;
            return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from CentilitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCentilitersPerDay(double centilitersperday)
        {
            double value = (double)centilitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from CentilitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCentilitersPerMinute(double centilitersperminute)
        {
            double value = (double)centilitersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from CentilitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCentilitersPerSecond(double centiliterspersecond)
        {
            double value = (double)centiliterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicCentimetersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicCentimetersPerMinute(double cubiccentimetersperminute)
        {
            double value = (double)cubiccentimetersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.CubicCentimeterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicDecimetersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicDecimetersPerMinute(double cubicdecimetersperminute)
        {
            double value = (double)cubicdecimetersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.CubicDecimeterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicFeetPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicFeetPerHour(double cubicfeetperhour)
        {
            double value = (double)cubicfeetperhour;
            return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicFeetPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicFeetPerMinute(double cubicfeetperminute)
        {
            double value = (double)cubicfeetperminute;
            return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicFeetPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicFeetPerSecond(double cubicfeetpersecond)
        {
            double value = (double)cubicfeetpersecond;
            return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicMetersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicMetersPerDay(double cubicmetersperday)
        {
            double value = (double)cubicmetersperday;
            return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicMetersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicMetersPerHour(double cubicmetersperhour)
        {
            double value = (double)cubicmetersperhour;
            return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicMetersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicMetersPerMinute(double cubicmetersperminute)
        {
            double value = (double)cubicmetersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicMetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicMetersPerSecond(double cubicmeterspersecond)
        {
            double value = (double)cubicmeterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicMillimetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicMillimetersPerSecond(double cubicmillimeterspersecond)
        {
            double value = (double)cubicmillimeterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.CubicMillimeterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicYardsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicYardsPerDay(double cubicyardsperday)
        {
            double value = (double)cubicyardsperday;
            return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicYardsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicYardsPerHour(double cubicyardsperhour)
        {
            double value = (double)cubicyardsperhour;
            return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicYardsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicYardsPerMinute(double cubicyardsperminute)
        {
            double value = (double)cubicyardsperminute;
            return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from CubicYardsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromCubicYardsPerSecond(double cubicyardspersecond)
        {
            double value = (double)cubicyardspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from DecilitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromDecilitersPerDay(double decilitersperday)
        {
            double value = (double)decilitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from DecilitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromDecilitersPerMinute(double decilitersperminute)
        {
            double value = (double)decilitersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from DecilitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromDecilitersPerSecond(double deciliterspersecond)
        {
            double value = (double)deciliterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from KilolitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromKilolitersPerDay(double kilolitersperday)
        {
            double value = (double)kilolitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from KilolitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromKilolitersPerMinute(double kilolitersperminute)
        {
            double value = (double)kilolitersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from KilolitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromKilolitersPerSecond(double kiloliterspersecond)
        {
            double value = (double)kiloliterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from KilousGallonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromKilousGallonsPerMinute(double kilousgallonsperminute)
        {
            double value = (double)kilousgallonsperminute;
            return new VolumeFlow(value, VolumeFlowUnit.KilousGallonPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from LitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromLitersPerDay(double litersperday)
        {
            double value = (double)litersperday;
            return new VolumeFlow(value, VolumeFlowUnit.LiterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from LitersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromLitersPerHour(double litersperhour)
        {
            double value = (double)litersperhour;
            return new VolumeFlow(value, VolumeFlowUnit.LiterPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from LitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromLitersPerMinute(double litersperminute)
        {
            double value = (double)litersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.LiterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from LitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromLitersPerSecond(double literspersecond)
        {
            double value = (double)literspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.LiterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from MegalitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMegalitersPerDay(double megalitersperday)
        {
            double value = (double)megalitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.MegaliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from MegaukGallonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMegaukGallonsPerSecond(double megaukgallonspersecond)
        {
            double value = (double)megaukgallonspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.MegaukGallonPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from MicrolitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMicrolitersPerDay(double microlitersperday)
        {
            double value = (double)microlitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from MicrolitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMicrolitersPerMinute(double microlitersperminute)
        {
            double value = (double)microlitersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from MicrolitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMicrolitersPerSecond(double microliterspersecond)
        {
            double value = (double)microliterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from MillilitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMillilitersPerDay(double millilitersperday)
        {
            double value = (double)millilitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from MillilitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMillilitersPerMinute(double millilitersperminute)
        {
            double value = (double)millilitersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from MillilitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMillilitersPerSecond(double milliliterspersecond)
        {
            double value = (double)milliliterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from MillionUsGallonsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromMillionUsGallonsPerDay(double millionusgallonsperday)
        {
            double value = (double)millionusgallonsperday;
            return new VolumeFlow(value, VolumeFlowUnit.MillionUsGallonsPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from NanolitersPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromNanolitersPerDay(double nanolitersperday)
        {
            double value = (double)nanolitersperday;
            return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from NanolitersPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromNanolitersPerMinute(double nanolitersperminute)
        {
            double value = (double)nanolitersperminute;
            return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from NanolitersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromNanolitersPerSecond(double nanoliterspersecond)
        {
            double value = (double)nanoliterspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from OilBarrelsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromOilBarrelsPerDay(double oilbarrelsperday)
        {
            double value = (double)oilbarrelsperday;
            return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from OilBarrelsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromOilBarrelsPerHour(double oilbarrelsperhour)
        {
            double value = (double)oilbarrelsperhour;
            return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from OilBarrelsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromOilBarrelsPerMinute(double oilbarrelsperminute)
        {
            double value = (double)oilbarrelsperminute;
            return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from OilBarrelsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromOilBarrelsPerSecond(double oilbarrelspersecond)
        {
            double value = (double)oilbarrelspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from UkGallonsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUkGallonsPerDay(double ukgallonsperday)
        {
            double value = (double)ukgallonsperday;
            return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from UkGallonsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUkGallonsPerHour(double ukgallonsperhour)
        {
            double value = (double)ukgallonsperhour;
            return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from UkGallonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUkGallonsPerMinute(double ukgallonsperminute)
        {
            double value = (double)ukgallonsperminute;
            return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from UkGallonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUkGallonsPerSecond(double ukgallonspersecond)
        {
            double value = (double)ukgallonspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerSecond);
        }
        /// <summary>
        ///     Get VolumeFlow from UsGallonsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUsGallonsPerDay(double usgallonsperday)
        {
            double value = (double)usgallonsperday;
            return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerDay);
        }
        /// <summary>
        ///     Get VolumeFlow from UsGallonsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUsGallonsPerHour(double usgallonsperhour)
        {
            double value = (double)usgallonsperhour;
            return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerHour);
        }
        /// <summary>
        ///     Get VolumeFlow from UsGallonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUsGallonsPerMinute(double usgallonsperminute)
        {
            double value = (double)usgallonsperminute;
            return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerMinute);
        }
        /// <summary>
        ///     Get VolumeFlow from UsGallonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlow FromUsGallonsPerSecond(double usgallonspersecond)
        {
            double value = (double)usgallonspersecond;
            return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerSecond);
        }

    }
}

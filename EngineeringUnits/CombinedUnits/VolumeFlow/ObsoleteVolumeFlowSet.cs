﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class VolumeFlow
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static VolumeFlow FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new VolumeFlow(value, VolumeFlowUnit.SI);
    //}

    /// <summary>
    ///     Get VolumeFlow from AcreFeetPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromAcreFeetPerDay->FromAcreFootPerDay")]
    public static VolumeFlow FromAcreFeetPerDay(double acrefeetperday)
    {
        var value = (double)acrefeetperday;
        return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from AcreFeetPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromAcreFeetPerHour->FromAcreFootPerHour")]
    public static VolumeFlow FromAcreFeetPerHour(double acrefeetperhour)
    {
        var value = (double)acrefeetperhour;
        return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from AcreFeetPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromAcreFeetPerMinute->FromAcreFootPerMinute")]
    public static VolumeFlow FromAcreFeetPerMinute(double acrefeetperminute)
    {
        var value = (double)acrefeetperminute;
        return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from AcreFeetPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromAcreFeetPerSecond->FromAcreFootPerSecond")]
    public static VolumeFlow FromAcreFeetPerSecond(double acrefeetpersecond)
    {
        var value = (double)acrefeetpersecond;
        return new VolumeFlow(value, VolumeFlowUnit.AcreFootPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from CentilitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentilitersPerDay->FromCentiliterPerDay")]
    public static VolumeFlow FromCentilitersPerDay(double centilitersperday)
    {
        var value = (double)centilitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from CentilitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentilitersPerMinute->FromCentiliterPerMinute")]
    public static VolumeFlow FromCentilitersPerMinute(double centilitersperminute)
    {
        var value = (double)centilitersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from CentilitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentilitersPerSecond->FromCentiliterPerSecond")]
    public static VolumeFlow FromCentilitersPerSecond(double centiliterspersecond)
    {
        var value = (double)centiliterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.CentiliterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicCentimetersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicCentimetersPerMinute->FromCubicCentimeterPerMinute")]
    public static VolumeFlow FromCubicCentimetersPerMinute(double cubiccentimetersperminute)
    {
        var value = (double)cubiccentimetersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.CubicCentimeterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicDecimetersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicDecimetersPerMinute->FromCubicDecimeterPerMinute")]
    public static VolumeFlow FromCubicDecimetersPerMinute(double cubicdecimetersperminute)
    {
        var value = (double)cubicdecimetersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.CubicDecimeterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicFeetPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromCubicFeetPerHour->FromCubicFootPerHour")]
    public static VolumeFlow FromCubicFeetPerHour(double cubicfeetperhour)
    {
        var value = (double)cubicfeetperhour;
        return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicFeetPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromCubicFeetPerMinute->FromCubicFootPerMinute")]
    public static VolumeFlow FromCubicFeetPerMinute(double cubicfeetperminute)
    {
        var value = (double)cubicfeetperminute;
        return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicFeetPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use singular form - FromCubicFeetPerSecond->FromCubicFootPerSecond")]
    public static VolumeFlow FromCubicFeetPerSecond(double cubicfeetpersecond)
    {
        var value = (double)cubicfeetpersecond;
        return new VolumeFlow(value, VolumeFlowUnit.CubicFootPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicMetersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicMetersPerDay->FromCubicMeterPerDay")]
    public static VolumeFlow FromCubicMetersPerDay(double cubicmetersperday)
    {
        var value = (double)cubicmetersperday;
        return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicMetersPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicMetersPerHour->FromCubicMeterPerHour")]
    public static VolumeFlow FromCubicMetersPerHour(double cubicmetersperhour)
    {
        var value = (double)cubicmetersperhour;
        return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicMetersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicMetersPerMinute->FromCubicMeterPerMinute")]
    public static VolumeFlow FromCubicMetersPerMinute(double cubicmetersperminute)
    {
        var value = (double)cubicmetersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicMetersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicMetersPerSecond->FromCubicMeterPerSecond")]
    public static VolumeFlow FromCubicMetersPerSecond(double cubicmeterspersecond)
    {
        var value = (double)cubicmeterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.CubicMeterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicMillimetersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicMillimetersPerSecond->FromCubicMillimeterPerSecond")]
    public static VolumeFlow FromCubicMillimetersPerSecond(double cubicmillimeterspersecond)
    {
        var value = (double)cubicmillimeterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.CubicMillimeterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicYardsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicYardsPerDay->FromCubicYardPerDay")]
    public static VolumeFlow FromCubicYardsPerDay(double cubicyardsperday)
    {
        var value = (double)cubicyardsperday;
        return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicYardsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicYardsPerHour->FromCubicYardPerHour")]
    public static VolumeFlow FromCubicYardsPerHour(double cubicyardsperhour)
    {
        var value = (double)cubicyardsperhour;
        return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicYardsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicYardsPerMinute->FromCubicYardPerMinute")]
    public static VolumeFlow FromCubicYardsPerMinute(double cubicyardsperminute)
    {
        var value = (double)cubicyardsperminute;
        return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from CubicYardsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCubicYardsPerSecond->FromCubicYardPerSecond")]
    public static VolumeFlow FromCubicYardsPerSecond(double cubicyardspersecond)
    {
        var value = (double)cubicyardspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.CubicYardPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from DecilitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecilitersPerDay->FromDeciliterPerDay")]
    public static VolumeFlow FromDecilitersPerDay(double decilitersperday)
    {
        var value = (double)decilitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from DecilitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecilitersPerMinute->FromDeciliterPerMinute")]
    public static VolumeFlow FromDecilitersPerMinute(double decilitersperminute)
    {
        var value = (double)decilitersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from DecilitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecilitersPerSecond->FromDeciliterPerSecond")]
    public static VolumeFlow FromDecilitersPerSecond(double deciliterspersecond)
    {
        var value = (double)deciliterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.DeciliterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from KilolitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilolitersPerDay->FromKiloliterPerDay")]
    public static VolumeFlow FromKilolitersPerDay(double kilolitersperday)
    {
        var value = (double)kilolitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from KilolitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilolitersPerMinute->FromKiloliterPerMinute")]
    public static VolumeFlow FromKilolitersPerMinute(double kilolitersperminute)
    {
        var value = (double)kilolitersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from KilolitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilolitersPerSecond->FromKiloliterPerSecond")]
    public static VolumeFlow FromKilolitersPerSecond(double kiloliterspersecond)
    {
        var value = (double)kiloliterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.KiloliterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from KilousGallonsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilousGallonsPerMinute->FromKilousGallonPerMinute")]
    public static VolumeFlow FromKilousGallonsPerMinute(double kilousgallonsperminute)
    {
        var value = (double)kilousgallonsperminute;
        return new VolumeFlow(value, VolumeFlowUnit.KilousGallonPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from LitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerDay->FromLiterPerDay")]
    public static VolumeFlow FromLitersPerDay(double litersperday)
    {
        var value = (double)litersperday;
        return new VolumeFlow(value, VolumeFlowUnit.LiterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from LitersPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerHour->FromLiterPerHour")]
    public static VolumeFlow FromLitersPerHour(double litersperhour)
    {
        var value = (double)litersperhour;
        return new VolumeFlow(value, VolumeFlowUnit.LiterPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from LitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerMinute->FromLiterPerMinute")]
    public static VolumeFlow FromLitersPerMinute(double litersperminute)
    {
        var value = (double)litersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.LiterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from LitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromLitersPerSecond->FromLiterPerSecond")]
    public static VolumeFlow FromLitersPerSecond(double literspersecond)
    {
        var value = (double)literspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.LiterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from MegalitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegalitersPerDay->FromMegaliterPerDay")]
    public static VolumeFlow FromMegalitersPerDay(double megalitersperday)
    {
        var value = (double)megalitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.MegaliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from MegaukGallonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegaukGallonsPerSecond->FromMegaukGallonPerSecond")]
    public static VolumeFlow FromMegaukGallonsPerSecond(double megaukgallonspersecond)
    {
        var value = (double)megaukgallonspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.MegaukGallonPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from MicrolitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrolitersPerDay->FromMicroliterPerDay")]
    public static VolumeFlow FromMicrolitersPerDay(double microlitersperday)
    {
        var value = (double)microlitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from MicrolitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrolitersPerMinute->FromMicroliterPerMinute")]
    public static VolumeFlow FromMicrolitersPerMinute(double microlitersperminute)
    {
        var value = (double)microlitersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from MicrolitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrolitersPerSecond->FromMicroliterPerSecond")]
    public static VolumeFlow FromMicrolitersPerSecond(double microliterspersecond)
    {
        var value = (double)microliterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.MicroliterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from MillilitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillilitersPerDay->FromMilliliterPerDay")]
    public static VolumeFlow FromMillilitersPerDay(double millilitersperday)
    {
        var value = (double)millilitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from MillilitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillilitersPerMinute->FromMilliliterPerMinute")]
    public static VolumeFlow FromMillilitersPerMinute(double millilitersperminute)
    {
        var value = (double)millilitersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from MillilitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillilitersPerSecond->FromMilliliterPerSecond")]
    public static VolumeFlow FromMillilitersPerSecond(double milliliterspersecond)
    {
        var value = (double)milliliterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.MilliliterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from MillionUsGallonsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static VolumeFlow FromMillionUsGallonsPerDay(double millionusgallonsperday)
    //{
    //    double value = (double)millionusgallonsperday;
    //    return new VolumeFlow(value, VolumeFlowUnit.MillionUsGallonsPerDay);
    //}
    /// <summary>
    ///     Get VolumeFlow from NanolitersPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanolitersPerDay->FromNanoliterPerDay")]
    public static VolumeFlow FromNanolitersPerDay(double nanolitersperday)
    {
        var value = (double)nanolitersperday;
        return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from NanolitersPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanolitersPerMinute->FromNanoliterPerMinute")]
    public static VolumeFlow FromNanolitersPerMinute(double nanolitersperminute)
    {
        var value = (double)nanolitersperminute;
        return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from NanolitersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanolitersPerSecond->FromNanoliterPerSecond")]
    public static VolumeFlow FromNanolitersPerSecond(double nanoliterspersecond)
    {
        var value = (double)nanoliterspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.NanoliterPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from OilBarrelsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOilBarrelsPerDay->FromOilBarrelPerDay")]
    public static VolumeFlow FromOilBarrelsPerDay(double oilbarrelsperday)
    {
        var value = (double)oilbarrelsperday;
        return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from OilBarrelsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOilBarrelsPerHour->FromOilBarrelPerHour")]
    public static VolumeFlow FromOilBarrelsPerHour(double oilbarrelsperhour)
    {
        var value = (double)oilbarrelsperhour;
        return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from OilBarrelsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOilBarrelsPerMinute->FromOilBarrelPerMinute")]
    public static VolumeFlow FromOilBarrelsPerMinute(double oilbarrelsperminute)
    {
        var value = (double)oilbarrelsperminute;
        return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from OilBarrelsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromOilBarrelsPerSecond->FromOilBarrelPerSecond")]
    public static VolumeFlow FromOilBarrelsPerSecond(double oilbarrelspersecond)
    {
        var value = (double)oilbarrelspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.OilBarrelPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from UkGallonsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUkGallonsPerDay->FromUkGallonPerDay")]
    public static VolumeFlow FromUkGallonsPerDay(double ukgallonsperday)
    {
        var value = (double)ukgallonsperday;
        return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from UkGallonsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUkGallonsPerHour->FromUkGallonPerHour")]
    public static VolumeFlow FromUkGallonsPerHour(double ukgallonsperhour)
    {
        var value = (double)ukgallonsperhour;
        return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from UkGallonsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUkGallonsPerMinute->FromUkGallonPerMinute")]
    public static VolumeFlow FromUkGallonsPerMinute(double ukgallonsperminute)
    {
        var value = (double)ukgallonsperminute;
        return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from UkGallonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUkGallonsPerSecond->FromUkGallonPerSecond")]
    public static VolumeFlow FromUkGallonsPerSecond(double ukgallonspersecond)
    {
        var value = (double)ukgallonspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.UkGallonPerSecond);
    }
    /// <summary>
    ///     Get VolumeFlow from UsGallonsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUsGallonsPerDay->FromUsGallonPerDay")]
    public static VolumeFlow FromUsGallonsPerDay(double usgallonsperday)
    {
        var value = (double)usgallonsperday;
        return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerDay);
    }
    /// <summary>
    ///     Get VolumeFlow from UsGallonsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUsGallonsPerHour->FromUsGallonPerHour")]
    public static VolumeFlow FromUsGallonsPerHour(double usgallonsperhour)
    {
        var value = (double)usgallonsperhour;
        return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerHour);
    }
    /// <summary>
    ///     Get VolumeFlow from UsGallonsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUsGallonsPerMinute->FromUsGallonPerMinute")]
    public static VolumeFlow FromUsGallonsPerMinute(double usgallonsperminute)
    {
        var value = (double)usgallonsperminute;
        return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerMinute);
    }
    /// <summary>
    ///     Get VolumeFlow from UsGallonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromUsGallonsPerSecond->FromUsGallonPerSecond")]
    public static VolumeFlow FromUsGallonsPerSecond(double usgallonspersecond)
    {
        var value = (double)usgallonspersecond;
        return new VolumeFlow(value, VolumeFlowUnit.UsGallonPerSecond);
    }
}

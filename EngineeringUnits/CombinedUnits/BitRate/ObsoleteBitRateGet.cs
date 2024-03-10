using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class BitRate
{
    /// <summary>
    ///     Get BitRate in BitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - BitsPerSecond->BitPerSecond")]
    public double BitsPerSecond => As(BitRateUnit.BitPerSecond);

    /// <summary>
    ///     Get BitRate in SI Unit (BitsPerSecond).
    /// </summary>
   // public double SI => As(BitRateUnit.SI);

    /// <summary>
    ///     Get BitRate in BytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - BytesPerSecond->BytePerSecond")]
    public double BytesPerSecond => As(BitRateUnit.BytePerSecond);

    /// <summary>
    ///     Get BitRate in ExabitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - ExabitsPerSecond->ExabitPerSecond")]
    public double ExabitsPerSecond => As(BitRateUnit.ExabitPerSecond);

    /// <summary>
    ///     Get BitRate in ExabytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - ExabytesPerSecond->ExabytePerSecond")]
    public double ExabytesPerSecond => As(BitRateUnit.ExabytePerSecond);

    /// <summary>
    ///     Get BitRate in ExbibitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - ExbibitsPerSecond->ExbibitPerSecond")]
    public double ExbibitsPerSecond => As(BitRateUnit.ExbibitPerSecond);

    /// <summary>
    ///     Get BitRate in ExbibytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - ExbibytesPerSecond->ExbibytePerSecond")]
    public double ExbibytesPerSecond => As(BitRateUnit.ExbibytePerSecond);

    /// <summary>
    ///     Get BitRate in GibibitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - GibibitsPerSecond->GibibitPerSecond")]
    public double GibibitsPerSecond => As(BitRateUnit.GibibitPerSecond);

    /// <summary>
    ///     Get BitRate in GibibytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - GibibytesPerSecond->GibibytePerSecond")]
    public double GibibytesPerSecond => As(BitRateUnit.GibibytePerSecond);

    /// <summary>
    ///     Get BitRate in GigabitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - GigabitsPerSecond->GigabitPerSecond")]
    public double GigabitsPerSecond => As(BitRateUnit.GigabitPerSecond);

    /// <summary>
    ///     Get BitRate in GigabytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - GigabytesPerSecond->GigabytePerSecond")]
    public double GigabytesPerSecond => As(BitRateUnit.GigabytePerSecond);

    /// <summary>
    ///     Get BitRate in KibibitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - KibibitsPerSecond->KibibitPerSecond")]
    public double KibibitsPerSecond => As(BitRateUnit.KibibitPerSecond);

    /// <summary>
    ///     Get BitRate in KibibytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - KibibytesPerSecond->KibibytePerSecond")]
    public double KibibytesPerSecond => As(BitRateUnit.KibibytePerSecond);

    /// <summary>
    ///     Get BitRate in KilobitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - KilobitsPerSecond->KilobitPerSecond")]
    public double KilobitsPerSecond => As(BitRateUnit.KilobitPerSecond);

    /// <summary>
    ///     Get BitRate in KilobytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - KilobytesPerSecond->KilobytePerSecond")]
    public double KilobytesPerSecond => As(BitRateUnit.KilobytePerSecond);

    /// <summary>
    ///     Get BitRate in MebibitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - MebibitsPerSecond->MebibitPerSecond")]
    public double MebibitsPerSecond => As(BitRateUnit.MebibitPerSecond);

    /// <summary>
    ///     Get BitRate in MebibytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - MebibytesPerSecond->MebibytePerSecond")]
    public double MebibytesPerSecond => As(BitRateUnit.MebibytePerSecond);

    /// <summary>
    ///     Get BitRate in MegabitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - MegabitsPerSecond->MegabitPerSecond")]
    public double MegabitsPerSecond => As(BitRateUnit.MegabitPerSecond);

    /// <summary>
    ///     Get BitRate in MegabytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - MegabytesPerSecond->MegabytePerSecond")]
    public double MegabytesPerSecond => As(BitRateUnit.MegabytePerSecond);

    /// <summary>
    ///     Get BitRate in PebibitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - PebibitsPerSecond->PebibitPerSecond")]
    public double PebibitsPerSecond => As(BitRateUnit.PebibitPerSecond);

    /// <summary>
    ///     Get BitRate in PebibytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - PebibytesPerSecond->PebibytePerSecond")]
    public double PebibytesPerSecond => As(BitRateUnit.PebibytePerSecond);

    /// <summary>
    ///     Get BitRate in PetabitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - PetabitsPerSecond->PetabitPerSecond")]
    public double PetabitsPerSecond => As(BitRateUnit.PetabitPerSecond);

    /// <summary>
    ///     Get BitRate in PetabytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - PetabytesPerSecond->PetabytePerSecond")]
    public double PetabytesPerSecond => As(BitRateUnit.PetabytePerSecond);

    /// <summary>
    ///     Get BitRate in TebibitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - TebibitsPerSecond->TebibitPerSecond")]
    public double TebibitsPerSecond => As(BitRateUnit.TebibitPerSecond);

    /// <summary>
    ///     Get BitRate in TebibytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - TebibytesPerSecond->TebibytePerSecond")]
    public double TebibytesPerSecond => As(BitRateUnit.TebibytePerSecond);

    /// <summary>
    ///     Get BitRate in TerabitsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - TerabitsPerSecond->TerabitPerSecond")]
    public double TerabitsPerSecond => As(BitRateUnit.TerabitPerSecond);

    /// <summary>
    ///     Get BitRate in TerabytesPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - TerabytesPerSecond->TerabytePerSecond")]
    public double TerabytesPerSecond => As(BitRateUnit.TerabytePerSecond);

}

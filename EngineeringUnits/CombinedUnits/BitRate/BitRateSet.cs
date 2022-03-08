
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class BitRate
    {

 

            /// <summary>
            ///     Get BitRate from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromSI(double SI)
            {
                double value= (double)SI;
                return new BitRate(value, BitRateUnit.SI);
            }
            /// <summary>
            ///     Get BitRate from BytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromBytePerSecond(double BytePerSecond)
            {
                double value= (double)BytePerSecond;
                return new BitRate(value, BitRateUnit.BytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from BitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromBitPerSecond(double BitPerSecond)
            {
                double value= (double)BitPerSecond;
                return new BitRate(value, BitRateUnit.BitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from KibibitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromKibibitPerSecond(double KibibitPerSecond)
            {
                double value= (double)KibibitPerSecond;
                return new BitRate(value, BitRateUnit.KibibitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from MebibitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromMebibitPerSecond(double MebibitPerSecond)
            {
                double value= (double)MebibitPerSecond;
                return new BitRate(value, BitRateUnit.MebibitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from GibibitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromGibibitPerSecond(double GibibitPerSecond)
            {
                double value= (double)GibibitPerSecond;
                return new BitRate(value, BitRateUnit.GibibitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from TebibitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromTebibitPerSecond(double TebibitPerSecond)
            {
                double value= (double)TebibitPerSecond;
                return new BitRate(value, BitRateUnit.TebibitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from PebibitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromPebibitPerSecond(double PebibitPerSecond)
            {
                double value= (double)PebibitPerSecond;
                return new BitRate(value, BitRateUnit.PebibitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from ExbibitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromExbibitPerSecond(double ExbibitPerSecond)
            {
                double value= (double)ExbibitPerSecond;
                return new BitRate(value, BitRateUnit.ExbibitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from KibibytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromKibibytePerSecond(double KibibytePerSecond)
            {
                double value= (double)KibibytePerSecond;
                return new BitRate(value, BitRateUnit.KibibytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from MebibytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromMebibytePerSecond(double MebibytePerSecond)
            {
                double value= (double)MebibytePerSecond;
                return new BitRate(value, BitRateUnit.MebibytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from GibibytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromGibibytePerSecond(double GibibytePerSecond)
            {
                double value= (double)GibibytePerSecond;
                return new BitRate(value, BitRateUnit.GibibytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from TebibytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromTebibytePerSecond(double TebibytePerSecond)
            {
                double value= (double)TebibytePerSecond;
                return new BitRate(value, BitRateUnit.TebibytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from PebibytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromPebibytePerSecond(double PebibytePerSecond)
            {
                double value= (double)PebibytePerSecond;
                return new BitRate(value, BitRateUnit.PebibytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from ExbibytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromExbibytePerSecond(double ExbibytePerSecond)
            {
                double value= (double)ExbibytePerSecond;
                return new BitRate(value, BitRateUnit.ExbibytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from KilobytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromKilobytePerSecond(double KilobytePerSecond)
            {
                double value= (double)KilobytePerSecond;
                return new BitRate(value, BitRateUnit.KilobytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from MegabytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromMegabytePerSecond(double MegabytePerSecond)
            {
                double value= (double)MegabytePerSecond;
                return new BitRate(value, BitRateUnit.MegabytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from GigabytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromGigabytePerSecond(double GigabytePerSecond)
            {
                double value= (double)GigabytePerSecond;
                return new BitRate(value, BitRateUnit.GigabytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from TerabytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromTerabytePerSecond(double TerabytePerSecond)
            {
                double value= (double)TerabytePerSecond;
                return new BitRate(value, BitRateUnit.TerabytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from PetabytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromPetabytePerSecond(double PetabytePerSecond)
            {
                double value= (double)PetabytePerSecond;
                return new BitRate(value, BitRateUnit.PetabytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from ExabytePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromExabytePerSecond(double ExabytePerSecond)
            {
                double value= (double)ExabytePerSecond;
                return new BitRate(value, BitRateUnit.ExabytePerSecond);
            }
            /// <summary>
            ///     Get BitRate from KilobitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromKilobitPerSecond(double KilobitPerSecond)
            {
                double value= (double)KilobitPerSecond;
                return new BitRate(value, BitRateUnit.KilobitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from MegabitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromMegabitPerSecond(double MegabitPerSecond)
            {
                double value= (double)MegabitPerSecond;
                return new BitRate(value, BitRateUnit.MegabitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from GigabitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromGigabitPerSecond(double GigabitPerSecond)
            {
                double value= (double)GigabitPerSecond;
                return new BitRate(value, BitRateUnit.GigabitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from TerabitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromTerabitPerSecond(double TerabitPerSecond)
            {
                double value= (double)TerabitPerSecond;
                return new BitRate(value, BitRateUnit.TerabitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from PetabitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromPetabitPerSecond(double PetabitPerSecond)
            {
                double value= (double)PetabitPerSecond;
                return new BitRate(value, BitRateUnit.PetabitPerSecond);
            }
            /// <summary>
            ///     Get BitRate from ExabitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BitRate FromExabitPerSecond(double ExabitPerSecond)
            {
                double value= (double)ExabitPerSecond;
                return new BitRate(value, BitRateUnit.ExabitPerSecond);
            }
    }
}



using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MassFlow
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromSI(double si)
        {
            double value = (double)si;
            return new MassFlow(value, MassFlowUnit.SI);
        }

        /// <summary>
        ///     Get MassFlow from CentigramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromCentigramsPerDay(double centigramsperday)
        {
            double value = (double)centigramsperday;
            return new MassFlow(value, MassFlowUnit.CentigramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from CentigramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromCentigramsPerSecond(double centigramspersecond)
        {
            double value = (double)centigramspersecond;
            return new MassFlow(value, MassFlowUnit.CentigramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from DecagramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecagramsPerDay(double decagramsperday)
        {
            double value = (double)decagramsperday;
            return new MassFlow(value, MassFlowUnit.DecagramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from DecagramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecagramsPerSecond(double decagramspersecond)
        {
            double value = (double)decagramspersecond;
            return new MassFlow(value, MassFlowUnit.DecagramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from DecigramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecigramsPerDay(double decigramsperday)
        {
            double value = (double)decigramsperday;
            return new MassFlow(value, MassFlowUnit.DecigramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from DecigramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecigramsPerSecond(double decigramspersecond)
        {
            double value = (double)decigramspersecond;
            return new MassFlow(value, MassFlowUnit.DecigramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from GramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromGramsPerDay(double gramsperday)
        {
            double value = (double)gramsperday;
            return new MassFlow(value, MassFlowUnit.GramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from GramsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromGramsPerHour(double gramsperhour)
        {
            double value = (double)gramsperhour;
            return new MassFlow(value, MassFlowUnit.GramPerHour);
        }
        /// <summary>
        ///     Get MassFlow from GramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromGramsPerSecond(double gramspersecond)
        {
            double value = (double)gramspersecond;
            return new MassFlow(value, MassFlowUnit.GramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from HectogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromHectogramsPerDay(double hectogramsperday)
        {
            double value = (double)hectogramsperday;
            return new MassFlow(value, MassFlowUnit.HectogramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from HectogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromHectogramsPerSecond(double hectogramspersecond)
        {
            double value = (double)hectogramspersecond;
            return new MassFlow(value, MassFlowUnit.HectogramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from KilogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerDay(double kilogramsperday)
        {
            double value = (double)kilogramsperday;
            return new MassFlow(value, MassFlowUnit.KilogramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from KilogramsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerHour(double kilogramsperhour)
        {
            double value = (double)kilogramsperhour;
            return new MassFlow(value, MassFlowUnit.KilogramPerHour);
        }
        /// <summary>
        ///     Get MassFlow from KilogramsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerMinute(double kilogramsperminute)
        {
            double value = (double)kilogramsperminute;
            return new MassFlow(value, MassFlowUnit.KilogramPerMinute);
        }
        /// <summary>
        ///     Get MassFlow from KilogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerSecond(double kilogramspersecond)
        {
            double value = (double)kilogramspersecond;
            return new MassFlow(value, MassFlowUnit.KilogramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from MegagramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegagramsPerDay(double megagramsperday)
        {
            double value = (double)megagramsperday;
            return new MassFlow(value, MassFlowUnit.MegagramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from MegapoundsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerDay(double megapoundsperday)
        {
            double value = (double)megapoundsperday;
            return new MassFlow(value, MassFlowUnit.MegapoundPerDay);
        }
        /// <summary>
        ///     Get MassFlow from MegapoundsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerHour(double megapoundsperhour)
        {
            double value = (double)megapoundsperhour;
            return new MassFlow(value, MassFlowUnit.MegapoundPerHour);
        }
        /// <summary>
        ///     Get MassFlow from MegapoundsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerMinute(double megapoundsperminute)
        {
            double value = (double)megapoundsperminute;
            return new MassFlow(value, MassFlowUnit.MegapoundPerMinute);
        }
        /// <summary>
        ///     Get MassFlow from MegapoundsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerSecond(double megapoundspersecond)
        {
            double value = (double)megapoundspersecond;
            return new MassFlow(value, MassFlowUnit.MegapoundPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from MicrogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMicrogramsPerDay(double microgramsperday)
        {
            double value = (double)microgramsperday;
            return new MassFlow(value, MassFlowUnit.MicrogramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from MicrogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMicrogramsPerSecond(double microgramspersecond)
        {
            double value = (double)microgramspersecond;
            return new MassFlow(value, MassFlowUnit.MicrogramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from MilligramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMilligramsPerDay(double milligramsperday)
        {
            double value = (double)milligramsperday;
            return new MassFlow(value, MassFlowUnit.MilligramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from MilligramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMilligramsPerSecond(double milligramspersecond)
        {
            double value = (double)milligramspersecond;
            return new MassFlow(value, MassFlowUnit.MilligramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from NanogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromNanogramsPerDay(double nanogramsperday)
        {
            double value = (double)nanogramsperday;
            return new MassFlow(value, MassFlowUnit.NanogramPerDay);
        }
        /// <summary>
        ///     Get MassFlow from NanogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromNanogramsPerSecond(double nanogramspersecond)
        {
            double value = (double)nanogramspersecond;
            return new MassFlow(value, MassFlowUnit.NanogramPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from PoundsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerDay(double poundsperday)
        {
            double value = (double)poundsperday;
            return new MassFlow(value, MassFlowUnit.PoundPerDay);
        }
        /// <summary>
        ///     Get MassFlow from PoundsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerHour(double poundsperhour)
        {
            double value = (double)poundsperhour;
            return new MassFlow(value, MassFlowUnit.PoundPerHour);
        }
        /// <summary>
        ///     Get MassFlow from PoundsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerMinute(double poundsperminute)
        {
            double value = (double)poundsperminute;
            return new MassFlow(value, MassFlowUnit.PoundPerMinute);
        }
        /// <summary>
        ///     Get MassFlow from PoundsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerSecond(double poundspersecond)
        {
            double value = (double)poundspersecond;
            return new MassFlow(value, MassFlowUnit.PoundPerSecond);
        }
        /// <summary>
        ///     Get MassFlow from ShortTonsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromShortTonsPerHour(double shorttonsperhour)
        {
            double value = (double)shorttonsperhour;
            return new MassFlow(value, MassFlowUnit.ShortTonPerHour);
        }
        /// <summary>
        ///     Get MassFlow from TonnesPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromTonnesPerDay(double tonnesperday)
        {
            double value = (double)tonnesperday;
            return new MassFlow(value, MassFlowUnit.TonnePerDay);
        }
        /// <summary>
        ///     Get MassFlow from TonnesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromTonnesPerHour(double tonnesperhour)
        {
            double value = (double)tonnesperhour;
            return new MassFlow(value, MassFlowUnit.TonnePerHour);
        }


    }
}

using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Molarity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromSI(double si)
        {
            double value = (double)si;
            return new Molarity(value, MolarityUnit.SI);
        }

        /// <summary>
        ///     Get Molarity from CentimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromCentimolesPerLiter(double centimolesperliter)
        {
            double value = (double)centimolesperliter;
            return new Molarity(value, MolarityUnit.CentimolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from DecimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromDecimolesPerLiter(double decimolesperliter)
        {
            double value = (double)decimolesperliter;
            return new Molarity(value, MolarityUnit.DecimolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from MicromolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMicromolesPerLiter(double micromolesperliter)
        {
            double value = (double)micromolesperliter;
            return new Molarity(value, MolarityUnit.MicromolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from MillimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMillimolesPerLiter(double millimolesperliter)
        {
            double value = (double)millimolesperliter;
            return new Molarity(value, MolarityUnit.MillimolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from MolesPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMolesPerCubicMeter(double molespercubicmeter)
        {
            double value = (double)molespercubicmeter;
            return new Molarity(value, MolarityUnit.MolesPerCubicMeter);
        }
        /// <summary>
        ///     Get Molarity from MolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMolesPerLiter(double molesperliter)
        {
            double value = (double)molesperliter;
            return new Molarity(value, MolarityUnit.MolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from NanomolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromNanomolesPerLiter(double nanomolesperliter)
        {
            double value = (double)nanomolesperliter;
            return new Molarity(value, MolarityUnit.NanomolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from PicomolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromPicomolesPerLiter(double picomolesperliter)
        {
            double value = (double)picomolesperliter;
            return new Molarity(value, MolarityUnit.PicomolesPerLiter);
        }
    }
}

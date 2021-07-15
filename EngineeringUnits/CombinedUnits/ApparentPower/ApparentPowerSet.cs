using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ApparentPower
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromSI(double si)
        {
            double value = (double)si;
            return new ApparentPower(value, ApparentPowerUnit.SI);
        }

        /// <summary>
        ///     Get ApparentPower from Gigavoltamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromGigavoltamperes(double gigavoltamperes)
        {
            double value = (double)gigavoltamperes;
            return new ApparentPower(value, ApparentPowerUnit.Gigavoltampere);
        }
        /// <summary>
        ///     Get ApparentPower from Kilovoltamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromKilovoltamperes(double kilovoltamperes)
        {
            double value = (double)kilovoltamperes;
            return new ApparentPower(value, ApparentPowerUnit.Kilovoltampere);
        }
        /// <summary>
        ///     Get ApparentPower from Megavoltamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromMegavoltamperes(double megavoltamperes)
        {
            double value = (double)megavoltamperes;
            return new ApparentPower(value, ApparentPowerUnit.Megavoltampere);
        }
        /// <summary>
        ///     Get ApparentPower from Voltamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromVoltamperes(double voltamperes)
        {
            double value = (double)voltamperes;
            return new ApparentPower(value, ApparentPowerUnit.Voltampere);
        }

    }
}

using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ReactivePower
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ReactivePower FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ReactivePower(value, ReactivePowerUnit.SI);
        //}

        /// <summary>
        ///     Get ReactivePower from GigavoltamperesReactive.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigavoltamperesReactive->FromGigavoltampereReactive")]
        public static ReactivePower FromGigavoltamperesReactive(double gigavoltamperesreactive)
        {
            double value = (double)gigavoltamperesreactive;
            return new ReactivePower(value, ReactivePowerUnit.GigavoltampereReactive);
        }
        /// <summary>
        ///     Get ReactivePower from KilovoltamperesReactive.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilovoltamperesReactive->FromKilovoltampereReactive")]
        public static ReactivePower FromKilovoltamperesReactive(double kilovoltamperesreactive)
        {
            double value = (double)kilovoltamperesreactive;
            return new ReactivePower(value, ReactivePowerUnit.KilovoltampereReactive);
        }
        /// <summary>
        ///     Get ReactivePower from MegavoltamperesReactive.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegavoltamperesReactive->FromMegavoltampereReactive")]
        public static ReactivePower FromMegavoltamperesReactive(double megavoltamperesreactive)
        {
            double value = (double)megavoltamperesreactive;
            return new ReactivePower(value, ReactivePowerUnit.MegavoltampereReactive);
        }
        /// <summary>
        ///     Get ReactivePower from VoltamperesReactive.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromVoltamperesReactive->FromVoltampereReactive")]
        public static ReactivePower FromVoltamperesReactive(double voltamperesreactive)
        {
            double value = (double)voltamperesreactive;
            return new ReactivePower(value, ReactivePowerUnit.VoltampereReactive);
        }

    }
}

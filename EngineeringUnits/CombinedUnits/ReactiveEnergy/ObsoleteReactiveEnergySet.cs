using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ReactiveEnergy
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ReactiveEnergy FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ReactiveEnergy(value, ReactiveEnergyUnit.SI);
        //}

        /// <summary>
        ///     Get ReactiveEnergy from KilovoltampereReactiveHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilovoltampereReactiveHours->FromKilovoltampereReactiveHour")]
        public static ReactiveEnergy FromKilovoltampereReactiveHours(double kilovoltamperereactivehours)
        {
            double value = (double)kilovoltamperereactivehours;
            return new ReactiveEnergy(value, ReactiveEnergyUnit.KilovoltampereReactiveHour);
        }
        /// <summary>
        ///     Get ReactiveEnergy from MegavoltampereReactiveHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegavoltampereReactiveHours->FromMegavoltampereReactiveHour")]
        public static ReactiveEnergy FromMegavoltampereReactiveHours(double megavoltamperereactivehours)
        {
            double value = (double)megavoltamperereactivehours;
            return new ReactiveEnergy(value, ReactiveEnergyUnit.MegavoltampereReactiveHour);
        }
        /// <summary>
        ///     Get ReactiveEnergy from VoltampereReactiveHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromVoltampereReactiveHours->FromVoltampereReactiveHour")]
        public static ReactiveEnergy FromVoltampereReactiveHours(double voltamperereactivehours)
        {
            double value = (double)voltamperereactivehours;
            return new ReactiveEnergy(value, ReactiveEnergyUnit.VoltampereReactiveHour);
        }

    }
}

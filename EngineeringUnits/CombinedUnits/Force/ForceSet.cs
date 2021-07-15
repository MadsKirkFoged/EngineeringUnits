using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Force
    {
        /// <summary>
        ///     Get Force from Decanewtons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromDecanewtons(double decanewtons)
        {
            double value = (double)decanewtons;
            return new Force(value, ForceUnit.Decanewton);
        }
        /// <summary>
        ///     Get Force from Dyne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromDyne(double dyne)
        {
            double value = (double)dyne;
            return new Force(value, ForceUnit.Dyn);
        }
        /// <summary>
        ///     Get Force from KilogramsForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromKilogramsForce(double kilogramsforce)
        {
            double value = (double)kilogramsforce;
            return new Force(value, ForceUnit.KilogramForce);
        }
        /// <summary>
        ///     Get Force from Kilonewtons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromKilonewtons(double kilonewtons)
        {
            double value = (double)kilonewtons;
            return new Force(value, ForceUnit.Kilonewton);
        }
        /// <summary>
        ///     Get Force from KiloPonds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromKiloPonds(double kiloponds)
        {
            double value = (double)kiloponds;
            return new Force(value, ForceUnit.KiloPond);
        }
        /// <summary>
        ///     Get Force from KilopoundsForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromKilopoundsForce(double kilopoundsforce)
        {
            double value = (double)kilopoundsforce;
            return new Force(value, ForceUnit.KilopoundForce);
        }
        /// <summary>
        ///     Get Force from Meganewtons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromMeganewtons(double meganewtons)
        {
            double value = (double)meganewtons;
            return new Force(value, ForceUnit.Meganewton);
        }
        /// <summary>
        ///     Get Force from Micronewtons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromMicronewtons(double micronewtons)
        {
            double value = (double)micronewtons;
            return new Force(value, ForceUnit.Micronewton);
        }
        /// <summary>
        ///     Get Force from Millinewtons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromMillinewtons(double millinewtons)
        {
            double value = (double)millinewtons;
            return new Force(value, ForceUnit.Millinewton);
        }
        /// <summary>
        ///     Get Force from Newtons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromNewtons(double newtons)
        {
            double value = (double)newtons;
            return new Force(value, ForceUnit.Newton);
        }
        /// <summary>
        ///     Get Force from OunceForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromOunceForce(double ounceforce)
        {
            double value = (double)ounceforce;
            return new Force(value, ForceUnit.OunceForce);
        }
        /// <summary>
        ///     Get Force from Poundals.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromPoundals(double poundals)
        {
            double value = (double)poundals;
            return new Force(value, ForceUnit.Poundal);
        }
        /// <summary>
        ///     Get Force from PoundsForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromPoundsForce(double poundsforce)
        {
            double value = (double)poundsforce;
            return new Force(value, ForceUnit.PoundForce);
        }
        /// <summary>
        ///     Get Force from ShortTonsForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromShortTonsForce(double shorttonsforce)
        {
            double value = (double)shorttonsforce;
            return new Force(value, ForceUnit.ShortTonForce);
        }
        /// <summary>
        ///     Get Force from TonnesForce.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Force FromTonnesForce(double tonnesforce)
        {
            double value = (double)tonnesforce;
            return new Force(value, ForceUnit.TonneForce);
        }

    }
}

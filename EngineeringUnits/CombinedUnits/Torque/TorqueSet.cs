using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Torque
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromSI(double si)
        {
            double value = (double)si;
            return new Torque(value, TorqueUnit.SI);
        }

        /// <summary>
        ///     Get Torque from KilogramForceCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceCentimeters(double kilogramforcecentimeters)
        {
            double value = (double)kilogramforcecentimeters;
            return new Torque(value, TorqueUnit.KilogramForceCentimeter);
        }
        /// <summary>
        ///     Get Torque from KilogramForceMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceMeters(double kilogramforcemeters)
        {
            double value = (double)kilogramforcemeters;
            return new Torque(value, TorqueUnit.KilogramForceMeter);
        }
        /// <summary>
        ///     Get Torque from KilogramForceMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceMillimeters(double kilogramforcemillimeters)
        {
            double value = (double)kilogramforcemillimeters;
            return new Torque(value, TorqueUnit.KilogramForceMillimeter);
        }
        /// <summary>
        ///     Get Torque from KilonewtonCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonCentimeters(double kilonewtoncentimeters)
        {
            double value = (double)kilonewtoncentimeters;
            return new Torque(value, TorqueUnit.KilonewtonCentimeter);
        }
        /// <summary>
        ///     Get Torque from KilonewtonMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonMeters(double kilonewtonmeters)
        {
            double value = (double)kilonewtonmeters;
            return new Torque(value, TorqueUnit.KilonewtonMeter);
        }
        /// <summary>
        ///     Get Torque from KilonewtonMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonMillimeters(double kilonewtonmillimeters)
        {
            double value = (double)kilonewtonmillimeters;
            return new Torque(value, TorqueUnit.KilonewtonMillimeter);
        }
        /// <summary>
        ///     Get Torque from KilopoundForceFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilopoundForceFeet(double kilopoundforcefeet)
        {
            double value = (double)kilopoundforcefeet;
            return new Torque(value, TorqueUnit.KilopoundForceFoot);
        }
        /// <summary>
        ///     Get Torque from KilopoundForceInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilopoundForceInches(double kilopoundforceinches)
        {
            double value = (double)kilopoundforceinches;
            return new Torque(value, TorqueUnit.KilopoundForceInch);
        }
        /// <summary>
        ///     Get Torque from MeganewtonCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonCentimeters(double meganewtoncentimeters)
        {
            double value = (double)meganewtoncentimeters;
            return new Torque(value, TorqueUnit.MeganewtonCentimeter);
        }
        /// <summary>
        ///     Get Torque from MeganewtonMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonMeters(double meganewtonmeters)
        {
            double value = (double)meganewtonmeters;
            return new Torque(value, TorqueUnit.MeganewtonMeter);
        }
        /// <summary>
        ///     Get Torque from MeganewtonMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonMillimeters(double meganewtonmillimeters)
        {
            double value = (double)meganewtonmillimeters;
            return new Torque(value, TorqueUnit.MeganewtonMillimeter);
        }
        /// <summary>
        ///     Get Torque from MegapoundForceFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMegapoundForceFeet(double megapoundforcefeet)
        {
            double value = (double)megapoundforcefeet;
            return new Torque(value, TorqueUnit.MegapoundForceFoot);
        }
        /// <summary>
        ///     Get Torque from MegapoundForceInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMegapoundForceInches(double megapoundforceinches)
        {
            double value = (double)megapoundforceinches;
            return new Torque(value, TorqueUnit.MegapoundForceInch);
        }
        /// <summary>
        ///     Get Torque from NewtonCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonCentimeters(double newtoncentimeters)
        {
            double value = (double)newtoncentimeters;
            return new Torque(value, TorqueUnit.NewtonCentimeter);
        }
        /// <summary>
        ///     Get Torque from NewtonMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonMeters(double newtonmeters)
        {
            double value = (double)newtonmeters;
            return new Torque(value, TorqueUnit.NewtonMeter);
        }
        /// <summary>
        ///     Get Torque from NewtonMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonMillimeters(double newtonmillimeters)
        {
            double value = (double)newtonmillimeters;
            return new Torque(value, TorqueUnit.NewtonMillimeter);
        }
        /// <summary>
        ///     Get Torque from PoundalFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundalFeet(double poundalfeet)
        {
            double value = (double)poundalfeet;
            return new Torque(value, TorqueUnit.PoundalFoot);
        }
        /// <summary>
        ///     Get Torque from PoundForceFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundForceFeet(double poundforcefeet)
        {
            double value = (double)poundforcefeet;
            return new Torque(value, TorqueUnit.PoundForceFoot);
        }
        /// <summary>
        ///     Get Torque from PoundForceInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundForceInches(double poundforceinches)
        {
            double value = (double)poundforceinches;
            return new Torque(value, TorqueUnit.PoundForceInch);
        }
        /// <summary>
        ///     Get Torque from TonneForceCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceCentimeters(double tonneforcecentimeters)
        {
            double value = (double)tonneforcecentimeters;
            return new Torque(value, TorqueUnit.TonneForceCentimeter);
        }
        /// <summary>
        ///     Get Torque from TonneForceMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceMeters(double tonneforcemeters)
        {
            double value = (double)tonneforcemeters;
            return new Torque(value, TorqueUnit.TonneForceMeter);
        }
        /// <summary>
        ///     Get Torque from TonneForceMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceMillimeters(double tonneforcemillimeters)
        {
            double value = (double)tonneforcemillimeters;
            return new Torque(value, TorqueUnit.TonneForceMillimeter);
        }

    }
}

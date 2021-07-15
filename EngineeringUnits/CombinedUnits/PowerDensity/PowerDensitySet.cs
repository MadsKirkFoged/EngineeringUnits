using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class PowerDensity
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromSI(double si)
        {
            double value = (double)si;
            return new PowerDensity(value, PowerDensityUnit.SI);
        }

        /// <summary>
        ///     Get PowerDensity from DecawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerCubicFoot(double decawattspercubicfoot)
        {
            double value = (double)decawattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from DecawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerCubicInch(double decawattspercubicinch)
        {
            double value = (double)decawattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from DecawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerCubicMeter(double decawattspercubicmeter)
        {
            double value = (double)decawattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from DecawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerLiter(double decawattsperliter)
        {
            double value = (double)decawattsperliter;
            return new PowerDensity(value, PowerDensityUnit.DecawattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from DeciwattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerCubicFoot(double deciwattspercubicfoot)
        {
            double value = (double)deciwattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from DeciwattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerCubicInch(double deciwattspercubicinch)
        {
            double value = (double)deciwattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from DeciwattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerCubicMeter(double deciwattspercubicmeter)
        {
            double value = (double)deciwattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from DeciwattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerLiter(double deciwattsperliter)
        {
            double value = (double)deciwattsperliter;
            return new PowerDensity(value, PowerDensityUnit.DeciwattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from GigawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerCubicFoot(double gigawattspercubicfoot)
        {
            double value = (double)gigawattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from GigawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerCubicInch(double gigawattspercubicinch)
        {
            double value = (double)gigawattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from GigawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerCubicMeter(double gigawattspercubicmeter)
        {
            double value = (double)gigawattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from GigawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerLiter(double gigawattsperliter)
        {
            double value = (double)gigawattsperliter;
            return new PowerDensity(value, PowerDensityUnit.GigawattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from KilowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerCubicFoot(double kilowattspercubicfoot)
        {
            double value = (double)kilowattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from KilowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerCubicInch(double kilowattspercubicinch)
        {
            double value = (double)kilowattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from KilowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerCubicMeter(double kilowattspercubicmeter)
        {
            double value = (double)kilowattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from KilowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerLiter(double kilowattsperliter)
        {
            double value = (double)kilowattsperliter;
            return new PowerDensity(value, PowerDensityUnit.KilowattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from MegawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerCubicFoot(double megawattspercubicfoot)
        {
            double value = (double)megawattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from MegawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerCubicInch(double megawattspercubicinch)
        {
            double value = (double)megawattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from MegawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerCubicMeter(double megawattspercubicmeter)
        {
            double value = (double)megawattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from MegawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerLiter(double megawattsperliter)
        {
            double value = (double)megawattsperliter;
            return new PowerDensity(value, PowerDensityUnit.MegawattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from MicrowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerCubicFoot(double microwattspercubicfoot)
        {
            double value = (double)microwattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from MicrowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerCubicInch(double microwattspercubicinch)
        {
            double value = (double)microwattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from MicrowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerCubicMeter(double microwattspercubicmeter)
        {
            double value = (double)microwattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from MicrowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerLiter(double microwattsperliter)
        {
            double value = (double)microwattsperliter;
            return new PowerDensity(value, PowerDensityUnit.MicrowattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from MilliwattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerCubicFoot(double milliwattspercubicfoot)
        {
            double value = (double)milliwattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from MilliwattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerCubicInch(double milliwattspercubicinch)
        {
            double value = (double)milliwattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from MilliwattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerCubicMeter(double milliwattspercubicmeter)
        {
            double value = (double)milliwattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from MilliwattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerLiter(double milliwattsperliter)
        {
            double value = (double)milliwattsperliter;
            return new PowerDensity(value, PowerDensityUnit.MilliwattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from NanowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerCubicFoot(double nanowattspercubicfoot)
        {
            double value = (double)nanowattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from NanowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerCubicInch(double nanowattspercubicinch)
        {
            double value = (double)nanowattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from NanowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerCubicMeter(double nanowattspercubicmeter)
        {
            double value = (double)nanowattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from NanowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerLiter(double nanowattsperliter)
        {
            double value = (double)nanowattsperliter;
            return new PowerDensity(value, PowerDensityUnit.NanowattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from PicowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerCubicFoot(double picowattspercubicfoot)
        {
            double value = (double)picowattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from PicowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerCubicInch(double picowattspercubicinch)
        {
            double value = (double)picowattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from PicowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerCubicMeter(double picowattspercubicmeter)
        {
            double value = (double)picowattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from PicowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerLiter(double picowattsperliter)
        {
            double value = (double)picowattsperliter;
            return new PowerDensity(value, PowerDensityUnit.PicowattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from TerawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerCubicFoot(double terawattspercubicfoot)
        {
            double value = (double)terawattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from TerawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerCubicInch(double terawattspercubicinch)
        {
            double value = (double)terawattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from TerawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerCubicMeter(double terawattspercubicmeter)
        {
            double value = (double)terawattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from TerawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerLiter(double terawattsperliter)
        {
            double value = (double)terawattsperliter;
            return new PowerDensity(value, PowerDensityUnit.TerawattPerLiter);
        }
        /// <summary>
        ///     Get PowerDensity from WattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerCubicFoot(double wattspercubicfoot)
        {
            double value = (double)wattspercubicfoot;
            return new PowerDensity(value, PowerDensityUnit.WattPerCubicFoot);
        }
        /// <summary>
        ///     Get PowerDensity from WattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerCubicInch(double wattspercubicinch)
        {
            double value = (double)wattspercubicinch;
            return new PowerDensity(value, PowerDensityUnit.WattPerCubicInch);
        }
        /// <summary>
        ///     Get PowerDensity from WattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerCubicMeter(double wattspercubicmeter)
        {
            double value = (double)wattspercubicmeter;
            return new PowerDensity(value, PowerDensityUnit.WattPerCubicMeter);
        }
        /// <summary>
        ///     Get PowerDensity from WattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerLiter(double wattsperliter)
        {
            double value = (double)wattsperliter;
            return new PowerDensity(value, PowerDensityUnit.WattPerLiter);
        }

    }
}

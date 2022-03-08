
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class PowerDensity
    {

 

            /// <summary>
            ///     Get PowerDensity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromSI(double SI)
            {
                double value= (double)SI;
                return new PowerDensity(value, PowerDensityUnit.SI);
            }
            /// <summary>
            ///     Get PowerDensity from WattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromWattPerCubicMeter(double WattPerCubicMeter)
            {
                double value= (double)WattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.WattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from WattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromWattPerLiter(double WattPerLiter)
            {
                double value= (double)WattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.WattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from WattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromWattPerCubicInch(double WattPerCubicInch)
            {
                double value= (double)WattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.WattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from WattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromWattPerCubicFoot(double WattPerCubicFoot)
            {
                double value= (double)WattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.WattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from TerawattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromTerawattPerLiter(double TerawattPerLiter)
            {
                double value= (double)TerawattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.TerawattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from TerawattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromTerawattPerCubicMeter(double TerawattPerCubicMeter)
            {
                double value= (double)TerawattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from TerawattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromTerawattPerCubicInch(double TerawattPerCubicInch)
            {
                double value= (double)TerawattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from TerawattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromTerawattPerCubicFoot(double TerawattPerCubicFoot)
            {
                double value= (double)TerawattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.TerawattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from PicowattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromPicowattPerLiter(double PicowattPerLiter)
            {
                double value= (double)PicowattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.PicowattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from PicowattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromPicowattPerCubicMeter(double PicowattPerCubicMeter)
            {
                double value= (double)PicowattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from PicowattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromPicowattPerCubicInch(double PicowattPerCubicInch)
            {
                double value= (double)PicowattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from PicowattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromPicowattPerCubicFoot(double PicowattPerCubicFoot)
            {
                double value= (double)PicowattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.PicowattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from NanowattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromNanowattPerLiter(double NanowattPerLiter)
            {
                double value= (double)NanowattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.NanowattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from NanowattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromNanowattPerCubicMeter(double NanowattPerCubicMeter)
            {
                double value= (double)NanowattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from NanowattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromNanowattPerCubicInch(double NanowattPerCubicInch)
            {
                double value= (double)NanowattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from NanowattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromNanowattPerCubicFoot(double NanowattPerCubicFoot)
            {
                double value= (double)NanowattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.NanowattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from MilliwattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMilliwattPerLiter(double MilliwattPerLiter)
            {
                double value= (double)MilliwattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.MilliwattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from MilliwattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMilliwattPerCubicMeter(double MilliwattPerCubicMeter)
            {
                double value= (double)MilliwattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from MilliwattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMilliwattPerCubicInch(double MilliwattPerCubicInch)
            {
                double value= (double)MilliwattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from MilliwattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMilliwattPerCubicFoot(double MilliwattPerCubicFoot)
            {
                double value= (double)MilliwattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.MilliwattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from MicrowattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMicrowattPerLiter(double MicrowattPerLiter)
            {
                double value= (double)MicrowattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.MicrowattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from MicrowattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMicrowattPerCubicMeter(double MicrowattPerCubicMeter)
            {
                double value= (double)MicrowattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from MicrowattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMicrowattPerCubicInch(double MicrowattPerCubicInch)
            {
                double value= (double)MicrowattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from MicrowattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMicrowattPerCubicFoot(double MicrowattPerCubicFoot)
            {
                double value= (double)MicrowattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.MicrowattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from MegawattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMegawattPerLiter(double MegawattPerLiter)
            {
                double value= (double)MegawattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.MegawattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from MegawattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMegawattPerCubicMeter(double MegawattPerCubicMeter)
            {
                double value= (double)MegawattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from MegawattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMegawattPerCubicInch(double MegawattPerCubicInch)
            {
                double value= (double)MegawattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from MegawattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromMegawattPerCubicFoot(double MegawattPerCubicFoot)
            {
                double value= (double)MegawattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.MegawattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from KilowattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromKilowattPerLiter(double KilowattPerLiter)
            {
                double value= (double)KilowattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.KilowattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from KilowattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromKilowattPerCubicMeter(double KilowattPerCubicMeter)
            {
                double value= (double)KilowattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from KilowattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromKilowattPerCubicInch(double KilowattPerCubicInch)
            {
                double value= (double)KilowattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from KilowattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromKilowattPerCubicFoot(double KilowattPerCubicFoot)
            {
                double value= (double)KilowattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.KilowattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from GigawattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromGigawattPerLiter(double GigawattPerLiter)
            {
                double value= (double)GigawattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.GigawattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from GigawattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromGigawattPerCubicMeter(double GigawattPerCubicMeter)
            {
                double value= (double)GigawattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from GigawattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromGigawattPerCubicInch(double GigawattPerCubicInch)
            {
                double value= (double)GigawattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from GigawattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromGigawattPerCubicFoot(double GigawattPerCubicFoot)
            {
                double value= (double)GigawattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.GigawattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from DeciwattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDeciwattPerLiter(double DeciwattPerLiter)
            {
                double value= (double)DeciwattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.DeciwattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from DeciwattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDeciwattPerCubicMeter(double DeciwattPerCubicMeter)
            {
                double value= (double)DeciwattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from DeciwattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDeciwattPerCubicInch(double DeciwattPerCubicInch)
            {
                double value= (double)DeciwattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from DeciwattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDeciwattPerCubicFoot(double DeciwattPerCubicFoot)
            {
                double value= (double)DeciwattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.DeciwattPerCubicFoot);
            }
            /// <summary>
            ///     Get PowerDensity from DecawattPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDecawattPerLiter(double DecawattPerLiter)
            {
                double value= (double)DecawattPerLiter;
                return new PowerDensity(value, PowerDensityUnit.DecawattPerLiter);
            }
            /// <summary>
            ///     Get PowerDensity from DecawattPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDecawattPerCubicMeter(double DecawattPerCubicMeter)
            {
                double value= (double)DecawattPerCubicMeter;
                return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicMeter);
            }
            /// <summary>
            ///     Get PowerDensity from DecawattPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDecawattPerCubicInch(double DecawattPerCubicInch)
            {
                double value= (double)DecawattPerCubicInch;
                return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicInch);
            }
            /// <summary>
            ///     Get PowerDensity from DecawattPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static PowerDensity FromDecawattPerCubicFoot(double DecawattPerCubicFoot)
            {
                double value= (double)DecawattPerCubicFoot;
                return new PowerDensity(value, PowerDensityUnit.DecawattPerCubicFoot);
            }
    }
}



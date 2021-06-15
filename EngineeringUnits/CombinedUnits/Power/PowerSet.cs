using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Power
    {
        /// <summary>
        ///     Get Power from BoilerHorsepower.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromBoilerHorsepower(double boilerhorsepower)
        {
            decimal value = (decimal)boilerhorsepower;
            return new Power(value, PowerUnit.BoilerHorsepower);
        }
        /// <summary>
        ///     Get Power from BritishThermalUnitsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromBritishThermalUnitsPerHour(double britishthermalunitsperhour)
        {
            decimal value = (decimal)britishthermalunitsperhour;
            return new Power(value, PowerUnit.BritishThermalUnitPerHour);
        }
        /// <summary>
        ///     Get Power from Decawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromDecawatts(double decawatts)
        {
            decimal value = (decimal)decawatts;
            return new Power(value, PowerUnit.Decawatt);
        }
        /// <summary>
        ///     Get Power from Deciwatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromDeciwatts(double deciwatts)
        {
            decimal value = (decimal)deciwatts;
            return new Power(value, PowerUnit.Deciwatt);
        }
        /// <summary>
        ///     Get Power from ElectricalHorsepower.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromElectricalHorsepower(double electricalhorsepower)
        {
            decimal value = (decimal)electricalhorsepower;
            return new Power(value, PowerUnit.ElectricalHorsepower);
        }
        /// <summary>
        ///     Get Power from Femtowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromFemtowatts(double femtowatts)
        {
            decimal value = (decimal)femtowatts;
            return new Power(value, PowerUnit.Femtowatt);
        }
        /// <summary>
        ///     Get Power from GigajoulesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromGigajoulesPerHour(double gigajoulesperhour)
        {
            decimal value = (decimal)gigajoulesperhour;
            return new Power(value, PowerUnit.GigajoulePerHour);
        }
        /// <summary>
        ///     Get Power from Gigawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromGigawatts(double gigawatts)
        {
            decimal value = (decimal)gigawatts;
            return new Power(value, PowerUnit.Gigawatt);
        }
        /// <summary>
        ///     Get Power from HydraulicHorsepower.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromHydraulicHorsepower(double hydraulichorsepower)
        {
            decimal value = (decimal)hydraulichorsepower;
            return new Power(value, PowerUnit.HydraulicHorsepower);
        }
        /// <summary>
        ///     Get Power from JoulesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromJoulesPerHour(double joulesperhour)
        {
            decimal value = (decimal)joulesperhour;
            return new Power(value, PowerUnit.JoulePerHour);
        }
        /// <summary>
        ///     Get Power from KilobritishThermalUnitsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromKilobritishThermalUnitsPerHour(double kilobritishthermalunitsperhour)
        {
            decimal value = (decimal)kilobritishthermalunitsperhour;
            return new Power(value, PowerUnit.KilobritishThermalUnitPerHour);
        }
        /// <summary>
        ///     Get Power from KilojoulesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromKilojoulesPerHour(double kilojoulesperhour)
        {
            decimal value = (decimal)kilojoulesperhour;
            return new Power(value, PowerUnit.KilojoulePerHour);
        }
        /// <summary>
        ///     Get Power from Kilowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromKilowatts(double kilowatts)
        {
            decimal value = (decimal)kilowatts;
            return new Power(value, PowerUnit.Kilowatt);
        }
        /// <summary>
        ///     Get Power from MechanicalHorsepower.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMechanicalHorsepower(double mechanicalhorsepower)
        {
            decimal value = (decimal)mechanicalhorsepower;
            return new Power(value, PowerUnit.MechanicalHorsepower);
        }
        /// <summary>
        ///     Get Power from MegajoulesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMegajoulesPerHour(double megajoulesperhour)
        {
            decimal value = (decimal)megajoulesperhour;
            return new Power(value, PowerUnit.MegajoulePerHour);
        }
        /// <summary>
        ///     Get Power from Megawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMegawatts(double megawatts)
        {
            decimal value = (decimal)megawatts;
            return new Power(value, PowerUnit.Megawatt);
        }
        /// <summary>
        ///     Get Power from MetricHorsepower.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMetricHorsepower(double metrichorsepower)
        {
            decimal value = (decimal)metrichorsepower;
            return new Power(value, PowerUnit.MetricHorsepower);
        }
        /// <summary>
        ///     Get Power from Microwatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMicrowatts(double microwatts)
        {
            decimal value = (decimal)microwatts;
            return new Power(value, PowerUnit.Microwatt);
        }
        /// <summary>
        ///     Get Power from MillijoulesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMillijoulesPerHour(double millijoulesperhour)
        {
            decimal value = (decimal)millijoulesperhour;
            return new Power(value, PowerUnit.MillijoulePerHour);
        }
        /// <summary>
        ///     Get Power from Milliwatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromMilliwatts(double milliwatts)
        {
            decimal value = (decimal)milliwatts;
            return new Power(value, PowerUnit.Milliwatt);
        }
        /// <summary>
        ///     Get Power from Nanowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromNanowatts(double nanowatts)
        {
            decimal value = (decimal)nanowatts;
            return new Power(value, PowerUnit.Nanowatt);
        }
        /// <summary>
        ///     Get Power from Petawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromPetawatts(double petawatts)
        {
            decimal value = (decimal)petawatts;
            return new Power(value, PowerUnit.Petawatt);
        }
        /// <summary>
        ///     Get Power from Picowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromPicowatts(double picowatts)
        {
            decimal value = (decimal)picowatts;
            return new Power(value, PowerUnit.Picowatt);
        }
        /// <summary>
        ///     Get Power from Terawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromTerawatts(double terawatts)
        {
            decimal value = (decimal)terawatts;
            return new Power(value, PowerUnit.Terawatt);
        }
        /// <summary>
        ///     Get Power from Watts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Power FromWatts(double watts)
        {
            decimal value = (decimal)watts;
            return new Power(value, PowerUnit.Watt);
        }

    }
}


using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Power
    {

 

            /// <summary>
            ///     Get Power from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromSI(double SI)
            {
                double value= (double)SI;
                return new Power(value, PowerUnit.SI);
            }
            /// <summary>
            ///     Get Power from Femtowatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromFemtowatt(double Femtowatt)
            {
                double value= (double)Femtowatt;
                return new Power(value, PowerUnit.Femtowatt);
            }
            /// <summary>
            ///     Get Power from Picowatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromPicowatt(double Picowatt)
            {
                double value= (double)Picowatt;
                return new Power(value, PowerUnit.Picowatt);
            }
            /// <summary>
            ///     Get Power from Nanowatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromNanowatt(double Nanowatt)
            {
                double value= (double)Nanowatt;
                return new Power(value, PowerUnit.Nanowatt);
            }
            /// <summary>
            ///     Get Power from Microwatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMicrowatt(double Microwatt)
            {
                double value= (double)Microwatt;
                return new Power(value, PowerUnit.Microwatt);
            }
            /// <summary>
            ///     Get Power from Milliwatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMilliwatt(double Milliwatt)
            {
                double value= (double)Milliwatt;
                return new Power(value, PowerUnit.Milliwatt);
            }
            /// <summary>
            ///     Get Power from Deciwatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromDeciwatt(double Deciwatt)
            {
                double value= (double)Deciwatt;
                return new Power(value, PowerUnit.Deciwatt);
            }
            /// <summary>
            ///     Get Power from Watt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromWatt(double Watt)
            {
                double value= (double)Watt;
                return new Power(value, PowerUnit.Watt);
            }
            /// <summary>
            ///     Get Power from Decawatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromDecawatt(double Decawatt)
            {
                double value= (double)Decawatt;
                return new Power(value, PowerUnit.Decawatt);
            }
            /// <summary>
            ///     Get Power from Kilowatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromKilowatt(double Kilowatt)
            {
                double value= (double)Kilowatt;
                return new Power(value, PowerUnit.Kilowatt);
            }
            /// <summary>
            ///     Get Power from Megawatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMegawatt(double Megawatt)
            {
                double value= (double)Megawatt;
                return new Power(value, PowerUnit.Megawatt);
            }
            /// <summary>
            ///     Get Power from Gigawatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromGigawatt(double Gigawatt)
            {
                double value= (double)Gigawatt;
                return new Power(value, PowerUnit.Gigawatt);
            }
            /// <summary>
            ///     Get Power from Terawatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromTerawatt(double Terawatt)
            {
                double value= (double)Terawatt;
                return new Power(value, PowerUnit.Terawatt);
            }
            /// <summary>
            ///     Get Power from Petawatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromPetawatt(double Petawatt)
            {
                double value= (double)Petawatt;
                return new Power(value, PowerUnit.Petawatt);
            }
            /// <summary>
            ///     Get Power from MillijoulePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMillijoulePerHour(double MillijoulePerHour)
            {
                double value= (double)MillijoulePerHour;
                return new Power(value, PowerUnit.MillijoulePerHour);
            }
            /// <summary>
            ///     Get Power from JoulePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromJoulePerHour(double JoulePerHour)
            {
                double value= (double)JoulePerHour;
                return new Power(value, PowerUnit.JoulePerHour);
            }
            /// <summary>
            ///     Get Power from KilojoulePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromKilojoulePerHour(double KilojoulePerHour)
            {
                double value= (double)KilojoulePerHour;
                return new Power(value, PowerUnit.KilojoulePerHour);
            }
            /// <summary>
            ///     Get Power from MegajoulePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMegajoulePerHour(double MegajoulePerHour)
            {
                double value= (double)MegajoulePerHour;
                return new Power(value, PowerUnit.MegajoulePerHour);
            }
            /// <summary>
            ///     Get Power from GigajoulePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromGigajoulePerHour(double GigajoulePerHour)
            {
                double value= (double)GigajoulePerHour;
                return new Power(value, PowerUnit.GigajoulePerHour);
            }
            /// <summary>
            ///     Get Power from BritishThermalUnitPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromBritishThermalUnitPerHour(double BritishThermalUnitPerHour)
            {
                double value= (double)BritishThermalUnitPerHour;
                return new Power(value, PowerUnit.BritishThermalUnitPerHour);
            }
            /// <summary>
            ///     Get Power from BritishThermalUnitPerMinute.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromBritishThermalUnitPerMinute(double BritishThermalUnitPerMinute)
            {
                double value= (double)BritishThermalUnitPerMinute;
                return new Power(value, PowerUnit.BritishThermalUnitPerMinute);
            }
            /// <summary>
            ///     Get Power from BritishThermalUnitPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromBritishThermalUnitPerSecond(double BritishThermalUnitPerSecond)
            {
                double value= (double)BritishThermalUnitPerSecond;
                return new Power(value, PowerUnit.BritishThermalUnitPerSecond);
            }
            /// <summary>
            ///     Get Power from KilobritishThermalUnitPerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromKilobritishThermalUnitPerHour(double KilobritishThermalUnitPerHour)
            {
                double value= (double)KilobritishThermalUnitPerHour;
                return new Power(value, PowerUnit.KilobritishThermalUnitPerHour);
            }
            /// <summary>
            ///     Get Power from BoilerHorsepower.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromBoilerHorsepower(double BoilerHorsepower)
            {
                double value= (double)BoilerHorsepower;
                return new Power(value, PowerUnit.BoilerHorsepower);
            }
            /// <summary>
            ///     Get Power from ElectricalHorsepower.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromElectricalHorsepower(double ElectricalHorsepower)
            {
                double value= (double)ElectricalHorsepower;
                return new Power(value, PowerUnit.ElectricalHorsepower);
            }
            /// <summary>
            ///     Get Power from HydraulicHorsepower.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromHydraulicHorsepower(double HydraulicHorsepower)
            {
                double value= (double)HydraulicHorsepower;
                return new Power(value, PowerUnit.HydraulicHorsepower);
            }
            /// <summary>
            ///     Get Power from MechanicalHorsepower.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMechanicalHorsepower(double MechanicalHorsepower)
            {
                double value= (double)MechanicalHorsepower;
                return new Power(value, PowerUnit.MechanicalHorsepower);
            }
            /// <summary>
            ///     Get Power from MetricHorsepower.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromMetricHorsepower(double MetricHorsepower)
            {
                double value= (double)MetricHorsepower;
                return new Power(value, PowerUnit.MetricHorsepower);
            }
            /// <summary>
            ///     Get Power from CaloriePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromCaloriePerSecond(double CaloriePerSecond)
            {
                double value= (double)CaloriePerSecond;
                return new Power(value, PowerUnit.CaloriePerSecond);
            }
            /// <summary>
            ///     Get Power from KilocaloriePerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromKilocaloriePerHour(double KilocaloriePerHour)
            {
                double value= (double)KilocaloriePerHour;
                return new Power(value, PowerUnit.KilocaloriePerHour);
            }
            /// <summary>
            ///     Get Power from KilocaloriePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromKilocaloriePerSecond(double KilocaloriePerSecond)
            {
                double value= (double)KilocaloriePerSecond;
                return new Power(value, PowerUnit.KilocaloriePerSecond);
            }
            /// <summary>
            ///     Get Power from SolarLuminosity.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Power FromSolarLuminosity(double SolarLuminosity)
            {
                double value= (double)SolarLuminosity;
                return new Power(value, PowerUnit.SolarLuminosity);
            }
    }
}



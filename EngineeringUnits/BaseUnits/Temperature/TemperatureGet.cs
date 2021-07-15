using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Temperature
    {

        /// <summary>
        ///     Get Temperature in DegreesCelsius.
        /// </summary>
        public double DegreesCelsius => As(TemperatureUnit.DegreeCelsius);

        /// <summary>
        ///     Get Temperature in DegreesDelisle.
        /// </summary>
        //public double DegreesDelisle => As(TemperatureUnit.DegreeDelisle);

        /// <summary>
        ///     Get Temperature in DegreesFahrenheit.
        /// </summary>
        public double DegreesFahrenheit => As(TemperatureUnit.DegreeFahrenheit);

        /// <summary>
        ///     Get Temperature in DegreesNewton.
        /// </summary>
        //public double DegreesNewton => As(TemperatureUnit.DegreeNewton);

        /// <summary>
        ///     Get Temperature in DegreesRankine.
        /// </summary>
        public double DegreesRankine => As(TemperatureUnit.DegreeRankine);

        /// <summary>
        ///     Get Temperature in DegreesReaumur.
        /// </summary>
        //public double DegreesReaumur => As(TemperatureUnit.DegreeReaumur);

        /// <summary>
        ///     Get Temperature in DegreesRoemer.
        /// </summary>
        //public double DegreesRoemer => As(TemperatureUnit.DegreeRoemer);

        /// <summary>
        ///     Get Temperature in Kelvins.
        /// </summary>
        public double Kelvins => As(TemperatureUnit.Kelvin);

        /// <summary>
        ///     Get Temperature in SI Unit (Kelvin).
        /// </summary>
        public double SI => As(TemperatureUnit.SI);

        /// <summary>
        ///     Get Temperature in MillidegreesCelsius.
        /// </summary>
        //public double MillidegreesCelsius => As(TemperatureUnit.MillidegreeCelsius);

        /// <summary>
        ///     Get Temperature in SolarTemperatures.
        /// </summary>
        //public double SolarTemperatures => As(TemperatureUnit.SolarTemperature);


    }
}

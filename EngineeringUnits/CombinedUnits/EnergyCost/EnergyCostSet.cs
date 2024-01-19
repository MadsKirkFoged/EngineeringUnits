
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class EnergyCost
    {

 

        /// <summary>
        ///     Get EnergyCost from SI.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromSI(double? SI)
        {
            if (SI is null)
                return null;

            return new EnergyCost((double)SI, EnergyCostUnit.SI);
        }
        /// <summary>
        ///     Get EnergyCost from DollarPerJoule.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromDollarPerJoule(double? DollarPerJoule)
        {
            if (DollarPerJoule is null)
                return null;

            return new EnergyCost((double)DollarPerJoule, EnergyCostUnit.DollarPerJoule);
        }
        /// <summary>
        ///     Get EnergyCost from DollarPerKilojoule.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromDollarPerKilojoule(double? DollarPerKilojoule)
        {
            if (DollarPerKilojoule is null)
                return null;

            return new EnergyCost((double)DollarPerKilojoule, EnergyCostUnit.DollarPerKilojoule);
        }
        /// <summary>
        ///     Get EnergyCost from DollarPerMegajoule.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromDollarPerMegajoule(double? DollarPerMegajoule)
        {
            if (DollarPerMegajoule is null)
                return null;

            return new EnergyCost((double)DollarPerMegajoule, EnergyCostUnit.DollarPerMegajoule);
        }
        /// <summary>
        ///     Get EnergyCost from DollarPerGigajoule.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromDollarPerGigajoule(double? DollarPerGigajoule)
        {
            if (DollarPerGigajoule is null)
                return null;

            return new EnergyCost((double)DollarPerGigajoule, EnergyCostUnit.DollarPerGigajoule);
        }
        /// <summary>
        ///     Get EnergyCost from DollarPerKilowattHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromDollarPerKilowattHour(double? DollarPerKilowattHour)
        {
            if (DollarPerKilowattHour is null)
                return null;

            return new EnergyCost((double)DollarPerKilowattHour, EnergyCostUnit.DollarPerKilowattHour);
        }
        /// <summary>
        ///     Get EnergyCost from DollarPerMegawattHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnergyCost FromDollarPerMegawattHour(double? DollarPerMegawattHour)
        {
            if (DollarPerMegawattHour is null)
                return null;

            return new EnergyCost((double)DollarPerMegawattHour, EnergyCostUnit.DollarPerMegawattHour);
        }
    }
}



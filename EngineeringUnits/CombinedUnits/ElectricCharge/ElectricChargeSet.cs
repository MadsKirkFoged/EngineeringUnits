
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCharge
    {

 

            /// <summary>
            ///     Get ElectricCharge from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCharge FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricCharge(value, ElectricChargeUnit.SI);
            }
            /// <summary>
            ///     Get ElectricCharge from Coulomb.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCharge FromCoulomb(double Coulomb)
            {
                double value= (double)Coulomb;
                return new ElectricCharge(value, ElectricChargeUnit.Coulomb);
            }
            /// <summary>
            ///     Get ElectricCharge from AmpereHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCharge FromAmpereHour(double AmpereHour)
            {
                double value= (double)AmpereHour;
                return new ElectricCharge(value, ElectricChargeUnit.AmpereHour);
            }
            /// <summary>
            ///     Get ElectricCharge from KiloampereHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCharge FromKiloampereHour(double KiloampereHour)
            {
                double value= (double)KiloampereHour;
                return new ElectricCharge(value, ElectricChargeUnit.KiloampereHour);
            }
            /// <summary>
            ///     Get ElectricCharge from MegaampereHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCharge FromMegaampereHour(double MegaampereHour)
            {
                double value= (double)MegaampereHour;
                return new ElectricCharge(value, ElectricChargeUnit.MegaampereHour);
            }
            /// <summary>
            ///     Get ElectricCharge from MilliampereHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCharge FromMilliampereHour(double MilliampereHour)
            {
                double value= (double)MilliampereHour;
                return new ElectricCharge(value, ElectricChargeUnit.MilliampereHour);
            }
    }
}



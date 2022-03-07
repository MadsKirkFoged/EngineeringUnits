
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Molarity
    {

 

            /// <summary>
            ///     Get Molarity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromSI(double SI)
            {
                double value= (double)SI;
                return new Molarity(value, MolarityUnit.SI);
            }
            /// <summary>
            ///     Get Molarity from MolesPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromMolesPerCubicMeter(double MolesPerCubicMeter)
            {
                double value= (double)MolesPerCubicMeter;
                return new Molarity(value, MolarityUnit.MolesPerCubicMeter);
            }
            /// <summary>
            ///     Get Molarity from MolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromMolesPerLiter(double MolesPerLiter)
            {
                double value= (double)MolesPerLiter;
                return new Molarity(value, MolarityUnit.MolesPerLiter);
            }
            /// <summary>
            ///     Get Molarity from NanomolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromNanomolesPerLiter(double NanomolesPerLiter)
            {
                double value= (double)NanomolesPerLiter;
                return new Molarity(value, MolarityUnit.NanomolesPerLiter);
            }
            /// <summary>
            ///     Get Molarity from PicomolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromPicomolesPerLiter(double PicomolesPerLiter)
            {
                double value= (double)PicomolesPerLiter;
                return new Molarity(value, MolarityUnit.PicomolesPerLiter);
            }
            /// <summary>
            ///     Get Molarity from CentimolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromCentimolesPerLiter(double CentimolesPerLiter)
            {
                double value= (double)CentimolesPerLiter;
                return new Molarity(value, MolarityUnit.CentimolesPerLiter);
            }
            /// <summary>
            ///     Get Molarity from DecimolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromDecimolesPerLiter(double DecimolesPerLiter)
            {
                double value= (double)DecimolesPerLiter;
                return new Molarity(value, MolarityUnit.DecimolesPerLiter);
            }
            /// <summary>
            ///     Get Molarity from MicromolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromMicromolesPerLiter(double MicromolesPerLiter)
            {
                double value= (double)MicromolesPerLiter;
                return new Molarity(value, MolarityUnit.MicromolesPerLiter);
            }
            /// <summary>
            ///     Get Molarity from MillimolesPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Molarity FromMillimolesPerLiter(double MillimolesPerLiter)
            {
                double value= (double)MillimolesPerLiter;
                return new Molarity(value, MolarityUnit.MillimolesPerLiter);
            }
    }
}



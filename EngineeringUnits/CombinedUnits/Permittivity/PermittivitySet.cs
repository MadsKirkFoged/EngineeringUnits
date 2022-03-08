
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Permittivity
    {

 

            /// <summary>
            ///     Get Permittivity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Permittivity FromSI(double SI)
            {
                double value= (double)SI;
                return new Permittivity(value, PermittivityUnit.SI);
            }
            /// <summary>
            ///     Get Permittivity from FaradPerMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Permittivity FromFaradPerMeter(double FaradPerMeter)
            {
                double value= (double)FaradPerMeter;
                return new Permittivity(value, PermittivityUnit.FaradPerMeter);
            }
    }
}



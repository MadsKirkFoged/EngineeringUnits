
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCurrentGradient
    {

 

            /// <summary>
            ///     Get ElectricCurrentGradient from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentGradient FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.SI);
            }
            /// <summary>
            ///     Get ElectricCurrentGradient from AmperePerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentGradient FromAmperePerSecond(double AmperePerSecond)
            {
                double value= (double)AmperePerSecond;
                return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerSecond);
            }
            /// <summary>
            ///     Get ElectricCurrentGradient from AmperePerMicrosecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentGradient FromAmperePerMicrosecond(double AmperePerMicrosecond)
            {
                double value= (double)AmperePerMicrosecond;
                return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMicrosecond);
            }
            /// <summary>
            ///     Get ElectricCurrentGradient from AmperePerMillisecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentGradient FromAmperePerMillisecond(double AmperePerMillisecond)
            {
                double value= (double)AmperePerMillisecond;
                return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMillisecond);
            }
            /// <summary>
            ///     Get ElectricCurrentGradient from AmperePerNanosecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentGradient FromAmperePerNanosecond(double AmperePerNanosecond)
            {
                double value= (double)AmperePerNanosecond;
                return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerNanosecond);
            }
    }
}



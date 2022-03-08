
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Illuminance
    {

 

            /// <summary>
            ///     Get Illuminance from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Illuminance FromSI(double SI)
            {
                double value= (double)SI;
                return new Illuminance(value, IlluminanceUnit.SI);
            }
            /// <summary>
            ///     Get Illuminance from Lux.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Illuminance FromLux(double Lux)
            {
                double value= (double)Lux;
                return new Illuminance(value, IlluminanceUnit.Lux);
            }
            /// <summary>
            ///     Get Illuminance from Kilolux.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Illuminance FromKilolux(double Kilolux)
            {
                double value= (double)Kilolux;
                return new Illuminance(value, IlluminanceUnit.Kilolux);
            }
            /// <summary>
            ///     Get Illuminance from Megalux.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Illuminance FromMegalux(double Megalux)
            {
                double value= (double)Megalux;
                return new Illuminance(value, IlluminanceUnit.Megalux);
            }
            /// <summary>
            ///     Get Illuminance from Millilux.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Illuminance FromMillilux(double Millilux)
            {
                double value= (double)Millilux;
                return new Illuminance(value, IlluminanceUnit.Millilux);
            }
    }
}




using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Capacitance
    {

 

            /// <summary>
            ///     Get Capacitance from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromSI(double SI)
            {
                double value= (double)SI;
                return new Capacitance(value, CapacitanceUnit.SI);
            }
            /// <summary>
            ///     Get Capacitance from Farad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromFarad(double Farad)
            {
                double value= (double)Farad;
                return new Capacitance(value, CapacitanceUnit.Farad);
            }
            /// <summary>
            ///     Get Capacitance from Kilofarad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromKilofarad(double Kilofarad)
            {
                double value= (double)Kilofarad;
                return new Capacitance(value, CapacitanceUnit.Kilofarad);
            }
            /// <summary>
            ///     Get Capacitance from Megafarad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromMegafarad(double Megafarad)
            {
                double value= (double)Megafarad;
                return new Capacitance(value, CapacitanceUnit.Megafarad);
            }
            /// <summary>
            ///     Get Capacitance from Microfarad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromMicrofarad(double Microfarad)
            {
                double value= (double)Microfarad;
                return new Capacitance(value, CapacitanceUnit.Microfarad);
            }
            /// <summary>
            ///     Get Capacitance from Millifarad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromMillifarad(double Millifarad)
            {
                double value= (double)Millifarad;
                return new Capacitance(value, CapacitanceUnit.Millifarad);
            }
            /// <summary>
            ///     Get Capacitance from Nanofarad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromNanofarad(double Nanofarad)
            {
                double value= (double)Nanofarad;
                return new Capacitance(value, CapacitanceUnit.Nanofarad);
            }
            /// <summary>
            ///     Get Capacitance from Picofarad.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Capacitance FromPicofarad(double Picofarad)
            {
                double value= (double)Picofarad;
                return new Capacitance(value, CapacitanceUnit.Picofarad);
            }
    }
}



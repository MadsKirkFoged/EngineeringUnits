
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Capacitance
    {

 

        /// <summary>
        ///     Get Capacitance from SI.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromSI(double? SI)
        {
            if (SI is null)
                return null;

            return new Capacitance((double)SI, CapacitanceUnit.SI);
        }
        /// <summary>
        ///     Get Capacitance from Farad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromFarad(double? Farad)
        {
            if (Farad is null)
                return null;

            return new Capacitance((double)Farad, CapacitanceUnit.Farad);
        }
        /// <summary>
        ///     Get Capacitance from Kilofarad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromKilofarad(double? Kilofarad)
        {
            if (Kilofarad is null)
                return null;

            return new Capacitance((double)Kilofarad, CapacitanceUnit.Kilofarad);
        }
        /// <summary>
        ///     Get Capacitance from Megafarad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMegafarad(double? Megafarad)
        {
            if (Megafarad is null)
                return null;

            return new Capacitance((double)Megafarad, CapacitanceUnit.Megafarad);
        }
        /// <summary>
        ///     Get Capacitance from Microfarad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMicrofarad(double? Microfarad)
        {
            if (Microfarad is null)
                return null;

            return new Capacitance((double)Microfarad, CapacitanceUnit.Microfarad);
        }
        /// <summary>
        ///     Get Capacitance from Millifarad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMillifarad(double? Millifarad)
        {
            if (Millifarad is null)
                return null;

            return new Capacitance((double)Millifarad, CapacitanceUnit.Millifarad);
        }
        /// <summary>
        ///     Get Capacitance from Nanofarad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromNanofarad(double? Nanofarad)
        {
            if (Nanofarad is null)
                return null;

            return new Capacitance((double)Nanofarad, CapacitanceUnit.Nanofarad);
        }
        /// <summary>
        ///     Get Capacitance from Picofarad.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromPicofarad(double? Picofarad)
        {
            if (Picofarad is null)
                return null;

            return new Capacitance((double)Picofarad, CapacitanceUnit.Picofarad);
        }
    }
}



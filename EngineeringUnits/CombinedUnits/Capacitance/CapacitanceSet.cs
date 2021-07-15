using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Capacitance
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromSI(double si)
        {
            double value = (double)si;
            return new Capacitance(value, CapacitanceUnit.SI);
        }

        /// <summary>
        ///     Get Capacitance from Farads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromFarads(double farads)
        {
            double value = (double)farads;
            return new Capacitance(value, CapacitanceUnit.Farad);
        }
        /// <summary>
        ///     Get Capacitance from Kilofarads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromKilofarads(double kilofarads)
        {
            double value = (double)kilofarads;
            return new Capacitance(value, CapacitanceUnit.Kilofarad);
        }
        /// <summary>
        ///     Get Capacitance from Megafarads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMegafarads(double megafarads)
        {
            double value = (double)megafarads;
            return new Capacitance(value, CapacitanceUnit.Megafarad);
        }
        /// <summary>
        ///     Get Capacitance from Microfarads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMicrofarads(double microfarads)
        {
            double value = (double)microfarads;
            return new Capacitance(value, CapacitanceUnit.Microfarad);
        }
        /// <summary>
        ///     Get Capacitance from Millifarads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMillifarads(double millifarads)
        {
            double value = (double)millifarads;
            return new Capacitance(value, CapacitanceUnit.Millifarad);
        }
        /// <summary>
        ///     Get Capacitance from Nanofarads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromNanofarads(double nanofarads)
        {
            double value = (double)nanofarads;
            return new Capacitance(value, CapacitanceUnit.Nanofarad);
        }
        /// <summary>
        ///     Get Capacitance from Picofarads.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromPicofarads(double picofarads)
        {
            double value = (double)picofarads;
            return new Capacitance(value, CapacitanceUnit.Picofarad);
        }

    }
}

using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Capacitance
    {
        /// <summary>
        ///     Get Capacitance in Farads.
        /// </summary>
        public double Farads => As(CapacitanceUnit.Farad);

        /// <summary>
        ///     Get Capacitance in SI Unit (Farads).
        /// </summary>
        public double SI => As(CapacitanceUnit.SI);

        /// <summary>
        ///     Get Capacitance in Kilofarads.
        /// </summary>
        public double Kilofarads => As(CapacitanceUnit.Kilofarad);

        /// <summary>
        ///     Get Capacitance in Megafarads.
        /// </summary>
        public double Megafarads => As(CapacitanceUnit.Megafarad);

        /// <summary>
        ///     Get Capacitance in Microfarads.
        /// </summary>
        public double Microfarads => As(CapacitanceUnit.Microfarad);

        /// <summary>
        ///     Get Capacitance in Millifarads.
        /// </summary>
        public double Millifarads => As(CapacitanceUnit.Millifarad);

        /// <summary>
        ///     Get Capacitance in Nanofarads.
        /// </summary>
        public double Nanofarads => As(CapacitanceUnit.Nanofarad);

        /// <summary>
        ///     Get Capacitance in Picofarads.
        /// </summary>
        public double Picofarads => As(CapacitanceUnit.Picofarad);

    }
}

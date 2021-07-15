using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricInductance
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromSI(double si)
        {
            double value = (double)si;
            return new ElectricInductance(value, ElectricInductanceUnit.SI);
        }

        /// <summary>
        ///     Get ElectricInductance from Henries.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromHenries(double henries)
        {
            double value = (double)henries;
            return new ElectricInductance(value, ElectricInductanceUnit.Henry);
        }
        /// <summary>
        ///     Get ElectricInductance from Microhenries.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromMicrohenries(double microhenries)
        {
            double value = (double)microhenries;
            return new ElectricInductance(value, ElectricInductanceUnit.Microhenry);
        }
        /// <summary>
        ///     Get ElectricInductance from Millihenries.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromMillihenries(double millihenries)
        {
            double value = (double)millihenries;
            return new ElectricInductance(value, ElectricInductanceUnit.Millihenry);
        }
        /// <summary>
        ///     Get ElectricInductance from Nanohenries.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromNanohenries(double nanohenries)
        {
            double value = (double)nanohenries;
            return new ElectricInductance(value, ElectricInductanceUnit.Nanohenry);
        }

    }
}

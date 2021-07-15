using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricAdmittance
    {

        /// <summary>
        ///     Get ElectricAdmittance from Microsiemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromMicrosiemens(double microsiemens)
        {
            double value = (double)microsiemens;
            return new ElectricAdmittance(value, ElectricAdmittanceUnit.Microsiemens);
        }
        /// <summary>
        ///     Get ElectricAdmittance from Millisiemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromMillisiemens(double millisiemens)
        {
            double value = (double)millisiemens;
            return new ElectricAdmittance(value, ElectricAdmittanceUnit.Millisiemens);
        }
        /// <summary>
        ///     Get ElectricAdmittance from Nanosiemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromNanosiemens(double nanosiemens)
        {
            double value = (double)nanosiemens;
            return new ElectricAdmittance(value, ElectricAdmittanceUnit.Nanosiemens);
        }
        /// <summary>
        ///     Get ElectricAdmittance from Siemens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricAdmittance FromSiemens(double siemens)
        {
            double value = (double)siemens;
            return new ElectricAdmittance(value, ElectricAdmittanceUnit.Siemens);
        }
    }
}

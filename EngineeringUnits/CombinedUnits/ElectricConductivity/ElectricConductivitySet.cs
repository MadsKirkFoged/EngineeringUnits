using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricConductivity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductivity FromSI(double si)
        {
            double value = (double)si;
            return new ElectricConductivity(value, ElectricConductivityUnit.SI);
        }

        /// <summary>
        ///     Get ElectricConductivity from SiemensPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductivity FromSiemensPerFoot(double siemensperfoot)
        {
            double value = (double)siemensperfoot;
            return new ElectricConductivity(value, ElectricConductivityUnit.SiemensPerFoot);
        }
        /// <summary>
        ///     Get ElectricConductivity from SiemensPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductivity FromSiemensPerInch(double siemensperinch)
        {
            double value = (double)siemensperinch;
            return new ElectricConductivity(value, ElectricConductivityUnit.SiemensPerInch);
        }
        /// <summary>
        ///     Get ElectricConductivity from SiemensPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductivity FromSiemensPerMeter(double siemenspermeter)
        {
            double value = (double)siemenspermeter;
            return new ElectricConductivity(value, ElectricConductivityUnit.SiemensPerMeter);
        }

    }
}

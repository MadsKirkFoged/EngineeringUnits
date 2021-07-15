using EngineeringUnits.Units;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class AmountOfSubstance
    {
        /// <summary>
        ///     Get AmountOfSubstance from Centimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromCentimoles(double centimoles)
        {
            double value = (double)centimoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Centimole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from CentipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromCentipoundMoles(double centipoundmoles)
        {
            double value = (double)centipoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.CentipoundMole);
        }

        /// <summary>
        ///     Get AmountOfSubstance from Decimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromDecimoles(double decimoles)
        {
            double value = (double)decimoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Decimole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from DecipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromDecipoundMoles(double decipoundmoles)
        {
            double value = (double)decipoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.DecipoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Kilomoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromKilomoles(double kilomoles)
        {
            double value = (double)kilomoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Kilomole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from KilopoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromKilopoundMoles(double kilopoundmoles)
        {
            double value = (double)kilopoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.KilopoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Megamoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMegamoles(double megamoles)
        {
            double value = (double)megamoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Megamole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Micromoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMicromoles(double micromoles)
        {
            double value = (double)micromoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Micromole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from MicropoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMicropoundMoles(double micropoundmoles)
        {
            double value = (double)micropoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.MicropoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Millimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMillimoles(double millimoles)
        {
            double value = (double)millimoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Millimole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from MillipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMillipoundMoles(double millipoundmoles)
        {
            double value = (double)millipoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.MillipoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Moles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMoles(double moles)
        {
            double value = (double)moles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Mole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Nanomoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromNanomoles(double nanomoles)
        {
            double value = (double)nanomoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Nanomole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from NanopoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromNanopoundMoles(double nanopoundmoles)
        {
            double value = (double)nanopoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.NanopoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from PoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromPoundMoles(double poundmoles)
        {
            double value = (double)poundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.PoundMole);
        }



    }
}

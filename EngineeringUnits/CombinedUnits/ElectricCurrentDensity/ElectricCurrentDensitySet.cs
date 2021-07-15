using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCurrentDensity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromSI(double si)
        {
            double value = (double)si;
            return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.SI);
        }

        /// <summary>
        ///     Get ElectricCurrentDensity from AmperesPerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromAmperesPerSquareFoot(double amperespersquarefoot)
        {
            double value = (double)amperespersquarefoot;
            return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareFoot);
        }
        /// <summary>
        ///     Get ElectricCurrentDensity from AmperesPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromAmperesPerSquareInch(double amperespersquareinch)
        {
            double value = (double)amperespersquareinch;
            return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareInch);
        }
        /// <summary>
        ///     Get ElectricCurrentDensity from AmperesPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromAmperesPerSquareMeter(double amperespersquaremeter)
        {
            double value = (double)amperespersquaremeter;
            return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareMeter);
        }

    }
}

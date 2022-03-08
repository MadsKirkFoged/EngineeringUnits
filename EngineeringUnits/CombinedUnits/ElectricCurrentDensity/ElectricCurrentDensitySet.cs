
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCurrentDensity
    {

 

            /// <summary>
            ///     Get ElectricCurrentDensity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentDensity FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.SI);
            }
            /// <summary>
            ///     Get ElectricCurrentDensity from AmperePerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentDensity FromAmperePerSquareMeter(double AmperePerSquareMeter)
            {
                double value= (double)AmperePerSquareMeter;
                return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareMeter);
            }
            /// <summary>
            ///     Get ElectricCurrentDensity from AmperePerSquareInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentDensity FromAmperePerSquareInch(double AmperePerSquareInch)
            {
                double value= (double)AmperePerSquareInch;
                return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareInch);
            }
            /// <summary>
            ///     Get ElectricCurrentDensity from AmperePerSquareFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricCurrentDensity FromAmperePerSquareFoot(double AmperePerSquareFoot)
            {
                double value= (double)AmperePerSquareFoot;
                return new ElectricCurrentDensity(value, ElectricCurrentDensityUnit.AmperePerSquareFoot);
            }
    }
}




using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class AreaDensity
    {

 

            /// <summary>
            ///     Get AreaDensity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static AreaDensity FromSI(double SI)
            {
                double value= (double)SI;
                return new AreaDensity(value, AreaDensityUnit.SI);
            }
            /// <summary>
            ///     Get AreaDensity from KilogramPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static AreaDensity FromKilogramPerSquareMeter(double KilogramPerSquareMeter)
            {
                double value= (double)KilogramPerSquareMeter;
                return new AreaDensity(value, AreaDensityUnit.KilogramPerSquareMeter);
            }
    }
}



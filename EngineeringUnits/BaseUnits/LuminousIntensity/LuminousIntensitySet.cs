
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class LuminousIntensity
    {

 

            /// <summary>
            ///     Get LuminousIntensity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static LuminousIntensity FromSI(double SI)
            {
                double value= (double)SI;
                return new LuminousIntensity(value, LuminousIntensityUnit.SI);
            }
            /// <summary>
            ///     Get LuminousIntensity from Candela.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static LuminousIntensity FromCandela(double Candela)
            {
                double value= (double)Candela;
                return new LuminousIntensity(value, LuminousIntensityUnit.Candela);
            }
    }
}



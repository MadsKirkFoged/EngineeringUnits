
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricChargeDensity
    {

 

            /// <summary>
            ///     Get ElectricChargeDensity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricChargeDensity FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricChargeDensity(value, ElectricChargeDensityUnit.SI);
            }
            /// <summary>
            ///     Get ElectricChargeDensity from CoulombPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricChargeDensity FromCoulombPerCubicMeter(double CoulombPerCubicMeter)
            {
                double value= (double)CoulombPerCubicMeter;
                return new ElectricChargeDensity(value, ElectricChargeDensityUnit.CoulombPerCubicMeter);
            }
    }
}



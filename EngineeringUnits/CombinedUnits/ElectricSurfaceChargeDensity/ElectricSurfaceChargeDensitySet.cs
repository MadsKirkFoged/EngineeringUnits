
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricSurfaceChargeDensity
    {

 

            /// <summary>
            ///     Get ElectricSurfaceChargeDensity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricSurfaceChargeDensity FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.SI);
            }
            /// <summary>
            ///     Get ElectricSurfaceChargeDensity from CoulombPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricSurfaceChargeDensity FromCoulombPerSquareMeter(double CoulombPerSquareMeter)
            {
                double value= (double)CoulombPerSquareMeter;
                return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter);
            }
            /// <summary>
            ///     Get ElectricSurfaceChargeDensity from CoulombPerSquareCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricSurfaceChargeDensity FromCoulombPerSquareCentimeter(double CoulombPerSquareCentimeter)
            {
                double value= (double)CoulombPerSquareCentimeter;
                return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter);
            }
            /// <summary>
            ///     Get ElectricSurfaceChargeDensity from CoulombPerSquareInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricSurfaceChargeDensity FromCoulombPerSquareInch(double CoulombPerSquareInch)
            {
                double value= (double)CoulombPerSquareInch;
                return new ElectricSurfaceChargeDensity(value, ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch);
            }
    }
}



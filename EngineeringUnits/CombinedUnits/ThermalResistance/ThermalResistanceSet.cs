
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ThermalResistance
    {

 

            /// <summary>
            ///     Get ThermalResistance from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalResistance FromSI(double SI)
            {
                double value= (double)SI;
                return new ThermalResistance(value, ThermalResistanceUnit.SI);
            }
            /// <summary>
            ///     Get ThermalResistance from SquareMeterDegreeCelsiusPerWatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalResistance FromSquareMeterDegreeCelsiusPerWatt(double SquareMeterDegreeCelsiusPerWatt)
            {
                double value= (double)SquareMeterDegreeCelsiusPerWatt;
                return new ThermalResistance(value, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);
            }
            /// <summary>
            ///     Get ThermalResistance from SquareMeterKelvinPerKilowatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalResistance FromSquareMeterKelvinPerKilowatt(double SquareMeterKelvinPerKilowatt)
            {
                double value= (double)SquareMeterKelvinPerKilowatt;
                return new ThermalResistance(value, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);
            }
            /// <summary>
            ///     Get ThermalResistance from SquareCentimeterKelvinPerWatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalResistance FromSquareCentimeterKelvinPerWatt(double SquareCentimeterKelvinPerWatt)
            {
                double value= (double)SquareCentimeterKelvinPerWatt;
                return new ThermalResistance(value, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
            }
            /// <summary>
            ///     Get ThermalResistance from SquareCentimeterHourDegreeCelsiusPerKilocalorie.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalResistance FromSquareCentimeterHourDegreeCelsiusPerKilocalorie(double SquareCentimeterHourDegreeCelsiusPerKilocalorie)
            {
                double value= (double)SquareCentimeterHourDegreeCelsiusPerKilocalorie;
                return new ThermalResistance(value, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);
            }
            /// <summary>
            ///     Get ThermalResistance from HourSquareFeetDegreeFahrenheitPerBtu.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalResistance FromHourSquareFeetDegreeFahrenheitPerBtu(double HourSquareFeetDegreeFahrenheitPerBtu)
            {
                double value= (double)HourSquareFeetDegreeFahrenheitPerBtu;
                return new ThermalResistance(value, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);
            }
    }
}



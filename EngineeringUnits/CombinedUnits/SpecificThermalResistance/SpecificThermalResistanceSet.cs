
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificThermalResistance
    {

 

            /// <summary>
            ///     Get SpecificThermalResistance from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificThermalResistance FromSI(double SI)
            {
                double value= (double)SI;
                return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.SI);
            }
            /// <summary>
            ///     Get SpecificThermalResistance from MeterDegreeCelsiusPerWatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificThermalResistance FromMeterDegreeCelsiusPerWatt(double MeterDegreeCelsiusPerWatt)
            {
                double value= (double)MeterDegreeCelsiusPerWatt;
                return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.MeterDegreeCelsiusPerWatt);
            }
            /// <summary>
            ///     Get SpecificThermalResistance from MeterKelvinPerKilowatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificThermalResistance FromMeterKelvinPerKilowatt(double MeterKelvinPerKilowatt)
            {
                double value= (double)MeterKelvinPerKilowatt;
                return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
            }
            /// <summary>
            ///     Get SpecificThermalResistance from CentimeterKelvinPerWatt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificThermalResistance FromCentimeterKelvinPerWatt(double CentimeterKelvinPerWatt)
            {
                double value= (double)CentimeterKelvinPerWatt;
                return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.CentimeterKelvinPerWatt);
            }
    }
}



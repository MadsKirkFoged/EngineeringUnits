
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricField
    {

 

            /// <summary>
            ///     Get ElectricField from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricField FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricField(value, ElectricFieldUnit.SI);
            }
            /// <summary>
            ///     Get ElectricField from VoltPerMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricField FromVoltPerMeter(double VoltPerMeter)
            {
                double value= (double)VoltPerMeter;
                return new ElectricField(value, ElectricFieldUnit.VoltPerMeter);
            }
    }
}



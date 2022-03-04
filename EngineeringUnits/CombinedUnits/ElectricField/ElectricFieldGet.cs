
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricField
    {

 

            /// <summary>
            ///     Get ElectricField in SI.
            /// </summary>
            public double SI => As(ElectricFieldUnit.SI);
            /// <summary>
            ///     Get ElectricField in VoltPerMeter.
            /// </summary>
            public double VoltPerMeter => As(ElectricFieldUnit.VoltPerMeter);
    }
}



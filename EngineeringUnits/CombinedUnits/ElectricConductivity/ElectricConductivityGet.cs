
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricConductivity
    {

 

            /// <summary>
            ///     Get ElectricConductivity in SI.
            /// </summary>
            public double SI => As(ElectricConductivityUnit.SI);
            /// <summary>
            ///     Get ElectricConductivity in SiemensPerMeter.
            /// </summary>
            public double SiemensPerMeter => As(ElectricConductivityUnit.SiemensPerMeter);
            /// <summary>
            ///     Get ElectricConductivity in SiemensPerInch.
            /// </summary>
            public double SiemensPerInch => As(ElectricConductivityUnit.SiemensPerInch);
            /// <summary>
            ///     Get ElectricConductivity in SiemensPerFoot.
            /// </summary>
            public double SiemensPerFoot => As(ElectricConductivityUnit.SiemensPerFoot);
    }
}




using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCharge
    {

 

            /// <summary>
            ///     Get ElectricCharge in SI.
            /// </summary>
            public double SI => As(ElectricChargeUnit.SI);
            /// <summary>
            ///     Get ElectricCharge in Coulomb.
            /// </summary>
            public double Coulomb => As(ElectricChargeUnit.Coulomb);
            /// <summary>
            ///     Get ElectricCharge in AmpereHour.
            /// </summary>
            public double AmpereHour => As(ElectricChargeUnit.AmpereHour);
            /// <summary>
            ///     Get ElectricCharge in KiloampereHour.
            /// </summary>
            public double KiloampereHour => As(ElectricChargeUnit.KiloampereHour);
            /// <summary>
            ///     Get ElectricCharge in MegaampereHour.
            /// </summary>
            public double MegaampereHour => As(ElectricChargeUnit.MegaampereHour);
            /// <summary>
            ///     Get ElectricCharge in MilliampereHour.
            /// </summary>
            public double MilliampereHour => As(ElectricChargeUnit.MilliampereHour);
    }
}



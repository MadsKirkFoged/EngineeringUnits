using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class BrakeSpecificFuelConsumption
    {
        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in GramsPerKiloWattHour.
        /// </summary>
        public double GramsPerKiloWattHour => As(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in KilogramsPerJoule.
        /// </summary>
        public double KilogramsPerJoule => As(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in SI Unit (KilogramsPerJoule).
        /// </summary>
        public double SI => As(BrakeSpecificFuelConsumptionUnit.SI);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in PoundsPerMechanicalHorsepowerHour.
        /// </summary>
        public double PoundsPerMechanicalHorsepowerHour => As(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);

    }
}

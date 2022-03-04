using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class BrakeSpecificFuelConsumption
    {
        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in GramsPerKiloWattHour.
        /// </summary>
        [Obsolete("Use without the 's' - GramsPerKiloWattHour->GramPerKiloWattHour")]
        public double GramsPerKiloWattHour => As(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in KilogramsPerJoule.
        /// </summary>
        [Obsolete("Use without the 's' - KilogramsPerJoule->KilogramPerJoule")]
        public double KilogramsPerJoule => As(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in SI Unit (KilogramsPerJoule).
        /// </summary>
        //public double SI => As(BrakeSpecificFuelConsumptionUnit.SI);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in PoundsPerMechanicalHorsepowerHour.
        /// </summary>
        [Obsolete("Use without the 's' - PoundsPerMechanicalHorsepowerHour->PoundPerMechanicalHorsepowerHour")]
        public double PoundsPerMechanicalHorsepowerHour => As(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);

    }
}

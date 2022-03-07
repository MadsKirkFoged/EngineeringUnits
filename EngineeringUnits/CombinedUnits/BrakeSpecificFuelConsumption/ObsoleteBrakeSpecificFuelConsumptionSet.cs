using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class BrakeSpecificFuelConsumption
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static BrakeSpecificFuelConsumption FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.SI);
        //}


        /// <summary>
        ///     Get BrakeSpecificFuelConsumption from GramsPerKiloWattHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerKiloWattHour->FromGramPerKiloWattHour")]
        public static BrakeSpecificFuelConsumption FromGramsPerKiloWattHour(double gramsperkilowatthour)
        {
            double value = (double)gramsperkilowatthour;
            return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
        }
        /// <summary>
        ///     Get BrakeSpecificFuelConsumption from KilogramsPerJoule.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerJoule->FromKilogramPerJoule")]
        public static BrakeSpecificFuelConsumption FromKilogramsPerJoule(double kilogramsperjoule)
        {
            double value = (double)kilogramsperjoule;
            return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
        }
        /// <summary>
        ///     Get BrakeSpecificFuelConsumption from PoundsPerMechanicalHorsepowerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsPerMechanicalHorsepowerHour->FromPoundPerMechanicalHorsepowerHour")]
        public static BrakeSpecificFuelConsumption FromPoundsPerMechanicalHorsepowerHour(double poundspermechanicalhorsepowerhour)
        {
            double value = (double)poundspermechanicalhorsepowerhour;
            return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
        }

    }
}

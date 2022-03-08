
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class BrakeSpecificFuelConsumption
    {

 

            /// <summary>
            ///     Get BrakeSpecificFuelConsumption from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BrakeSpecificFuelConsumption FromSI(double SI)
            {
                double value= (double)SI;
                return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.SI);
            }
            /// <summary>
            ///     Get BrakeSpecificFuelConsumption from KilogramPerJoule.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BrakeSpecificFuelConsumption FromKilogramPerJoule(double KilogramPerJoule)
            {
                double value= (double)KilogramPerJoule;
                return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
            }
            /// <summary>
            ///     Get BrakeSpecificFuelConsumption from GramPerKiloWattHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BrakeSpecificFuelConsumption FromGramPerKiloWattHour(double GramPerKiloWattHour)
            {
                double value= (double)GramPerKiloWattHour;
                return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
            }
            /// <summary>
            ///     Get BrakeSpecificFuelConsumption from PoundPerMechanicalHorsepowerHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static BrakeSpecificFuelConsumption FromPoundPerMechanicalHorsepowerHour(double PoundPerMechanicalHorsepowerHour)
            {
                double value= (double)PoundPerMechanicalHorsepowerHour;
                return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
            }
    }
}



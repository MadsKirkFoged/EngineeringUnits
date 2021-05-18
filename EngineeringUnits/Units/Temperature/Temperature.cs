using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Temperature : BaseUnit
    {

        public Temperature()
        {
            unitsystem.TemperatureCount = 1;
        }


        public Temperature(double value, TemperatureUnit? unit) :this()
        {
            unitsystem.SetUnit(unit);
            base.Value = value;
        }

        public static Temperature From(double value, TemperatureUnit unit)
        {
            return new Temperature(value, unit);
        }

        public double As(TemperatureUnit ReturnInThisUnit)
        {
            return UnitSystem.VectorDifferent(unitsystem.SelectedLengthUnit, ReturnInThisUnit) * Value;
        }


        public void PermanentChangeUnitTo(TemperatureUnit ReturnInThisUnit)
        {
            double Vector = UnitSystem.VectorDifferent(unitsystem.SelectedTemperatureUnit, ReturnInThisUnit);

            double FixedFactor = UnitSystem.VectorFixed(unitsystem.SelectedTemperatureUnit, ReturnInThisUnit);
            double FixedFactor2 = UnitSystem.VectorFixed2(unitsystem.SelectedTemperatureUnit, ReturnInThisUnit);


            if (ReturnInThisUnit == TemperatureUnit.DegreeFahrenheit)
            {
                Value += FixedFactor;
                Value *= Vector;
                Value += FixedFactor2;
            }
            else
            {
                Value += FixedFactor2;
               Value *= Vector;
                Value += FixedFactor;
            }





            unitsystem.SelectedTemperatureUnit = ReturnInThisUnit;
        }


        //Every units needs this
        public static implicit operator Temperature(UnknownUnit Unit)
        {
            Temperature local = new Temperature();

            if (local.unitsystem != Unit.baseUnit.unitsystem)
            {
                throw new InvalidOperationException("Units did not result in Length!");
            }

            local.Value = Unit.baseUnit.Value;
            local.unitsystem = Unit.baseUnit.unitsystem;

            return local;
        }



    }
}

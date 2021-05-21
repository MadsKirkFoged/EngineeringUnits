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
            unitsystem.Temperature.Count = 1;
        }


        public Temperature(double value, TemperatureUnit unit) :this()
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
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Temperature.SelectedUnit = ReturnInThisUnit;
            ReturnInThisUnitSystem.Temperature.Count = 1;


            return UnitSystem.Convert(Value, this.unitsystem, ReturnInThisUnitSystem);
        }


        //public void PermanentChangeUnitTo(TemperatureUnit ReturnInThisUnit)
        //{
        //    //double Vector = UnitSystem.VectorDifferent(unitsystem.SelectedTemperatureUnit, ReturnInThisUnit);

        //    //double FixedFactor = UnitSystem.VectorFixed(unitsystem.SelectedTemperatureUnit, ReturnInThisUnit);
        //    //double FixedFactor2 = UnitSystem.VectorFixed2(unitsystem.SelectedTemperatureUnit, ReturnInThisUnit);





        //    double y2 = Value;

        //    double a1 = UnitSystem.Vector(ReturnInThisUnit).AFactor;
        //    double a2 = UnitSystem.Vector(unitsystem.SelectedTemperatureUnit).AFactor;

        //    double b1 = UnitSystem.Vector(ReturnInThisUnit).BFactor; 
        //    double b2 = UnitSystem.Vector(unitsystem.SelectedTemperatureUnit).BFactor; 

        //    double factor = a1 / a2;


        //    double y1 = (y2 * factor) - b2 * factor + b1;

        //    Value = y1;

        //    unitsystem.SelectedTemperatureUnit = ReturnInThisUnit;
        //}


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

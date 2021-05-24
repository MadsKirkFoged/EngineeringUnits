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
            Unit.Temperature.Count = 1;
        }


        public Temperature(double value, TemperatureUnit unit) :this()
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Temperature.SelectedUnit = unit;
            ReturnInThisUnitSystem.Temperature.Count = 1;


            //Convert to 'local' unit
            ValueLocalUnit = UnitSystem.GetLocalUnit(value, ReturnInThisUnitSystem);
            Unit = ReturnInThisUnitSystem;
        }

        public static Temperature From(double value, TemperatureUnit unit)
        {
            return new Temperature(value, unit);
        }

        public decimal As(TemperatureUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Temperature.SelectedUnit = ReturnInThisUnit;
            ReturnInThisUnitSystem.Temperature.Count = 1;


            return Unit.ToTheOutSide(ValueLocalUnit, ReturnInThisUnitSystem) / 1.000000000000000000000000000000000m;
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

            if (local.Unit != Unit.baseUnit.Unit)
            {
                throw new InvalidOperationException("Units did not result in Length!");
            }

            local.ValueLocalUnit = Unit.baseUnit.ValueLocalUnit;
            local.Unit = Unit.baseUnit.Unit;

            return local;
        }



    }
}

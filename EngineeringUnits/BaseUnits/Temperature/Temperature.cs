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
            Name = "Temperature";
           // Unit.Temperature.Count = 1;
        }


        public Temperature(double value, TemperatureUnit unit) :this()
        {
            //UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            //ReturnInThisUnitSystem.Temperature.SelectedUnit = unit;
            //ReturnInThisUnitSystem.Temperature.Count = 1;


            ////Convert to 'local' unit
            //ValueLocalUnit = UnitSystem.GetLocalUnit(value, ReturnInThisUnitSystem);
            //Unit = ReturnInThisUnitSystem;


            Unit.Temperature = unit;
            //ValueLocalUnit = Unit.ReturnLocalValue((decimal)value);
            SetLocalValue((decimal)value);
        }

        public static Temperature From(double value, TemperatureUnit unit)
        {
            return new Temperature(value, unit);
        }

        public decimal As(TemperatureUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Temperature = ReturnInThisUnit;
            ReturnInThisUnitSystem.Temperature.Count = 1;


            return ToTheOutSide(ReturnInThisUnitSystem) / 1.000000000000000000000000000000000m;
        }




        //Every units needs this
        public static implicit operator Temperature(UnknownUnit Unit)
        {
            Temperature local = new Temperature(0, TemperatureUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}

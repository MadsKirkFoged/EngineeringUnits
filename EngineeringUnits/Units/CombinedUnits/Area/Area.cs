using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {

        public Area()
        {
            unitsystem.Length.Count = 2;
        }

        public Area(double value, LengthUnit SquaredlengthUnit) : this()
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Length.SelectedUnit = SquaredlengthUnit;
            ReturnInThisUnitSystem.Length.Count = 2;

            //Convert to 'local' unit
            ValueLocalUnit = UnitSystem.GetLocalUnit(value, ReturnInThisUnitSystem);
            unitsystem = ReturnInThisUnitSystem;
        }

        public static Area From(double value, LengthUnit unit)
        {
            return new Area(value, unit);
        }

        public decimal As(LengthUnit SquaredlengthUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Length.SelectedUnit = SquaredlengthUnit;
            ReturnInThisUnitSystem.Length.Count = 2;

            return unitsystem.ToTheOutSide(ValueLocalUnit, ReturnInThisUnitSystem) / 1.000000000000000000000000000000000m;
        }

        //public void ChangeUnitTo(LengthUnit ReturnInThisUnit)
        //{
        //    double Vector = UnitSystem.VectorDifferent(unitsystem.SelectedLengthUnit, ReturnInThisUnit);
        //    Value *= Vector;

        //    unitsystem.SelectedLengthUnit = ReturnInThisUnit;
        //}


        //Every units needs this
        public static implicit operator Area(UnknownUnit Unit)
        {
            Area local = new Area();

            if (local.unitsystem != Unit.baseUnit.unitsystem)
            {
                throw new InvalidOperationException("Units did not result in Area!");
            }

            local.ValueLocalUnit = Unit.baseUnit.ValueLocalUnit;
            local.unitsystem = Unit.baseUnit.unitsystem;

            return local;
        }




    }
}

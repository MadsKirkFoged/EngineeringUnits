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

        public Area(double value, LengthUnit unit) : this()
        {
            //unitsystem.SelectedLengthUnit = unit;
            base.Value = value;
        }

        public static Area From(double value, LengthUnit unit)
        {
            return new Area(value, unit);
        }

        //public double As(LengthUnit ReturnInThisUnit)
        //{
        //    return UnitSystem.VectorDifferent(unitsystem.SelectedLengthUnit, ReturnInThisUnit) * Value;
        //}

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

            local.Value = Unit.baseUnit.Value;
            local.unitsystem = Unit.baseUnit.unitsystem;

            return local;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Length : BaseUnit
    {

        public Length()
        {
            unitsystem.LengthCount = 1;
        }


        public Length(double value, LengthUnit? unit) :this()
        {
            unitsystem.SetUnit(unit);
            base.Value = value;
        }

        public static Length From(double value, LengthUnit unit)
        {
            return new Length(value, unit);
        }

        public double As(LengthUnit ReturnInThisUnit)
        {
            return UnitSystem.Convert(Value,unitsystem.SelectedLengthUnit, ReturnInThisUnit);
        }


        public void PermanentChangeUnitTo(LengthUnit ReturnInThisUnit)
        {

            Value = As(ReturnInThisUnit);
            unitsystem.SelectedLengthUnit = ReturnInThisUnit;
        }


        //Every units needs this
        public static implicit operator Length(UnknownUnit Unit)
        {
            Length local = new Length();

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

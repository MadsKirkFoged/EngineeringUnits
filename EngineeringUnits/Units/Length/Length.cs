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
            unitsystem.Length.Count = 1;
        }


        public Length(double value, LengthUnit unit) :this()
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

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Length.SelectedUnit = ReturnInThisUnit;
            ReturnInThisUnitSystem.Length.Count = 1;


            return UnitSystem.Convert(Value, this.unitsystem, ReturnInThisUnitSystem);
        }


        public void PermanentChangeUnitTo(LengthUnit ReturnInThisUnit)
        {

            Value = As(ReturnInThisUnit);
            unitsystem.Length.SelectedUnit = ReturnInThisUnit;
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Amount : BaseUnit
    {

        public Amount()
        {
            Unit.Amount.Count = 1;
        }


        public Amount(double value, AmountOfSubstanceUnit unit) :this()
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Amount.SelectedUnit = unit;
            ReturnInThisUnitSystem.Amount.Count = 1;


            //Convert to 'local' unit
            ValueLocalUnit = UnitSystem.GetLocalUnit(value, ReturnInThisUnitSystem);
            Unit = ReturnInThisUnitSystem;

        }

        public static Amount From(double value, AmountOfSubstanceUnit unit)
        {
            return new Amount(value, unit);
        }

        public decimal As(LengthUnit ReturnInThisUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Amount.SelectedUnit = ReturnInThisUnit;
            ReturnInThisUnitSystem.Amount.Count = 1;

            return Unit.ToTheOutSide(ValueLocalUnit, ReturnInThisUnitSystem) / 1.000000000000000000000000000000000m;

        }


        public void PermanentChangeUnitTo(LengthUnit ReturnInThisUnit)
        {

            //Value = As(ReturnInThisUnit);
            Unit.Length.SelectedUnit = ReturnInThisUnit;
        }


        //Every units needs this
        public static implicit operator Amount(UnknownUnit Unit)
        {
            Amount local = new Amount();

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

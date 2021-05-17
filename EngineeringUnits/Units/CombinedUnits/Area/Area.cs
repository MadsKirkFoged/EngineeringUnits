using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {

        public Area()
        {
            UnitList.LengthCount = 2;
        }

        public Area(double value, LengthUnit? unit) : this()
        {
            UnitList.SelectedLengthUnit = unit;
            base.Value = value;
        }

        public static Area From(double value, LengthUnit unit)
        {
            return new Area(value, unit);
        }

        public double As(LengthUnit ReturnInThisUnit)
        {
            return UnitSystem.VectorDifferent(UnitList.SelectedLengthUnit, ReturnInThisUnit) * Value;
        }

        public void ChangeUnitTo(LengthUnit ReturnInThisUnit)
        {
            double Vector = UnitSystem.VectorDifferent(UnitList.SelectedLengthUnit, ReturnInThisUnit);
            Value *= Vector;

            UnitList.SelectedLengthUnit = ReturnInThisUnit;
        }


        //Every units needs this
        public static implicit operator Area(UnknownUnit Unit)
        {
            Area local = new Area();

            if (local.UnitList != Unit.baseUnit.UnitList)
            {
                throw new InvalidOperationException("Units did not result in Area!");
            }

            local.Value = Unit.baseUnit.Value;
            local.UnitList = Unit.baseUnit.UnitList;

            return local;
        }




    }
}

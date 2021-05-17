using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {
        public LengthUnits? SelectedUnit
        {
            get { return UnitList.SelectedLengthUnit; }
            set { UnitList.SelectedLengthUnit = value; }
        }

        public Area()
        {
            UnitList.LengthCount = 2;
        }

        public Area(double value, LengthUnits? unit) : this()
        {
            SelectedUnit = unit;
            base.Value = value;
        }

        public static Area From(double value, LengthUnits unit)
        {
            return new Area(value, unit);
        }

        public double To(LengthUnits ReturnInThisUnit)
        {
            return UnitStore.VectorDifferent(SelectedUnit, ReturnInThisUnit) * Value;
        }

        public void ChangeUnitTo(LengthUnits ReturnInThisUnit)
        {
            double Vector = UnitStore.VectorDifferent(SelectedUnit, ReturnInThisUnit);
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

        //Every units needs this

        public static UnknownUnit operator *(Area a, BaseUnit b) => BaseUnit.Multiply(a, b);
        public static UnknownUnit operator /(Area a, BaseUnit b) => BaseUnit.Divide(a, b);
        public static Area operator +(Area a, Area b) => BaseUnit.Add(a, b);
        public static Area operator -(Area a, Area b) => BaseUnit.Subtract(a, b);
    



    }
}

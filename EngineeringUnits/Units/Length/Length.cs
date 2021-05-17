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
            UnitList.LengthCount = 1;
        }


        public Length(double value, LengthUnit? unit) :this()
        {
            UnitList.SetUnit(unit);
            base.Value = value;
        }

        public static Length From(double value, LengthUnit unit)
        {
            return new Length(value, unit);
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
        public static implicit operator Length(UnknownUnit Unit)
        {
            Length local = new Length();

            if (local.UnitList != Unit.baseUnit.UnitList)
            {
                throw new InvalidOperationException("Units did not result in Length!");
            }

            local.Value = Unit.baseUnit.Value;
            local.UnitList = Unit.baseUnit.UnitList;

            return local;
        }
        
        //Every units needs this

        //public static UnknownUnit operator *(Length a, BaseUnit b) => BaseUnit.Multiply(a,b);
        //public static UnknownUnit operator *(Length a, double b) => BaseUnit.Multiply(a,b);
        //public static UnknownUnit operator *(double a, Length b) => BaseUnit.Multiply(b,a);
        //public static UnknownUnit operator /(Length a, BaseUnit b) => BaseUnit.Divide(a,b);
        //public static UnknownUnit operator /(Length a, double b) => BaseUnit.Divide(a,b);
        //public static UnknownUnit operator /(double a, Length b) => BaseUnit.Divide(a,b);
        //public static double operator /(Length a, Length b) => BaseUnit.DivideResultsInDouble(a, b);
        //public static Length operator +(Length a, Length b) => BaseUnit.Add(a, b);
        //public static Length operator -(Length a, Length b) => BaseUnit.Subtract(a, b);

    }
}

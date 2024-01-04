using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using System;
using System.Diagnostics;
using System.Globalization;

namespace EngineeringUnits
{

    // UnknownUnit is just a copy of a BaseUnit
    // At first we tried not having the class but we got errors from the implicit operators
    // All calculations between two units gets converted into an UnknownUnit
    // --> ex lenght / duration turns into a UnknownUnit
    // --> because at this time the unit is Unknown
    // --> If you try to convert it into a Power then you get a WrongUnitException
    // --> You can only convert it into the correct unit (in this case 'Speed')

    public class UnknownUnit: BaseUnit
    {


        public UnknownUnit() : base() { }

        public UnknownUnit(double valueLocalUnit) : base(valueLocalUnit) { }
        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) : base(valueLocalUnit, unitsystem) { }
        public UnknownUnit(decimal valueLocalUnit, UnitSystem unitsystem) : base(valueLocalUnit, unitsystem) { }
        public UnknownUnit(BaseUnit baseunit) : base(baseunit) { }

        public static UnknownUnit operator *(UnknownUnit left, UnknownUnit right)
        {
            if (left is null || right is null)
                return null;

            try
            {
                var NewTestValue = left.NEWValue * right.NEWValue;

                return new UnknownUnit(NewTestValue, left.Unit * right.Unit);

            }
            catch (OverflowException)
            {
                return new UnknownUnit(double.PositiveInfinity, left.Unit * right.Unit);
            }
        }
        public static UnknownUnit operator /(UnknownUnit left, UnknownUnit right)
        {
            if (left is null || right is null)
                return null;

            if (right.NEWValue == 0m)
                return new UnknownUnit(double.PositiveInfinity, left.Unit / right.Unit);

            try
            {
                var NewTestValue = left.NEWValue / right.NEWValue;

                return new UnknownUnit(NewTestValue, left.Unit / right.Unit);

            }
            catch (OverflowException)
            {
                return new UnknownUnit(double.PositiveInfinity, left.Unit / right.Unit);
            }
        }


        public static implicit operator double(UnknownUnit Unit)
        {
            if (UnitSystemExtensions.UnitsystemForDouble != Unit)            
                throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");
            

            return (double)Unit.GetValueAs(UnitSystemExtensions.UnitsystemForDouble);
        }
        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.Unit)            
                throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");
            

            return Unit.GetValueAs(new UnitSystem());
        }



        public override string ToString()
        {
            var CastingUnit = this.IntelligentCast();

            if (CastingUnit is null)
                return base.ToString();
            

            return CastingUnit.ToString();
        }
        public override string ToString(IFormatProvider provider)
        {
            var CastingUnit = this.IntelligentCast();

            if (CastingUnit is null)
                return base.ToString(provider);


            return this.IntelligentCast().ToString(provider);
        }
        public override string ToString(string format)
        {
            var CastingUnit = this.IntelligentCast();

            if (CastingUnit is null)
                return base.ToString(format);

            return this.IntelligentCast().ToString(format);
        }
        public override string ToString(string format, IFormatProvider provider)
        {
            var CastingUnit = this.IntelligentCast();

            if (CastingUnit is null)
                return base.ToString(format, provider);

            return this.IntelligentCast().ToString(format, provider);
        }

    }
}

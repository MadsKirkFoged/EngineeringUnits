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

    public class UnknownUnit: IEquatable<UnknownUnit>, IComparable, IComparable<UnknownUnit>, IUnitSystem, IFormattable
    {
        public BaseUnit BaseUnit { get; init; }


        public UnknownUnit() => BaseUnit = new BaseUnit();
        public UnknownUnit(double valueLocalUnit) => BaseUnit = new BaseUnit(valueLocalUnit, new UnitSystem());
        public UnknownUnit(double valueLocalUnit, UnitSystem unitsystem) => BaseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(decimal valueLocalUnit, UnitSystem unitsystem) => BaseUnit = new BaseUnit(valueLocalUnit, unitsystem);
        public UnknownUnit(BaseUnit baseunit) => BaseUnit = baseunit;
 

        public static UnknownUnit operator *(UnknownUnit left, UnknownUnit right) => left?.BaseUnit * right?.BaseUnit;
        public static UnknownUnit operator /(UnknownUnit left, UnknownUnit right) => left?.BaseUnit / right?.BaseUnit;
        public static UnknownUnit operator +(UnknownUnit left, UnknownUnit right) => left?.BaseUnit + right?.BaseUnit;
        public static UnknownUnit operator -(UnknownUnit left, UnknownUnit right) => left?.BaseUnit - right?.BaseUnit;

        public static bool operator ==(UnknownUnit left, UnknownUnit right) => left?.BaseUnit == right?.BaseUnit;
        public static bool operator !=(UnknownUnit left, UnknownUnit right) => left?.BaseUnit != right?.BaseUnit;
        public static bool operator <=(UnknownUnit left, UnknownUnit right) => left?.BaseUnit <= right?.BaseUnit;
        public static bool operator >=(UnknownUnit left, UnknownUnit right) => left?.BaseUnit >= right?.BaseUnit;
        public static bool operator < (UnknownUnit left, UnknownUnit right) => left?.BaseUnit < right?.BaseUnit;
        public static bool operator > (UnknownUnit left, UnknownUnit right) => left?.BaseUnit > right?.BaseUnit;


        public static implicit operator double(UnknownUnit Unit)
        {
            if (UnitSystem.UnitsystemForDouble != Unit.BaseUnit.Unit)            
                throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");
            

            return (double)Unit.BaseUnit.GetValueAs(UnitSystem.UnitsystemForDouble);
        }
        public static implicit operator UnknownUnit(double Unit) => new (Unit);
        public static implicit operator UnknownUnit(int Unit) => new (Unit);
        public static explicit operator decimal(UnknownUnit Unit)
        {
            if (new UnitSystem() != Unit.BaseUnit.Unit)            
                throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");
            

            return Unit.BaseUnit.GetValueAs(new UnitSystem());
        }
        public static explicit operator BaseUnit(UnknownUnit Unit)
        {
            if (Unit is null)
                return null;
            

            return Unit.BaseUnit;
        }


        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => BaseUnit.Value;
        public decimal SI => BaseUnit.GetBaseValue();

        public UnitSystem Unit 
        { 
            get => BaseUnit.Unit; 
            init => throw new MemberAccessException("UnknownUnit cant init the Unitsystem!"); 
        }

        public override string ToString()
        {
            if (BaseUnit.Unit.Symbol is not null)            
                return BaseUnit.ToString();            

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString();
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (BaseUnit.Unit.Symbol is not null)
                return BaseUnit.ToString(format, provider);

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString(format, provider);


        }

        public string ToString(string format)
        {
            if (BaseUnit.Unit.Symbol is not null)
                return BaseUnit.ToString(format);

            BaseUnit simple = this.IntelligentCast();
            return simple.ToString(format);


        }

        public override int GetHashCode() => BaseUnit.GetHashCode();

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return this == (UnknownUnit)obj;
        }


        public bool Equals(UnknownUnit other)
        {
             return this == other;
        }

        public int CompareTo(object obj)
        {
            UnknownUnit local = (UnknownUnit)obj;
            return CompareTo(local);
        }

        public int CompareTo(UnknownUnit other)
        {
           if(Unit != other.Unit)            
                throw new WrongUnitException($"Cannot do Compare two different units!");

            return (this - other).SI switch
            {
                0m => 0,
                <0m => -1,
                >0m => 1,
            };
           
        }

        public void UnitCheck(IUnitSystem a)
        {
            BaseUnit.UnitCheck(a);
        }

    }
}

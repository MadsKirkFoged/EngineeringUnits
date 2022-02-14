using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System;

namespace EngineeringUnits
{


    [JsonObject(MemberSerialization.Fields)]
    public class BaseUnit : IComparable
    {

        public bool Inf { get; init; }
        public UnitSystem Unit { get; init;}

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => SI;

        public decimal NEWValue { get; set; }


        public BaseUnit() {}

        public BaseUnit(decimal value, UnitSystem unitSystem)
        {
            Unit = new UnitSystem(unitSystem, GetStandardSymbol(unitSystem));
            NEWValue = value.Normalize();
        }

        public BaseUnit(double value, UnitSystem unitSystem)
        {
            Unit = new UnitSystem(unitSystem, GetStandardSymbol(unitSystem));

            if (IsValueOverDecimalMax(value))            
                Inf = true;        
            else
            {
                Inf = false;
                NEWValue = (decimal)value;
            }
        }

        public BaseUnit(int value, UnitSystem unitSystem)
        {
            Unit = new UnitSystem(unitSystem, GetStandardSymbol(unitSystem));
            NEWValue = (decimal)value;
        }

        public BaseUnit(UnknownUnit unit)
        {
            Unit = new UnitSystem(unit.unitsystem, GetStandardSymbol(unit.unitsystem));
            NEWValue = unit.baseUnit.NEWValue;
        }


        public double As(UnitSystem a)
        {
            return (double)ToTheOutSide(a);                     
        }

        public double As(BaseUnit a)
        { 
            return As(a.Unit); 
        }

        public double SI => (double)(NEWValue * (decimal)Unit.SumConstant());

        public void UnitCheck(UnknownUnit a) => UnitCheck(a.unitsystem);

        public void UnitCheck(UnitSystem a)
        {
            if (a != Unit)
                throw new WrongUnitException($"This is NOT a [{Unit}] as expected! Your Unit is a [{a}]");
        }

        public BaseUnit ToUnit(Enumeration selectedUnit)
        {
            //Add Unit check!
            UnitCheck(selectedUnit.Unit);

            return new(ToTheOutSide(selectedUnit.Unit), selectedUnit.Unit);
        }


        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            return AddUnits(left, right);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {
            return SubtractUnits(left, right);
        }
        public static UnknownUnit operator *(BaseUnit left, BaseUnit right)
        {
            return MultiplyUnits(left, right);
        }
        public static UnknownUnit operator /(BaseUnit left, BaseUnit right)
        {
            return DivideUnits(left, right);
        }

        public static UnknownUnit operator /(BaseUnit left, UnknownUnit right)
        {
            return left / right.baseUnit;
        }
        public static UnknownUnit operator /(UnknownUnit left, BaseUnit right)
        {
            return left.baseUnit / right;
        }
        public static UnknownUnit operator *(BaseUnit left, UnknownUnit right)
        {
            return left * right.baseUnit;
        }
        public static UnknownUnit operator *(UnknownUnit left, BaseUnit right)
        {
            return left.baseUnit * right;
        }


        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))            
                return false;            
            else          
                return this == (BaseUnit)obj;            
        }
        public static bool operator ==(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] == [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue == right.ToTheOutSide(left.Unit); 
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] != [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue != right.ToTheOutSide(left.Unit);
        }
        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] <= [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue <= right.ToTheOutSide(left.Unit);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] >= [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue >= right.ToTheOutSide(left.Unit);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] < [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue < right.ToTheOutSide(left.Unit);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] > [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue > right.ToTheOutSide(left.Unit);
        }

        public static implicit operator UnknownUnit(BaseUnit baseUnit)
        {
            return new(baseUnit);
        }


        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString() => ToString("g4");
        

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString(IFormatProvider provider) => ToString("g", provider);      

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentUICulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format) => ToString(format, CultureInfo.CurrentUICulture);
        

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider provider)
        {
            if (Inf)
            {
                return $"{double.PositiveInfinity.ToString(format)} {Unit}";
            }

            //Are As(Unit) and NewValue not always the same?
            return $"{As(Unit).ToString(format)} {Unit}";
        }


        public Fraction ConvertionFactor(BaseUnit To)
        {
            return Unit.SumConstant() / To.Unit.SumConstant();
        }
        public decimal ConvertValueInto(BaseUnit From)
        {
            return (decimal)ConvertionFactor(From) * NEWValue;
        }


        private static BaseUnit AddUnits(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] + [{right.Unit}]. Can't add two different units!");


            try
            {
                var NewTestValue = left.NEWValue + right.ConvertValueInto(left);

                return new BaseUnit(NewTestValue, left.Unit + right.Unit);

            }
            catch (OverflowException)
            {
                return new BaseUnit(double.PositiveInfinity, left.Unit + right.Unit);
            }

        }
        private static BaseUnit SubtractUnits(BaseUnit left, BaseUnit right)
        {

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] - [{right.Unit}]. Can't subtract two different units!");


            try
            {
                var NewTestValue = left.NEWValue - right.ConvertValueInto(left);                

                return new BaseUnit(NewTestValue, left.Unit - right.Unit);

            }
            catch (OverflowException)
            {
                return new BaseUnit(double.PositiveInfinity, left.Unit - right.Unit);
            }

        }
        private static BaseUnit MultiplyUnits(BaseUnit left, BaseUnit right)
        {

            try
            {
                var NewTestValue = left.NEWValue * right.NEWValue;

                return new BaseUnit(NewTestValue, left.Unit * right.Unit);

            }
            catch (OverflowException)
            {
                return new BaseUnit(double.PositiveInfinity, left.Unit * right.Unit);
            }

        }
        private static BaseUnit DivideUnits(BaseUnit left, BaseUnit right)
        {

            if (right.NEWValue == 0)            
                return new BaseUnit(double.PositiveInfinity, left.Unit / right.Unit);
            


            try
            {
                var NewTestValue = left.NEWValue / right.NEWValue;

                return new BaseUnit(NewTestValue, left.Unit / right.Unit);

            }
            catch (OverflowException)
            {
                return new BaseUnit(double.PositiveInfinity, left.Unit / right.Unit);
            }

        }



        //public UnknownUnit Sqrt()
        //{
        //    return new BaseUnit(NewValue.Sqrt(), Unit.Sqrt());
        //}

        public UnknownUnit Abs()
        {
            if (NEWValue < 0)
                return this * -1;
            else         
                return this;
        }

        public UnknownUnit Pow(int toPower)
        {

            UnknownUnit localtest = this;
            
            if (toPower == 0)
                return 1;


            if (toPower > 1)            
                for (int i = 1; i < toPower; i++)
                    localtest *= this;


            if (toPower < 0)            
                for (int i = 1; i > toPower; i--)
                    localtest /= this;            



            return localtest;
        }

        public UnknownUnit InRangeOf(UnknownUnit Min, UnknownUnit Max)
        {

            UnitCheck(Min);
            UnitCheck(Max);

            if (Max < Min)
            {
                //TODO you need max to be larger then min
                return this;
            }


            if (this < Min)            
                return Min;
            

            if (this > Max)            
                return Max;
            

            return this;

            
        }

        public bool IsZero()
        {
            return NEWValue == 0;
        }

        public bool IsNotZero()
        {
            return !IsZero();
        }

        //Add isAboveZero

        //Add isBelowZero
        

        public decimal ToTheOutSide(UnitSystem To)
        {

            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();     
            Fraction Factor = To.ConvertionFactor(Unit);


            Fraction b3test2 = Factor * (b1 * -1) + b2;
            Fraction y2test2 = Factor * (Fraction)NEWValue + b3test2;    

            return (decimal)y2test2;
        }

        public double ToTheOutSideDouble(UnitSystem To)
        {
            if (Inf)
                return double.PositiveInfinity;

            return (double)ToTheOutSide(To);
        }


        public string DisplaySymbol()
        {
            return Unit.ToString();
        }

        public int CompareTo(object obj)
        {
            BaseUnit local = (BaseUnit)obj; 

            if (Unit != local.Unit)            
                throw new WrongUnitException($"Cant do CompareTo on two differnt units!");
            

            return (int)((double)NEWValue - local.As(this));
        }   
       

        public override int GetHashCode()
        {
            HashCode hashCode = new HashCode();
            hashCode.Add(NEWValue);
            hashCode.Add(Unit.GetHashCode());

            return hashCode.ToHashCode();
        }

        public string GetStandardSymbol<T>(UnitSystem _unit)
            where T : Enumeration
        {

            if (_unit.Symbol is not null)
                return _unit.Symbol;


            //This check the list of Predefined unit and if it finds a match it returns that Symbol
            return Enumeration.ListOf<T>()
                .Find(x => x.Unit.SumConstant() == _unit.SumConstant())?
                .Unit.Symbol;            
        }

        public virtual string GetStandardSymbol(UnitSystem _unit)
        {
            if (_unit.Symbol is not null)
                return _unit.Symbol;

            return null;
        }

        private bool IsValueOverDecimalMax(double value)
        {
            return double.IsInfinity(value) || value > (double)decimal.MaxValue || value < (double)decimal.MinValue || double.IsNaN(value);
        }
        


    }


}

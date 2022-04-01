using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System;
using System.Linq;

namespace EngineeringUnits
{


    [JsonObject(MemberSerialization.Fields)]
    public class BaseUnit : IEquatable<BaseUnit>, IComparable, IComparable<BaseUnit>, IFormattable, IUnitSystem
    {

        protected bool Inf { get; init; }
        public UnitSystem Unit { get; init;}

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => (double)SI;
        public decimal NEWValue { get; init; }

        public BaseUnit() {}
        public BaseUnit(decimal value, UnitSystem unitSystem)
        {
            Unit = unitSystem;
            NEWValue = value;
        }
        public BaseUnit(double value, UnitSystem unitSystem)
        {
            Unit = unitSystem;

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
            Unit = unitSystem;

            NEWValue = (decimal)value;
        }
        protected BaseUnit(UnknownUnit unit)
        {
            Unit = unit.Unit;
            NEWValue = unit.BaseUnit.NEWValue;
        }

        public decimal SI => (NEWValue * (decimal)Unit.SumConstant());

        public void UnitCheck(IUnitSystem a)
        {
            if (a.Unit != Unit)
                throw new WrongUnitException($"This is NOT a [{Unit}] as expected! Your Unit is a [{a.Unit}]");
        }

        public void UnitCheck(UnitSystem a)
        {
            if (a != Unit)
                throw new WrongUnitException($"This is NOT a [{Unit}] as expected! Your Unit is a [{a}]");
        }

        public static void UnitCheck(UnitSystem a, UnitSystem b)
        {
            if (a != b)
                throw new WrongUnitException($"This is NOT a [{b}] as expected! Your Unit is a [{a}]");
        }

        public static void UnitCheck(IUnitSystem a, IUnitSystem b)
        {
            if (a.Unit != b.Unit)
                throw new WrongUnitException($"This is NOT a [{b.Unit}] as expected! Your Unit is a [{a.Unit}]");
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
            return left / right.BaseUnit;
        }
        public static UnknownUnit operator /(UnknownUnit left, BaseUnit right)
        {
            return left.BaseUnit / right;
        }
        public static UnknownUnit operator *(BaseUnit left, UnknownUnit right)
        {
            return left * right.BaseUnit;
        }
        public static UnknownUnit operator *(UnknownUnit left, BaseUnit right)
        {
            return left.BaseUnit * right;
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
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.InvariantCulture" /> if null.</param>
        public string ToString(IFormatProvider provider) => ToString("g4", provider);

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.InvariantCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format) => ToString(format, CultureInfo.InvariantCulture);

        private static readonly char[] UnitFormatSpecifiers = { 'A', 'a', 'Q', 'q', 'U', 'u', 'V', 'v' };

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider provider)
        {

            if (format is null)
                format = "g4";

            if (provider is null)
                provider = CultureInfo.InvariantCulture;



            if (UnitFormatSpecifiers.Any(x => x == format[0]))
            {
                return format[0] switch
                {
                    'A'or'a' => GetStandardSymbol(Unit).ToString(),//return Unit.ToString();
                    'V'or'v' => NEWValue.ToString(provider),
                    'U'or'u' => GetStandardSymbol(Unit).ToString(),//return Unit.ToString();
                    'Q'or'q' => GetStandardSymbol(Unit).ToString(),//return Unit.ToString();
                    _ => throw new FormatException($"The {format} format string is not supported."),
                };
            }



            if (Inf)
            {
                return $"{double.PositiveInfinity.ToString(format, provider)} {GetStandardSymbol(Unit)}";
            }


            return $"{NEWValue.ToString(format, provider)} {GetStandardSymbol(Unit)}";
        }

        
        private Fraction ConvertionFactor(BaseUnit To)
        {
            return Unit.SumConstant() / To.Unit.SumConstant();
        }
        private decimal ConvertValueInto(BaseUnit From)
        {
            return (decimal)ConvertionFactor(From) * NEWValue;
        }


        private static UnknownUnit AddUnits(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new WrongUnitException($"Trying to do [{left.Unit}] + [{right.Unit}]. Can't add two different units!");
            }


            try
            {

                if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())                
                    return new UnknownUnit(left.NEWValue + right.NEWValue, left.Unit);                

                return new UnknownUnit(left.NEWValue + right.ConvertValueInto(left), left.Unit);

            }
            catch (OverflowException)
            {
                return new UnknownUnit(double.PositiveInfinity, left.Unit + right.Unit);
            }

        }
        private static UnknownUnit SubtractUnits(BaseUnit left, BaseUnit right)
        {

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] - [{right.Unit}]. Can't subtract two different units!");


            try
            {
                if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
                    return new UnknownUnit(left.NEWValue - right.NEWValue, left.Unit);

                return new UnknownUnit(left.NEWValue - right.ConvertValueInto(left), left.Unit);

            }
            catch (OverflowException)
            {
                return new UnknownUnit(double.PositiveInfinity, left.Unit - right.Unit);
            }

        }
        private static UnknownUnit MultiplyUnits(BaseUnit left, BaseUnit right)
        {

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
        private static UnknownUnit DivideUnits(BaseUnit left, BaseUnit right)
        {

            if (right.NEWValue == 0)            
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



        public decimal ToTheOutSide(UnitSystem To)
        {
            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();     
            Fraction Factor = To.ConvertionFactor(Unit);

            Fraction y2test2;

            if (b1.IsZero && b2.IsZero)
            {
                y2test2 = Factor * (Fraction)NEWValue;
            }
            else
            {
                Fraction b3test2 = Factor * (b1 * -1) + b2;
                y2test2 = Factor * (Fraction)NEWValue + b3test2;

            }



            //Fraction b3test2 = Factor * (b1 * -1) + b2;
            //y2test2 = Factor * (Fraction)NEWValue + b3test2;    

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
            return Unit.ReduceUnits().ToString();
        }


        public override int GetHashCode()
        {
            HashCode hashCode = new();
            hashCode.Add(NEWValue);
            hashCode.Add(Unit.GetHashCode());

            return hashCode.ToHashCode();
        }

        public static string GetStandardSymbol<T>(UnitSystem _unit)
            where T : UnitTypebase
        {

            if (_unit.Symbol is not null)
                return _unit.Symbol;


            //foreach (var item in Enumeration.ListOf<T>())
            //{
            //    Debug.Print($"{item.Unit.SumConstant()} = {_unit.SumConstant()}");
            //    Debug.Print($"{item.Unit}");
            //}


            //This check the list of Predefined unit and if it finds a match it returns that Symbol
            return UnitTypebase.ListOf<T>()
                .Find(x => x.Unit.SumConstant() == _unit.SumConstant())?
                .Unit.ToString();            
        }
        public virtual string GetStandardSymbol(UnitSystem _unit)
        {
            if (_unit.Symbol is not null)
                return _unit.Symbol;

            return $"{_unit}";

            //return null;
        }

        private static bool IsValueOverDecimalMax(double value)
        {
            return double.IsInfinity(value) || 
                    value > (double)decimal.MaxValue || 
                    value < (double)decimal.MinValue || 
                    double.IsNaN(value);
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return this == (BaseUnit)obj;
        }

        public bool Equals(BaseUnit other)
        {
            return this == other;
        }

        public int CompareTo(object obj)
        {
            BaseUnit local = (BaseUnit)obj;

            //if (Unit != local.Unit)
            //    throw new WrongUnitException($"Cant do CompareTo on two differnt units!");


            //return (int)((double)NEWValue - local.As(this));
            return CompareTo(local);

        }

        public int CompareTo(BaseUnit other)
        {

            if (Unit != other.Unit)
                throw new WrongUnitException($"Cant do CompareTo on two differnt units!");

          //  return (int)((double)NEWValue - other.As(this));

            var compare = ((double)NEWValue - (double)other.As(this))
;
            var result = compare switch
            {
                0 => 0,
                < 0 => -1,
                > 0 => 1,
            };
            //return (int)((double)_baseUnit.NEWValue - other._baseUnit.As(this._baseUnit));
            return (int)result;
        }

    }


}

using Fractions;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace EngineeringUnits
{
    //The baseunit is inherited by all other unit.
    //It stores the value and the unitsystem

    [JsonObject(MemberSerialization.Fields)]
    public class BaseUnit : IEquatable<BaseUnit>, IComparable, IComparable<BaseUnit>, IFormattable
    {

        internal bool Inf { get; init; }
        internal bool IsNaN { get; init; }
        internal UnitSystem Unit { get; init; }

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => (double)this.GetBaseValue();
        internal decimal NEWValue { get; init; }

        public BaseUnit() { }
        public BaseUnit(decimal value, UnitSystem unitSystem)
        {
            Unit = unitSystem;
            NEWValue = value;
        }
        public BaseUnit(double value, UnitSystem unitSystem)
        {
            Unit = unitSystem;

            if (double.IsNaN(value))
            {
                IsNaN = true;
                return;
            }

            if (value.IsValueOverDecimalMax())
            {
                Inf = true;
                return;
            }

            Inf = false;
            NEWValue = (decimal)value;

        }
        public BaseUnit(int value, UnitSystem unitSystem)
        {
            Unit = unitSystem;
            NEWValue = value;
        }
        protected BaseUnit(UnknownUnit unit)
        {
            Unit = unit.Unit;
            NEWValue = unit.BaseUnit.NEWValue;
        }

       
        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            if (left is null || right is null)
                return null;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] + [{right.Unit}]. Can't add two different units!");

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
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {
            if (left is null || right is null)
                return null;

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
        public static UnknownUnit operator *(BaseUnit left, BaseUnit right)
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
        public static UnknownUnit operator /(BaseUnit left, BaseUnit right)
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

        public static UnknownUnit operator /(BaseUnit left, UnknownUnit right)
        {
            return left / right?.BaseUnit;
        }
        public static UnknownUnit operator /(UnknownUnit left, BaseUnit right)
        {
            return left?.BaseUnit / right;
        }
        public static UnknownUnit operator *(BaseUnit left, UnknownUnit right)
        {
            return left * right?.BaseUnit;
        }
        public static UnknownUnit operator *(UnknownUnit left, BaseUnit right)
        {
            return left?.BaseUnit * right;
        }

        public static bool operator ==(BaseUnit left, BaseUnit right)
        {
            if (left is null && right is null)
                return true;
            if (left is null || right is null)
                return false;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] == [{right.Unit}]. Can't compare two different units!");

            if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
                return left.NEWValue == right.NEWValue;

            return left.NEWValue == right.GetValueAs(left.Unit);
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left is null && right is null)
                return false;
            if (left is null || right is null)
                return true;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] != [{right.Unit}]. Can't compare two different units!");

            if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
                return left.NEWValue != right.NEWValue;

            return left.NEWValue != right.GetValueAs(left.Unit);
        }
        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left is null && right is null)
                return true;
            if (left is null || right is null)
                return false;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] <= [{right.Unit}]. Can't compare two different units!");

            if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
                return left.NEWValue <= right.NEWValue;

            return left.NEWValue <= right.GetValueAs(left.Unit);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left is null && right is null)
                return true;
            if (left is null || right is null)
                return false;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] >= [{right.Unit}]. Can't compare two different units!");

            if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
                return left.NEWValue >= right.NEWValue;

            return left.NEWValue >= right.GetValueAs(left.Unit);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left is null || right is null)
                return false;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] < [{right.Unit}]. Can't compare two different units!");

            if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
                return left.NEWValue < right.NEWValue;

            return left.NEWValue < right.GetValueAs(left.Unit);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left is null || right is null)
                return false;

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] > [{right.Unit}]. Can't compare two different units!");

            return left.NEWValue > right.GetValueAs(left.Unit);
        }

        public static implicit operator UnknownUnit(BaseUnit baseUnit)
        {
            if (baseUnit is null)
                return null;

            return new(baseUnit);
        }

        public static implicit operator UnitSystem(BaseUnit unit) => unit.Unit;

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

        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.InvariantCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format) => ToString(format, CultureInfo.InvariantCulture);

        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public virtual string ToString(string format, IFormatProvider provider)
        {
            if (format is null)
                format = "S4";

            if (provider is null)
                provider = CultureInfo.InvariantCulture;

            //Set unit
            var GetUnit = GetStandardSymbol(Unit);
            var ValueToDisplay = NEWValue;

            //It could not find a unit to display
            if (GetUnit is null)
            {
                var SIUnit = Unit.GetSIUnitsystem();
                var CorrectionToSI = SIUnit.ConvertionFactor(Unit);

                ValueToDisplay = (decimal)(CorrectionToSI * (Fraction)ValueToDisplay);
                GetUnit = GetStandardSymbol(SIUnit);
            }

            //Set value
            var value = format[0] switch
            {
                'A'or'a' => "",
                'U'or'u' => "",
                'Q'or'q' => "",
                'V'or'v' => ValueToDisplay.DisplaySignificantDigits(int.Parse(format.Remove(0, 1))),
                'S'or's' => ValueToDisplay.DisplaySignificantDigits(int.Parse(format.Remove(0, 1))),
                _ => ValueToDisplay.ToString(format, provider),
            };

            if (Inf && value != "")
                value = double.PositiveInfinity.ToString();

            if (IsNaN && value != "")
                value = double.NaN.ToString();



            var unit = format[0] switch
            {
                'A'or'a' => GetUnit,
                'U'or'u' => GetUnit,
                'Q'or'q' => GetUnit,
                'V'or'v' => "",
                _ => $" {GetUnit}",
            };

            //Merged and return       
            return $"{value}{unit}";
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

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;
            else
                return this == (BaseUnit)obj;
        }

        public bool Equals(BaseUnit other) => this == other;

        public int CompareTo(object obj)
        {
            var local = (BaseUnit)obj;

            return CompareTo(local);
        }

        public int CompareTo(BaseUnit other)
        {

            if (Unit != other.Unit)
                throw new WrongUnitException($"Cant do CompareTo on two differnt units!");
            ;
            return (this - other).SI switch
            {
                0m => 0,
                <0m => -1,
                >0m => 1,
            };
        }
    
    }
}

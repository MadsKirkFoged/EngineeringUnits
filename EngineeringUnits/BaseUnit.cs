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


    [JsonObject(MemberSerialization.OptIn)]
    public class BaseUnit : IComparable
    {

        public bool Inf { get; init; }

        [JsonProperty(PropertyName = "U", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public UnitSystem Unit { get; init;}

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        protected decimal SymbolValue { get; init; }
        public decimal BaseunitValue => SymbolValue * ConvertToBaseUnit();

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => (double)SymbolValue;

        [JsonConstructor]
        public BaseUnit()
        {
        }

        public BaseUnit(double valueLocalUnit) :this()
        {
            if (double.IsInfinity(valueLocalUnit) || valueLocalUnit > (double)decimal.MaxValue || valueLocalUnit < (double)decimal.MinValue || double.IsNaN(valueLocalUnit))
            {
                SymbolValue = 0;
                Inf = true;
            }
            else
            {                
                SymbolValue = (decimal)valueLocalUnit;
                Inf = false;
            }


        }


        public BaseUnit(decimal value, UnitSystem unitSystem)
        {
            //Unit = unitSystem.Copy();
            Unit = unitSystem;
            //SetValue(value);
            SymbolValue = value / 1.000000000000000000000000000000000m;
        }

        public BaseUnit(double value, UnitSystem unitSystem)
        {
            
            //Unit = unitSystem.Copy();
            Unit = unitSystem;

            if (double.IsInfinity(value) || value > (double)decimal.MaxValue || value < (double)decimal.MinValue || double.IsNaN(value))
            {
                Inf = true;
                SymbolValue = 0;           
            }
            else
            {
                Inf = false;
                SymbolValue = (decimal)value;         
            }
        }

        public BaseUnit(int value, UnitSystem unitSystem)
        {
            //Unit = unitSystem.Copy();
            Unit = unitSystem;
            SymbolValue = (decimal)value;
        }

        public BaseUnit(UnknownUnit unit)
        {

            Unit = unit.unitsystem;
            SymbolValue = unit.baseUnit.ToTheOutSide(Unit);


            UnitCheck(unit);
        }

        public BaseUnit(UnknownUnit unit, UnitSystem unitSystem)
        {
            if (unit.baseUnit.Unit.Symbol is null)            
                Unit = unitSystem;            
            else            
                Unit = unit.unitsystem;


            //SetValue(unit.baseUnit.ToTheOutSide(Unit));
            SymbolValue = unit.baseUnit.ToTheOutSide(Unit);
            Inf = unit.baseUnit.Inf;

            UnitCheck(unit);
        }


        public double As(UnitSystem a)
        {

            if (Unit is object)            
                return (double)ToTheOutSide(a);            
            else            
                return 0;           

        }

        public double As(BaseUnit a) => As(a.Unit);

        public void UnitCheck(UnknownUnit a)
        {

            if (a.unitsystem != Unit)
            {
                throw new WrongUnitException($"This is NOT a [{Unit}] as expected! Your Unit is a [{a.unitsystem}]");
            }

        }


        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new WrongUnitException($"Trying to do [{left.Unit}] + [{right.Unit}]. Can't add two different units!");            

            return BaseUnit.DoMath(left, right, MathEnum.Add);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {

            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] - [{right.Unit}]. Can't subtract two different units!");

            return BaseUnit.DoMath(left, right, MathEnum.Subtract);
        }

        public static UnknownUnit operator *(BaseUnit a, BaseUnit b) => BaseUnit.DoMath(a, b, MathEnum.Multiply);
        public static UnknownUnit operator /(BaseUnit a, BaseUnit b) => BaseUnit.DoMath(a, b, MathEnum.Divide);


        public static UnknownUnit operator /(BaseUnit left, UnknownUnit right) => left / right.baseUnit;
        public static UnknownUnit operator /(UnknownUnit left, BaseUnit right) => left.baseUnit / right;

        public static UnknownUnit operator *(BaseUnit left, UnknownUnit right) => left * right.baseUnit;
        public static UnknownUnit operator *(UnknownUnit left, BaseUnit right) => left.baseUnit * right;




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


            return (double)left.SymbolValue == right.As(left);
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] != [{right.Unit}]. Can't compare two different units!");

            return (double)left.SymbolValue != right.As(left);
        }
        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] <= [{right.Unit}]. Can't compare two different units!");

            return (double)left.SymbolValue <= right.As(left);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] >= [{right.Unit}]. Can't compare two different units!");

            return (double)left.SymbolValue >= right.As(left);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] < [{right.Unit}]. Can't compare two different units!");

            return (double)left.SymbolValue < right.As(left);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
                throw new WrongUnitException($"Trying to do [{left.Unit}] > [{right.Unit}]. Can't compare two different units!");

            return (double)left.SymbolValue > right.As(left);
        }

        public static implicit operator UnknownUnit(BaseUnit baseUnit) => new(baseUnit);
        


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


            if (Unit is null) //dimensionless            
            {
                if (Inf)
                    return $"{double.PositiveInfinity.ToString(format)}";

                return $"{SymbolValue.ToString(format)}";        
            } 


            if (Unit.Symbol is object)
            {
                if (Inf)
                    return $"{double.PositiveInfinity.ToString(format)} {Unit.Symbol}";

                return $"{SymbolValue.ToString(format)} {Unit.Symbol}";            
            }


            if (Inf)
                return $"{double.PositiveInfinity.ToString(format)} {Unit}";

            return $"{BaseunitValue.ToString(format)} {Unit}";         
        }

        public static UnknownUnit DoMath(BaseUnit left, BaseUnit right, MathEnum math)
        {

            //BaseUnit local = new();
            UnitSystem LocalUnit = new();
            bool LocalINF = false;
            decimal X3 = 0;


            //Turn both into Baseunits

            //Turn 'right' into lefts unitsystem
            decimal ConvertionsFactor = (decimal)UnitSystem.Convert(right.Unit.BaseUnitSystem(), left.Unit.BaseUnitSystem());
            decimal testRightConverted = right.BaseunitValue * ConvertionsFactor;

            switch (math)
            {
                case MathEnum.Add:                   

                    //Value math
                    X3 = left.BaseunitValue + testRightConverted;

                    //Unit math
                    LocalUnit = left.Unit + right.Unit;
                    break;
                case MathEnum.Subtract:

                    //Value math
                    X3 = left.BaseunitValue - testRightConverted;

                    //Unit math
                    //local.Unit = left.Unit- right.Unit;
                    LocalUnit = left.Unit - right.Unit;
                    break;
                case MathEnum.Multiply:

                    //Value math
                    X3 = left.BaseunitValue * testRightConverted;

                    //Unit math
                    //local.Unit = left.Unit * right.Unit;
                    LocalUnit = left.Unit * right.Unit;
                    break;
                case MathEnum.Divide:

                    //Value math
                    if (testRightConverted != 0)
                    {
                        X3 = left.BaseunitValue / testRightConverted;
                        LocalINF = false;
                    }
                    else
                    {
                        X3 = 0;
                        LocalINF = true;
                    }

                    //Unit math
                    LocalUnit = left.Unit / right.Unit;
                    break;
                default:
                    break;
            }

            if (left.Inf || right.Inf)
                LocalINF = true;

            //Convert back to New unitsystem
            decimal x3TestConvertedBack = X3 / LocalUnit.ConvertToBaseUnit();


            //return local;
            if (LocalINF)
            {
                return new BaseUnit(double.PositiveInfinity, LocalUnit);
            }
            else
            {
                return new BaseUnit(x3TestConvertedBack, LocalUnit);
            }
        }


        public UnknownUnit Sqrt()
        {

            UnitSystem local = Unit.Sqrt();           


            return new BaseUnit(Sqrt(SymbolValue), local);
        }


        public UnknownUnit Abs()
        {
            if (SymbolValue < 0)
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
            return BaseunitValue == 0;
        }

        public bool IsNotZero()
        {
            return !IsZero();
        }


        public decimal ConvertToBaseUnit() => (decimal)(Unit.GetCombi() / Unit.GetActualC());
        

        public decimal ToTheOutSide(UnitSystem To)
        {


            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();         

            Fraction test = UnitSystem.Convert(Unit, To);

            Fraction b3test = test * (b1 * -1) + b2;
            Fraction y2test = test * (Fraction)SymbolValue + b3test;
            return (decimal)y2test;
        }

        public double ToTheOutSideDouble(UnitSystem To)
        {
            if (Inf)
                return double.PositiveInfinity;

            return (double)ToTheOutSide(To);
        }


        public string DisplaySymbol()
        {
            if (Unit.Symbol is object)            
                return Unit.Symbol;            
            else
                return Unit.ToString();

        }

        public int CompareTo(object obj)
        {
            BaseUnit local = (BaseUnit)obj; 

            if (Unit != local.Unit)            
                throw new WrongUnitException($"Cant do CompareTo on two differnt units!");
            

            return (int)((double)SymbolValue - local.As(this));
        }
    
    
        public string ResultWithSymbol() => $"{SymbolValue} {Unit.Symbol}";
        

        public string ResultWithBaseunit() => $"{BaseunitValue} {Unit}";

        public override int GetHashCode()
        {


            HashCode hashCode = new HashCode();
            hashCode.Add(SymbolValue);
            hashCode.Add(Unit.GetHashCode());

            return hashCode.ToHashCode();



        }


        // x - a number, from which we need to calculate the square root
        // epsilon - an accuracy of calculation of the root from our number.
        // The result of the calculations will differ from an actual value
        // of the root on less than epslion.
        public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }


    }




    }

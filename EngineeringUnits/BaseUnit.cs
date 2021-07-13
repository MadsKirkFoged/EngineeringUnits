using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace EngineeringUnits
{

    [JsonObject(MemberSerialization.OptIn)]
    public class BaseUnit : IComparable
    {

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public UnitSystem Unit { get; set;}

        public double Value => (double)Unit.GetActualC()* (double)ValueLocalUnit;

        [JsonProperty]
        public decimal ValueLocalUnit { get; protected set; }

        [JsonProperty]
        public decimal SymbolValue { get; set; }
        public decimal BaseunitValue => SymbolValue * ((decimal)Unit.GetCombi() / (decimal)Unit.GetActualC());

        public BaseUnit()
        {

        }

        public BaseUnit(double valueLocalUnit) :this()
        {
            ValueLocalUnit = (decimal)valueLocalUnit;
            SymbolValue = (decimal)valueLocalUnit;

        }


        public BaseUnit(decimal value, UnitSystem unitSystem)
        {
            Unit = unitSystem.Copy();
            SetValue(value);

        }

        public BaseUnit(double value, UnitSystem unitSystem)
        {
            
            Unit = unitSystem.Copy();

            if (value < (double)Decimal.MinValue || value > (double)Decimal.MaxValue || Double.IsNaN(value))            
                SetValue(0);            
            else            
                SetValue(value);           

           

        }

        public BaseUnit(int value, UnitSystem unitSystem)
        {
            Unit = unitSystem.Copy();
            SetValue(value);
        }

     
        public double As(UnitSystem a)
        {

            if (Unit is object)
            {
                return (double)ToTheOutSide(a);
            }
            else
            {
                return 0;
            }

        }

        public double As(BaseUnit a) => As(a.Unit);

        public void Transform(UnknownUnit a)
        {

            if (a.unitsystem != Unit)
            {
                throw new InvalidOperationException($"This is NOT a {Name} [{Unit}] as expected! Your Unit is a [{a.unitsystem}] ");
            }
            
            Unit = a.unitsystem.Copy();
            ValueLocalUnit = a.baseUnit.ValueLocalUnit;
            SymbolValue = a.baseUnit.SymbolValue;
        }



        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '+' on two differnt units!");
            }

            return BaseUnit.DoMath(left, right, MathEnum.Add);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {

            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '-' on two differnt units!");
            }

            return BaseUnit.DoMath(left, right, MathEnum.Subtract);
        }

        public static UnknownUnit operator *(BaseUnit a, BaseUnit b) => BaseUnit.DoMath(a, b, MathEnum.Multiply);
        public static UnknownUnit operator /(BaseUnit a, BaseUnit b) => BaseUnit.DoMath(a, b, MathEnum.Divide);


        public static UnknownUnit operator *(BaseUnit a, double b) => a * (new UnknownUnit(b));
        public static UnknownUnit operator /(BaseUnit a, double b) => a / (new UnknownUnit(b));
        public static UnknownUnit operator /(double a, BaseUnit b) => (new UnknownUnit(a)) / b;
        public static UnknownUnit operator *(double a, BaseUnit b) => b * a;


        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BaseUnit p = (BaseUnit)obj;
                return this == p;
            }
        }

        


        public static bool operator ==(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '==' on two differnt units!");
            }

            //Debug.Print();

            return (double)left.SymbolValue == right.As(left);
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '!=' on two differnt units!");
            }

            return (double)left.SymbolValue != right.As(left);
        }

        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '<=' on two differnt units!");
            }

            return (double)left.SymbolValue <= right.As(left);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '>=' on two differnt units!");
            }

            return (double)left.SymbolValue >= right.As(left);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '<' on two differnt units!");
            }

            return (double)left.SymbolValue < right.As(left);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '>' on two differnt units!");
            }

            return (double)left.SymbolValue > right.As(left);
        }

        public static implicit operator UnknownUnit(BaseUnit baseUnit)
        {
            UnknownUnit local = new UnknownUnit();
            local.baseUnit = baseUnit;

            return local;
        }

        //public override string ToString()
        //{
        //    return $"{ValueLocalUnit} {Unit}";
        //}

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g4");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString(IFormatProvider provider)
        {
            return ToString("g", provider);
        }



        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentUICulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentUICulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider provider)
        {

            if (Unit.Symbol is object)
            {
                return $"{SymbolValue.ToString(format)} {Unit.Symbol}";
            }
            else
            {
                return $"{BaseunitValue.ToString(format)} {Unit}";
            }


        }

        public static UnknownUnit DoMath(BaseUnit left, BaseUnit right, MathEnum math)
        {

            BaseUnit local = new BaseUnit();
            decimal x3 = 0;

            Fraction b1 = left.Unit.SumOfBConstants();
            //Fraction b2 = right.Unit.SumOfBConstants();

            //decimal y1 = left.ValueLocalUnit * (decimal)left.Unit.GetCombi();
            //decimal y2 = right.ValueLocalUnit * (decimal)UnitSystem.Convert(right.Unit, left.Unit) + (decimal)b1 * -1;



            //Testing new system
            decimal x3Test = 0;
            //Turn both into Baseunits

            //decimal LeftTest = left.SymbolValue * ((decimal)left.Unit.GetCombi() * (decimal)left.Unit.GetActualC());
            //decimal RightTest = right.SymbolValue * (decimal)right.Unit.GetCombi() * (decimal)right.Unit.GetActualC();

            decimal LeftTest = left.BaseunitValue;
            decimal RightTest = right.BaseunitValue;

            //Debug.Print($"Combi:   {(decimal)left.Unit.GetCombi()}");
            //Debug.Print($"ActualC: {(decimal)left.Unit.GetActualC()}");

            //Turn 'right' into lefts unitsystem
            decimal ConvertionsFactor = (decimal)UnitSystem.Convert(right.Unit.BaseUnitSystem(), left.Unit.BaseUnitSystem());
            decimal testRightConverted = RightTest * ConvertionsFactor;

            //Do math

            //turn left back to its orginale unitsystem


            switch (math)
            {
                case MathEnum.Add:

                    //Value math
                   // x3 = y1 + y2;
                    x3Test = LeftTest + testRightConverted;

                    //Unit math
                    local.Unit = left.Unit + right.Unit;
                    break;
                case MathEnum.Subtract:

                    //Value math
                   // x3 = y1 - y2;
                    x3Test = LeftTest - testRightConverted;

                    //Unit math
                    local.Unit = left.Unit- right.Unit;
                    break;
                case MathEnum.Multiply:

                    //Value math
                    //x3 = y1 * y2;
                    x3Test = LeftTest * testRightConverted;

                    //Unit math
                    local.Unit = left.Unit * right.Unit;
                    break;
                case MathEnum.Divide:

                    //Value math
                    if (testRightConverted != 0)
                    {
                   //     x3 = y1  / y2;
                        x3Test = LeftTest / testRightConverted;
                    }
                    else                    
                        x3 = 0;

                    //Unit math
                    local.Unit = left.Unit / right.Unit;
                    break;
                default:
                    break;
            }


            //Convert back to New unitsystem
            //decimal x3TestConvertedBack = x3Test / ((decimal)left.Unit.GetCombi() / (decimal)left.Unit.GetActualC());
            decimal x3TestConvertedBack = x3Test / ((decimal)local.Unit.GetCombi() / (decimal)local.Unit.GetActualC());


            //Removing traling zeros
            local.ValueLocalUnit = x3 / 1.000000000000000000000000000000000m;
            local.SymbolValue = x3TestConvertedBack / 1.000000000000000000000000000000000m;


            return local;
        }

        protected void SetValue(int value)
        {
            SetValue((decimal)value);
        }


        protected void SetValue(double value)
        {
            SetValue((decimal)value);
        }

        protected void SetValue(decimal value)
        {
            ValueLocalUnit = value / (decimal)Unit.GetActualC();


            SymbolValue = value;
            //BaseunitValue = 


    }


        public decimal ToTheOutSide(UnitSystem To)
        {

            //Creating a new system call 3

            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();
           

            //Fraction a3 = FactorDifferent(To);
            //Fraction b3 = a3 * (b1*-1) + b2;


            //Fraction y1 = (Fraction)ValueLocalUnit;
            //Fraction y2 = a3 * y1 + b3;




            Fraction test = UnitSystem.Convert(Unit, To);

            Fraction b3test = test * (b1 * -1) + b2;
            Fraction y2test = test * (Fraction)SymbolValue + b3test;
            return (decimal)y2test;


            //return (decimal)y2;
        }

       

        //public Fraction FactorDifferent(UnitSystem To)
        //{

        //    //Samle konstanter
        //    Fraction leftA1 = Unit.GetFactorLocal();
        //    Fraction leftA2 = Unit.GetFactorGlobal();
        //    Fraction rightA1 = To.GetFactorLocal();
        //    Fraction rightA2 = To.GetFactorGlobal();


        //    Fraction a1 = 1 / (leftA2 * leftA1);
        //    Fraction a2 = 1 / (rightA2 * rightA1);

        //    //Debug.Print(To.GetActualC().ToString());

        //    Fraction a3 = (a2 / a1) * To.GetActualC();


        //    return a3;
        //}

        public string DisplaySymbol()
        {
            if (Unit.Symbol is object)
            {
                return Unit.Symbol;
            }

            return Unit.ToString();

        }

        public int CompareTo(object obj)
        {
            BaseUnit local = (BaseUnit)obj; 

            if (Unit != local.Unit)            
                throw new InvalidOperationException($"Cant do CompareTo on two differnt units!");
            

            return (int)(Value - local.As(this));
        }
    
    
        public string ResultWithSymbol()
        {


            return $"{SymbolValue} {Unit.Symbol}";
        }

        public string ResultWithBaseunit()
        {

            
            return $"{BaseunitValue} {Unit}";
        }


    }
}

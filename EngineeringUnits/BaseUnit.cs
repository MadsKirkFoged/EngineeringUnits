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

        [JsonProperty(PropertyName = "U")]
        public UnitSystem Unit { get; set;}

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.Ignore)]
        protected decimal SymbolValue { get; set; }
        public decimal BaseunitValue => SymbolValue * ConvertToBaseUnit();

        [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
        public double Value => (double)SymbolValue;

        [JsonConstructor]
        public BaseUnit()
        {
        }

        public BaseUnit(double valueLocalUnit) :this()
        {
            SymbolValue = (decimal)valueLocalUnit;
        }


        public BaseUnit(decimal value, UnitSystem unitSystem)
        {
            //Unit = unitSystem.Copy();
            Unit = unitSystem;
            SetValue(value);
        }

        public BaseUnit(double value, UnitSystem unitSystem)
        {
            
            //Unit = unitSystem.Copy();
            Unit = unitSystem;

            if (value < (double)Decimal.MinValue || value > (double)Decimal.MaxValue || Double.IsNaN(value))            
                SetValue(0);            
            else            
                SetValue(value);          
        }

        public BaseUnit(int value, UnitSystem unitSystem)
        {
            //Unit = unitSystem.Copy();
            Unit = unitSystem;
            SetValue(value);
        }

        public BaseUnit(UnknownUnit unit)
        {

            Unit = unit.unitsystem;
            SetValue(unit.baseUnit.ToTheOutSide(Unit));


            UnitCheck(unit);
        }

        public BaseUnit(UnknownUnit unit, UnitSystem unitSystem)
        {
            if (unit.baseUnit.Unit.Symbol is null)            
                Unit = unitSystem;            
            else            
                Unit = unit.unitsystem;
            

            SetValue(unit.baseUnit.ToTheOutSide(Unit));


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

        public void Transform(UnknownUnit a)
        {
            if (a.unitsystem != Unit)
            {
                throw new InvalidOperationException($"This is NOT a [{Unit}] as expected! Your Unit is a [{a.unitsystem}] ");
            }                       

            SetValue(a.baseUnit.ToTheOutSide(Unit));
        }


        public void UnitCheck(UnknownUnit a)
        {

            if (a.unitsystem != Unit)
            {
                throw new InvalidOperationException($"This is NOT a [{Unit}] as expected! Your Unit is a [{a.unitsystem}] ");
            }

        }



        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '+' on two differnt units!");            

            return BaseUnit.DoMath(left, right, MathEnum.Add);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {

            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '-' on two differnt units!");            

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
                throw new InvalidOperationException($"Cant do '==' on two differnt units!");
            

            return (double)left.SymbolValue == right.As(left);
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '!=' on two differnt units!");            

            return (double)left.SymbolValue != right.As(left);
        }
        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '<=' on two differnt units!");            

            return (double)left.SymbolValue <= right.As(left);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '>=' on two differnt units!");            

            return (double)left.SymbolValue >= right.As(left);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '<' on two differnt units!");            

            return (double)left.SymbolValue < right.As(left);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)            
                throw new InvalidOperationException($"Cant do '>' on two differnt units!");            

            return (double)left.SymbolValue > right.As(left);
        }

        public static implicit operator UnknownUnit(BaseUnit baseUnit) => new UnknownUnit { baseUnit = baseUnit };
        


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
                return $"{SymbolValue.ToString(format)}";        


            if (Unit.Symbol is object)            
                return $"{SymbolValue.ToString(format)} {Unit.Symbol}";            
            
            

                return $"{BaseunitValue.ToString(format)} {Unit}";         
        }

        public static UnknownUnit DoMath(BaseUnit left, BaseUnit right, MathEnum math)
        {

            BaseUnit local = new BaseUnit();   
            decimal x3Test = 0;


            //Turn both into Baseunits

            //Turn 'right' into lefts unitsystem
            decimal ConvertionsFactor = (decimal)UnitSystem.Convert(right.Unit.BaseUnitSystem(), left.Unit.BaseUnitSystem());
            decimal testRightConverted = right.BaseunitValue * ConvertionsFactor;

            switch (math)
            {
                case MathEnum.Add:

                    //Value math
                    x3Test = left.BaseunitValue + testRightConverted;

                    //Unit math
                    local.Unit = left.Unit + right.Unit;
                    break;
                case MathEnum.Subtract:

                    //Value math
                    x3Test = left.BaseunitValue - testRightConverted;

                    //Unit math
                    local.Unit = left.Unit- right.Unit;
                    break;
                case MathEnum.Multiply:

                    //Value math
                    x3Test = left.BaseunitValue * testRightConverted;

                    //Unit math
                    local.Unit = left.Unit * right.Unit;
                    break;
                case MathEnum.Divide:

                    //Value math
                    if (testRightConverted != 0)                    
                        x3Test = left.BaseunitValue / testRightConverted;                    
                    else
                        x3Test = 0;

                    //Unit math
                    local.Unit = left.Unit / right.Unit;
                    break;
                default:
                    break;
            }


            //Convert back to New unitsystem
            decimal x3TestConvertedBack = x3Test / local.ConvertToBaseUnit();

            //Removing traling zeros
            local.SymbolValue = x3TestConvertedBack / 1.000000000000000000000000000000000m;


            return local;
        }


        public UnknownUnit Abs()
        {

            UnknownUnit local = new UnknownUnit();
            local.baseUnit.Unit = Unit;
            local.baseUnit.SymbolValue = SymbolValue;

            if (SymbolValue < 0)
                local.baseUnit.SymbolValue *= -1;
            


            return local;
        }



        public UnknownUnit Pow(int toPower)
        {

            if (toPower == 1)            
                return this;
            
            UnknownUnit local = new UnknownUnit();
            local.baseUnit.Unit = new UnitSystem();
            local.baseUnit.SymbolValue = 1;


            if (toPower == 0)
                return local;


            if (toPower > 1)            
                for (int i = 0; i < toPower; i++)                
                    local = local * this;


            if (toPower < 0)            
                for (int i = 0; i > toPower; i--)                
                    local = local / this;            



            return local;
        }

        public decimal ConvertToBaseUnit() => (decimal)(Unit.GetCombi() / Unit.GetActualC());
        


        protected void SetValue(int value)  => SetValue((decimal)value);
        protected void SetValue(double value) => SetValue((decimal)value);
        protected void SetValue(decimal value) => SymbolValue = value;



        public decimal ToTheOutSide(UnitSystem To)
        {


            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();         

            Fraction test = UnitSystem.Convert(Unit, To);

            Fraction b3test = test * (b1 * -1) + b2;
            Fraction y2test = test * (Fraction)SymbolValue + b3test;
            return (decimal)y2test;
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
                throw new InvalidOperationException($"Cant do CompareTo on two differnt units!");
            

            return (int)((double)SymbolValue - local.As(this));
        }
    
    
        public string ResultWithSymbol() => $"{SymbolValue} {Unit.Symbol}";
        

        public string ResultWithBaseunit() => $"{BaseunitValue} {Unit}";



    }




    }

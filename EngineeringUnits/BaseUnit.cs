using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{
    public class BaseUnit
    {

        public string Name { get; set; }
        public UnitSystem Unit { get; set;}

        public double Value => As(Unit);

        public decimal ValueLocalUnit { get; protected set; }

        public BaseUnit()
        {
            if (Unit is null)
            {
                Unit = new UnitSystem();
            }
        }

        public BaseUnit(double valueLocalUnit) :this()
        {
            ValueLocalUnit = (decimal)valueLocalUnit;
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
            
            Unit = a.unitsystem;
            ValueLocalUnit = a.baseUnit.ValueLocalUnit;
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


        public static UnknownUnit operator *(BaseUnit a, double b)
        {
            UnknownUnit local = new UnknownUnit(b);

            return a * local;
        }
       
        public static UnknownUnit operator /(BaseUnit a, double b)
        {
            UnknownUnit local = new UnknownUnit(b);

            return a / local;
        }
        
        public static UnknownUnit operator /(double a, BaseUnit b)
        {
            UnknownUnit local = new UnknownUnit(a);

            return local / b;
        }
        
        public static UnknownUnit operator *(double a, BaseUnit b) => b*a;
        

        public static bool operator ==(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '==' on two differnt units!");
            }

            return left.Value == right.As(left);
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '!=' on two differnt units!");
            }

            return left.Value != right.As(left);
        }

        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '<=' on two differnt units!");
            }

            return left.Value <= right.As(left);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '>=' on two differnt units!");
            }

            return left.Value >= right.As(left);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '<' on two differnt units!");
            }

            return left.Value < right.As(left);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '>' on two differnt units!");
            }

            return left.Value > right.As(left);
        }

        public static implicit operator UnknownUnit(BaseUnit baseUnit)
        {
            UnknownUnit local = new UnknownUnit();
            local.baseUnit = baseUnit;
            return local;
        }

        public override string ToString()
        {
            return $"{Value} {Unit}";
        }




        //Moving math

        public static UnknownUnit DoMath(BaseUnit left, BaseUnit right, MathEnum math)
        {

            BaseUnit local = new BaseUnit();

            //Get constants
            Fraction a1 = 1 / left.Unit.GetAFactorGlobal();
            decimal y1 = left.ValueLocalUnit;

            Fraction a2 = 1 / right.Unit.GetAFactorGlobal();
            decimal y2 = right.ValueLocalUnit;


            //Turn to SI
            decimal x1 = (y1) / a1.ToDecimal();
            decimal x2 = (y2) / a2.ToDecimal();

            //Do math in SI
            decimal x3;
            //decimal b1;
            switch (math)
            {
                case MathEnum.Add:
                    x3 = x1 + x2;
                    local.Unit = UnitSystem.Add(left.Unit, right.Unit);
                    local.ValueLocalUnit = (a1.ToDecimal() * x3) / 1.000000000000000000000000000000000m;                   
                    break;
                case MathEnum.Subtract:
                    x3 = x1 - x2;
                    local.Unit = UnitSystem.Subtract(left.Unit, right.Unit);
                    local.ValueLocalUnit = (a1.ToDecimal() * x3) / 1.000000000000000000000000000000000m;
                    break;
                case MathEnum.Multiply:
                    x3 = x1 * x2;
                    local.Unit = UnitSystem.Multiply(left.Unit, right.Unit);
                    a1 = 1 / local.Unit.GetAFactorGlobal();
                    //b1 = local.Unit.SumOfBConstants();
                    local.ValueLocalUnit = (x3 * a1.ToDecimal()) / 1.000000000000000000000000000000000m;
                    break;
                case MathEnum.Divide:
                    x3 = x1 / x2;
                    local.Unit = UnitSystem.Divide(left.Unit, right.Unit);
                    a1 = 1 / local.Unit.GetAFactorGlobal();
                    local.ValueLocalUnit = (x3 * a1.ToDecimal()) / 1.000000000000000000000000000000000m;
                    break;
                default:
                    break;
            }



            return local;
        }


        public double ToTheOutSide(UnitSystem To)
        {

            //Samle konstanter
            Fraction leftA1 = 1;
            Fraction leftA2 = Unit.SumOfA2ConstantsWithPow();
            Fraction rightA1 = To.SumOfA1ConstantsWithPow();
            Fraction rightA2 = To.SumOfA2ConstantsWithPow();

            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();

            decimal y1 = ValueLocalUnit;
            decimal y2 = y1;

            //Debug.Print(y1.ToDecimal().ToString());


            //Trying to avoid small numeric error
            if (rightA1 >= leftA1)
                y2 /= (decimal)(rightA1 / leftA1);
            else
                y2 *= (decimal)(leftA1 / rightA1);


            if (rightA2 >= leftA2)
                y2 /= (decimal)(rightA2 / leftA2);
            else
                y2 *= (decimal)(leftA2 / rightA2);


            //Debug.Print(y2.ToDecimal().ToString());


            y2 = y2 + b2.ToDecimal(); // + b1;

            //return y2 / 1.000000000000000000000000000000000m;

            return (double)y2;
        }


        public void SetLocalValue(double ValueFrom)
        {

            //Samle konstanter
            //decimal a11 = Unit.SumOfA1Constants();
            Fraction a11 = Unit.SumOfA1ConstantsWithPow();
            Fraction b1 = Unit.SumOfBConstants();

            decimal y1 = (decimal)ValueFrom;

            decimal y2 = y1 - b1.ToDecimal();
            y2 *= a11.ToDecimal();

            ValueLocalUnit = y2;

        }



    }
}

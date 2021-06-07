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

        public double Value => (double)Unit.GetActualC()* (double)ValueLocalUnit;

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


        public decimal GetDecimal(UnitSystem a)
        {
            if (Unit is object)
            {
                return ToTheOutSide(a);
            }
            else
            {
                return 0;
            }


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
          //  Fraction a1 = left.Unit.GetFactorGlobal();
            decimal y1 = left.ValueLocalUnit;

          //  Fraction a2 = right.Unit.GetFactorGlobal();
            decimal y2 = right.ValueLocalUnit;

            Fraction b1 = left.Unit.SumOfBConstants();
            Fraction b2 = right.Unit.SumOfBConstants();


            //Turn to SI
           // decimal x1 = (y1) * a1.ToDecimal();
           // decimal x2 = (y2) * a2.ToDecimal();

            //Do math in SI
            decimal x3;
            //decimal b1;
            switch (math)
            {
                case MathEnum.Add:


                    //Turn right into lefts unit
                    x3 = y1 + right.GetDecimal(left.Unit) + (decimal)b1*-1;

                    local.Unit = UnitSystem.Add(left.Unit, right.Unit);
                    local.ValueLocalUnit = x3 / 1.000000000000000000000000000000000m;


                    break;


                case MathEnum.Subtract:

                    //Turn right into lefts unit
                    x3 = y1 - right.GetDecimal(left.Unit) + (decimal)b1 * -1;

                    local.Unit = UnitSystem.Subtract(left.Unit, right.Unit);
                    local.ValueLocalUnit = x3 / 1.000000000000000000000000000000000m;

                    break;
                case MathEnum.Multiply:

                    x3 = y1 * y2;


                    local.Unit = UnitSystem.Multiply(left.Unit, right.Unit);



                    local.ValueLocalUnit = x3 / 1.000000000000000000000000000000000m;
                    break;
                case MathEnum.Divide:

                    if (y2 != 0)                    
                        x3 = y1 / y2;                    
                    else                    
                        x3 = 0;
                    
                    local.Unit = UnitSystem.Divide(left.Unit, right.Unit);
                    local.ValueLocalUnit = x3 / 1.000000000000000000000000000000000m;

                    break;
                default:
                    break;
            }



            return local;
        }


        public decimal ToTheOutSide(UnitSystem To)
        {

            //Samle konstanter
            Fraction leftA1 = Unit.GetFactorLocal();
            Fraction leftA2 = Unit.GetFactorGlobal();
            Fraction rightA1 = To.GetFactorLocal();
            Fraction rightA2 = To.GetFactorGlobal();



            Fraction a1 =   1/(leftA2 * leftA1);
            Fraction a2 = 1/(rightA2 * rightA1);


            Fraction b1 = Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();


            Fraction a3 = a2 / a1;

            Debug.WriteLine($"{Unit.GetActualC()}");
            Debug.WriteLine($"{To.GetActualC()}");

            //Fraction c = Unit.GetActualC() / To.GetActualC();
            Fraction c = To.GetActualC() / Unit.GetActualC();

            a3 *= c;



            Fraction b3 = a3 * (b1*-1) + b2;


            Fraction y1 = (Fraction)ValueLocalUnit;            
            
            Fraction y2 = a3 * y1 + b3;



            return (decimal)y2;
        }

        public double ToDouble()
        {
           return (double)((decimal)Unit.GetTotalFactor() * ValueLocalUnit);
        }


        public void SetLocalValue(double ValueFrom)
        {

            //Samle konstanter
            //decimal a11 = Unit.SumOfA1Constants();
            Fraction a11 = Unit.GetFactorLocal();
            Fraction b1 = Unit.SumOfBConstants();

            decimal y1 = (decimal)ValueFrom;

            decimal y2 = y1 - b1.ToDecimal();
            y2 *= a11.ToDecimal();

            ValueLocalUnit = y2;

        }



    }
}

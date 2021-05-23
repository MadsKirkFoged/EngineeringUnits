using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class BaseUnit
    {
        public UnitSystem unitsystem { get; set;}

        public double Value => As(unitsystem);

        public decimal ValueLocalUnit { get; set; }

        public BaseUnit()
        {
            unitsystem = new UnitSystem();
        }


        public double As(UnitSystem a)
        {

            if (unitsystem is object)
            {

                return (double)unitsystem.ToTheOutSide(ValueLocalUnit, a);
                //return UnitSystem.Convert((double)ValueLocalUnit, unitsystem, a);
            }
            else
            {
                return 0;
            }

        }

        public double As(BaseUnit a)
        {
            return UnitSystem.Convert(Value, unitsystem, a.unitsystem);
        }


        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '+' on two differnt units!");
            }

            return UnitSystem.DoMath(left, right, MathEnum.Add);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {

            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '-' on two differnt units!");
            }

            return UnitSystem.DoMath(left, right, MathEnum.Subtract);
        }

        public static UnknownUnit operator *(BaseUnit a, BaseUnit b) => UnitSystem.DoMath(a, b, MathEnum.Multiply);
        public static UnknownUnit operator /(BaseUnit a, BaseUnit b) => UnitSystem.DoMath(a, b, MathEnum.Divide);


        public static UnknownUnit operator *(BaseUnit a, double b)
        {
            UnknownUnit local = new UnknownUnit();
            local.baseUnit.ValueLocalUnit = (decimal)b;

            return a * local;
        }
        





        public static UnknownUnit operator /(BaseUnit a, double b)
        {
            UnknownUnit local = new UnknownUnit();
            local.baseUnit.ValueLocalUnit = (decimal)b;

            return a / local;


        }
        
        public static UnknownUnit operator /(double a, BaseUnit b)
        {
            UnknownUnit local = new UnknownUnit();
            local.baseUnit.ValueLocalUnit = (decimal)a;

            return local / b;


        }
        
        
        
        public static UnknownUnit operator *(double a, BaseUnit b) => b*a;
        

        public static bool operator ==(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '==' on two differnt units!");
            }

            return left.Value == right.As(left);
        }
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '!=' on two differnt units!");
            }

            return left.Value != right.As(left);
        }

        public static bool operator <=(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '<=' on two differnt units!");
            }

            return left.Value <= right.As(left);
        }
        public static bool operator >=(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '>=' on two differnt units!");
            }

            return left.Value >= right.As(left);
        }
        public static bool operator <(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '<' on two differnt units!");
            }

            return left.Value < right.As(left);
        }
        public static bool operator >(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
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
            return $"{Value} {unitsystem}";
        }



    }
}

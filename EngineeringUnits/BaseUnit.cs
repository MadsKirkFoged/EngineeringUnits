using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class BaseUnit
    {

        public string Name { get; set; }
        public UnitSystem Unit { get; set;}

        public double Value => As(Unit);

        public decimal ValueLocalUnit { get; set; }

        public BaseUnit()
        {
            Unit = new UnitSystem();
        }

        public BaseUnit(decimal valueLocalUnit) :this()
        {
            ValueLocalUnit = valueLocalUnit;
        }


        public double As(UnitSystem a)
        {

            if (Unit is object)
            {
                return (double)Unit.ToTheOutSide(ValueLocalUnit, a);
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

            return UnitSystem.DoMath(left, right, MathEnum.Add);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {

            if (left.Unit != right.Unit)
            {
                throw new InvalidOperationException($"Cant do '-' on two differnt units!");
            }

            return UnitSystem.DoMath(left, right, MathEnum.Subtract);
        }

        public static UnknownUnit operator *(BaseUnit a, BaseUnit b) => UnitSystem.DoMath(a, b, MathEnum.Multiply);
        public static UnknownUnit operator /(BaseUnit a, BaseUnit b) => UnitSystem.DoMath(a, b, MathEnum.Divide);


        public static UnknownUnit operator *(BaseUnit a, double b)
        {
            UnknownUnit local = new UnknownUnit((decimal)b);

            return a * local;
        }
        





        public static UnknownUnit operator /(BaseUnit a, double b)
        {
            UnknownUnit local = new UnknownUnit((decimal)b);

            return a / local;
        }
        
        public static UnknownUnit operator /(double a, BaseUnit b)
        {
            UnknownUnit local = new UnknownUnit((decimal)a);

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

        

    }
}

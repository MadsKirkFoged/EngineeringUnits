using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class BaseUnit
    {
        public UnitSystem unitsystem { get; set;}

        public double Value { get; set; }

        public BaseUnit()
        {
            unitsystem = new UnitSystem();
        }


        public double As(UnitSystem a)
        {
            return UnitSystem.Convert(Value, unitsystem, a);
        }

        public double As(BaseUnit a)
        {
            return UnitSystem.Convert(Value, unitsystem, a.unitsystem);
        }


        //public static UnknownUnit Add(BaseUnit a, BaseUnit b)
        //{
        //    return new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Add(a.unitsystem, b.unitsystem),
        //        Value = a.Value + UnitSystem.ValueConvert(b.Value, b.unitsystem, a.unitsystem)
        //    };

        //}

        public static UnknownUnit Subtract(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                unitsystem = UnitSystem.Subtract(a.unitsystem, b.unitsystem),
                Value = a.Value - (UnitSystem.Convert(b.Value, b.unitsystem, a.unitsystem))
            };

        }
        public static UnknownUnit Multiply(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                unitsystem = UnitSystem.Multiply(a.unitsystem, b.unitsystem),
                Value = a.Value * UnitSystem.Convert(b.Value, b.unitsystem, a.unitsystem)
            };

        }
        public static UnknownUnit Multiply(BaseUnit a, double b)
        {
            return new BaseUnit
            {
                unitsystem = a.unitsystem.Copy(),
                Value = a.Value * b,
            };

        }
        public static UnknownUnit Divide(BaseUnit a, BaseUnit b)
        {
            return new BaseUnit
            {
                unitsystem = UnitSystem.Divide(a.unitsystem, b.unitsystem),
                Value = a.Value / UnitSystem.Convert(b.Value, b.unitsystem, a.unitsystem)
            };
        }
        public static UnknownUnit Divide(BaseUnit a, double b)
        {
            return new BaseUnit
            {
                unitsystem = a.unitsystem.Copy(),
                Value = a.Value / b,
            };
        }
        public static UnknownUnit Divide(double a, BaseUnit b)
        {
            return new BaseUnit
            {
                unitsystem = b.unitsystem.Copy(),
                Value = b.Value / a,
            };
        }
        public static double DivideResultsInDouble(BaseUnit a, BaseUnit b)
        {
            return a.Value / UnitSystem.Convert(b.Value, b.unitsystem, a.unitsystem);
        }



        public static UnknownUnit operator *(BaseUnit a, BaseUnit b) => UnitSystem.Multiply(a, b);
        public static UnknownUnit operator /(BaseUnit a, BaseUnit b) => UnitSystem.Divide(a, b);
        public static UnknownUnit operator +(BaseUnit left, BaseUnit right)
        {
            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '+' on two differnt units!");
            }

  
            return UnitSystem.Add(left, right);
        }
        public static UnknownUnit operator -(BaseUnit left, BaseUnit right)
        {

            if (left.unitsystem != right.unitsystem)
            {
                throw new InvalidOperationException($"Cant do '-' on two differnt units!");
            }

            return UnitSystem.Subtract(left, right);
        }
        
        
        public static UnknownUnit operator *(BaseUnit a, double b) => BaseUnit.Multiply(a, b);
        public static UnknownUnit operator /(BaseUnit a, double b) => BaseUnit.Divide(a, b);
        public static UnknownUnit operator *(double a, BaseUnit b) => BaseUnit.Multiply(b, a);
        public static UnknownUnit operator /(double a, BaseUnit b) => BaseUnit.Divide(a, b);
        

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

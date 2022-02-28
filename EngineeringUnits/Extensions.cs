using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{
    public static class Extensions
    {
        public static decimal Normalize(this decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }


        
        public static decimal Sqrt(this decimal x, decimal epsilon = 0.0M)
        {
            // x - a number, from which we need to calculate the square root
            // epsilon - an accuracy of calculation of the root from our number.
            // The result of the calculations will differ from an actual value
            // of the root on less than epslion.

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

        public static string ToSuperScript(this int number)
        {
            if (number == 0 ||
                number == 1)
                return "";

            const string SuperscriptDigits =
                "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string Superscript = "";

            if (number < 0)
            {
                //Adds superscript minus
                Superscript = ((char)0x207B).ToString();
                number *= -1;
            }


            Superscript += new string(number.ToString()
                                            .Select(x => SuperscriptDigits[x - '0'])
                                            .ToArray()
                                      );

            return Superscript;
        }

        public static UnknownUnit Abs(this BaseUnit a)
        {
            if (a.SI < 0)
                return a * -1;
            else
                return a;
        }
        public static UnknownUnit Abs(this UnknownUnit a)
        {
            return a._baseUnit.Abs();
        }


        public static double As(this BaseUnit a, IUnitSystem b)
        {
            return a.As(b.Unit);
        }
        public static double As(this BaseUnit a, UnitSystem b)
        {
            return (double)a.ToTheOutSide(b);
        }
        public static double As(this UnknownUnit a, IUnitSystem b)
        {
            return a._baseUnit.As(b);
        }

        public static UnknownUnit ToUnit(this BaseUnit a, IUnitSystem selectedUnit)
        {
            a.UnitCheck(selectedUnit);

            return new(a.ToTheOutSide(selectedUnit.Unit), selectedUnit.Unit);
        }
        public static UnknownUnit ToUnit(this UnknownUnit a, IUnitSystem selectedUnit)
        {
            a._baseUnit.UnitCheck(selectedUnit);

            return new(a._baseUnit.ToTheOutSide(selectedUnit.Unit), selectedUnit.Unit);
        }

        public static UnknownUnit Pow(this BaseUnit a, int toPower)
        {
            return toPower switch
            {
                0 => 1,
                1 => a,
                > 1 => a.Pow(toPower - 1) * a,
                < 0 => a.Pow(toPower + 1) / a
            };

        }

        public static UnitSystem Pow(this UnitSystem a, int toPower)
        {
            return toPower switch
            {
                0 => new UnitSystem(),
                1 => a,
                > 1 => a.Pow(toPower - 1) * a,
                < 0 => a.Pow(toPower + 1) / a
            };

        }

        public static UnknownUnit Pow(this UnknownUnit a, int toPower)
        {
           return a._baseUnit.Pow(toPower);
        }
        public static UnitSystem Pow(this Enumeration a, int toPower)
        {
            return a.Unit.Pow(toPower);
        }

        public static UnknownUnit InRangeOf(this BaseUnit a, UnknownUnit Min, UnknownUnit Max)
        {

            a.UnitCheck(Min);
            a.UnitCheck(Max);

            if (Max < Min)
            {
                //TODO you need max to be larger then min
                return a;
            }


            if (a < Min)
                return Min;


            if (a > Max)
                return Max;


            return a;


        }
        public static UnknownUnit InRangeOf(this UnknownUnit a, UnknownUnit Min, UnknownUnit Max)
        {
            return a._baseUnit.InRangeOf(Min, Max);
        }

        public static bool IsZero(this BaseUnit a)
        {
            return a.SI == 0;
        }
        public static bool IsZero(this UnknownUnit a)
        {
            return a._baseUnit.IsZero();
        }

        public static bool IsNotZero(this BaseUnit a)
        {
            return !a.IsZero();
        }
        public static bool IsNotZero(this UnknownUnit a)
        {
            return a._baseUnit.IsNotZero();
        }

        public static bool IsAboveZero(this BaseUnit a)
        {
            return a.SI > 0;
        }
        public static bool IsAboveZero(this UnknownUnit a)
        {
            return a._baseUnit.IsAboveZero();
        }

        public static bool IsBelowZero(this BaseUnit a)
        {
            return a.SI < 0;
        }
        public static bool IsBelowZero(this UnknownUnit a)
        {
            return a._baseUnit.IsBelowZero();
        }


        public static UnknownUnit Sum(this IEnumerable<BaseUnit> list)
        {
            return list.Aggregate(new UnknownUnit(0m, list.First().Unit),
                                 (x, y) => x + y);
        }
        public static UnknownUnit Sum(this IEnumerable<UnknownUnit> list)
        {
            return list.Aggregate(new UnknownUnit(0m, list.First()._baseUnit.Unit),
                                 (x, y) => x + y);
        }

        public static UnknownUnit Average(this IEnumerable<BaseUnit> list)
        {
            return list.Sum() / list.Count();
        }
        public static UnknownUnit Average(this IEnumerable<UnknownUnit> list)
        {
            return list.Sum() / list.Count();
        }


        public static UnknownUnit Mean(this IEnumerable<UnknownUnit> list)
        {
            return list.OrderBy(x => x)
                       .ToList()
                        [list.Count() / 2];
        }

        public static UnknownUnit Mean(this IEnumerable<BaseUnit> list)
        {
            return list.OrderBy(x => x)
                       .ToList()
                        [list.Count() / 2];
        }



    }
}

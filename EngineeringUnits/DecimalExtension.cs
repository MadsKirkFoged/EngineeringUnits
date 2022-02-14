using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public static class DecimalExtension
    {
        public static decimal Normalize(this decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }


        // x - a number, from which we need to calculate the square root
        // epsilon - an accuracy of calculation of the root from our number.
        // The result of the calculations will differ from an actual value
        // of the root on less than epslion.
        public static decimal Sqrt(this decimal x, decimal epsilon = 0.0M)
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




    }
}

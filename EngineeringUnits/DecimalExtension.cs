using System;
using System.Collections.Generic;
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




    }
}

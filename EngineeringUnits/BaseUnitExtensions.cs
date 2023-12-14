using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public static class BaseUnitExtensions
    {
        public static decimal ConvertValueInto(this BaseUnit To, BaseUnit From)
        {
            Fraction Factor = From.Unit.ConvertionFactor(To.Unit);

            return (decimal)(Factor * (Fraction)To.NEWValue);
        }


        public static decimal GetValueAs(this BaseUnit From, UnitSystem To)
        {
            Fraction b1 = From.Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();
            Fraction Factor = To.ConvertionFactor(From.Unit);

            Fraction y2test2;

            if (b1.IsZero && b2.IsZero)
            {
                y2test2 = Factor * (Fraction)From.NEWValue;
            }
            else
            {
                Fraction b3test2 = (Factor * (b1 * -1)) + b2;
                y2test2 = (Factor * (Fraction)From.NEWValue) + b3test2;

            } 

            return (decimal)y2test2;
        }

        public static double GetValueAsDouble(this BaseUnit From, UnitSystem To)
        {
            if (From.IsNaN)
                return double.NaN;

            if (From.Inf)
                return double.PositiveInfinity;

            return (double)From.GetValueAs(To);
        }

        public static string DisplaySymbol(this BaseUnit From)
        {
            return From.Unit.ReduceUnits().ToString();
        }

        public static decimal GetBaseValue(this BaseUnit From)
        {
            if (From.Unit.IsSIUnit())
                return From.NEWValue;

            return (decimal)(From.Unit.SumConstant() * (Fraction)From.NEWValue);
        }

        public static double As(this BaseUnit From, UnitSystem b)
        {
            return From.GetValueAsDouble(b);
        }
    }
}

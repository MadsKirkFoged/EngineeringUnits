using EngineeringUnits.Units;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringUnits
{
    public static class UnitMath
    {

      
        public static UnknownUnit Sum(IEnumerable<BaseUnit> list)
        {
            UnknownUnit test = new(0m, list.First().Unit);

            foreach (var item in list)        
                test += item;

            return test;
        }

        public static UnknownUnit Sum(IEnumerable<UnknownUnit> list)
        {
            UnknownUnit test = new(0m, list.First()._baseUnit.Unit);

            foreach (var item in list)
                test += item;

            return test;
        }

        public static UnknownUnit Average(IEnumerable<BaseUnit> list)
        {
            UnknownUnit test = Sum(list);

            test /= list.Count();

            return test;
        }

        public static UnknownUnit Average(IEnumerable<UnknownUnit> list)
        {
            UnknownUnit test = Sum(list);

            test /= list.Count();

            return test;
        }

        public static UnknownUnit Min(IEnumerable<BaseUnit> list)
        {

            UnknownUnit test = new(list.First());

            foreach (var item in list)
            {
                if (item < test)
                    test = item;
            }

            return test;
        }

        public static UnknownUnit Min(IEnumerable<UnknownUnit> list)
        {

            UnknownUnit test = list.First();

            foreach (var item in list)
            {
                if (item < test)
                    test = item;
            }

            return test;
        }

        public static UnknownUnit Max(IEnumerable<BaseUnit> list)
        {

            UnknownUnit test = new(list.First());

            foreach (var item in list)
            {
                if (item > test)
                    test = item;
            }

            return test;
        }

        public static UnknownUnit Max(IEnumerable<UnknownUnit> list)
        {

            UnknownUnit test = list.First();

            foreach (var item in list)
            {
                if (item > test)
                    test = item;
            }

            return test;
        }


        public static UnknownUnit Sum(params BaseUnit[] x) { return Sum((IEnumerable<BaseUnit>)x); }
        public static UnknownUnit Sum(params UnknownUnit[] x) { return Sum((IEnumerable<UnknownUnit>)x); }
        public static UnknownUnit Average(params BaseUnit[] x) { return Average((IEnumerable<BaseUnit>)x); }
        public static UnknownUnit Average(params UnknownUnit[] x) { return Average((IEnumerable<UnknownUnit>)x); }
        public static UnknownUnit Max(params BaseUnit[] x) { return Max((IEnumerable<BaseUnit>)x); }
        public static UnknownUnit Max(params UnknownUnit[] x) { return Max((IEnumerable<UnknownUnit>)x); }
        public static UnknownUnit Min(params BaseUnit[] x) { return Min((IEnumerable<BaseUnit>)x); }
        public static UnknownUnit Min(params UnknownUnit[] x) { return Min((IEnumerable<UnknownUnit>)x); }



        public static UnknownUnit LinearInterpolation(UnknownUnit x, UnknownUnit x0, UnknownUnit x1, UnknownUnit y0, UnknownUnit y1)
        {

            if (x1 == x0)
            {
                return (y0 + y1) / 2;
            }

            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }





    }
}

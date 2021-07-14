using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringUnits
{
    public static class UnitMath
    {

        [Obsolete("This has been moved to the unit itself -> ex lenght.Abs()",true)]
        public static TQuantity Abs<TQuantity>(this TQuantity value)
        {
            throw new NotSupportedException("This has been moved to the unit itself -> ex lenght.Abs()");
        }

        //public static UnknownUnit Sum(IEnumerable<BaseUnit> SumList)

        public static UnknownUnit Sum(IEnumerable<BaseUnit> list)
        {
            UnknownUnit test = new UnknownUnit();

            foreach (var item in list)
            {
                if (test.baseUnit.Unit is null)                
                    test.baseUnit.Unit = item.Unit;                

                test += item;
            }

            return test;
        }


        public static UnknownUnit Sum(params BaseUnit[] list)
        {
            UnknownUnit test = new UnknownUnit();

            foreach (var item in list)
            {
                if (test.baseUnit.Unit is null)
                    test.baseUnit.Unit = item.Unit;

                test += item;
            }

            return test;
        }


        public static UnknownUnit Average(IEnumerable<BaseUnit> list)
        {
            UnknownUnit test = Sum(list);

            test /= list.Count();

            return test;
        }

        public static UnknownUnit Average(params BaseUnit[] list)
        {
            UnknownUnit test = Sum(list);

            test /= list.Count();

            return test;
        }



        public static UnknownUnit Min(IEnumerable<BaseUnit> list)
        {

            UnknownUnit test = new UnknownUnit();

            foreach (var item in list)
            {
                if (test.baseUnit.Unit is null)
                    test = item;

                if (item < test)
                    test = item;
            }

            return test;
        }


        public static UnknownUnit Min(params BaseUnit[] list)
        {

            UnknownUnit test = new UnknownUnit();

            foreach (var item in list)
            {
                if (test.baseUnit.Unit is null)
                    test = item;

                if (item < test)
                    test = item;
            }

            return test;
        }

        public static UnknownUnit Max(IEnumerable<BaseUnit> list)
        {

            UnknownUnit test = new UnknownUnit();

            foreach (var item in list)
            {
                if (test.baseUnit.Unit is null)
                    test = item;

                if (item > test)
                    test = item;
            }

            return test;
        }


        public static UnknownUnit Max(params BaseUnit[] list)
        {

            UnknownUnit test = new UnknownUnit();

            foreach (var item in list)
            {
                if (test.baseUnit.Unit is null)
                    test = item;

                if (item > test)
                    test = item;
            }

            return test;
        }

    }
}

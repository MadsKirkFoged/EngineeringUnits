using System;
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






    }
}

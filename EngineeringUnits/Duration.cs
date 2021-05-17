using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class Duration : BaseUnit
    {

        public Duration()
        {
            UnitList.TimeCount = 1;
        }

        //public static UnknownUnit operator /(Duration a, BaseUnit b) => UnknownUnit.DivideWith(a, b);


    }
}

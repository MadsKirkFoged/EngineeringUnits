using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{
    public class Speed : BaseUnit
    {


        public Speed()
        {
            UnitList.LengthCount = 1;
            UnitList.TimeCount = -1;
        }

        public static Speed From()
        {
            return new Speed();
        }


        public static implicit operator Speed(UnknownUnit Unit)
        {

            Speed local = new Speed();


            if (local.UnitList != Unit.baseUnit.UnitList)
            {
                throw new InvalidOperationException("Units did not result in Speed!");
            }

            local.Value = Unit.baseUnit.Value;
            local.UnitList = Unit.baseUnit.UnitList;

            return local;
        }

    }
}

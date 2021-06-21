using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class BaseUnitClass
    {


        public int Count { get; set; }
        public Enum? BaseUnitType { get; set; }
        public Enumeration SelectedUnit { get; set; }


        //Kunne man have A og b her?



        public BaseUnitClass(Enum? baseUnitType)
        {
            Count = 0;
            BaseUnitType = baseUnitType; 
        }




        public static bool operator ==(BaseUnitClass a, BaseUnitClass b)
        {
            //return a.BaseUnitType == b.BaseUnitType &&
            //       a.Count == b.Count;

            return   a.Count == b.Count;

        }

        public static bool operator !=(BaseUnitClass a, BaseUnitClass b)
        {
            return !(a == b);
        }

        

    }
}

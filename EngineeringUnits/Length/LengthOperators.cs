using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Length : BaseUnit
    {

        //Optional for units
        public static Speed operator /(Length a, Duration b) => BaseUnit.Divide(a, b);
        public static Area operator *(Length a, Length b) => BaseUnit.Multiply(a, b);
    }
}

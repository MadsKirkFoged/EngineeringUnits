using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public static class AreaExtra
    {

        /// <summary>Get circle area from a diameter.</summary>
        public static Area FromCircleDiameter(this Length diameter)
        {
            return FromCircleRadius(diameter / 2);
        }

        /// <summary>Get circle area from a radius.</summary>
        public static Area FromCircleRadius(this Length radius) => radius * radius * Math.PI;



    }

}

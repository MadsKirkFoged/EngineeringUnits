using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area
    {

        /// <summary>Get circle area from a diameter.</summary>
        public static Area FromCircleDiameter(Length diameter)
        {
            return FromCircleRadius(diameter / 2);
        }

        /// <summary>Get circle area from a radius.</summary>
        public static Area FromCircleRadius(Length radius) => radius * radius * Math.PI;



    }
}

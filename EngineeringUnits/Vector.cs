using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class Vector : Attribute
    {

        public double Factor { get; set; }
        public string Name { get; set; }


        public double ToSIFactor { get; set; }

        public Vector()
        {


        }

        public Vector(double factor, string name, double toSIFactor)
        {
            Factor = factor;
            Name = name;
            ToSIFactor = toSIFactor;
        }

        public Vector Copy(Vector a)
        {
            return new Vector()
            {
                Factor = a.Factor,
                Name = a.Name,
                ToSIFactor = a.ToSIFactor,

            };


        }




    }





}

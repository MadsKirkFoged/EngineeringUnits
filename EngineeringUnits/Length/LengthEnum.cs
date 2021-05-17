using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum LengthUnits
    {        
        [Vector(1000, "km", UnitSystem.SI, 1)] Kilometer,
        [Vector(1, "m", UnitSystem.SI, 1)] Meter,
        [Vector(0.01, "cm", UnitSystem.SI, 1)] Centimeter,
        [Vector(0.001, "mm", UnitSystem.SI, 1)] Milimeter,


        [Vector(1, "ft", UnitSystem.PI, 0.3048)] Foot,
        [Vector(1/12.0, "in", UnitSystem.PI, 0.3048)] Inch,
        [Vector(3, "yd", UnitSystem.PI, 0.3048)] Yard,
        [Vector(66, "ch", UnitSystem.PI, 0.3048)] chain,
        [Vector(5280, "mi", UnitSystem.PI, 0.3048)] mile,

    }



    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }

        public int Id { get; private set; }

        protected Enumeration(int id, string name) => (Id, Name) = (id, name);

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                     .Select(f => f.GetValue(null))
                     .Cast<T>();



        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);

        // Other utility methods ...
    }

}
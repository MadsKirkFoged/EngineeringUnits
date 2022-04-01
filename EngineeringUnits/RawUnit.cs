using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace EngineeringUnits
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
    public record RawUnit
    {

        [JsonIgnore]
        public string QuantityName { get; set; }

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue("")]
        public string Symbol { get; init; } 

        [JsonProperty(PropertyName = "A", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Fraction A { get; init; }

        [JsonProperty(PropertyName = "B", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue(0d)]
        public decimal B { get; init; }

        [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue(1)]
        public int Count { get; init; } 

        [JsonIgnore]
        public Fraction TotalConstant => Fraction.Pow(A, Count);

        [JsonProperty(PropertyName = "Type", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public BaseunitType UnitType { get; init; }

        [JsonIgnore]
        public bool IsSI { get; init; }

        public RawUnit()
        {
        }

        private RawUnit(RawUnit unit, bool ReverseCount)
        {
            //Used for cloning
            QuantityName = unit.QuantityName;
            Symbol = unit.Symbol;
            A = unit.A;
            B = unit.B;

            if (ReverseCount)            
                Count = unit.Count*-1;            
            else
                Count = unit.Count;
  

            UnitType = unit.UnitType;

            if (A == Fraction.One)
                IsSI = true;
        }

        public RawUnit(RawUnit unit, int NewCount) : this(unit, false)
        {
            Count = NewCount;
        }


        public RawUnit CloneAndReverseCount()
        {

            //return this with
            //{
            //    Count = Count * -1,
            //};


            return new RawUnit(this, true);
        }


        private int HashCode;

        public override int GetHashCode()
        {

            if (HashCode == 0)
            {
                unchecked // Overflow is fine, just wrap
                {
                    HashCode = (int)2166136261;
                    HashCode = (HashCode * 16777619) ^ A.GetHashCode();
                    HashCode = (HashCode * 45476689) ^ B.GetHashCode();
                    HashCode = (HashCode * 16777619) ^ Count.GetHashCode();
                    HashCode = (HashCode * 16777619) ^ UnitType.GetHashCode();                  
                }
            }

            return HashCode;
        }
    }
}

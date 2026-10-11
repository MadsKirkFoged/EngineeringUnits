using System;

namespace EngineeringUnits
{
    /// <summary>
    /// The ISO 4217 code of a currency unit, e.g. "EUR" on <c>CostUnit.Euro</c>. It is accepted wherever the unit's name is:
    /// <see cref="UnitTypebase.GetUnitByString{T}"/> (so <c>price.AddUnit&lt;CostUnit&gt;("DKK")</c>) and the parser
    /// (<c>Cost.Parse("10 EUR")</c>).
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class CurrencyCodeAttribute : Attribute
    {
        public CurrencyCodeAttribute(string code) => Code = code;

        /// <summary>The ISO 4217 code, e.g. "EUR".</summary>
        public string Code { get; }
    }
}

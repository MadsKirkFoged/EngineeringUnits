using System.Reflection;
using System.Text.Json;
using EngineeringUnits.Fast;
using EngineeringUnits.Units.Fast;
using static EngineeringUnits.Fast.ExchangeRates;
using EU = global::EngineeringUnits;

namespace UnitTests.Fast;

/// <summary>The currency units (€, £, kr, and €/m², €/kg, kr/kWh, ... built on them) and their exchange rates.</summary>
[TestClass]
[DoNotParallelize]   // UpdateRate changes the rates for the whole process
public class CurrencyTests
{
    [TestCleanup]
    public void RestoreDefaultRates()
    {
        foreach (var currency in Enum.GetValues<Currency>())
            UpdateRate(currency, EU.ExchangeRates.GetRate(Enum.Parse<EU.ExchangeRates.Currency>(currency.ToString())));
    }

    [TestMethod]
    public void SameCurrenciesAndDefaultRatesAsEngineeringUnits()
    {
        CollectionAssert.AreEqual(Enum.GetNames<EU.ExchangeRates.Currency>(), Enum.GetNames<Currency>());

        foreach (var currency in Enum.GetValues<Currency>())
        {
            var original = Enum.Parse<EU.ExchangeRates.Currency>(currency.ToString());
            Assert.AreEqual((int)original, (int)currency, currency.ToString());
            Assert.AreEqual(EU.ExchangeRates.GetRate(original), GetRate(currency), currency.ToString());
        }
    }

    [TestMethod]
    public void CurrencyUnits_ConvertAtTheRate()
    {
        Assert.AreEqual(108.568, Cost.FromEuro(100).USDollar, 1e-9);
        Assert.AreEqual(100, Cost.FromUSDollar(108.568).Euro, 1e-9);
        Assert.AreEqual(126.65902, Cost.FromBritishPound(100).USDollar, 1e-9);
        Assert.AreEqual(15, Cost.FromDanishKrone(100).USDollar, 1e-9);
        Assert.AreEqual(1.08568, MassCost.FromEuroPerKilogram(1).USDollarPerKilogram, 1e-12);
        Assert.AreEqual(0.15, EnergyCost.FromDKKPerKilowattHour(1).USDollarPerKilowattHour, 1e-12);

        Assert.AreEqual("10 €", Cost.FromEuro(10).ToString(CostUnit.Euro));
        Assert.AreEqual("2.5 kr/kWh", $"{EnergyCost.FromDKKPerKilowattHour(2.5).ToUnit(EnergyCostUnit.DKKPerKilowattHour)}");
    }

    [TestMethod]
    public void UpdateRate_AppliesAtOnce_AlsoAfterTheUnitsWereUsed()
    {
        Assert.AreEqual(1.08568, Cost.FromEuro(1).USDollar, 1e-12);

        // EngineeringUnits ignores an update once CostUnit has been used: it reads the rates into static readonly fields
        UpdateRate(Currency.Euro, 1.19m);

        Assert.AreEqual(1.19m, GetRate(Currency.Euro));
        Assert.AreEqual(1.19, Cost.FromEuro(1).USDollar, 1e-12);
        Assert.AreEqual(1.19, CostUnit.Euro.Factor, 1e-12);
        Assert.AreEqual(1000 / 1.19, LengthCost.FromUSDollarPerMeter(1000).EuroPerMeter, 1e-9);
        Assert.AreEqual(1.2665902, Cost.FromBritishPound(1).USDollar, 1e-12);   // the other rates stay
    }

    [TestMethod]
    public void AValueKeepsItsDollarAmount_WhenARateChanges()
    {
        Cost price = Cost.FromEuro(100);   // stored as 108.568 $

        UpdateRate(Currency.Euro, 2m);

        Assert.AreEqual(108.568, price.USDollar, 1e-9);
        Assert.AreEqual(54.284, price.Euro, 1e-9);
    }

    [TestMethod]
    public void UpdateRate_RefusesWhatIsNotARate()
    {
        UpdateRate(Currency.USDollar, 1);   // allowed: EngineeringUnits' own tests do this

        Assert.ThrowsExactly<ArgumentException>(() => UpdateRate(Currency.USDollar, 2));
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => UpdateRate(Currency.Euro, 0));
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => UpdateRate(Currency.Euro, -1.1m));
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => UpdateRate((Currency)42, 1));
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => GetRate((Currency)42));

        Assert.AreEqual(1m, GetRate(Currency.USDollar));
        Assert.AreEqual(1.08568m, GetRate(Currency.Euro));   // untouched by the refused updates
    }

    /// <summary>A price with its unit name next to it, as read from a database ("Euro"): no detour through EngineeringUnits.</summary>
    [TestMethod]
    public void AddUnit_ReadsCurrencyUnitNames_LikeEngineeringUnits()
    {
        foreach (var name in new[] { "Euro", "BritishPound", "DanishKrone", "USDollar", "MillionUSDollar" })
        {
            Cost fast = 123.45.AddUnit<CostUnit>(name);
            var original = ((EU.Cost)EU.Extensions.AddUnit<EU.Units.CostUnit>(123.45, name)).ToFast();
            Assert.IsTrue(fast.IsCloseTo(original), $"{name}: {fast.USDollar:R} $, EngineeringUnits {original.USDollar:R} $");
        }

        Cost? none = ((double?)null).AddUnit<CostUnit>("Euro");
        Assert.IsNull(none);
    }

    /// <summary>The currency codes are unit names too, as in EngineeringUnits: COMP2's motor prices are stored as "DKK".</summary>
    [TestMethod]
    public void CurrencyCodes_WorkAsUnitNames_LikeEngineeringUnits()
    {
        Assert.AreSame(CostUnit.USDollar, UnitTypebase.GetUnitByString<CostUnit>("USD"));
        Assert.AreSame(CostUnit.Euro, UnitTypebase.GetUnitByString<CostUnit>("EUR"));
        Assert.AreSame(CostUnit.BritishPound, UnitTypebase.GetUnitByString<CostUnit>("GBP"));
        Assert.AreSame(CostUnit.DanishKrone, UnitTypebase.GetUnitByString<CostUnit>("DKK"));
        Assert.AreSame(CostUnit.DanishKrone, UnitTypebase.GetUnitByString<CostUnit>("dkk"));

        foreach (var code in new[] { "USD", "EUR", "GBP", "DKK", "eur" })
        {
            Cost fast = 123.45.AddUnit<CostUnit>(code);
            var original = ((EU.Cost)EU.Extensions.AddUnit<EU.Units.CostUnit>(123.45, code)).ToFast();
            Assert.IsTrue(fast.IsCloseTo(original), $"{code}: {fast.USDollar:R} $, EngineeringUnits {original.USDollar:R} $");
        }

        var e = Assert.ThrowsExactly<ArgumentException>(() => UnitTypebase.GetUnitByString<CostUnit>("SEK"));
        StringAssert.Contains(e.Message, "DanishKrone");
        StringAssert.Contains(e.Message, "DKK");
    }

    /// <summary>The generator copies every [CurrencyCode] from EngineeringUnits.</summary>
    [TestMethod]
    public void CurrencyCodes_SameAsEngineeringUnits()
    {
        var checkedCodes = 0;

        foreach (var q in Quantities.All)
        {
            var fastUnitType = q.SIUnit.GetType();
            foreach (var field in Original.UnitType(q.Name).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var code = field.GetCustomAttribute<EU.CurrencyCodeAttribute>()?.Code;
                var fastCode = fastUnitType.GetField(field.Name)?.GetCustomAttribute<CurrencyCodeAttribute>()?.Code;
                Assert.AreEqual(code, fastCode, $"{q.Name}.{field.Name}");
                if (code is not null)
                    checkedCodes++;
            }
        }

        Assert.AreEqual(4, checkedCodes);
    }

    [TestMethod]
    public void Json_ReadsACurrencySymbol_AndWritesDollars()
    {
        Assert.AreEqual(10.8568, JsonSerializer.Deserialize<Cost>("""{"Value":10,"Unit":"€"}""").USDollar, 1e-12);

        var json = JsonSerializer.Serialize(Cost.FromEuro(10));
        StringAssert.Contains(json, "\"Unit\":\"$\"");
        Assert.AreEqual(10, JsonSerializer.Deserialize<Cost>(json).Euro, 1e-12);
    }
}

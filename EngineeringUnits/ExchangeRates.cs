using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EngineeringUnits;
public static class ExchangeRates
{

    public enum Currency
    {
        USDollar,
        Euro,
        BritishPound,
    }

    private static Dictionary<Currency, decimal> Rates = new Dictionary<Currency, decimal>()
    {
        { Currency.USDollar, 1 },
        { Currency.Euro, 1.08568m },
        { Currency.BritishPound, 1.2665902m },
    };



    /// <summary>
    /// Updates the exchange rate for a specific currency.
    /// All rates are based on USDollar.
    /// If updating the Euro rate, you need the EUR to USD Exchange Rate
    /// </summary>
    public static void UpdateRate(Currency currency, decimal USDBasedExchangeRate)
    {
        Rates[currency] = USDBasedExchangeRate;
    }

    public static decimal GetRate(Currency currency)
    {
        return Rates[currency];
    }


}

using System;
using System.Threading;

namespace EngineeringUnits.Fast;

/// <summary>
/// The exchange rates of the currency units: €, £ and kr, and the prices built on them (€/m², €/kg, kr/kWh, ...). Same API,
/// currencies and default rates as EngineeringUnits. A rate is in USD per unit of the currency.<br></br>
/// <br></br>
/// Unlike EngineeringUnits, an update applies at once, also after the units have been used: a currency unit reads its rate at
/// every conversion. Values are stored in USD, so a value keeps its dollar amount when a rate changes: <c>Cost.FromEuro(100)</c>
/// is 108.568 $ at the default rate, and still 108.568 $ (now shown as 54.284 €) after <c>UpdateRate(Currency.Euro, 2m)</c>.<br></br>
/// EngineeringUnits keeps rates of its own: an application that uses both and changes a rate updates it in both.
/// </summary>
public static class ExchangeRates
{
    public enum Currency
    {
        USDollar,
        Euro,
        BritishPound,
        DKK
    }

    // USD per unit, indexed by Currency: the decimal as given (GetRate) and the double the units multiply with. Replaced as a
    // whole, so a conversion never sees half an update
    private static (decimal Rate, double UsdPerUnit)[] _rates =
    [
        (1m, 1d),
        (1.08568m, 1.08568d),
        (1.2665902m, 1.2665902d),
        (0.15m, 0.15d),
    ];

    private static readonly Lock Gate = new();

    /// <summary>
    /// Updates the exchange rate for a specific currency. All rates are based on USDollar: for the Euro, give the EUR to USD
    /// exchange rate (1.08568 when 1 € is 1.08568 $). Applies at once to every later conversion from or to a unit of that currency.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The rate is zero or negative, or the currency is not defined.</exception>
    /// <exception cref="ArgumentException">A USDollar rate other than 1: costs are stored in USD.</exception>
    public static void UpdateRate(Currency currency, decimal USDBasedExchangeRate)
    {
        var index = Index(currency);

        if (USDBasedExchangeRate <= 0)
            throw new ArgumentOutOfRangeException(nameof(USDBasedExchangeRate), USDBasedExchangeRate, "An exchange rate must be above zero.");
        if (currency == Currency.USDollar && USDBasedExchangeRate != 1)
            throw new ArgumentException("USDollar is the base currency: costs are stored in USD, so its rate is always 1.", nameof(USDBasedExchangeRate));

        lock (Gate)
        {
            var rates = ((decimal Rate, double UsdPerUnit)[])_rates.Clone();
            rates[index] = (USDBasedExchangeRate, (double)USDBasedExchangeRate);
            Volatile.Write(ref _rates, rates);
        }
    }

    /// <summary>The exchange rate of <paramref name="currency"/> in USD per unit, e.g. 1.08568 for the Euro by default.</summary>
    public static decimal GetRate(Currency currency) => Volatile.Read(ref _rates)[Index(currency)].Rate;

    // What a currency unit multiplies with, read at every conversion
    internal static double UsdPerUnit(Currency currency) => Volatile.Read(ref _rates)[(int)currency].UsdPerUnit;

    private static int Index(Currency currency) => Enum.IsDefined(currency)
        ? (int)currency
        : throw new ArgumentOutOfRangeException(nameof(currency), currency, "Not a currency of ExchangeRates.Currency.");
}

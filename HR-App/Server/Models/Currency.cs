﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HR-App.Server.Models;

/// <summary>
/// Lookup table containing standard ISO currencies.
/// </summary>
public partial class Currency
{
    /// <summary>
    /// The ISO code for the Currency.
    /// </summary>
    public string CurrencyCode { get; set; }

    /// <summary>
    /// Currency name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; } = new List<CountryRegionCurrency>();

    public virtual ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigations { get; set; } = new List<CurrencyRate>();

    public virtual ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigations { get; set; } = new List<CurrencyRate>();
}
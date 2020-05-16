using System;
using Newtonsoft.Json;

namespace LitDev.Finances
{
    public class BalanceStatement
    {
        [JsonProperty("date")]
        public DateTime Date;

        [JsonProperty("Cash and cash equivalents")]
        public string CashAndCashEquivalents;

        [JsonProperty("Short-term investments")]
        public string ShortTermInvestments;

        [JsonProperty("Cash and short-term investments")]
        public string CashAndShortTermInvestments;

        [JsonProperty("Receivables")]
        public string Receivables;

        [JsonProperty("Inventories")]
        public string Inventories;

        [JsonProperty("Total current assets")]
        public string TotalCurrentAssets;

        [JsonProperty("Property, Plant & Equipment Net")]
        public string PropertyPlantEquipmentNet;

        [JsonProperty("Goodwill and Intangible Assets")]
        public string GoodwillAndIntangibleAssets;

        [JsonProperty("Long-term investments")]
        public string LongTermInvestments;

        [JsonProperty("Tax assets")]
        public string TaxAssets;

        [JsonProperty("Total non-current assets")]
        public string TotalNonCurrentAssets;

        [JsonProperty("Total assets")]
        public string TotalAssets;

        [JsonProperty("Payables")]
        public string Payables;

        [JsonProperty("Short-term debt")]
        public string ShortTermDebt;

        [JsonProperty("Total current liabilities")]
        public string TotalCurrentLiabilities;

        [JsonProperty("Long-term debt")]
        public string LongTermDebt;

        [JsonProperty("Total debt")]
        public string TotalDebt;

        [JsonProperty("Deferred revenue")]
        public string DeferredRevenue;

        [JsonProperty("Tax Liabilities")]
        public string TaxLiabilities;

        [JsonProperty("Deposit Liabilities")]
        public string DepositLiabilities;

        [JsonProperty("Total non-current liabilities")]
        public string TotalNonCurrentLiabilities;

        [JsonProperty("Total liabilities")]
        public string TotalLiabilities;

        [JsonProperty("Other comprehensive income")]
        public string OtherComprehensiveIncome;

        [JsonProperty("Retained earnings (deficit)")]
        public string RetainedEarningsDeficit;

        [JsonProperty("Total shareholders equity")]
        public string TotalShareholdersEquity;

        [JsonProperty("Investments")]
        public string Investments;

        [JsonProperty("Net Debt")]
        public string NetDebt;

        [JsonProperty("Other Assets")]
        public string OtherAssets;

        [JsonProperty("Other Liabilities")]
        public string OtherLiabilities;
    }
}
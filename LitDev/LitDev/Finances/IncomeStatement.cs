using System;
using Newtonsoft.Json;

namespace LitDev.Finances
{
    public class IncomeStatement
    {
        public DateTime date;
        public double Revenue;

        [JsonProperty("Revenue Growth")]
        public decimal RevenueGrowth;
        [JsonProperty("Cost of Revenue")]
        public decimal CostOfRevenue;
        [JsonProperty("Gross Profit")]
        public decimal GrossProfit;
        [JsonProperty("R&D Expenses")]
        public decimal ResearchAndDevelopmentExpenses;
        [JsonProperty("SG&A Expense")]
        public decimal SGAExpenses;
        [JsonProperty("Operating Expenses")]
        public decimal OperatingExpenses;
        [JsonProperty("Operating Income")]
        public decimal OperatingIncome;
        [JsonProperty("Interest Expense")] 
        public decimal InterestExpense;
        [JsonProperty("Earnings before Tax")]
        public decimal EarningsBeforeTax;
        [JsonProperty("Income Tax Expense")]
        public decimal IncomeTaxExpense;
        [JsonProperty("Net Income - Non-Controlling int")]
        public decimal NetIncomeNonControllingInt;
        [JsonProperty("Net Income - Discontinued ops")]
        public decimal NetIncomeDiscontinuedOps;
        [JsonProperty("Net Income")]
        public decimal NetIncome;
        [JsonProperty("Preferred Dividends")]
        public decimal PreferredDividends;
        [JsonProperty("Net Income Com")]
        public decimal NetIncomeCom;

        public decimal EPS;
        [JsonProperty("EPS Diluted")]
        public decimal EPSDiluted;

        [JsonProperty("Weighted Average Shs Out")]
        public decimal WeightedAverageShsOut;
        [JsonProperty("Weighted Average Shs Out (Dil)")]
        public decimal WeightedAverageShsOutDil;
        [JsonProperty("Dividend per Share")]
        public decimal DividendPerShare;
        [JsonProperty("Gross Margin")]
        public decimal GrossMargin;
        [JsonProperty("EBITDA Margin")]
        public decimal EBITDAMargin;
        [JsonProperty("EBIT Margin")]
        public decimal EBITMargin;
        [JsonProperty("Profit Margin")]
        public decimal ProfitMargin;
        [JsonProperty("Free Cash Flow margin")]
        public decimal FreeCashFlowMargin;

        public decimal EBITDA;
        public decimal EBIT;
        [JsonProperty("Consolidated Income")]
        public decimal ConsolidatedIncome;
        [JsonProperty("Earnings Before Tax Margin")]
        public decimal EarningsBeforeTaxMargin;
        [JsonProperty("Net Profit Margin")]
        public decimal NetProfitMargin;
    }
}
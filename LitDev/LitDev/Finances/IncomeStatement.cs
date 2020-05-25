using System;
using System.Text;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"date={date.ToString("YYYY-MM-DD")};");
            sb.Append($"Revenue={Revenue};");
            sb.Append($"RevenueGrowth={RevenueGrowth};");
            sb.Append($"CostOfRevenue={CostOfRevenue};");
            sb.Append($"GrossProfit={GrossProfit};");
            sb.Append($"R&DExpenses={ResearchAndDevelopmentExpenses};");
            sb.Append($"SG&AExpenses={SGAExpenses};");
            sb.Append($"OperatingExpenses={OperatingExpenses};");
            sb.Append($"OperatingIncome={OperatingIncome};");
            sb.Append($"InterestExpense={InterestExpense}");
            sb.Append($"EarningsBeforeTax={EarningsBeforeTax};");
            sb.Append($"IncomeTaxExpense={IncomeTaxExpense};");
            sb.Append($"NetIncomeNonControllingInt={NetIncomeNonControllingInt};");
            sb.Append($"NetIncomeDiscontinuedOps={NetIncomeDiscontinuedOps};");
            sb.Append($"NetIncome={NetIncome};");
            sb.Append($"PreferredDividends={PreferredDividends};");
            sb.Append($"NetIncomeCom={NetIncomeCom};");
            sb.Append($"EPS={EPS};");
            sb.Append($"EPSDiluted={EPSDiluted};");
            sb.Append($"WeightedAverageShsOut={WeightedAverageShsOut};");
            sb.Append($"WeightedAverageShsOutDil={WeightedAverageShsOutDil};");
            sb.Append($"DividendPerShare={DividendPerShare};");
            sb.Append($"GrossMargin={GrossMargin};");
            sb.Append($"EBITDAMargin={EBITDAMargin};");
            sb.Append($"EBITMargin={EBITMargin};");
            sb.Append($"ProfitMargin={ProfitMargin};");
            sb.Append($"FreeCashFlowMargin={FreeCashFlowMargin};");
            sb.Append($"EBITDA={EBITDA};");
            sb.Append($"EBIT={EBIT};");
            sb.Append($"ConsolidatedIncome={ConsolidatedIncome};");
            sb.Append($"EarningsBeforeTaxMargin={EarningsBeforeTaxMargin};");
            sb.Append($"NetProfitMargin={NetProfitMargin};");
            return sb.ToString();
        }
    }
}
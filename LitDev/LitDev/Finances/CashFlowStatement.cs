using System;
using System.Text;
using Newtonsoft.Json;

namespace LitDev.Finances
{
    public class CashFlowStatement
    {
        [JsonProperty("date")]
        public DateTime Date ;

        [JsonProperty("Depreciation & Amortization")]
        public string DepreciationAmortization ;

        [JsonProperty("Stock-based compensation")]
        public string StockBasedCompensation ;

        [JsonProperty("Operating Cash Flow")]
        public string OperatingCashFlow ;

        [JsonProperty("Capital Expenditure")]
        public string CapitalExpenditure ;

        [JsonProperty("Acquisitions and disposals")]
        public string AcquisitionsAndDisposals ;

        [JsonProperty("Investment purchases and sales")]
        public string InvestmentPurchasesAndSales ;

        [JsonProperty("Investing Cash flow")]
        public string InvestingCashFlow ;

        [JsonProperty("Issuance (repayment) of debt")]
        public string IssuanceRepaymentOfDebt ;

        [JsonProperty("Issuance (buybacks) of shares")]
        public string IssuanceBuybacksOfShares ;

        [JsonProperty("Dividend payments")]
        public string DividendPayments ;

        [JsonProperty("Financing Cash Flow")]
        public string FinancingCashFlow ;

        [JsonProperty("Effect of forex changes on cash")]
        public string EffectOfForexChangesOnCash ;

        [JsonProperty("Net cash flow / Change in cash")]
        public string NetCashFlowChangeInCash ;

        [JsonProperty("Free Cash Flow")]
        public string FreeCashFlow ;

        [JsonProperty("Net Cash/Marketcap")]
        public string NetCashMarketcap ;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"date={Date.ToString("YYYY-MM-DD")};");
            sb.Append($"DepreciationAmortization={DepreciationAmortization};");
            sb.Append($"StockBasedCompensation={StockBasedCompensation};");
            sb.Append($"OperatingCashFlow={OperatingCashFlow};");
            sb.Append($"CapitalExpenditure={CapitalExpenditure};");
            sb.Append($"AcquisitionsAndDisposals={AcquisitionsAndDisposals};");
            sb.Append($"InvestmentPurchasesAndSales={InvestmentPurchasesAndSales};");
            sb.Append($"InvestingCashFlow={InvestingCashFlow};");
            sb.Append($"IssuanceRepaymentOfDebt={IssuanceRepaymentOfDebt};");
            sb.Append($"IssuanceBuybacksOfShares={IssuanceBuybacksOfShares};");
            sb.Append($"DividendPayments={DividendPayments};");
            sb.Append($"FinancingCashFlow={FinancingCashFlow};");
            sb.Append($"EffectOfForexChangesOnCash={EffectOfForexChangesOnCash};");
            sb.Append($"NetCashFlowChangeInCash={NetCashFlowChangeInCash};");
            sb.Append($"FreeCashFlow={FreeCashFlow};");
            sb.Append($"NetCashMarketcap={NetCashMarketcap};");
            return sb.ToString();
        }
    }
}
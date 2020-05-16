using System;
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Newtonsoft.Json;

namespace LitDev
{
    /// <summary>
    /// This is the abstraction layer for LDFinance
    /// we can change the source of the information
    /// hopefully without changing the public API for LDFinance
    /// API Documentation is stored here: https://financialmodelingprep.com/developer/docs/
    /// </summary>
    public static class Finances
    {
        private static WebAPI api = WebAPIFactory.Instance.GetWebApi("https://financialmodelingprep.com/api/v3");
        private static int limit = 10;

        public enum ReportingPeriod
        {
            Annual, 
            Quarterly
        }

        public static Company GetCompanyProfile(string company)
        {
            return api.DeserializeJSON<Company>($"/company/profile/{company}");
        }

        public static Quote[] GetCompanyQuote(string company)
        {
            return api.DeserializeJSON<Quote[]>($"/quote/{company}");
        }

        public static Search[] GetSearch(string name, string exchange)
        {
            return api.DeserializeJSON<Search[]>($"/search?query={name}&limit={limit}&exchange={exchange}");
        }

        public static FinancialWrapper<IncomeStatement> GetIncomeStatement(string name, ReportingPeriod period = ReportingPeriod.Annual)
        {
            switch (period)
            {
                case ReportingPeriod.Quarterly:
                    return api.DeserializeJSON<FinancialWrapper<IncomeStatement>>($"/financials/income-statement/{name}?period=quarter");
                case ReportingPeriod.Annual:
                default:
                    return api.DeserializeJSON<FinancialWrapper<IncomeStatement>>($"/financials/income-statement/{name}");
            }
        }

        public static FinancialWrapper<BalanceStatement> GetBalanceStatement(string name, ReportingPeriod period = ReportingPeriod.Annual)
        {
            switch (period)
            {
                case ReportingPeriod.Quarterly:
                    return api.DeserializeJSON<FinancialWrapper<BalanceStatement>>($"/financials/balance-sheet-statement/{name}?period=quarter");
                case ReportingPeriod.Annual:
                default:
                    return api.DeserializeJSON<FinancialWrapper<BalanceStatement>>($"/financials/balance-sheet-statement/{name}");
            }
        }

        public static FinancialWrapper<CashFlowStatement> GetCashFlowStatement(string name, ReportingPeriod period = ReportingPeriod.Annual)
        {
            switch (period)
            {
                case ReportingPeriod.Quarterly:
                    return api.DeserializeJSON<FinancialWrapper<CashFlowStatement>>($"/financials/cash-flow-statement/{name}?period=quarter");
                case ReportingPeriod.Annual:
                default:
                    return api.DeserializeJSON<FinancialWrapper<CashFlowStatement>>($"/financials/cash-flow-statement/{name}");
            }
        }

        public static void GetFinancialRatios()
        {

        }

        public static void GetEnterpriseValueAnnual()
        {

        }

        public static void GetEnterpriseValueQuarterly()
        {

        }

        public static void GetCompanyKeyMetrics()
        {

        }

        public static void GetFinancialGrowthStatement()
        {

        }

        public static void GetCompanyRating()
        {

        }

        public static void GetDiscountedCashValueFlow()
        {

        }

        public static void GetDiscountedCashValueFlowHistorical()
        {

        }

        public static void GetSymbolsList()
        {

        }

        public static Price GetRealTimePrice(string company)
        {
            return api.DeserializeJSON<Price>($"/stock/real-time-price/{company}");
        }
        public static void GetStockPriceList()
        {

        }

        public static void GetHistoricalPrice()
        {

        }

        public static void GetHistroicDailyPrice() { }


        public static void GetMarketIndexes()
        {

        }

        public static void GetMarketIndexesPrice()
        {

        }

        public static void GetMarketIndexesPriceHistorical()
        {

        }

        public static void GetAvailableCommodities()
        {

        }

        public static void GetAllCommodityPrices()
        {

        }


        public static void GetCommodityPrice()
        {

        }

        public static void GetHistoricCommodityPrice()
        {

        }

        public static void GetAvailableETF()
        {

        }

        public static void GetAllETFPrices()
        {

        }

        public static void GetETFPrice()
        {

        }

        public static void GetHistoricalETFPrice()
        {

        }

        public static void GetAllMutualFunds()
        {

        }

        public static void GetAllMutualFundPrice()
        {

        }

        public static void GetMutualFundPrice()
        {

        }

        public static void GetHistoricalMutualFundPrice()
        {

        }

        public static void GetHistoricalVolumeMutualFundPrice()
        {

        }

        public static void GetEuroNext()
        {

        }

        public static void GetAllEuroNextPrices()
        {

        }

        public static void GetEuroNextPrice()
        {

        }

        public static void GetHistoricalEuroNextPrice()
        {

        }

        public static void GetTSX()
        {

        }

        public static void GetAllTSXPrices()
        {

        }

        public static void GetTSXPrice()
        {

        }

        public static void GetHistoricalTSXPrice()
        {

        }
        
        //TODO: Eventually add cryptocurrencies

        public static void GetForex()
        {

        }

        public static void GetForexPrices()
        {

        }

        public static void GetForexPriceCurrencey()
        {

        }

        public static void GetHistoricalForexPrices()
        {

        }
    }

    public class Company
    {
        public string symbol;
        public Profile profile;
    }

    /// <summary>
    /// Information about a companies profile
    /// </summary>
    public class Profile
    {
        public decimal price;
        public decimal beta;
        public int volAvg;
        public double mktCap;
        public decimal lastDiv;
        public string range;
        public decimal changes;
        public string changesPercentage;
        public string companyName;
        public string exchange;
        public string industry;
        public string description;
        public string ceo;
        public string sector;
        public string image;
    }

    /// <summary>
    /// Information about a companies quote.
    /// </summary>
    public class Quote
    {
        public string symbol;
        public string name;
        public decimal price;
        public decimal changesPercentage;
        public decimal change;
        public decimal dayLow;
        public decimal dayHigh;
        public decimal yearHigh;
        public decimal yearLow;
        public decimal marketCap;
        public decimal priceAvg50;
        public decimal priceAvg200;
        public int volume;
        public int avgVolume;

        [JsonProperty("exhange")]
        public string exchange;
        public decimal open;
        public decimal previousClose;
        public decimal eps;
        public decimal pe;
        public DateTime earningsAnnouncement;
        public decimal sharesOutstanding;
        public int timestamp;
    }

    public class Price
    {
        public string symbol;
        public decimal price;
    }

    public class Search
    {
        public string symbol;
        public string name;
        public string currency;
        public string stockExchange;
        [JsonProperty("exchangeShortName")]
        public string stockExchangeShortName; 
    }

    public class FinancialWrapper<T>
    {
        public string symbol;
        public T[] financials; 
    }

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

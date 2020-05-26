using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LitDev.Finances
{
    /// <summary>
    /// This is the abstraction layer for LDFinance
    /// we can change the source of the information
    /// hopefully without changing the public API for LDFinance
    /// API Documentation is stored here: https://financialmodelingprep.com/developer/docs/
    /// </summary>
    public static class Engine
    {
        private static WebAPI api = WebAPIFactory.Instance.GetWebApi("https://financialmodelingprep.com/api/v3");
        private static int limit = 10;
        public static string key = "d7f226423e7ccbe237e43e93f064acb2";

        public static string LastURL => api.lastUrl;

        public enum ReportingPeriod
        {
            Annual, 
            Quarterly
        }

        public static Company GetCompanyProfile(string company)
        {
            return api.DeserializeJSON<Company>($"/company/profile/{company}?apikey={key}");
        }

        public static Quote[] GetCompanyQuote(string company)
        {
            return api.DeserializeJSON<Quote[]>($"/quote/{company}?apikey={key}");
        }

        public static Search[] GetSearch(string name, string exchange)
        {
            return api.DeserializeJSON<Search[]>($"/search?query={name}&limit={limit}&exchange={exchange}&apikey={key}");
        }

        public static FinancialWrapper<IncomeStatement> GetIncomeStatement(string name, ReportingPeriod period = ReportingPeriod.Annual)
        {
            switch (period)
            {
                case ReportingPeriod.Quarterly:
                    return api.DeserializeJSON<FinancialWrapper<IncomeStatement>>($"/financials/income-statement/{name}?period=quarter&apikey={key}");
                case ReportingPeriod.Annual:
                default:
                    return api.DeserializeJSON<FinancialWrapper<IncomeStatement>>($"/financials/income-statement/{name}?apikey={key}");
            }
        }

        public static FinancialWrapper<BalanceStatement> GetBalanceStatement(string name, ReportingPeriod period = ReportingPeriod.Annual)
        {
            switch (period)
            {
                case ReportingPeriod.Quarterly:
                    return api.DeserializeJSON<FinancialWrapper<BalanceStatement>>($"/financials/balance-sheet-statement/{name}?period=quarter&apikey={key}");
                case ReportingPeriod.Annual:
                default:
                    return api.DeserializeJSON<FinancialWrapper<BalanceStatement>>($"/financials/balance-sheet-statement/{name}?apikey={key}");
            }
        }

        public static FinancialWrapper<CashFlowStatement> GetCashFlowStatement(string name, ReportingPeriod period = ReportingPeriod.Annual)
        {
            switch (period)
            {
                case ReportingPeriod.Quarterly:
                    return api.DeserializeJSON<FinancialWrapper<CashFlowStatement>>($"/financials/cash-flow-statement/{name}?period=quarter&apikey={key}");
                case ReportingPeriod.Annual:
                default:
                    return api.DeserializeJSON<FinancialWrapper<CashFlowStatement>>($"/financials/cash-flow-statement/{name}?apikey={key}");
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
            return api.DeserializeJSON<Price>($"/stock/real-time-price/{company}?apikey={key}");
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
}

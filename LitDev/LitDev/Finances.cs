using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitDev.Finances;
using Microsoft.SmallBasic.Library;

namespace LitDev
{
    /// <summary>
    /// Lets you ask financial information... 
    /// Created by Abhishek Sathiabalan for LD extension.
    /// </summary>
    [SmallBasicType]
    public static class LDFinances
    {

        /// <summary>
        /// The API key to use for this API.
        /// You need to get an api key from
        /// https://financialmodelingprep.com/developer/docs/
        /// </summary>
        public static Primitive Key
        {
            get { return Engine.key; }
            set { Engine.key = value; }
        }

        /// <summary>
        /// Gets a description of the company including information such as
        /// CEO, Sector, price, and market cap amongst other things.
        ///
        /// This information is updated on a minute to minute basis. 
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <returns>
        ///    A description of the company in the form of an array upon success.
        ///    On failure returns FAILURE.
        /// </returns>
        public static Primitive Description(Primitive ticker)
        {
            try
            {
                return Engine.GetCompanyProfile(ticker).ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        /// <summary>
        /// Gets a quote for the company requested.
        /// This information is updated in real-time. 
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <returns>
        ///    A quote of the company in the form of an array upon success
        ///    and a failure returns FAILURE. 
        /// </returns>
        public static Primitive Quote(Primitive ticker)
        {
            try
            {
                Quote[] quotes = Engine.GetCompanyQuote(ticker);
                return quotes.ToPrimitiveArray();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Gets the current price of the company.
        /// This information is returned in real-time.
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <returns>
        ///    A price of the company in the form of an array upon success
        ///    and a failure returns FAILURE. 
        /// </returns>
        public static Primitive Price(Primitive ticker)
        {
            try
            {
                return Engine.GetRealTimePrice(ticker).ToString();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Searches the exchange for the ticker name
        /// and returns results that are similar to the ticker name. 
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <param name="exchange">
        ///       The exchange to search on, valid exchanges values include the following:
        ///       ETF | MUTUAL_FUND | COMMODITY | INDEX | CRYPTO | FOREX | TSX | AMEX | NASDAQ | NYSE | EURONEXT | ""
        ///       If the exchange is set to "" it searches all exchanges listed above. 
        /// </param>
        /// <returns>
        ///    A quote of the company in the form of an array upon success
        ///    and a failure returns FAILURE.
        /// </returns>
        public static Primitive Search(Primitive ticker, Primitive exchange)
        {
            try
            {
                Search[] results = Engine.GetSearch(ticker, exchange);
                return results.ToPrimitiveArray();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <param name="reportingPeriod">
        ///     Valid reporting periods are "Annual" and "Quarterly". 
        /// </param>
        /// <param name="statementType">
        ///     Valid statement types are: "Income", "Balance", and, "CashFlow". 
        /// </param>
        /// <returns></returns>
        public static Primitive Statement(Primitive ticker, Primitive reportingPeriod, Primitive statementType)
        {
            StringComparison sc = StringComparison.InvariantCultureIgnoreCase;

            Engine.ReportingPeriod period = Engine.ReportingPeriod.Annual;
            if (ticker.ToString().Equals("Quarterly", sc))
            {
                period = Engine.ReportingPeriod.Quarterly;
            }

            try
            {
                if (statementType.ToString().Equals("Income", sc))
                {
                    FinancialWrapper<IncomeStatement> statement = Engine.GetIncomeStatement(ticker, period);
                    return statement.ToString();
                }
                else if (statementType.ToString().Equals("Balance", sc))
                {
                    FinancialWrapper<BalanceStatement> statement = Engine.GetBalanceStatement(ticker, period);
                    return statement.ToString();
                }
                else if (statementType.ToString().Equals("CashFlow", sc))
                {
                    FinancialWrapper<CashFlowStatement> statement = Engine.GetCashFlowStatement(ticker, period);
                    return statement.ToString();
                }
            }
            catch (Exception ex)
            {
                return "FAILED";
            }

            return "FAILED";
        }
    }
}

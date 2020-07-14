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
        /// https://api.tiingo.com/documentation/general/overview
        /// </summary>
        public static Primitive Key
        {
            get { return Engine.key; }
            set { Engine.key = value; }
        }

        /// <summary>
        /// Gets a description of the company.
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
                return Engine.GetDescription(ticker).ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        /// <summary>
        /// Gets the current price of the company as
        /// reported by the API.
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
        /// Gets the Historical stock information for a stock
        /// </summary>
        /// <param name="ticker">The symbol of the company we want to find.</param>
        /// <param name="startDate">The start date formatted in YYYY-MM-DD</param>
        /// <param name="endDate">The end date formatted in YYYY-MM-DD</param>
        /// <param name="freq">daily', 'weekly','monthly', 'annually' are the only valid paramaters</param>
        /// <returns></returns>
        public static Primitive HistoricalPrice(Primitive ticker, Primitive startDate, Primitive endDate,
            Primitive freq)
        {
            try
            {
                Price[] prices = Engine.GetHistoricalPrice(ticker, startDate, endDate, freq);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < prices.Length; i++)
                {
                    sb.AppendFormat("{0}={1};", i + 1, Utilities.ArrayParse( prices[i].ToString() ) );
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

    }
}

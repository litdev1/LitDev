using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using LitDev.Finances;

namespace LitDev.Finances
{
    /// <summary>
    /// This is the abstraction layer for LDFinance
    /// we can change the source of the information
    /// hopefully without changing the public API for LDFinance
    /// API Documentation is stored here: https://api.tiingo.com/documentation/general/overview
    /// </summary>
    public static class Engine
    {
        private static WebAPI api = WebAPIFactory.Instance.GetWebApi("https://api.tiingo.com/tiingo/");
        public static string key;
        public static string LastURL => api.lastUrl;


        public static Price GetRealTimePrice(string ticker)
        {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(ticker))
            {
                return null;
            }

            Price[] prices = api.DeserializeJSON<Price[]>($"/daily/{ticker}/prices?token={key}");
            return prices[0];
        }

        public static Price[] GetHistoricalPrice(string ticker, string start, string end, string frequency)
        {
            return string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(ticker) ? null :
                api.DeserializeJSON<Price[]>($"/daily/{ticker}/prices?startDate={start}&endDate={end}&resampleFreq={frequency}&token={key}");
        }

        public static Description GetDescription(string ticker)
        {
            if (string.IsNullOrWhiteSpace(ticker) || string.IsNullOrWhiteSpace(key))
            {
                return null;
            }
            return api.DeserializeJSON<Description>($"/daily/{ticker}?token={key}");

        }

    }
}

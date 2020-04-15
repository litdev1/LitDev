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
    /// </summary>
    public static class Finances
    {
        private static WebAPI api = WebAPIFactory.Instance.GetWebApi("https://financialmodelingprep.com/api/v3");

        public static Company GetCompanyProfile(string company)
        {
            return api.DeserializeJSON<Company>($"/company/profile/{company}");
        }

        public static Quote[] GetCompanyQuote(string company)
        {
            return api.DeserializeJSON<Quote[]>($"/quote/{company}");
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
}

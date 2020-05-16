using System;
using Newtonsoft.Json;

namespace LitDev.Finances
{
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
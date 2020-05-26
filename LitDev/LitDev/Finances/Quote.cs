using System;
using System.Text;
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
        [JsonProperty("exchange")]
        public string exchange;
        public decimal open;
        public decimal previousClose;
        public decimal eps;
        public decimal pe;
        public DateTime earningsAnnouncement;
        public decimal sharesOutstanding;
        public int timestamp;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"symbol={symbol};");
            sb.Append($"name={name};");
            sb.Append($"price={price};");
            sb.Append($"changesPercentage={changesPercentage};");
            sb.Append($"change={change};");
            sb.Append($"dayLow={dayLow};");
            sb.Append($"dayHigh={dayHigh};");
            sb.Append($"yearHigh={yearHigh};");
            sb.Append($"yearLow={yearLow};");
            sb.Append($"marketCap={marketCap};");
            sb.Append($"priceAvg50={priceAvg50};");
            sb.Append($"priceAvg200={priceAvg200};");
            sb.Append($"volume={volume};");
            sb.Append($"avgVolume={avgVolume};");
            sb.Append($"exchange={exchange};");
            sb.Append($"open={open};");
            sb.Append($"previousClose={previousClose};");
            sb.Append($"eps={eps};");
            sb.Append($"pe={pe};");
            sb.Append($"earningsAnnouncement={earningsAnnouncement.ToString("yyyy-MM-dd")};");
            sb.Append($"sharesOutstanding={sharesOutstanding};");
            sb.Append($"timestamp={timestamp};");
            return sb.ToString();
        }
    }
}
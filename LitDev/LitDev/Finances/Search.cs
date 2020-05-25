using System.Text;
using Newtonsoft.Json;

namespace LitDev.Finances
{
    public class Search
    {
        public string symbol;
        public string name;
        public string currency;
        public string stockExchange;
        [JsonProperty("exchangeShortName")]
        public string stockExchangeShortName;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"symbol={symbol};");
            sb.Append($"name={name};");
            sb.Append($"currency={currency};");
            sb.Append($"stockExchange={stockExchange};");
            sb.Append($"stockExchangeShortName={stockExchangeShortName};");
            return sb.ToString();
        }
    }
}
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
    }
}
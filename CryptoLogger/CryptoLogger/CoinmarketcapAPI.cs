using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoLogger
{
    public class Coinmarketcap_ticker
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "price_usd")]
        public string price_usd { get; set; }

        [JsonProperty(PropertyName = "price_btc")]
        public string price_btc { get; set; }

        [JsonProperty(PropertyName = "24h_volume_usd")]
        public string Volume_24H { get; set; }

        [JsonProperty(PropertyName = "market_cap_usd")]
        public string Marketcap_Usd { get; set; }

        [JsonProperty(PropertyName = "available_supply")]
        public string Available_Supply { get; set; }

        [JsonProperty(PropertyName = "total_supply")]
        public string Total_Supply { get; set; }

        [JsonProperty(PropertyName = "max_supply")]
        public string Max_Supply { get; set; }

        [JsonProperty(PropertyName = "percent_change_1h")]
        public string Change_1H { get; set; }

        [JsonProperty(PropertyName = "percent_change_24h")]
        public string Change_24H { get; set; }

        [JsonProperty(PropertyName = "percent_change_7d")]
        public string Change_7d { get; set; }

        [JsonProperty(PropertyName = "last_updated")]
        public string Last_Updated { get; set; }

    }
}

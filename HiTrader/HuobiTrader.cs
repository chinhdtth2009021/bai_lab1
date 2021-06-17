using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace HiTrader
{
    public class HuobiTrader : ITraderAction
    {
        public List<Coin> GetTickers()
        {
            var coins = new List<Coin>();
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
            var url = "https://api.huobi.pro/market/tickers";
            Task<string> response = httpClient.GetStringAsync(url);
            var data = JObject.Parse(response.Result);
            foreach (var obj in data["data"])
            {
                coins.Add(new Coin
                {
                    Symbol = obj["symbol"].Value<string>(),
                    High = obj["high"].Value<double>(),
                    Low = obj["low"].Value<double>(),
                    Volume = obj["volume"].Value<double>(),
                    Bid = obj["bid"].Value<double>(),
                    BidSize = obj["bidSize"].Value<double>()
                });
            }
            return coins;
        }
    }
}
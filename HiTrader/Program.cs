using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HiTrader
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var huobiTrader = new BitfinexTrader();
            var tickers = huobiTrader.GetTickers();
            foreach (var ticker  in tickers)
            {
                Console.WriteLine(ticker.ToString());
            }
        }
    }
}
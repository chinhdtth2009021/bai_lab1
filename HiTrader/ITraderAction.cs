using System.Collections.Generic;

namespace HiTrader
{
    public interface ITraderAction
    {
        List<Coin> GetTickers();
    }
}
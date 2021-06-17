namespace HiTrader
{
    public class Coin
    {
        // public string FullName { get; set; }
        public string Symbol { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Volume { get; set; }
        public double Bid { get; set; }
        public double BidSize { get; set; }

        public override string ToString()
        {
            return $"{Symbol} - High: {High} - Low: {Low} -Volume: {Volume}- Bid: {Bid} - BidSize: {BidSize}";
        }
       
    }
}
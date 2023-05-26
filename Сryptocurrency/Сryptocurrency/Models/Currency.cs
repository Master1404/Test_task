using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сryptocurrency.Models
{
    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public decimal TradeVolume { get; set; }
        public decimal MarketCapitalization { get; set; }
        public decimal PriceChange { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<string> TradingPairs { get; set; }
    }
}

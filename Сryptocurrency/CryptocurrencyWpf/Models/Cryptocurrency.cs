using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWpf.Models
{
    public class Cryptocurrency : INotifyPropertyChanged
    {
        private string name;
        private string symbol;
        public decimal price;
       // public decimal tradeVolume;
       // public decimal marketCapitalization;
       // public decimal priceChange;
        //public List<string> tradingPairs;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Symbol
        {
            get { return symbol; }
            set
            {
                symbol = value;
                OnPropertyChanged("Symbol");
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

       /* public decimal TradeVolume
        {
            get { return tradeVolume; }
            set
            {
                tradeVolume = value;
                OnPropertyChanged("TradeVolume");
            }
        }

        public decimal MarketCapitalization
        {
            get { return marketCapitalization; }
            set
            {
                marketCapitalization = value;
                OnPropertyChanged("MarketCapitalization");
            }
        }

        public decimal PriceChange
        {
            get { return priceChange; }
            set
            {
                priceChange = value;
                OnPropertyChanged("PriceChange");
            }
        }*/

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

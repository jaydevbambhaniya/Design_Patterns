using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Event
{
    public class PriceChangedEventArgs : EventArgs
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
        public PriceChangedEventArgs(string symbol,double newPrice)
        {
            Symbol = symbol;
            Price = newPrice;
        }
    }
}

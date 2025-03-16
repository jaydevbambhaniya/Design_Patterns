using Observer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Publisher
{
    public class Stock
    {
        public string Symbol { get; set; }
        private double _Price;

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            _Price = price;
        }

        public double Price
        {
            get => _Price;
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    OnPriceChanged(new PriceChangedEventArgs(Symbol, value));
                }
            }
        }

        public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);
        public event PriceChangedEventHandler? PriceChangedEvent;

        protected void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChangedEvent?.Invoke(this, e);
        }
    }
}

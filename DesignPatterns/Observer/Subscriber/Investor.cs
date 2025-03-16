using Observer.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscriber
{
    public class Investor
    {
        public string Name { get; set; }
        public Investor(string name)
        {
            Name = name;
        }

        public void OnPriceChanged(object sender,PriceChangedEventArgs e)
        {
            Console.WriteLine($"{Name} Notified: {e.Symbol}'s new Price: {e.Price}");
        }
    }
}

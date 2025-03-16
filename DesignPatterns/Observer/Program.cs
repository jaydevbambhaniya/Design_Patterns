using Observer.Publisher;
using Observer.Subscriber;

Stock tata = new Stock("Tata Motors", 745.8);
Investor inv1 = new Investor("Ratan Tata");
Investor inv2 = new Investor("Sachin Tendulkar");

// Subscribed and attached the observer
tata.PriceChangedEvent += inv1.OnPriceChanged;
tata.PriceChangedEvent += inv2.OnPriceChanged;

tata.Price = 784.3;

// Detached, won't be notified.
tata.PriceChangedEvent -= inv2.OnPriceChanged;

tata.Price = 850;
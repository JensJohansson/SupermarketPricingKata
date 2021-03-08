using System;

namespace Groceries
{
    public class GroceryItem
    {
        private readonly IPricer _pricer;

        public double Price => _pricer.Price;

        public GroceryItem(IPricer pricer)
        {
            _pricer = pricer;
        }
    }
}
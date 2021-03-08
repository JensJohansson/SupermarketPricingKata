namespace Groceries
{
    public class SimplePricer : IPricer
    {

        public double Price { get; private set; }
        public SimplePricer(double price)
        {
            Price = price;
        }
    }
}
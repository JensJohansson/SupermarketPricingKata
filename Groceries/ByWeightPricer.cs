namespace Groceries
{
    public class ByWeightPricer : IPricer
    {
        private double _price;
        private double Weight { get; }
        private double PricePerWeight { get; }

        public ByWeightPricer(double weight, double pricePerWeight)
        {
            Weight = weight;
            PricePerWeight = pricePerWeight;
        }

        double IPricer.Price => PricePerWeight * Weight;
    }
}
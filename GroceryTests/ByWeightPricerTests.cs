using NUnit.Framework;
using Groceries;

namespace GroceryTests
{
    [TestFixture]
    public class ByWeightPricerTests
    {
        [Test]
        public void Price_WhenWeightIsZero_ReturnsZero()
        {
            IPricer pricer = new ByWeightPricer(0, 4.00);
            var actual = pricer.Price;
            var expected = 0;
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Price_WhenPricePerWeightIsZero_ReturnsZero()
        {
            IPricer pricer = new ByWeightPricer(10, 0);
            var actual = pricer.Price;
            var expected = 0;
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Price_WhenValidInputs_ReturnsValue()
        {
            IPricer pricer = new ByWeightPricer(10, .25);
            var actual = pricer.Price;
            var expected = 2.50;
            
            Assert.AreEqual(expected, actual);
        }
    }
}
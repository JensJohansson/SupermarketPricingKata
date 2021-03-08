using Groceries;
using NUnit.Framework;

namespace GroceryTests
{
    [TestFixture]
    public class SimplePricerTests
    {
        [Test]
        public void Price_WhenCalled_ReturnsSetPrice()
        {
            var expected = 1.23;
            var pricer = new SimplePricer(expected);
            var actual = pricer.Price;
            
            Assert.AreEqual(expected, actual);
        }
    }
}
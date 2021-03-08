using Groceries;
using NUnit.Framework;

namespace GroceryTests
{
    public class GroceryItemTests
    {
        [Test]
        public void Price_WhenFixedPrice_ReturnsPrice()
        {
            var expected = 1.05;
            var item = new GroceryItem(new SimplePricer(expected));
            Assert.AreEqual(expected, item.Price);
        }

        [Test]
        public void Price_ByWeight_ReturnsPrice()
        {
            //$2 a pound
            //Weighs 4 ounces
            //Expected Price $0.50
            var item = new GroceryItem(new ByWeightPricer(0.25, 2.00));
            var expected = 0.50;
            var actual = item.Price;
            
            Assert.AreEqual(expected, actual);
        
        }
    }
}
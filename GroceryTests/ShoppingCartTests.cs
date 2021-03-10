using System;
using Groceries;
using NUnit.Framework;

namespace GroceryTests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void Checkout_NoItem_ThrowsException()
        {
            var cart = new ShoppingCart();
            var ex = Assert.Throws<ApplicationException>(() => cart.Total());
            Assert.AreEqual("A cart must have at least one item.", ex.Message);
        }
        
        [Test]
        public void Checkout_OneItem_ReturnPriceOfItem()
        {
            var expected = 0.99;
            var item = new GroceryItem(new SimplePricer(expected));
            var cart = new ShoppingCart();
            cart.Add(item);
            
            Assert.AreEqual(expected, cart.Total());
        }
        
        [Test]
        public void Checkout_TwoItems_ReturnTheSumOfPrices()
        {
            var expected = 2.50;
            var item1 = new GroceryItem(new SimplePricer(1.20));
            var item2 = new GroceryItem(new SimplePricer(1.30));
            var cart = new ShoppingCart();
            cart.Add(item1);
            cart.Add(item2);
            
            Assert.AreEqual(expected, cart.Total());
        }
        
    }
}
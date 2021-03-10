using System;
using System.Collections.Generic;
using System.Linq;

namespace Groceries
{
    public class ShoppingCart
    {
        private readonly List<GroceryItem> _contents = new List<GroceryItem>();
        public double Total()
        {
            if (_contents.Count == 0) throw new ApplicationException("A cart must have at least one item.");
            return _contents.Sum(item => item.Price);
        }

        public void Add(GroceryItem item)
        {
            _contents.Add(item);
        }
    }
}
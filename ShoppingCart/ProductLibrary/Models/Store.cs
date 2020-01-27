using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLibrary.Models
{
    public class Store
    {
        public List<Product> Products = new List<Product>();
        public List<Product> Cart = new List<Product>();
        public decimal Checkout()
        {
            decimal total=0;
            foreach (var item in Cart)
            {
                total += item.Price;
            }
            Cart.Clear();
            return total;
        }
    }
}

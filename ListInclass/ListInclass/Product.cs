using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInclass
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        //public List<Product> Products = new List<Product>();
        private List<Product> Products = new List<Product>();

        public override string ToString()
        {
            return $"{Code} {Name} {Price} {Quantity}";
        }
        public void Insert(Product product)
        {
            Products.Add(product);
        }

        public void ShowList()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
        //public Product()
        //{
        //    Products = new List<Product>();

        //}
    }
}

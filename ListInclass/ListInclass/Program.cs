using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInclass
{
    class Program
    {
        static string prod = "1000 Chanel 500ML ";
        static void Main(string[] args)
        {
            //List<Product> products = new List<Product>();
            //products.Add(new Product {Code="0001CHAN100", Name="Bazoka", Price=1.0, Quantity=5 });
            //products.Add(new Product {Code="0002CHAN100", Name="Chiclet", Price=2.10, Quantity=5 });
            //products.Add(new Product {Code="0003CHAN100", Name="Bonbon", Price=10.05, Quantity=5 });
            //products.Add(new Product {Code="0004CHAN100", Name="Biscuit", Price=15.27, Quantity=5 });

            Product product = new Product();
            //product.Products.Add(new Product { Code = "0001CHAN100", Name = "Bazoka", Price = 1.0, Quantity = 5 });
            //product.Products.Add(new Product { Code = "0002CHAN100", Name = "Chiclet", Price = 2.10, Quantity = 5 });
            //product.Products.Add(new Product { Code = "0003CHAN100", Name = "Bonbon", Price = 10.05, Quantity = 5 });
            //product.Products.Add(new Product { Code = "0004CHAN100", Name = "Biscuit", Price = 15.27, Quantity = 5 });
            //foreach (var item in product.Products)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            product.Insert(new Product { Code = "0001CHAN100", Name = "Bazoka", Price = 1.0, Quantity = 5 });
            product.Insert(new Product { Code = "0002CHAN100", Name = "Chiclet", Price = 2.10, Quantity = 5 });
            product.Insert(new Product { Code = "0003CHAN100", Name = "Bonbon", Price = 10.05, Quantity = 5 });
            product.Insert(new Product { Code = "0004CHAN100", Name = "Biscuit", Price = 15.27, Quantity = 5 });

            product.ShowList();

            Console.ReadKey();

        }
    }
}

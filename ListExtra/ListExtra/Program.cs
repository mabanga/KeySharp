using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> products = new List<Product>;

            var products = new List<Product>
            {
                new Product { ID = 01, Category = "Electronics", Value = 15.8 }, 
                new Product { ID = 02, Category = "Groceries", Value = 40.5 }, 
                new Product { ID = 03, Category = "Groceries", Value = 10.2 },
                new Product { ID = 4, Category = "Garden", Value = 12.5 }, 
                new Product { ID = 5, Category = "Garden", Value = 210.5 },
                new Product { ID = 6, Category = "Pets", Value = 2.1 }, 
                new Product { ID = 7, Category = "Electronics", Value = 45.8 }, 
                new Product { ID = 8, Category = "Automobile", Value = 17.3 }, 
                new Product { ID = 9, Category = "Automobile", Value = 38.9 },
                new Product { ID = 10, Category = "Electronics", Value = 15.8 }
            };

            foreach (var item in products)
            {
                Console.WriteLine($"{item}");
                //Console.WriteLine($"{item.ID}");
                //Console.WriteLine($"{item.Value}");
                //Console.WriteLine($"{item.Category}");
            }
            Console.WriteLine(new string('-',15));
            //Lambda expression

            foreach (var group in products.GroupBy(p=> p.Category))
            {
                //Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }




            Console.ReadKey();
        }
    }
}

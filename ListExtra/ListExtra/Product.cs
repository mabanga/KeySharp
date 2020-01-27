using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtra
{
    public class Product
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public double Value { get; set; }
        public override string ToString()
        {
            return string.Format($"Id: {ID} - Category: {Category} - Value; {Value}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.CommonLibrary.Models
{
    interface IProductRepository
    {
        void AddProduct(Product newProduct);
        void DeleteProduct(int Id);
        List<Product> GetProduct();
        Product GetProduct(int Id);
        void UpdateProduct(int Id);
    }
}

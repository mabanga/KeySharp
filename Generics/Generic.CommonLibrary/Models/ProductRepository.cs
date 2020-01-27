using System;
using System.Collections.Generic;

namespace Generic.CommonLibrary.Models
{
    public class ProductRepository : IProductRepository
    {
        FakeDatabase proxy = new FakeDatabase();

        public void AddProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }
        public void DeleteProduct(int Ide)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProduct()
        {
            throw new NotImplementedException();
        }
        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }
        public void UpdateProduct(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

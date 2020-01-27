namespace ProductLibrary.Models
{
    public class Product
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Make: {Make},\nModel: {Model},\nPrice: {Price}";
        }
        public Product(string make="noMake", string model="noModel", decimal price=0.00m)
        {
            Make = make;
            Model = model;
            Price = price;
        }
    }
}

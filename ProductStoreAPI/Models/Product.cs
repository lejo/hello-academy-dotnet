namespace ProductStoreAPI.Models
{
    public class Product
    {
        public string Description { get; } = "Coming Soon";
        public double Price { get; } = 0d;
        public string Title { get; } = "Coming Soon";

        public Product(string title, string description, double price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public Product()
        {
        }
    }
}
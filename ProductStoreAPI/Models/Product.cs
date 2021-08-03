namespace ProductStoreAPI.Models
{
    public class Product
    {
        public string Description { get; set; } = "Coming Soon";
        public double Price { get; set; } = 0d;
        public string Title { get; set; } = "Coming Soon";

        public Product(string title, string description, double price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public Product()
        {
        }

        public bool isInvalid()
        {
            return Price == 0 || Title == "Coming Soon" || Description == "Coming Soon";
        }
    }
}
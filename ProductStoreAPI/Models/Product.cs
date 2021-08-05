namespace ProductStoreAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public Product(string title, string description, double price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public Product()
        {
        }

        public bool isValid()
        {
            return Price != 0 && !string.IsNullOrWhiteSpace(Title) && Description != null;
        }




        public bool isInvalid()
        {
            return !isValid();
        }
    }
}
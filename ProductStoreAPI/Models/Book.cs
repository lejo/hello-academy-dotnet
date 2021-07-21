namespace ProductStoreAPI.Models
{
    public class Book : Product
    {
        public Book(string title, string description, double price) : base(title, description, price) {} 
        public Book() {}
    }
}
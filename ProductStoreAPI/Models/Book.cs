namespace ProductStoreAPI.Models
{
    public class Book : Product
    {
        public int NumOfPages;

        public Book(string title, string description, double price, string author="Author", int numOfPages=0) :  base(title, description, price) 
        {
            NumOfPages = numOfPages;
        } 
        
        
        
        
        public Book() {}
    }
}
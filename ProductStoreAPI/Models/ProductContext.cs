using Microsoft.EntityFrameworkCore;

namespace ProductStoreAPI.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        
        public DbSet<Product> ProductItems { get; set; }
    }
}
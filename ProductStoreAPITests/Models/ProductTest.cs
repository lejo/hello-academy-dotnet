using System.Net.Http.Headers;
using NUnit.Framework;
using ProductStoreAPI.Models;

namespace ProductStoreAPITests
{
    public class ProductTests
    {
        [Test]
        public void ValidProduct()
        {
            Product p = new Product();
            p.Title = "Product Title";
            p.Description = "Product Description";
            p.Price = 5;

            Assert.IsTrue(p.isValid());
        }

        [Test]
        public void ProductWithoutATitileIsNotValid()
        {
            Product p = new Product();
            p.Title = null;
            p.Description = "Product Description";
            p.Price = 5;

            Assert.IsFalse(p.isValid());
        }
        

        [Test]
        public void ProductWithOnlySpacesInTitileIsNotValid()
        {
            Product p = new Product();
            p.Title = "    ";
            p.Description = "Product Description";
            p.Price = 5;

            Assert.IsFalse(p.isValid());
        }
        
        
    }
}
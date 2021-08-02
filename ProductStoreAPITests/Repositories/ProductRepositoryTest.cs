using NUnit.Framework;
using ProductStoreAPI.Models;
using ProductStoreAPI.Repositories;
using System.Collections.Generic;

namespace ProductStoreAPITests.Repositories
{
    class ProductRepostoryTest
    {
        [Test]
        public void GetAllProductsReturnsCorrectly()
        {
            var repository = new ProductRepository();
            Assert.That(repository.getAllProducts().Count, Is.EqualTo(2));
        }

        [Test]
        public void AddsCorrectly()
        {
            var repository = new ProductRepository(new List<Product>());

            Assert.IsEmpty(repository.getAllProducts());

            repository.add(new Product(title: "Eraser", description: "Pink Eraser", price: 0.99));

            Assert.IsNotEmpty(repository.getAllProducts());
        }
    }
}

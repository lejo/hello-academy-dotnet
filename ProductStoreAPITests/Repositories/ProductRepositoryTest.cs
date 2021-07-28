using NUnit.Framework;
using ProductStoreAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

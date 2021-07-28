using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using ProductStoreAPI.Controllers;
using ProductStoreAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreAPITests.Controllers
{
    class ProductControllerTest
    {
        [Test]
        public void GetAllProductsReturnHTTP200()
        {
            IProductRepository productRepository = new ProductRepository();
            ProductController productController = new ProductController(productRepository);
            
            ActionResult<List<ProductStoreAPI.Models.Product>> result = productController.GetAllProducts();
            OkObjectResult okObjectResult = result.Result as OkObjectResult;

            Assert.NotNull(okObjectResult);
            Assert.AreEqual(200, okObjectResult.StatusCode);
        }
    }
}

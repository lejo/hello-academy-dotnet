using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using ProductStoreAPI.Controllers;
using ProductStoreAPI.Models;
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

        [Test]
        public void AbleToAddNewProduct()
        {
            Product newProduct = new Product("Coke Zero", "Caffiene fix", 1.50);

            IProductRepository productRepository = new ProductRepository();
            ProductController productController = new ProductController(productRepository);

            OkResult addResult = (OkResult) productController.AddNew(newProduct);

            // Get the list of products so we can validate it was actually added
            ActionResult<List<ProductStoreAPI.Models.Product>> getResult = productController.GetAllProducts();
            OkObjectResult okGetResult = getResult.Result as OkObjectResult;
            List<Product> listOfProducts = okGetResult.Value as List<Product>;

            Assert.AreEqual(200, addResult.StatusCode);
            Assert.AreEqual(3, listOfProducts.Count);


        }
    }
}

using ProductStoreAPI.Models;
using System;
using System.Collections.Generic;

namespace ProductStoreAPI.Repositories
{
    internal class ProductRepository
    {
        public ProductRepository()
        {
        }

        public List<Product> getAllProducts()
        {
            var product1 = new Product(title: "Blue Pen", description: "0.7mm Felt Tip Pen", price: .99);
            var product2 = new Book(title: "Learn C#", description: "Teach Basics of C#", price: 39.99);

            var listOfProducts = new List<Product>();

            listOfProducts.Add(product1);
            listOfProducts.Add(product2);

            return listOfProducts;
        }
    }
}
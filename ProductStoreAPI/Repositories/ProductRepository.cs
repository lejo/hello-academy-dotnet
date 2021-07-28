using ProductStoreAPI.Models;
using System;
using System.Collections.Generic;

namespace ProductStoreAPI.Repositories
{
    public interface IProductRepository
    {
        List<Product> getAllProducts();
        void add(Product product);
    }

    public class ProductRepository : IProductRepository
    {
        private List<Product> listOfProducts = new List<Product>();

        public ProductRepository()
        {
            listOfProducts.Add(new Product(title: "Blue Pen", description: "0.7mm Felt Tip Pen", price: .99));
            listOfProducts.Add(new Book(title: "Learn C#", description: "Teach Basics of C#", price: 39.99));
        }

        public ProductRepository(List<Product> products)
        {
            listOfProducts = products;
        }

        public void add(Product product)
        {
            listOfProducts.Add(product);
        }

        public List<Product> getAllProducts()
        {
            return listOfProducts;
        }
    }
}
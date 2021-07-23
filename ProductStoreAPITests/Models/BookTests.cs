using System;
using NUnit.Framework;
using ProductStoreAPI.Models;

namespace ProductStoreAPITests
{
    public class BookTests
    {
        [Test]
        public void InheritanceTests()
        {
            Assert.That(new Book(), Is.InstanceOf<Product>());
            Assert.That(new Book(), Is.InstanceOf<Book>());
            Assert.That(new Book(), Is.InstanceOf<Object>());

            Assert.That(new Product(), Is.Not.InstanceOf<Book>());
            Assert.That(new Product(), Is.InstanceOf<Object>());
        }


        [Test]
        public void NumberOfPagesIsGreaterThanZero()
        {
            var book = new Book(title: "Book Title", description: "Book Description", price: 19.99, numOfPages: 15);
            Assert.That(book.NumOfPages, Is.GreaterThan(0));
        }
    }
}
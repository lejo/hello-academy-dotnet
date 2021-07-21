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
    }
}
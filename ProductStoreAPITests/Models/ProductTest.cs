using System.Net.Http.Headers;
using NUnit.Framework;
using ProductStoreAPI.Models;

namespace ProductStoreAPITests
{
    public class ProductTests
    {
        [Test]
        public void DescriptionDefaultsToComingSoon()
        {
            Assert.AreEqual("Coming Soon", new Product().Description);
        }
        
        [Test]
        public void TitleDefaultsToComingSoon()
        {
            Assert.AreEqual("Coming Soon", new Product().Title);
        }
        
        [Test]
        public void PriceDefaultsToZero()
        {
            Assert.Zero(new Product().Price);
        }
        
        
    }
}
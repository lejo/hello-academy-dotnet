using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStoreAPI.Models;
using ProductStoreAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            var repository = new ProductRepository();

            return repository.getAllProducts();
        }
    }
}

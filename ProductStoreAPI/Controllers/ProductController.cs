using Microsoft.AspNetCore.Cors;
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
    [EnableCors("localhost")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(productRepository.getAllProducts());
        }

        [HttpPost]
        public ActionResult AddNew(Product newProduct)
        {
            try {
                this.productRepository.add(newProduct);
                return Ok();

            } catch (Exception e) 
            {
                return BadRequest();
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApiRep.Models;
using MyWebApiRep.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApiRep.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository productRepository;
        private IProductRepository _productRepository;

        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                return Ok(productRepository.GetAll().ToList());
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("find/{id}")]
        public async Task<IActionResult> Find(int id)
        {
            try
            {
                var product = await _productRepository.GetById(id);
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("search/{Keyword}")]
        public async Task<IActionResult> Search(string Keyword)
        {
            try
            {
                
                return Ok(productRepository.Search(Keyword));
            }
            catch
            {
                return BadRequest();
            }
        }
       
        [Produces("application/json")]
        [HttpGet("search/{min}/{max}")]
        public async Task<IActionResult> Search(double min, double max)
        {
            try
            {

                return Ok(productRepository.Search(min,max));
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                await productRepository.Create(product);
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}

using business.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.DTO;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private IProductService _productService;
      
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProductsAsync()
        {
            var products = await _productService.GetAll();

            var productsDTO = new List<ProductDTO>();

            foreach(var p in products)
            {
                productsDTO.Add(new ProductDTO
                {
                    Code = p.Code,
                    Renk = p.Renk,
                    KoliIciAdet = p.KoliIciAdet,
                    SosisIciAdet = p.SosisIciAdet,
                    ImageUrl = p.ImageUrl,
                });
            }
            return Ok(productsDTO);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            var product = await _productService.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(new ProductDTO
            {
                Code = product.Code,
                Renk = product.Renk,
                KoliIciAdet = product.KoliIciAdet,
                SosisIciAdet = product.SosisIciAdet,
                ImageUrl = product.ImageUrl,
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProductAsync),new {id = entity.ProductId },entity);

        }
    }
}

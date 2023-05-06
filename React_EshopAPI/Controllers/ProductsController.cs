using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_EshopAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepo;
        public ProductsController(IProductsRepository productsRepo)
        {
            this._productsRepo = productsRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await this._productsRepo.GetProducts());
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProduct(long Id)
        {
            return Ok(await this._productsRepo.GetProduct(Id));
        }
        [HttpGet("search/{textToSearch}")]
        public async Task<IActionResult> GetSearchedProducts(string textToSearch)
        {
            return Ok(await this._productsRepo.GetSearchedProducts(textToSearch));
        }
        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetProduct(string name)
        {
            return Ok(await this._productsRepo.GetProduct(name));
        }
        [HttpGet("incredibleOffers")]
        public async Task<IActionResult> GetProductIncredibleOffers()
        {
            return Ok(await this._productsRepo.GetProductIncredibleOffers());
        }
        [HttpGet("dailySuggests")]
        public async Task<IActionResult> GetProductDailySuggests()
        {
            return Ok(await this._productsRepo.GetProductDailySuggests());
        }
        [HttpGet("category/{categoryName}")]
        public async Task<IActionResult> GetProductCategory( string categoryName)
        {
            return Ok(await this._productsRepo.GetProductCategory(categoryName));
        }
        [HttpGet("categories")]
        public async Task<IActionResult> GetProductCategories()
        {
            return Ok(await this._productsRepo.GetProductCategories());
        }
        [HttpGet("PishnahadeRoozeMobile")]
        public async Task<IActionResult> GetProductsPishnahadeRoozeMobile()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("PishnahadeRoozeMobile"));
        }
        [HttpGet("KharideSareMah")]
        public async Task<IActionResult> GetProductsKharideSareMah()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("KharideSareMah"));
        }
        [HttpGet("KharideAghsati")]
        public async Task<IActionResult> GetProductsKharideAghsati()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("KharideAghsati"));
        }
        [HttpGet("JameJahani")]
        public async Task<IActionResult> GetProductsJameJahani()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("JameJahani"));
        }
        [HttpGet("Harajestoon")]
        public async Task<IActionResult> GetProductsHarajestoon()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("Harajestoon"));
        }
        [HttpGet("ForoosheOmdeh")]
        public async Task<IActionResult> GetProductsForoosheOmdeh()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("ForoosheOmdeh"));
        }
        [HttpGet("DigiJet")]
        public async Task<IActionResult> GetProductsDigiJet()
        {
            return Ok(await this._productsRepo.GetProductBySevenIcons("DigiJet"));
        }
    }
}

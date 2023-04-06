using BlazorECommerce.Server.Repositories.Implementations;
using BlazorECommerce.Server.Repositories.Interfaces;
using BlazorECommerce.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;
        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _repo.GetList());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _repo.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product NewProduct)
        {
            return Ok(await _repo.Add(NewProduct));
        }
    }
}

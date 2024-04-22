using Demo01.api.Services.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.api.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public ProductController(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }


        [HttpGet("{OrderId}")]

        public async Task<IActionResult> GetProducts(int OrderId)
        {
            var response = await _ProductRepository.GetProducts(OrderId);

            if(response == null)
            {
                return Ok("There is no products for the given order id");
            }

            return Ok(response);
        }
    }
}

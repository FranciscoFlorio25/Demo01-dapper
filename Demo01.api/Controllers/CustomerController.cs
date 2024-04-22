using Demo01.api.Services.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.api.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }


        [HttpGet("{OrderId}")]

        public async Task<IActionResult> getCustomer(int OrderId)
        {
            var response = await _CustomerRepository.GetCustomerNameAddress(OrderId);

            return Ok(response);
        }
    }

}


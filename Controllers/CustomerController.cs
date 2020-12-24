using System;
using System.Threading.Tasks;
using AspNetDocker.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDocker.Controllers
{
    [Route("api/v1/customers")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            return await Task.FromResult(Ok(await _customerRepository.GetAsync(id)));
        }
    }
}
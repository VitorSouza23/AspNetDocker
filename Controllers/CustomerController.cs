using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDocker.Controllers
{
    [Route("api/v1/customers")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await Task.FromResult(Ok("Teste"));
        }
    }
}
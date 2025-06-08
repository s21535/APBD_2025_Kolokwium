using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shows.API.Repositories;

namespace Shows.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IPurchaseRepository _purchaseRepository;
        public CustomersController(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPurchases(string? customerLastName = null)
        {
            var purchases = await _purchaseRepository.GetOrdersAsync(customerLastName);
            return Ok(purchases);
        }
    }
}

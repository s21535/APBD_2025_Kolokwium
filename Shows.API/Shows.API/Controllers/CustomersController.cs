using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shows.API.Repositories;

namespace Shows.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        public CustomersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
    }
}

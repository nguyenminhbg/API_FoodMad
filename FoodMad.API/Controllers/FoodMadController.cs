using FoodMap_Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodMad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodMadController : ControllerBase
    {
        [HttpGet("orders/{page}")]
        public Task<List<Order>> GetListOrder(int page)
        {
            var datas = new List<Order>()
            {
                new Order(){ }
            };
            return Task.FromResult(datas);
        }
    }
}
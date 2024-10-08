using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(new { id = 1, Name = "Kalem", Price = 20 });
        }

        [HttpGet("{name}/{price}")]
        public IActionResult GetProduct(string name, int price)
        {
            return Ok(name);
        }


        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok(new { Status = "Success" });
        }

        [HttpPut]
        public IActionResult UpdateProduct() 
        {
            return Ok();
        }

    }
}

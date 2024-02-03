using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniEat.Data;

namespace UniEat.Controllers
{
    [Route("api/unieat")]
    [ApiController]
    public class apiUniEat : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public apiUniEat(ApplicationDbContext context)  
        {
            _context = context;
        }

        [HttpGet("dish")]
        public IActionResult Get()
        {
            return Ok(_context.DishesDatabase);
        }

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("Hello World");
        }
    }
}

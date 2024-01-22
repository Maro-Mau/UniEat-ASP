using Microsoft.AspNetCore.Mvc;

namespace UniEat.Controllers
{
    public class UniEatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace UniEat.Controllers
{
    public class LunchOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuList()
        {
            return View();
        }
    }
}
